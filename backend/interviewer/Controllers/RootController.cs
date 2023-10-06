using System.Xml.Serialization;
using interviewer.Data;
using interviewer.Responses;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace interviewer.Controllers;

[ApiController]
[Route("/elc_recruit/root")]
public class RootController : ControllerBase
{
    public RootController(IConfiguration configuration, UserManager<InterviewerUser> userManager)
    {
        _configuration = configuration;
        _userManager = userManager;
        _dbContext = new InterviewerDbContext(configuration);
    }

    private readonly IConfiguration _configuration;
    private readonly UserManager<InterviewerUser> _userManager;
    private readonly InterviewerDbContext _dbContext;

    [HttpGet("get_current_process")]
    [Authorize(Roles = "Admin")]
    public async Task<object> GetCurrentProcess()
    {
        int processState = GetProcessState();

        return new
        {
            Success = true,
            Data = processState
        };
    }

    [HttpGet("ex_access")]
    [Authorize(Roles = "Admin")]
    public async Task<IActionResult> Export(StudentState studentState, ElcDepartment department)
    {
        Student[]? data = null;
        try
        {
            data = await _dbContext.Students.Where(s =>
                    s.State == studentState && (department == ElcDepartment.All || s.FirstDepartment == department))
                .ToArrayAsync();
        }
        catch (Exception e)
        {
            return Ok(new RootControllerResponses
            {
                ErrorMessage = new[] { e.Message },
                Data = null
            });
        }

        MemoryStream stream = new MemoryStream();

        XmlSerializer serializer =
            new XmlSerializer(typeof(Student[]));

        serializer.Serialize(stream, data);

        var response = File(stream.ToArray(), "application/vnd.ms-excel", "Export.xls");

        return response;
    }

    [HttpPost("push_status")]
    [Authorize(Roles = "Admin")]
    public async Task<object> PushStatus(bool force = false)
    {
        int processState = GetProcessState();

        if (processState == (int)ProcessState.Finish)
            return new
            {
                Success = false,
                ErrorMessages = new string[] { "已到达最终阶段！" }
            };

        Dictionary<StudentState, int> stateDict = new();

        await _dbContext.Students.ForEachAsync(student =>
        {
            StudentState state = student.State;
            stateDict.TryAdd(state, 0);
            stateDict[state]++;
        });

        if (!force)
        {
            Dictionary<StudentState, int> unexpectedStateCount = stateDict
                .Where(pair => pair.Key is not (StudentState.Applied or StudentState.Failed))
                .ToDictionary(pair => pair.Key, pair => pair.Value);

            if (unexpectedStateCount.Any())
            {
                var errorMessage = unexpectedStateCount.Aggregate("当前还有",
                    (s, pair) => pair.Key == 0 ? s : $"{s} {pair.Value} 个学生为 {pair.Key} 状态，");
                errorMessage = (string)errorMessage.TrimEnd('，').Append('。');
                return new
                {
                    Success = false,
                    ErrorMessages = new string[] { errorMessage }
                };
            }
        }

        List<StudentHistory> histories = new();
        foreach (Student student in _dbContext.Students)
        {
            histories.Add(new StudentHistory
            {
                Id = Guid.NewGuid().ToString(),
                StudentId = student.Id,
                State = student.State,
                ProcessState = (ProcessState)processState
            });
            student.State = student.State == StudentState.Pass ? StudentState.Applied : StudentState.Failed;
        }
        histories.ForEach(history => _dbContext.StudentHistories.Add(history));
        SetProcessState(processState + 1);
        await _dbContext.SaveChangesAsync();

        return new
        {
            Success = true
        };
    }

    [HttpPost("rollback_status")]
    [Authorize(Roles = "Admin")]
    public async Task<object> RollbackStatus()
    {
        int processState = GetProcessState();

        if (processState == (int)ProcessState.FirstRoundInterview)
            return new
            {
                Success = false,
                ErrorMessages = new string[] { "已到达最初阶段！" }
            };

        foreach (StudentHistory history in _dbContext.StudentHistories.ToList()
                     .Where(history => (int)history.ProcessState == processState - 1))
        {
            Student? student = _dbContext.Students.FirstOrDefault(student => student.Id == history.StudentId);
            if (student is not null)
                student.State = history.State;
        }

        SetProcessState(processState - 1);

        await _dbContext.SaveChangesAsync();

        return new
        {
            Success = true
        };
    }

    private void SetProcessState(int processState)
    {
        _dbContext.IntegerProperties.First(property => property.Name == "ProcessState").Value =
            processState;
    }

    private int GetProcessState()
    {
        IntegerProperty processStateProperty;
        try
        {
            processStateProperty =
                _dbContext.IntegerProperties.Single(property => property.Name == "ProcessState");
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw new Exception("数据库中没有 ProcessState 属性！");
        }

        var processState = processStateProperty.Value;
        return processState;
    }
}
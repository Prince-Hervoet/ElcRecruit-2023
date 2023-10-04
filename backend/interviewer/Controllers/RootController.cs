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
        IntegerProperty? processState =
            _dbContext.IntegerProperties.FirstOrDefault(property => "ProcessState" == property.Name, null);
        if (processState is null) throw new Exception("数据库中没有 ProcessState 属性！");

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
        IntegerProperty? processState =
            _dbContext.IntegerProperties.FirstOrDefault(property => property.Name == "ProcessState");
        if (processState is null) throw new Exception("数据库中没有 ProcessState 属性！");
        if (processState.Value == (int)ProcessState.Finish)
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

        await _dbContext.Students.ForEachAsync(student =>
        {
            _dbContext.StudentHistories.Add(new StudentHistory
            {
                StudentId = student.Id,
                State = student.State,
                ProcessState = (ProcessState)processState.Value
            });
            student.State = student.State == StudentState.Pass ? StudentState.Applied : StudentState.Failed;
            _dbContext.IntegerProperties.First(property => property.Name == "ProcessState").Value =
                processState.Value + 1;
            _dbContext.SaveChanges();
        });
        return new
        {
            Success = true
        };
    }
}
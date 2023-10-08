using System.ComponentModel.DataAnnotations;
using interviewer.Data;
using interviewer.Responses;
using interviewer.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using StackExchange.Redis;

namespace interviewer.Controllers;

[ApiController]
[Route("/elc_recruit/student")]
public class MiniProgramController : ControllerBase
{
    public MiniProgramController(IConfiguration configuration, UserManager<InterviewerUser> userManager, IMessageService messageService)
    {
        _configuration = configuration;
        _userManager = userManager;
        _messageService = messageService;
        _dbContext = new InterviewerDbContext(configuration);
        _random = new Random();
    }

    private readonly IConfiguration _configuration;
    private readonly UserManager<InterviewerUser> _userManager;
    private readonly IMessageService _messageService;
    private readonly InterviewerDbContext _dbContext;
    private readonly Random _random;

    [HttpPost("commit")]
    [Authorize(Roles = "Student")]
    public async Task<MiniProgramControllerResult> Commit([FromBody] Student student)
    {
        var user = await _userManager.GetUserAsync(User);
        if (user is null)
        {
            return new MiniProgramControllerResult() { Data = null, ErrorMessages = new[] { "用户不存在" } };
        }

        student.Id = user.Id;
        var existingStudent = _dbContext.Students.FirstOrDefault(s => s.Id == student.Id);

        if (existingStudent is not null)
        {
            existingStudent.College = student.College;
            existingStudent.FirstDepartment = student.FirstDepartment;
            existingStudent.SecondDepartment = student.SecondDepartment;
            existingStudent.Grade = student.Grade;
            existingStudent.Introduction = student.Introduction;
            existingStudent.Name = student.Name;
            existingStudent.Phone = student.Phone;
            existingStudent.Qq = student.Qq;
            existingStudent.Skills = student.Skills;
            //existingStudent.State=student.State;
            existingStudent.StudentNumber = student.StudentNumber;
            existingStudent.WeChat = student.WeChat;
            _dbContext.Students.Update(existingStudent);
        }
        else
        {
            _dbContext.Students.Add(student);
        }

        await _dbContext.SaveChangesAsync();
        var foundStudent = _dbContext.Students.FirstOrDefault(s => s.Id == student.Id);
        return new MiniProgramControllerResult() { Data = foundStudent };
    }

    [HttpGet("get_info")]
    [Authorize(Roles = "Student")]
    public async Task<MiniProgramControllerResult> GetInfo()
    {
        var user = await _userManager.GetUserAsync(User);
        var student = _dbContext.Students.FirstOrDefault(s => s.Id == user.Id);
        if (student is null)
        {
            return new MiniProgramControllerResult() { ErrorMessages = new[] { "没有记录！" } };
        }
        
        return new MiniProgramControllerResult() { Data = student };
    }

    [HttpGet("get_process")]
    [Authorize(Roles = "Student")]
    public async Task<MiniProgramControllerResult> GetProcess()
    {
        var user = await _userManager.GetUserAsync(User);
        var student = _dbContext.Students.FirstOrDefault(s => s.Id == user.Id);
        var studentHistories = _dbContext.StudentHistories.Where(history => history.StudentId == student.Id).OrderBy(history => history.ProcessState).ToList();
        studentHistories.Add(new StudentHistory()
        {
            ProcessState = (ProcessState)GetProcessState(),
            StudentId = student.Id,
            Time = DateTime.UtcNow,
            State = student.State,
            Id = Guid.NewGuid().ToString()
        });
        if (!studentHistories.Any())
        {
            return new MiniProgramControllerResult() { ErrorMessages = new[] { "没有记录！" } };
        }

        return new MiniProgramControllerResult() { Data = studentHistories.ToArray() };
    }

    [HttpGet("checkin")]
    [Authorize(Roles = "Student")]
    public async Task<MiniProgramControllerResult> CheckIn()
    {
        var user = await _userManager.GetUserAsync(User);
        if (user is null) return new MiniProgramControllerResult() { Data = null, ErrorMessages = new[] { "用户不存在" } };
        var student = _dbContext.Students.FirstOrDefault(s => s.Id == user.Id);
        if (student is null)
            return new MiniProgramControllerResult() { Data = null, ErrorMessages = new[] { "用户不存在" } };
        student.State = StudentState.CheckedIn;
        _dbContext.Students.Update(student);
        await _dbContext.SaveChangesAsync();
        return new MiniProgramControllerResult() { Data = student?.State };
    }

    [HttpGet("send_verification_code")]
    public async Task<IActionResult> SendVerifyCode(
        [RegularExpression(@"^(13[0-9]|14[01456879]|15[0-35-9]|16[2567]|17[0-8]|18[0-9]|19[0-35-9])\d{8}$",
            ErrorMessage = "手机号格式不正确")]
        string phoneNumber)
    {
        return Ok(await _messageService.SendVerificationCode(phoneNumber));
    }

    string RandomNumber(int length)
    {
        const string chars = "0123456789";
        return new string(Enumerable.Repeat(chars, length)
            .Select(s => s[_random.Next(s.Length)]).ToArray());
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
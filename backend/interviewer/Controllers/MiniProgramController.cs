using interviewer.Data;
using interviewer.Responses;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace interviewer.Controllers;

[ApiController]
[Route("/elc_recruit/student")]
public class MiniProgramController : ControllerBase
{
    public MiniProgramController(IConfiguration configuration, UserManager<InterviewerUser> userManager)
    {
        _configuration = configuration;
        _userManager = userManager;
        _dbContext = new InterviewerDbContext(configuration);
    }

    private readonly IConfiguration _configuration;
    private readonly UserManager<InterviewerUser> _userManager;
    private readonly InterviewerDbContext _dbContext;

    [HttpPost("commit")]
    [Authorize(Roles = "Student")]
    public async Task<MiniProgramControllerResponse> Commit([FromBody] Student student)
    {
        var user = await _userManager.GetUserAsync(User);
        student.Id = user.Id;
        var existingStudent = _dbContext.Students.FirstOrDefault(s => s.Id == student.Id);
        
        if (existingStudent is not null)
        {
            existingStudent.College=student.College;
            existingStudent.FirstDepartment=student.FirstDepartment;
            existingStudent.SecondDepartment=student.SecondDepartment;
            existingStudent.Grade=student.Grade;
            existingStudent.Introduction=student.Introduction;
            existingStudent.Name=student.Name;
            existingStudent.Phone=student.Phone;
            existingStudent.Qq=student.Qq;
            existingStudent.Skills=student.Skills;
            //existingStudent.State=student.State;
            existingStudent.StudentId=student.StudentId;
            existingStudent.WeChat=student.WeChat;
            _dbContext.Students.Update(existingStudent);
        }
        else
        {
            _dbContext.Students.Add(student);
        }

        await _dbContext.SaveChangesAsync();
        var foundStudent = _dbContext.Students.FirstOrDefault(s => s.Id == student.Id);
        return new MiniProgramControllerResponse() { Data = foundStudent };
    }

    [HttpGet("get_info")]
    [Authorize(Roles = "Student")]
    public async Task<MiniProgramControllerResponse> GetInfo()
    {
        var user = await _userManager.GetUserAsync(User);
        var student = _dbContext.Students.FirstOrDefault(s => s.Id == user.Id);
        return new MiniProgramControllerResponse() { Data = student };
    }

    [HttpGet("get_process")]
    [Authorize(Roles = "Student")]
    public async Task<MiniProgramControllerResponse> GetProcess()
    {
        var user = await _userManager.GetUserAsync(User);
        var student = _dbContext.Students.FirstOrDefault(s => s.Id == user.Id);
        return new MiniProgramControllerResponse() { Data = student?.State };
    }

    [HttpGet("checkin")]
    [Authorize(Roles = "Student")]
    public async Task<MiniProgramControllerResponse> CheckIn()
    {
        var user = await _userManager.GetUserAsync(User);
        var student = _dbContext.Students.FirstOrDefault(s => s.Id == user.Id);
        student.State = StudentState.CheckedIn;
        _dbContext.Students.Update(student);
        await _dbContext.SaveChangesAsync();
        return new MiniProgramControllerResponse() { Data = student?.State };
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using interviewer.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace interviewer.Controllers
{
    [Route("elc_recruit/interviewer")]
    [ApiController]
    public class InterviewController : ControllerBase
    {
        public InterviewController(IConfiguration configuration, UserManager<InterviewerUser> userManager)
        {
            _configuration = configuration;
            _userManager = userManager;
            _dbContext = new InterviewerDbContext(configuration);
        }

        private readonly IConfiguration _configuration;
        private readonly UserManager<InterviewerUser> _userManager;
        private readonly InterviewerDbContext _dbContext;

        [HttpGet]
        [Authorize]
        public IActionResult Hello()
        {
            return Ok("Hello ASP.NET!");
        }

        [HttpGet("get_brief_infos")]
        [Authorize(Roles = "Interviewer")]
        public object GetBriefInfos(int pageCount = 1, int pageLimit = 5, ElcDepartment depId = ElcDepartment.Software)
        {
            var students = _dbContext.Students?.Where(s => depId == ElcDepartment.All || s.FirstDepartment == depId);
            var count = students?.Count() ?? 0;
            var pageStudents = students
                ?.Skip(pageCount * pageLimit).Take(pageLimit)
                .ToArray();
            return new
            {
                Count = count,
                Data = pageStudents
            };
        }

        [HttpGet("get_detailed_info")]
        [Authorize(Roles = "Interviewer")]
        public object? GetDetailedInfo(Guid userId) =>
            new { data = _dbContext.Students?.FirstOrDefault(s => s.Id == userId) };

        [HttpGet("get_deps_size")]
        public object GetDepsSize() => new
        {
            data = Enum.GetValues<ElcDepartment>().Select(depId =>
            {
                var size = _dbContext.Students?.Count(s => depId == ElcDepartment.All || s.FirstDepartment == depId);
                return new
                {
                    depId,
                    size
                };
            })
        };

        [HttpGet("get_dep_checked_in")]
        [Authorize(Roles = "Interviewer")]
        public object GetDepCheckedIn([Required] ElcDepartment depId) =>
            new
            {
                data = _dbContext.Students?.Where(s =>
                        (depId == ElcDepartment.All || s.FirstDepartment == depId) && s.State == StudentState.CheckedIn)
                    .ToArray()
            };

        [HttpGet("/elc_recruit/interviewer/get_comment_score")]
        [Authorize(Roles = "Interviewer")]
        public IActionResult GetCommentScore([Required] Guid studentId)
        {
            return Ok(new
            {
                data = _dbContext.Comments?.Where(comment => studentId == comment.StudentId).Select(comment => comment)
            });
        }

        [HttpPost("update_student_status")]
        [Authorize(Roles = "Interviewer")]
        public object UpdateStudentStatus([Required] Guid userId, [Required] StudentState state)
        {
            var interviewerDepartment = _dbContext.Interviewers?.FirstOrDefault(i => i.Id == _userManager.GetUserAsync(User).Result.Id)?.Department;
            var studentDepartment = _dbContext.Students?.FirstOrDefault(s => s.Id == userId)?.FirstDepartment;
            if (interviewerDepartment != studentDepartment)
                return Unauthorized("不能更新其他部门的面试者状态");
            _dbContext.Students?.FirstOrDefault(s => s.Id == userId);
            var student = _dbContext.Students?.FirstOrDefault(s => s.Id == userId);
            if (student == null)
            {
                return new
                {
                    success = false,
                    message = "找不到此学生"
                };
            }

            student.State = state;
            _dbContext.SaveChanges();
            return new
            {
                success = true,
                data = student
            };
        }

        [HttpPost("/elc_recruit/interviewer/update_comment")]
        [Authorize(Roles = "Interviewer")]
        public IActionResult UpdateComment([Required] Comment comment)
        {
            var interviewerDepartment = _dbContext.Interviewers?.FirstOrDefault(i => i.Id == _userManager.GetUserAsync(User).Result.Id)?.Department;
            var studentDepartment = _dbContext.Students?.FirstOrDefault(s => s.Id == comment.StudentId)?.FirstDepartment;
            if (interviewerDepartment != studentDepartment)
                return Unauthorized("不能对其他部门的面试者提交评价");
            comment.DepId = studentDepartment;
            _dbContext.Comments?.Add(comment);
            _dbContext.SaveChanges();
            return Ok();
        }

        [HttpPost("/elc_recruit/interviewer/transfer_student")]
        public IActionResult TransferStudent([Required] Guid studentId, [Required] ElcDepartment sourceDepId, [Required] ElcDepartment targetDepId)
        {
            var student = _dbContext.Students?.FirstOrDefault(s => s.Id == studentId);
            //TODO
            throw new NotImplementedException();
        }   
    }
}

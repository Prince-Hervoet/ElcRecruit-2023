using System.ComponentModel.DataAnnotations;
using interviewer.Data;
using Microsoft.AspNetCore.Authorization;
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
                ?.Skip((pageCount - 1) * pageLimit).Take(pageLimit)
                .ToArray();
            return new Result
            {
                Data = new
                {
                    Count = count,
                    PageStudents = pageStudents
                }
            };
        }

        [HttpGet("get_detailed_info")]
        [Authorize(Roles = "Interviewer")]
        public object? GetDetailedInfo(string userId) =>
            new Result { Data = _dbContext.Students?.FirstOrDefault(s => s.Id == userId) };

        [HttpGet("get_deps_size")]
        public object GetDepsSize() => new Result
        {
            Data = Enum.GetValues<ElcDepartment>().Select(depId =>
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
            new Result
            {
                Data = _dbContext.Students?.Where(s =>
                        (depId == ElcDepartment.All && s.FirstDepartment == depId) && s.State == StudentState.CheckedIn)
                    .ToArray()
            };

        [HttpGet("get_comment_score")]
        [Authorize(Roles = "Interviewer")]
        public IActionResult GetCommentScore([Required] string studentUserId)
        {
            return Ok(new Result
            {
                Data = _dbContext.Comments?.Where(comment => studentUserId == comment.StudentUserId)
                    .Select(comment => comment)
            });
        }

        public record UpdateStudentStatusParms([Required] string userId, [Required] StudentState state);

        [HttpPost("update_student_status")]
        [Authorize(Roles = "Interviewer")]
        public object UpdateStudentStatus([Required] UpdateStudentStatusParms p)
        {
            var interviewerDepartment = _dbContext.Interviewers
                ?.FirstOrDefault(i => i.Id == _userManager.GetUserAsync(User).Result.Id)?.Department;
            var studentDepartment = _dbContext.Students?.FirstOrDefault(s => s.Id == p.userId)?.FirstDepartment;
            if (interviewerDepartment != ElcDepartment.All && interviewerDepartment != studentDepartment)
                return Unauthorized(new Result()
                {
                    ErrorMessages = new[] { "不能更新其他部门的面试者状态" }
                });
            _dbContext.Students?.FirstOrDefault(s => s.Id == p.userId);
            var student = _dbContext.Students?.FirstOrDefault(s => s.Id == p.userId);
            if (student == null)
            {
                return new Result
                {
                    ErrorMessages = new[] { "找不到此学生" }
                };
            }

            student.State = p.state;
            _dbContext.SaveChanges();
            return new Result
            {
                Data = student
            };
        }

        [HttpPost("commit_comment")]
        [Authorize(Roles = "Interviewer")]
        public IActionResult CommitComment([Required] Comment comment)
        {
            comment.Id = Guid.NewGuid().ToString();
            var interviewerDepartment = _dbContext.Interviewers
                ?.FirstOrDefault(i => i.Id == _userManager.GetUserAsync(User).Result.Id)?.Department;
            var studentDepartment = _dbContext.Students?.FirstOrDefault(s => s.Id == comment.StudentUserId)
                ?.FirstDepartment;
            if (interviewerDepartment != ElcDepartment.All || interviewerDepartment != studentDepartment)
                return Unauthorized(new Result
                {
                    ErrorMessages = new string[] { "不能对其他部门的面试者提交评价" }
                });
            comment.DepId = studentDepartment;
            _dbContext.Comments?.Add(comment);
            _dbContext.SaveChanges();
            return Ok();
        }

        public record TransferStudentParms([Required] string StudentId, [Required] ElcDepartment SourceDepId,
            [Required] ElcDepartment TargetDepId);

        [HttpPost("transfer_student")]
        [Authorize(Roles = "Interviewer")]
        public IActionResult TransferStudent([Required] TransferStudentParms p)
        {
            var student = _dbContext.Students?.FirstOrDefault(s => s.Id == p.StudentId);
            if (student == null)
                return Ok(new Result
                {
                    ErrorMessages = new[] { "找不到此学生" }
                });

            var interviewerDepartment = _dbContext.Interviewers
                .FirstOrDefault(i => i.Id == _userManager.GetUserAsync(User).Result.Id)?.Department;
            var studentDepartment = student.FirstDepartment;
            
            if (interviewerDepartment != ElcDepartment.All && interviewerDepartment != studentDepartment)
                return Unauthorized(new Result
                {
                    ErrorMessages = new[] { "不能调剂其他部门的面试者" }
                });

            student.FirstDepartment = p.TargetDepId;
            _dbContext.SaveChanges();

            return Ok(new Result
            {
                Data = student
            });
        }

        [HttpGet("get_search_brief_info")]
        [Authorize(Roles = "Interviewer")]
        public IActionResult GetSearchBriefInfo([Required] string keyword, ElcDepartment depId = ElcDepartment.All)
        {
            var students = _dbContext.Students?.Where(s =>
                (depId == ElcDepartment.All || s.FirstDepartment == depId) &&
                (s.Name.StartsWith(keyword) || s.StudentNumber.StartsWith(keyword)));
            return Ok(new Result()
            {
                Data = students
            });
        }

        [HttpPost("update_interviewer_info")]
        [Authorize(Roles = "Interviewer")]
        public IActionResult UpdateInterviewerInfo(Interviewer interviewer)
        {
            var user = _userManager.GetUserAsync(User).Result;
            var interviewerInDb = _dbContext.Interviewers?.FirstOrDefault(i => i.Id == user!.Id);
            if (interviewerInDb == null)
            {
                var newInterviewer = new Interviewer
                {
                    Id = user!.Id,
                    Name = interviewer.Name,
                    Department = interviewer.Department
                };
                _dbContext.Interviewers?.Add(newInterviewer);
                _dbContext.SaveChanges();
                return Ok(new Result
                {
                    Data = interviewerInDb
                });
            }

            interviewerInDb.Name = interviewer.Name;
            interviewerInDb.Department = interviewer.Department;
            _dbContext.SaveChanges();
            return Ok(new Result
            {
                Data = interviewerInDb
            });
        }
    }
}
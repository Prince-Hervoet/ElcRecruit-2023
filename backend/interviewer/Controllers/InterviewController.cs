using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using interviewer.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace interviewer.Controllers
{
    [Route("elc_recruit/interviewer")]
    [ApiController]
    public class InterviewController : ControllerBase
    {
        public InterviewController(IConfiguration configuration)
        {
            _configuration = configuration;
            _context = new InterviewerContext(configuration);
        }

        private readonly IConfiguration _configuration;
        private readonly InterviewerContext _context;

        [HttpGet]
        public IActionResult Hello()
        {
            return Ok("Hello ASP.NET!");
        }

        [HttpGet("get_brief_infos")]
        public object GetBriefInfos(int pageCount = 1, int pageLimit = 5, ElcDepartment depId = ElcDepartment.Software)
        {
            var students = _context.Students?.Where(s => depId == ElcDepartment.All || s.FirstDepartment == depId);
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
        public object? GetDetailedInfo(Guid userId) => new { data = _context.Students?.FirstOrDefault(s => s.Id == userId) };

        [HttpGet("get_deps_size")]
        public object GetDepsSize() => new
        {
            data = Enum.GetValues<ElcDepartment>().Select(depId =>
            {
                var size = _context.Students?.Count(s => depId == ElcDepartment.All || s.FirstDepartment == depId);
                return new
                {
                    depId,
                    size
                };
            })
        };

        [HttpGet("get_dep_checked_in")]
        public object GetDepCheckedIn([Required] ElcDepartment depId) =>
            new
            {
                data = _context.Students?.Where(s =>
                    (depId == ElcDepartment.All || s.FirstDepartment == depId) && s.State == StudentState.CheckedIn).ToArray()
            };
    }
}

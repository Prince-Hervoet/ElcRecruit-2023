using System;
using System.Collections.Generic;
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
        // public (int Total, List<Student>? data) GetBriefInfos(int pageCount = 1, int pageLimit = 5, ElcDepartment depId = ElcDepartment.Software) =>
        //     (_context.Students?.Count() ?? 0, _context.Students?.Where(s => s.FirstDepartment == depId).Skip(pageCount * pageLimit).Take(pageLimit)
        //         .ToList());
        public object GetBriefInfos(int pageCount = 1, int pageLimit = 5, ElcDepartment depId = ElcDepartment.Software)
        {
            var students = _context.Students?.Where(s => depId == ElcDepartment.All || s.FirstDepartment == depId);
            var count = students?.Count() ?? 0;
            var pageStudents = students
                ?.Skip(pageCount * pageLimit).Take(pageLimit)
                .ToList();
            return new
            {
                Count = count,
                Data = pageStudents
            };
        }
    }
}

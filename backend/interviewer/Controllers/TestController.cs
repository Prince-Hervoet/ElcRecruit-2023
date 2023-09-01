using interviewer.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace interviewer.Controllers
{
    [Route("api/[controller]")]
    public class TestController : ControllerBase
    {
        public TestController(UserManager<InterviewerUser> userManager)
        {
            _userManager = userManager;
        }

        private readonly UserManager<InterviewerUser> _userManager;

        [HttpGet("hello_admin")]
        [Authorize(Roles = "Admin")]
        public IActionResult HelloAdmin()
        {
            return Ok("Hello Admin!");
        }

        [HttpGet("check_role")]
        public async Task<IActionResult> CheckRole()
        {
            var user = await _userManager.GetUserAsync(HttpContext.User);
            if (user is null)
            {
                return Ok("Hello Guest!");
            }
            return Ok($"Hello {(await _userManager.GetRolesAsync(user)).Aggregate((prev, current) => prev + "|" + current)} {user.UserName}!");
        }
    }
}

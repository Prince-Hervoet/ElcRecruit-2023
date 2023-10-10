using interviewer.Data;
using Microsoft.AspNetCore.Authorization;
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

            var roles = (await _userManager.GetRolesAsync(user));
            if (roles.Any())
            {
                return Ok($"Hello {roles.Aggregate((prev, current) => prev + "|" + current)} {user.UserName}!");
            }

            return Ok($"Hello {user.UserName}!");
        }

        [HttpGet("delete_user")]
        [Authorize]
        public async Task<IActionResult> DeleteUser()
        {
            var user = await _userManager.GetUserAsync(HttpContext.User);
            if (user is null)
            {
                return Ok("Hello Guest!");
            }

            var result = await _userManager.DeleteAsync(user);
            if (result.Succeeded)
            {
                return Ok("User deleted!");
            }

            return BadRequest(result.Errors);
        }

        [HttpGet("delete_user_by_name")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> DeleteUserByName(string username)
        {
            var user = await _userManager.FindByNameAsync(username);
            if (user is null)
            {
                return Ok("User not found!");
            }

            var result = await _userManager.DeleteAsync(user);
            if (result.Succeeded)
            {
                return Ok("User deleted!");
            }

            return BadRequest(result.Errors);
        }

        [HttpGet("become_admin")]
        [Authorize]
        public async Task<IActionResult> BecomeAdmin()
        {
            InterviewerUser? interviewerUser = await _userManager.GetUserAsync(User);
            if (interviewerUser is null)
                return Ok(new Result
                {
                    ErrorMessages = new[] { "用户不存在" }
                });
            IdentityResult result = await _userManager.AddToRoleAsync(interviewerUser, "Admin");
            if (result.Succeeded)
                return Ok(new Result());

            return Ok(new Result
            {
                ErrorMessages = result.Errors.Select(e => e.Description).ToArray()
            });
        }
        
        [HttpGet("become_interviewer")]
        [Authorize]
        public async Task<IActionResult> BecomeInterviewer()
        {
            InterviewerUser? interviewerUser = await _userManager.GetUserAsync(User);
            if (interviewerUser is null)
                return Ok(new Result
                {
                    ErrorMessages = new[] { "用户不存在" }
                });
            IdentityResult result = await _userManager.AddToRoleAsync(interviewerUser, "Interviewer");
            if (result.Succeeded)
                return Ok(new Result());

            return Ok(new Result
            {
                ErrorMessages = result.Errors.Select(e => e.Description).ToArray()
            });
        }
    }
}
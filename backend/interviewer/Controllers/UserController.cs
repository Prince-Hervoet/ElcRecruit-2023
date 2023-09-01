using interviewer.Requests;
using interviewer.Responses;
using interviewer.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace interviewer.Controllers
{
    [Route("elc_recruit/interviewer/")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost("Register")]
        public async Task<IActionResult> Register(RegisterRequest request)
        {
            var result = await _userService.RegisterAsync(request.UserName, request.Password);
            if (!result.Success)
            {
                return BadRequest(new FailedResponse()
                {
                    Errors = result.Errors
                });
            }
            return Ok(new TokenResponse
            {
                AccessToken = result.AccessToken,
                TokenType = result.TokenType
            });
        }

        [HttpPost("Login")]
        public async Task<IActionResult> Login(LoginRequest request)
        {
            var result = await _userService.LoginAsync(request.UserName, request.Password);
            if (!result.Success)
            {
                return Ok(new FailedResponse()
                {
                    Errors = result.Errors
                });
            }
            return Ok(new TokenResponse
            {
                AccessToken = result.AccessToken,
                TokenType = result.TokenType
            });
        }

        [HttpPost("AddToUserRole")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> AddToUserRole(AddUserRoleRequest request)
        {
            var result = await _userService.AddToRoleAsync(request.Username, request.Password, request.Role);
            if (!result.Success)
            {
                return BadRequest(new FailedResponse()
                {
                    Errors = result.Errors
                });
            }
            return Ok();
        }
    }
}

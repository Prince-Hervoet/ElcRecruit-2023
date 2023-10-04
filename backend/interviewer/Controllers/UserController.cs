using interviewer.Requests;
using interviewer.Responses;
using interviewer.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using System.Text.Json;
using interviewer.Data;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.DataProtection;

namespace interviewer.Controllers
{
    [Route("elc_recruit/interviewer/")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private const string LoginProviderKey = "LoginProvider";
        private const string Provider_WeChat = "WeChat";

        private readonly IUserService<InterviewerUser> _userService;
        private readonly IHttpContextAccessor _contextAccessor;
        private readonly ILogger _logger;
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly IConfiguration _configuration;

        public UserController(IUserService<InterviewerUser> userService, IHttpContextAccessor contextAccessor,
            ILogger<UserController> logger, IHttpClientFactory httpClientFactory, IConfiguration configuration)
        {
            _userService = userService;
            _contextAccessor = contextAccessor;
            _logger = logger;
            _httpClientFactory = httpClientFactory;
            _configuration = configuration;
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

        [HttpPost("WeChatLogin")]
        public async Task<IActionResult> WeChatLogin(WeChatRequest request)
        {
            var builder = new UriBuilder("https://api.weixin.qq.com/sns/jscode2session");
            builder.Query =
                $"appid={_configuration["Authentication:WeChat:AppId"]}&secret={_configuration["Authentication:WeChat:AppSecret"]}" +
                $"&js_code={request.JsCode}&grant_type=authorization_code";
            var httpRequestMessage = new HttpRequestMessage(
                HttpMethod.Get,
                builder.Uri);

            var httpClient = _httpClientFactory.CreateClient();
            var httpResponseMessage = await httpClient.SendAsync(httpRequestMessage);

            if (!httpResponseMessage.IsSuccessStatusCode) return Problem();

            using var contentStream =
                await httpResponseMessage.Content.ReadAsStreamAsync();

            var sessionResponse = await JsonSerializer.DeserializeAsync
                <Code2SessionResponse>(contentStream);

            //TODO: sessionResponse.ErrorMessage
            if (sessionResponse is null || sessionResponse.ErrorCode != 0)
            {
                var failResult = new TokenResult();
                if (sessionResponse is not null)
                {
                    failResult.Errors = new[] { sessionResponse.ErrorMessage };
                }
                else
                {
                    failResult.Errors = new[] { "WeChat session response is empty." };
                }

                return Ok(failResult);
            }

            var openId = sessionResponse.OpenId;
            var tokenResult = await _userService.WeChatLoginAsync(openId);

            return Ok(tokenResult);
        }
    }
}
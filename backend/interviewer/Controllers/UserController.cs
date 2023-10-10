using System.ComponentModel.DataAnnotations;
using interviewer.Requests;
using interviewer.Responses;
using interviewer.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using interviewer.Data;
using StackExchange.Redis;
using TokenResult = interviewer.Responses.TokenResult;

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
        private readonly IMessageService _messageService;

        public UserController(IUserService<InterviewerUser> userService, IHttpContextAccessor contextAccessor,
            ILogger<UserController> logger, IHttpClientFactory httpClientFactory, IConfiguration configuration,
            IMessageService messageService)
        {
            _userService = userService;
            _contextAccessor = contextAccessor;
            _logger = logger;
            _httpClientFactory = httpClientFactory;
            _configuration = configuration;
            _messageService = messageService;
        }

        [HttpPost("Register")]
        public async Task<IActionResult> Register(RegisterRequest request)
        {
            var result = await _userService.RegisterAsync(request.UserName, request.Password);
            if (!result.Success)
            {
                return BadRequest(new FailedResult()
                {
                    ErrorMessages = result.ErrorMessages
                });
            }

            return Ok(new TokenResult
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
                return Ok(new FailedResult()
                {
                    ErrorMessages = result.ErrorMessages
                });
            }

            return Ok(new TokenResult
            {
                AccessToken = result.AccessToken,
                TokenType = result.TokenType
            });
        }
        
        [HttpPost("student_login")]
        public async Task<IActionResult> StudentLogin(StudentLoginRequest request)
        {
            var result = await _userService.LoginAsync("stu_" + request.PhoneNumber, request.Password);
            if (!result.Success)
            {
                return Ok(new FailedResult()
                {
                    ErrorMessages = result.ErrorMessages
                });
            }

            return Ok(new TokenResult
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
                return BadRequest(new FailedResult()
                {
                    ErrorMessages = result.ErrorMessages.ToArray()
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
                var failResult = new Services.TokenResult();
                if (sessionResponse is not null)
                {
                    failResult.ErrorMessages = new[] { sessionResponse.ErrorMessage };
                }
                else
                {
                    failResult.ErrorMessages = new[] { "WeChat session response is empty." };
                }

                return Ok(failResult);
            }

            var openId = sessionResponse.OpenId;
            var tokenResult = await _userService.WeChatLoginAsync(openId);

            return Ok(tokenResult);
        }

        [HttpGet("register_student")]
        public async Task<IActionResult> RegisterStudent(
            [RegularExpression(@"^(13[0-9]|14[01456879]|15[0-35-9]|16[2567]|17[0-8]|18[0-9]|19[0-35-9])\d{8}$",
                ErrorMessage = "手机号格式不正确")]
            string phoneNumber, string code, string password)
        {
            if (!await _messageService.VerifyCode(phoneNumber, code))
            {
                return Ok(new FailedResult()
                {
                    ErrorMessages = new[] { "验证码错误" }
                });
            }

            Services.TokenResult tokenResult = await _userService.RegisterStudentAsync(phoneNumber, password);
            return Ok(tokenResult);
        }

        [HttpPost("reset_password")]
        public async Task<IActionResult> ResetPassword(
            [RegularExpression(@"^(13[0-9]|14[01456879]|15[0-35-9]|16[2567]|17[0-8]|18[0-9]|19[0-35-9])\d{8}$",
                ErrorMessage = "手机号格式不正确")]
            string phoneNumber, string code, string password)
        {
            if (!await _messageService.VerifyCode(phoneNumber, code))
            {
                return Ok(new FailedResult()
                {
                    ErrorMessages = new[] { "验证码错误" }
                });
            }

            return Ok(await _userService.ResetPasswordAsync("stu_" + phoneNumber, password));
        }

    }
}
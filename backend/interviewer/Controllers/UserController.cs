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

        public UserController(IUserService<InterviewerUser> userService, IHttpContextAccessor contextAccessor, ILogger<UserController> logger, IHttpClientFactory httpClientFactory, IConfiguration configuration)
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
            builder.Query = $"appid={_configuration["Authentication:WeChat:AppId"]}&secret={_configuration["Authentication:WeChat:AppSecret"]}" +
                            $"&js_code={request.JsCode}&grant_type=authorization_code";
            var httpRequestMessage = new HttpRequestMessage(
                HttpMethod.Get,
                builder.Uri);

            var httpClient = _httpClientFactory.CreateClient();
            var httpResponseMessage = await httpClient.SendAsync(httpRequestMessage);

            Code2SessionResponse? sessionResponse = null;

            if (httpResponseMessage.IsSuccessStatusCode)
            {
                using var contentStream =
                    await httpResponseMessage.Content.ReadAsStreamAsync();

                sessionResponse = await JsonSerializer.DeserializeAsync
                    <Code2SessionResponse>(contentStream);
            }

            if (sessionResponse?.ErrorCode != 0)
                return BadRequest(sessionResponse);

            return Ok(sessionResponse);
        }

        // /// <summary>
        // /// 微信登录
        // /// </summary>
        // /// <param name="redirectUrl">授权成功后的跳转地址</param>
        // /// <returns></returns>
        // [HttpGet("LoginByWeChat")]
        // public IActionResult LoginByWeChat(string redirectUrl)
        // {
        //     var request = _contextAccessor.HttpContext.Request;
        //     var url = $"{request.Scheme}://{request.Host}{request.PathBase}{request.Path}Callback?provider={Provider_WeChat}&redirectUrl={redirectUrl}";
        //     var properties = new AuthenticationProperties { RedirectUri = url };
        //     properties.Items[LoginProviderKey] = Provider_WeChat;
        //     return Challenge(properties, Provider_WeChat);
        // }
        //
        // /// <summary>
        // /// 微信授权成功后自动回调的地址
        // /// </summary>
        // /// <param name="provider"></param>
        // /// <param name="redirectUrl">授权成功后的跳转地址</param>
        // /// <returns></returns>
        // [HttpGet("LoginByWeChatCallback")]
        // public async Task<IActionResult> LoginByWeChatCallbackAsync(string provider = null, string redirectUrl = "")
        // {
        //     var authenticateResult = await _contextAccessor.HttpContext.AuthenticateAsync(provider);
        //     if (!authenticateResult.Succeeded) return Redirect(redirectUrl);
        //     var openIdClaim = authenticateResult.Principal.FindFirst(ClaimTypes.NameIdentifier);
        //     if (openIdClaim == null || string.IsNullOrWhiteSpace(openIdClaim.Value))
        //         return Redirect(redirectUrl);
        //     //TODO 记录授权成功后的微信信息
        //     var city = authenticateResult.Principal.FindFirst("urn:wechat:city")?.Value;
        //     var country = authenticateResult.Principal.FindFirst(ClaimTypes.Country)?.Value;
        //     var headimgurl = authenticateResult.Principal.FindFirst(ClaimTypes.Uri)?.Value;
        //     var nickName = authenticateResult.Principal.FindFirst(ClaimTypes.Name)?.Value;
        //     var openId = authenticateResult.Principal.FindFirst(ClaimTypes.NameIdentifier)?.Value;
        //     var privilege = authenticateResult.Principal.FindFirst("urn:wechat:privilege")?.Value;
        //     var province = authenticateResult.Principal.FindFirst("urn:wechat:province")?.Value;
        //     var sexClaim = authenticateResult.Principal.FindFirst(ClaimTypes.Gender);
        //     int sex = 0;
        //     if (sexClaim != null && !string.IsNullOrWhiteSpace(sexClaim.Value))
        //         sex = int.Parse(sexClaim.Value);
        //     var unionId = authenticateResult.Principal.FindFirst("urn:wechat:unionid")?.Value;
        //     _logger.LogDebug($"WeChat Info=> openId: {openId},nickName: {nickName}");
        //     return Redirect($"{redirectUrl}?openId={openIdClaim.Value}");
        // }
    }
}

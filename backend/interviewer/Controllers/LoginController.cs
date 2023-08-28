using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Identity.Models;
using IdentityModel.Client;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace interviewer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        public LoginController(IConfiguration configuration)
        {
            _configuration=configuration;
        }

        private readonly IConfiguration _configuration;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;

        [HttpPost("Login")]
        public async Task<IActionResult> Login(string userName,string password)
        {
            // 从元数据中发现端点
            var client = new HttpClient();
            var disco = await client.GetDiscoveryDocumentAsync(_configuration["IdentityServerAddress"]);
            if (disco.IsError)
            {
                return Problem(disco.Error);
            }
            // 请求令牌
            var tokenResponse = await client.RequestClientCredentialsTokenAsync(new ClientCredentialsTokenRequest()
            {
                Address = disco.TokenEndpoint,

                ClientId = "mvc",
                // Scope = 
            });

            if (tokenResponse.IsError)
            {
                return BadRequest(tokenResponse.Error);
            }

            return Ok(tokenResponse.Json);
        }

        [HttpPost("Logout")]
        public IActionResult Logout()
        {
            return SignOut("Cookies", "oidc");
        }
    }
}

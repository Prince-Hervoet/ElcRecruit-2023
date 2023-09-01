using System.IdentityModel.Tokens.Jwt;
using System.Net;
using System.Security.Claims;
using System.Text;
using interviewer.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;

namespace interviewer.Services
{
    // UserService 实现
    public class UserService : IUserService
    {
        private readonly JwtSettings _jwtSettings;
        private readonly UserManager<InterviewerUser> _userManager;

        public UserService(JwtSettings jwtSettings, UserManager<InterviewerUser> userManager)
        {
            _jwtSettings = jwtSettings;
            _userManager = userManager;
        }

        public async Task<TokenResult> RegisterAsync(string username, string password)
        {
            var existingUser = await _userManager.FindByNameAsync(username);
            if (existingUser != null)
            {
                return new TokenResult
                {
                    Errors = new[] { "user already exists!" }, //用户已存在
                };
            }
            var newUser = new InterviewerUser() { UserName = username };
            var isCreated = await _userManager.CreateAsync(newUser, password);
            if (!isCreated.Succeeded)
            {
                return new TokenResult
                {
                    Errors = isCreated.Errors.Select(p => p.Description)
                };
            }
            return GenerateJwtToken(newUser);
        }
        public async Task<TokenResult> LoginAsync(string username, string password)
        {
            var existingUser = await _userManager.FindByNameAsync(username);
            if (existingUser == null)
            {
                return new TokenResult
                {
                    Errors = new[] { "user does not exist!" }, //用户不存在
                };
            }
            var isCorrect = await _userManager.CheckPasswordAsync(existingUser, password);
            if (!isCorrect)
            {
                return new TokenResult
                {
                    Errors = new[] { "wrong user name or password!" }, //用户名或密码错误
                };
            }
            return GenerateJwtToken(existingUser);
        }

        public async Task<EditResult> AddToRoleAsync(string username,string password, string role)
        {
            var existingUser = await _userManager.FindByNameAsync(username);
            if (existingUser == null)
            {
                return new EditResult
                {
                    Errors = new[] { "user does not exist!" }, //用户不存在
                };
            }
            var isCorrect = await _userManager.CheckPasswordAsync(existingUser, password);
            if (!isCorrect)
            {
                return new EditResult
                {
                    Errors = new[] { "wrong user name or password!" }, //用户名或密码错误
                };
            }

            var isAdded = await _userManager.AddToRoleAsync(existingUser, role);
            if (!isAdded.Succeeded)
            {
                return new EditResult
                {
                    Errors = isAdded.Errors.Select(p => p.Description)
                };
            }
            return new EditResult();
        }

        private TokenResult GenerateJwtToken(InterviewerUser user)
        {
            var key = Encoding.ASCII.GetBytes(_jwtSettings.SecurityKey);
            var roleClaims = new List<Claim>();
            foreach (var role in _userManager.GetRolesAsync(user).Result)
            {
                roleClaims.Add(new Claim(ClaimTypes.Role, role));
            }
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new[]
                {
                    new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                    new Claim(JwtRegisteredClaimNames.Sub, user.Id.ToString())
                }.Concat(roleClaims)),
                IssuedAt = DateTime.UtcNow,
                NotBefore = DateTime.UtcNow,
                Expires = DateTime.UtcNow.Add(_jwtSettings.ExpiresIn),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key),
                    SecurityAlgorithms.HmacSha256Signature)
            };
            var jwtTokenHandler = new JwtSecurityTokenHandler();
            var securityToken = jwtTokenHandler.CreateToken(tokenDescriptor);
            var token = jwtTokenHandler.WriteToken(securityToken);
            return new TokenResult
            {
                AccessToken = token,
                TokenType = "Bearer"
            };
        }
    }
}

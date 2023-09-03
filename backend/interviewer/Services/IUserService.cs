using interviewer.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SignInResult = Microsoft.AspNetCore.Identity.SignInResult;

namespace interviewer.Services;

// IUserService 接口
public interface IUserService<in TUser> where TUser : class
{
    Task<TokenResult> RegisterAsync(string username, string password);
    Task<TokenResult> LoginAsync(string username, string password);
    Task<TokenResult> WeChatRegisterAsync();
    IActionResult WeChatLoginAsync(string returnUrl);
    Task<ExternalLoginInfo?> GetExternalLoginInfoAsync();
    Task<SignInResult> ExternalLoginSignInAsync(ExternalLoginInfo info);
    Task<IdentityResult> CreateUser(TUser user);
    Task<IdentityResult> AddLoginAsync(TUser user, ExternalLoginInfo info);
    Task<EditResult> AddToRoleAsync(string username, string password, string role);
}
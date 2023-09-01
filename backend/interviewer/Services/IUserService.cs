namespace interviewer.Services;

// IUserService 接口
public interface IUserService
{
    Task<TokenResult> RegisterAsync(string username, string password);
    Task<TokenResult> LoginAsync(string username, string password);
    Task<EditResult> AddToRoleAsync(string username, string password, string role);
}
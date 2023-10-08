using interviewer.Data;

namespace interviewer.Services;

public interface IMessageService
{
    Task<Result> SendVerificationCode(string phoneNumber);
    Task<bool> VerifyCode(string phoneNumber, string code);
}
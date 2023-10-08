using interviewer.Data;

namespace interviewer.Services;

internal abstract class MessageServiceBase : IMessageService
{
    public abstract Task<Result> SendVerificationCode(string phoneNumber);
    public abstract Task<bool> VerifyCode(string phoneNumber, string code);
}
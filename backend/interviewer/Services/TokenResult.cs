using interviewer.Data;
using interviewer.Responses;

namespace interviewer.Services
{
    // TokenResult 定义
    public class TokenResult : Result
    {
        public string AccessToken { get; set; }
        public string TokenType { get; set; }
    }
}
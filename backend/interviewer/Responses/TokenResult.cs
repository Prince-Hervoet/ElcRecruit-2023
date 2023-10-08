using System.Text.Json.Serialization;
using interviewer.Data;

namespace interviewer.Responses
{
    // 注册 登录 成功后返回 token
    public class TokenResult : Result
    {
        [JsonPropertyName("access_token")] public string AccessToken { get; set; }
        [JsonPropertyName("token_type")] public string TokenType { get; set; }
    }
}
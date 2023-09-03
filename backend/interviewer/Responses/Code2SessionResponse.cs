using System.Text.Json.Serialization;

namespace interviewer.Responses
{
    public class Code2SessionResponse
    {
        [JsonPropertyName("session_key")] public string SessionKey { get; set; }
        [JsonPropertyName("unionid")] public string UnionId { get; set; }
        [JsonPropertyName("errmsg")] public string ErrorMessage { get; set; }
        [JsonPropertyName("openid")] public string OpenId { get; set; }
        [JsonPropertyName("errcode")] public int ErrorCode { get; set; }
    }
}

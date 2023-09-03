using System.Text.Json.Serialization;

namespace interviewer.Requests;

public class WeChatRequest
{
    [JsonPropertyName("js_code")]
    public string JsCode { get; set; }
}
namespace interviewer.Responses
{
    // 登录 注册 失败时返回错误信息
    public class FailedResponse
    {
        public IEnumerable<string> Errors { get; set; }
    }
}

namespace interviewer.Responses;

public class MiniProgramControllerResponse
{
    public string[]? ErrorMessages { get; set; }
    public object? Data { get; set; }
    public bool Success => ErrorMessages?.Any() != false;
}
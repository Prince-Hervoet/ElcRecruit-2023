namespace interviewer.Responses;

public class RootControllerResponses
{
    public string[]? ErrorMessage { get; set; }
    public object? Data { get; set; }
    public bool Success => ErrorMessage?.Any() != false;
}
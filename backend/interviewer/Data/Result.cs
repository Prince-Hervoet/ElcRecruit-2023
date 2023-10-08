namespace interviewer.Data;

public class Result
{
    public string[]? ErrorMessages { get; set; }
    public object? Data { get; set; }
    public bool Success => ErrorMessages?.Any() != true;
}
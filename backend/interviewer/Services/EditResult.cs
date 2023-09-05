namespace interviewer.Services;

public class EditResult
{
    public bool Success => Errors == null || !Errors.Any();
    public IEnumerable<string> Errors { get; set; }
}
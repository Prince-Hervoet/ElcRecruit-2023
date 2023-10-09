namespace interviewer.Data;

public class MessageSettings
{
    public int CodeLength { get; set; }
    public TimeSpan CodeExpireIn { get; set; }
    public TimeSpan SendCodeInterval { get; set; }
}
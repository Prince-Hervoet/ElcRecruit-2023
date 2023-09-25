namespace interviewer.Responses;

public class RootControllerResponses
{
    public string ErrorMessage { get; }
    public object Data { get; }
    public bool Success { get; }

    public RootControllerResponses(string errorMessage, object data, bool success)
    {
        ErrorMessage = errorMessage;
        Data = data;
        Success = success;
    }

    public override string ToString()
    {
        return $"{{ ErrorMessage = {ErrorMessage}, Data = {Data}, Success = {Success} }}";
    }

    public override bool Equals(object? value)
    {
        return value is RootControllerResponses other && EqualityComparer<string>.Default.Equals(other.ErrorMessage, ErrorMessage) && EqualityComparer<object>.Default.Equals(other.Data, Data) && EqualityComparer<bool>.Default.Equals(other.Success, Success);
    }

    public override int GetHashCode()
    {
        var hash = 0x7a2f0b42;
        hash = (-1521134295 * hash) + EqualityComparer<string>.Default.GetHashCode(ErrorMessage);
        hash = (-1521134295 * hash) + EqualityComparer<object>.Default.GetHashCode(Data);
        return (-1521134295 * hash) + EqualityComparer<bool>.Default.GetHashCode(Success);
    }
}
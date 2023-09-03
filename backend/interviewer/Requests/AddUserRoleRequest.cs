namespace interviewer.Requests;

public class AddUserRoleRequest
{
    public string Username { get; set; }
    public string Password { get; set; }
    public string Role { get; set; }
}
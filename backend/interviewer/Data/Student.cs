using System.ComponentModel.DataAnnotations;

namespace interviewer.Data;

public class Student
{
    [Key]
    public Guid Id { get; set; }
    public string StudentId { get; set; }
    public string Name { get; set; }
    public string College { get; set; }
    public string Grade { get; set; }
    public string? Skills { get; set; }
    public string Introduction { get; set; }
    public string Phone { get; set; }
    public string? Qq { get; set; }
    public string? WeChat { get; set; }
    public ElcDepartment FirstDepartment { get; set; }
    public ElcDepartment? SecondDepartment { get; set; }
}
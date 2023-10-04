using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace interviewer.Data;

public class StudentHistory
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public string Id { get; set; } = new Guid().ToString();
    public required string StudentId { get; set; }
    public StudentState State { get; set; }
    public ProcessState ProcessState { get; set; }
    public DateTime Time { get; set; } = DateTime.UtcNow;
}
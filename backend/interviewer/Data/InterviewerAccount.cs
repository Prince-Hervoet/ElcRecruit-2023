using System.ComponentModel.DataAnnotations;

namespace interviewer.Data
{
    public class InterviewerAccount
    {
        [Key]
        public Guid Id { get; set; }
        public required string Password { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;

namespace interviewer.Data
{
    public class Comment
    {
        [Key]
        public Guid StudentId { get; set; }
        public required string InterviewerName { get; set; }
        public ElcDepartment? DepId { get; set; }
        [Range(1, 10)] public int Score { get; set; }
        public required string Content { get; set; }
        public DateTime Time { get; set; }
    }
}

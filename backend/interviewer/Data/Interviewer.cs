using System.ComponentModel.DataAnnotations;

namespace interviewer.Data
{
    public class Interviewer
    {
        [Key]
        public Guid Id { get; set; }
        public required string Name { get; set; }
        public ElcDepartment Department { get; set; }
    }
}

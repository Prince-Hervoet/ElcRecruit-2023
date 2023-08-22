using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace interviewer.Data
{
    public class StudentAccount
    {
        [Key]
        public Guid Id { get; set; }
        public required string Password { get; set; }
    }
}

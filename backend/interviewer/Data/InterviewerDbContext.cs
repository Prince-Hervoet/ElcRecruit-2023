using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace interviewer.Data;

public class InterviewerDbContext : IdentityDbContext<InterviewerUser,IdentityRole<Guid>,Guid>
{
    public DbSet<Student> Students { get; set; }
    public DbSet<Interviewer> Interviewers { get; set; }
    public DbSet<Comment> Comments { get; set; }

    private readonly string? _connectionString;

    public InterviewerDbContext(IConfiguration configuration)
    {
        _connectionString = configuration["ConnectionStrings:DefaultConnection"];
        if (_connectionString is null)
            throw new Exception("Connection string is null");
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(_connectionString);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<IdentityRole<Guid>>().HasData(new IdentityRole<Guid> { Name = "Admin", NormalizedName = "ADMIN", Id = Guid.NewGuid(), ConcurrencyStamp = Guid.NewGuid().ToString() });
        modelBuilder.Entity<IdentityRole<Guid>>().HasData(new IdentityRole<Guid> { Name = "Interviewer", NormalizedName = "INTERVIEWER", Id = Guid.NewGuid(), ConcurrencyStamp = Guid.NewGuid().ToString() });
        modelBuilder.Entity<IdentityRole<Guid>>().HasData(new IdentityRole<Guid> { Name = "Student", NormalizedName = "STUDENT", Id = Guid.NewGuid(), ConcurrencyStamp = Guid.NewGuid().ToString() });

        List<Student> students= new();
        for (int i = 0; i < 50; i++)
        {
            students.Add(new Student
            {
                Id = Guid.NewGuid(),
                College = "计算机学院",
                FirstDepartment = ElcDepartment.Software,
                Grade = "22网络工程",
                Introduction = "学生",
                Name = "HeChu",
                Phone = "13323588435",
                Qq = "235247902",
                StudentId = "3122004832"
            });
            students.Add(new Student
            {
                Id = Guid.NewGuid(),
                College = "计算机学院",
                FirstDepartment = ElcDepartment.Project,
                Grade = "22网络工程",
                Introduction = "学生",
                Name = "ChuHe",
                Phone = "13323588435",
                Qq = "235247902",
                StudentId = "3122004832"
            });
        }
        modelBuilder.Entity<Student>().HasData(students);
    }
}
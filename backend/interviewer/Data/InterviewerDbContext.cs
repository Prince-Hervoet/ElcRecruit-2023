using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace interviewer.Data;

public class InterviewerDbContext : IdentityDbContext<InterviewerUser>
{
    public DbSet<Student> Students { get; set; }
    public DbSet<Interviewer> Interviewers { get; set; }
    public DbSet<Comment> Comments { get; set; }

    private readonly string? _connectionString;

    private readonly UserManager<InterviewerUser> _userManager;

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

        modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole { Name = "Admin", NormalizedName = "ADMIN", Id = Guid.NewGuid().ToString(), ConcurrencyStamp = Guid.NewGuid().ToString() });
        modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole { Name = "Interviewer", NormalizedName = "INTERVIEWER", Id = Guid.NewGuid().ToString(), ConcurrencyStamp = Guid.NewGuid().ToString() });
        modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole { Name = "Student", NormalizedName = "STUDENT", Id = Guid.NewGuid().ToString(), ConcurrencyStamp = Guid.NewGuid().ToString() });

        List<Student> students= new();
        for (int i = 0; i < 50; i++)
        {
            students.Add(new Student
            {
                Id = Guid.NewGuid().ToString(),
                College = "�����ѧԺ",
                FirstDepartment = ElcDepartment.Software,
                Grade = "22���繤��",
                Introduction = "ѧ��",
                Name = "HeChu",
                Phone = "13323588435",
                Qq = "235247902",
                StudentId = "3122004832"
            });
            students.Add(new Student
            {
                Id = Guid.NewGuid().ToString(),
                College = "�����ѧԺ",
                FirstDepartment = ElcDepartment.Project,
                Grade = "22���繤��",
                Introduction = "ѧ��",
                Name = "ChuHe",
                Phone = "13323588435",
                Qq = "235247902",
                StudentId = "3122004832"
            });
        }
        modelBuilder.Entity<Student>().HasData(students);
    }
}
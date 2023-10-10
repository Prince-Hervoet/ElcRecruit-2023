using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace interviewer.Data;

public class InterviewerDbContext : IdentityDbContext<InterviewerUser>
{
    public DbSet<Student> Students { get; set; }
    public DbSet<Interviewer> Interviewers { get; set; }
    public DbSet<Comment> Comments { get; set; }
    public DbSet<IntegerProperty> IntegerProperties { get; set; }
    public DbSet<StudentHistory> StudentHistories { get; set; }

    private readonly string? _connectionString;

    [FromServices] public UserManager<InterviewerUser> UserManager { get; set; }

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

    protected override async void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole
        {
            Name = "Admin", NormalizedName = "ADMIN", Id = Guid.NewGuid().ToString(),
            ConcurrencyStamp = Guid.NewGuid().ToString()
        });
        modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole
        {
            Name = "Interviewer", NormalizedName = "INTERVIEWER", Id = Guid.NewGuid().ToString(),
            ConcurrencyStamp = Guid.NewGuid().ToString()
        });
        modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole
        {
            Name = "Student", NormalizedName = "STUDENT", Id = Guid.NewGuid().ToString(),
            ConcurrencyStamp = Guid.NewGuid().ToString()
        });

        Random random = new();

        List<Student> students = new();
        for (int i = 0; i < 100; i++)
        {
            students.Add(new Student
            {
                Id = Guid.NewGuid().ToString(),
                College = (College)random.Next(27),
                FirstDepartment = (ElcDepartment)random.Next(1, 7),
                Grade = RandomString(6),
                Introduction = RandomNumber(24),
                Name = RandomString(6),
                Phone = RandomNumber(11),
                Qq = RandomNumber(10),
                StudentNumber = RandomNumber(10)
            });
        }

        modelBuilder.Entity<Student>().HasData(students);

        if (await UserManager.FindByNameAsync("admin") is null)
        {
            InterviewerUser user = new InterviewerUser()
            {
                Id = new Guid().ToString(),
                UserName = "admin",
            };
            await UserManager.CreateAsync(user, "@Admin");

            await UserManager.AddToRoleAsync(user, "Admin");
        }

        string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        string RandomNumber(int length)
        {
            const string chars = "0123456789";
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        modelBuilder.Entity<IntegerProperty>().HasData(new IntegerProperty()
            { Name = "ProcessState", Value = (int)ProcessState.FirstRoundInterview });
    }
}
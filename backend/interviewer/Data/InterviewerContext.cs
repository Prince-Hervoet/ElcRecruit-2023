using Microsoft.EntityFrameworkCore;

namespace interviewer.Data;

public class InterviewerContext : DbContext
{
    public DbSet<Student>? Students { get; set; }
    public DbSet<Interviewer>? Interviewers { get; set; }
    public DbSet<StudentAccount>? StudentAccounts { get; set; }
    public DbSet<InterviewerAccount>? InterviewerAccounts { get; set; }

    private readonly string? _connectionString;

    public InterviewerContext(IConfiguration configuration)
    {
        _connectionString = configuration["ConnectionStrings:DefaultConnection"];
        if (_connectionString is null)
            throw new Exception("Connection string is null");
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(_connectionString);
    }
}
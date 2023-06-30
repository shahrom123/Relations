using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Context;

public class DataContext:DbContext
{
    public DataContext(DbContextOptions<DataContext>options):base(options)
    {
        
    }
    public DbSet<Company> Companies { get; set;}
    public DbSet<EmployeeSkill> EmployeeSkills { get; set; }
    public DbSet<Employee> Employees { get; set; }
    public DbSet<Skill> Skills { get; set; }
    
    
    
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<EmployeeSkill>().HasKey(es => new { es.EmployeeId, es.SkillId });
        base.OnModelCreating(modelBuilder);
    }
}
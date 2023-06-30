using System.ComponentModel.DataAnnotations;

namespace Domain.Entities;

public class Skill
{
    public int Id { get; set; }
    [Required,MaxLength(50)]
    public string Name { get; set; }
    [Required]
    public List<EmployeeSkill> EmployeeSkills { get; set; }
    
}


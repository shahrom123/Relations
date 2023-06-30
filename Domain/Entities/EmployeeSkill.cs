namespace Domain.Entities;

public class EmployeeSkill
{
    public int SkillId { get; set; }
    public int EmployeeId { get; set; }
    public Skill Skill { get; set; }
    public Employee Employee { get; set; }
}
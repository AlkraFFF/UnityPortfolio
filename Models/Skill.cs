namespace UnityPortfolio.Models;

public record Skill(string Name, string ProficiencyLevel, string IconClass);

public record SkillCategory(string CategoryName, List<Skill> Skills);
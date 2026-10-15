using UnityPortfolio.Models;


namespace UnityPortfolio.Services;

public interface IPortfolioService
{
    Task<IReadOnlyList<Project>> GetProjectsAsync();
    Task<IReadOnlyList<SkillCategory>> GetSkillCategoriesAsync();
}
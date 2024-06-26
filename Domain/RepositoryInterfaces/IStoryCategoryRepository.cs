using Domain.Entities;

namespace Domain.RepositoryInterfaces;

public interface IStoryCategoryRepository
{
    Task<IEnumerable<StoryCategory>> GetAllAsync();
    Task<StoryCategory> GetCategoryByName(string name);
}
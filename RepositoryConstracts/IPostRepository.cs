using Entities;

namespace RepositoryConstracts;

public class IPostRepository
{
    Task<Post> AddAsync(Post post);
    Task UpdateAsync(Post post);
    Task DeleteAsync(int id);
    Task<Post> GetSingleAsync(int id);
    IQueryable<Post> GetMany();
}
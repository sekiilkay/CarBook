namespace UdemyCarBook.Application.Features.RepositoryPattern
{
    public interface IGenericRepository<T> where T : class
    {
        Task<List<T>> GetAllAsync();
        Task CreateAsync(T entity);
        Task UpdateAsync(T entity);
        Task RemoveAsync(T entity);
        Task<T> GetByIdAsync(int id);
        Task<List<T>> GetCommentsByBlogIdAsync(int id);
        Task<int> GetCountCommentByBlogAsync(int id);
    }
}

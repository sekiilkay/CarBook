using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Interfaces.BlogInterfaces
{
    public interface IBlogRepository
    {
        Task<List<Blog>> GetLast3BlogsWithAuthorsAsync();
        Task<List<Blog>> GetAllBlogsWithAuthorsAsync();
        Task<List<Blog>> GetBlogByAuthorIdAsync(int id);
    }
}

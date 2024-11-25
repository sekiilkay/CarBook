using Microsoft.EntityFrameworkCore;
using UdemyCarBook.Application.Interfaces.BlogInterfaces;
using UdemyCarBook.Domain.Entities;
using UdemyCarBook.Persistance.Context;

namespace UdemyCarBook.Persistance.Repositories.BlogRepositories
{
    public class BlogRepository(CarBookContext context) : IBlogRepository
    {
        public async Task<List<Blog>> GetAllBlogsWithAuthorsAsync()
        {
            return await context.Blogs
                .Include(x => x.Category)
                .Include(x => x.Author)
                .ToListAsync();
        }

        public async Task<List<Blog>> GetBlogByAuthorIdAsync(int id)
        {
            return await context.Blogs
                .Include(x => x.Author)
                .Where(x => x.Id == id)
                .ToListAsync(); ;
        }

        public async Task<List<Blog>> GetLast3BlogsWithAuthorsAsync()
        {
            return await context.Blogs.
                Include(x => x.Author)
                .OrderByDescending(x => x.Id)
                .Take(3)
                .ToListAsync();
        }
    }
}

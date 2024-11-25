using Microsoft.EntityFrameworkCore;
using UdemyCarBook.Application.Features.RepositoryPattern;
using UdemyCarBook.Domain.Entities;
using UdemyCarBook.Persistance.Context;

namespace UdemyCarBook.Persistance.Repositories.CommentRepositories
{
    public class CommentRepository(CarBookContext context) : IGenericRepository<Comment>
    {
        public async Task CreateAsync(Comment entity)
        {
            await context.AddAsync(entity);
            await context.SaveChangesAsync();
        }

        public async Task<List<Comment>> GetAllAsync()
        {
            return await context.Comments.Select(x => new Comment
            {
                BlogId = x.BlogId,
                CreatedDate = x.CreatedDate,
                Description = x.Description,
                Id = x.Id,
                Email = x.Email,
                Name = x.Name,
            }).ToListAsync();
        }

        public async Task<Comment> GetByIdAsync(int id)
        {
            return await context.Comments.FindAsync(id);
        }

        public async Task<List<Comment>> GetCommentsByBlogIdAsync(int id)
        {
            return await context.Set<Comment>()
                .Where(x => x.BlogId == id).ToListAsync();
        }

        public async Task<int> GetCountCommentByBlogAsync(int id)
        {
            return await context.Comments
                .Where(x => x.BlogId == id)
                .CountAsync();
        }

        public async Task RemoveAsync(Comment entity)
        {
            context.Remove(entity);
            await context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Comment entity)
        {
            context.Update(entity);
            await context.SaveChangesAsync();
        }
    }
}

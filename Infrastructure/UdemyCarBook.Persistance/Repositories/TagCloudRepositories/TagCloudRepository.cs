using Microsoft.EntityFrameworkCore;
using UdemyCarBook.Application.Interfaces.TagCloudInterfaces;
using UdemyCarBook.Domain.Entities;
using UdemyCarBook.Persistance.Context;

namespace UdemyCarBook.Persistance.Repositories.TagCloudRepositories
{
    public class TagCloudRepository(CarBookContext context) : ITagCloudRepository
    {
        public async Task<List<TagCloud>> GetTagCloudsByBlogIdAsync(int id)
        {
            return await context.TagClouds
                .Where(x => x.BlogId == id)
                .ToListAsync();
        }
    }
}

using Microsoft.EntityFrameworkCore;
using UdemyCarBook.Application.Interfaces.ReviewInterfaces;
using UdemyCarBook.Domain.Entities;
using UdemyCarBook.Persistance.Context;

namespace UdemyCarBook.Persistance.Repositories.ReviewRepositories
{
    public class ReviewRepository(CarBookContext context) : IReviewRepository
    {
        public async Task<List<Review>> GetReviewsByCarIdAsync(int carId)
        {
            return await context.Reviews
                .Where(x => x.CarId == carId)
                .ToListAsync();
        }
    }
}

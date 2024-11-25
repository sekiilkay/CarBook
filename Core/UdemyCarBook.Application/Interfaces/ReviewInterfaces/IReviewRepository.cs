using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Interfaces.ReviewInterfaces
{
    public interface IReviewRepository
    {
        Task<List<Review>> GetReviewsByCarIdAsync(int carId);
    }
}

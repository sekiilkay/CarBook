using Microsoft.EntityFrameworkCore;
using UdemyCarBook.Application.Interfaces.CarDescriptionInterfaces;
using UdemyCarBook.Domain.Entities;
using UdemyCarBook.Persistance.Context;

namespace UdemyCarBook.Persistance.Repositories.CarDescriptionRepositories
{
    public class CarDescriptionRepository(CarBookContext context) : ICarDescriptionRepository
    {
        public async Task<CarDescription> GetCarDescriptionAsync(int carId)
        {
            return await context.CarDescriptions
                .Where(x => x.CarId == carId)
                .FirstOrDefaultAsync();
        }
    }
}

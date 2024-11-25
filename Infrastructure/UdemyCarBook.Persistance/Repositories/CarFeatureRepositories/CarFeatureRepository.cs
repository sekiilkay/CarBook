using Microsoft.EntityFrameworkCore;
using UdemyCarBook.Application.Interfaces.CarFeatureInterfaces;
using UdemyCarBook.Domain.Entities;
using UdemyCarBook.Persistance.Context;

namespace UdemyCarBook.Persistance.Repositories.CarFeatureRepositories
{
    public class CarFeatureRepository(CarBookContext context) : ICarFeatureRepository
    {
        public void ChangeCarFeatureAvailableToFalse(int id)
        {
            var values = context.CarFeatures.Where(x => x.Id == id).FirstOrDefault();
            values.Available = false;
            context.SaveChanges();
        }

        public void ChangeCarFeatureAvailableToTrue(int id)
        {
            var values = context.CarFeatures.Where(x => x.Id == id).FirstOrDefault();
            values.Available = true;
            context.SaveChanges();
        }

        public async Task CreateCarFeatureByCarAsync(CarFeature carFeature)
        {
            await context.CarFeatures.AddAsync(carFeature);
            await context.SaveChangesAsync();
        }

        public async Task<List<CarFeature>> GetCarFeaturesByCarIdAsync(int carId)
        {
            return await context.CarFeatures.
                Include(y => y.Feature).
                Where(x => x.CarId == carId)
                .ToListAsync();
        }
    }
}

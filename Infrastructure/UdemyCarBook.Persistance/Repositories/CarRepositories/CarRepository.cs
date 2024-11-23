using Microsoft.EntityFrameworkCore;
using UdemyCarBook.Application.Interfaces.CarInterfaces;
using UdemyCarBook.Domain.Entities;
using UdemyCarBook.Persistance.Context;

namespace UdemyCarBook.Persistance.Repositories.CarRepositories
{
    public class CarRepository(CarBookContext context) : ICarRepository
    {
        public async Task<List<Car>> GetCarsListWithBrandsAsync()
        {
            return await context.Cars
                .Include(x => x.Brand)
                .ToListAsync();
        }

        public async Task<List<Car>> GetLast5CarsWithBrandsAsync()
        {
            return await context.Cars
                .Include(x => x.Brand)
                .OrderByDescending(x => x.Id)
                .Take(5)
                .ToListAsync();
        }
    }
}

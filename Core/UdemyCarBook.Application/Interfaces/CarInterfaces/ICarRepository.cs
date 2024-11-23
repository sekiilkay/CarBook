using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Interfaces.CarInterfaces
{
    public interface ICarRepository
    {
        Task<List<Car>> GetCarsListWithBrandsAsync();
        Task<List<Car>> GetLast5CarsWithBrandsAsync();
    }
}

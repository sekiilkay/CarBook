using UdemyCarBook.Application.ViewModels;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Interfaces.CarPricingInterfaces
{
    public interface ICarPricingRepository
    {
        Task<List<CarPricing>> GetCarPricingWithCarsAsync();
        Task<List<CarPricing>> GetCarPricingWithTimePeriodAsync();
        List<CarPricingViewModel> GetCarPricingWithTimePeriod1();
    }
}

using Microsoft.EntityFrameworkCore;
using UdemyCarBook.Application.Interfaces.StatisticsInterfaces;
using UdemyCarBook.Persistance.Context;

namespace UdemyCarBook.Persistance.Repositories.StatisticsRepositories
{
    public class StatisticsRepository(CarBookContext context) : IStatisticsRepository
    {
        public async Task<int> GetAuthorCountAsync()
        {
            return await context.Authors
                .CountAsync();
        }

        public async Task<decimal> GetAvgRentPriceForDailyAsync()
        {
            int id = await context.Pricings.Where(x => x.Name == "Günlük")
                .Select(y => y.Id).FirstOrDefaultAsync();

            return await context.CarPricings.Where(x => x.PricingId == id)
                .AverageAsync(x => x.Amount);
        }

        public async Task<decimal> GetAvgRentPriceForMonthlyAsync()
        {
            int id = await context.Pricings.Where(x => x.Name == "Aylık")
                 .Select(y => y.Id).FirstOrDefaultAsync();

            return await context.CarPricings.Where(x => x.PricingId == id)
                .AverageAsync(x => x.Amount);
        }

        public async Task<decimal> GetAvgRentPriceForWeeklyAsync()
        {
            int id = await context.Pricings.Where(x => x.Name == "Haftalık")
                 .Select(y => y.Id).FirstOrDefaultAsync();

            return await context.CarPricings.Where(x => x.PricingId == id)
                .AverageAsync(x => x.Amount);
        }

        public async Task<int> GetBlogCountAsync()
        {
            return await context.Blogs
                .CountAsync();
        }

        public async Task<string> GetBlogTitleByMaxBlogCommentAsync()
        {
            var values = await context.Comments.GroupBy(x => x.BlogId).
                              Select(y => new
                              {
                                  BlogId = y.Key,
                                  Count = y.Count()
                              }).OrderByDescending(z => z.Count).Take(1).FirstOrDefaultAsync();

            return await context.Blogs.Where(x => x.Id == values.BlogId).Select(y => y.Title).FirstOrDefaultAsync();
        }

        public async Task<int> GetBrandCountAsync()
        {
            return await context.Brands
                .CountAsync();
        }

        public async Task<string> GetBrandNameByMaxCarAsync()
        {
            var values = await context.Cars.GroupBy(x => x.BrandId).
                             Select(y => new
                             {
                                 BrandId = y.Key,
                                 Count = y.Count()
                             }).OrderByDescending(z => z.Count).Take(1).FirstOrDefaultAsync();
            return await context.Brands.Where(x => x.Id == values.BrandId).Select(y => y.Name).FirstOrDefaultAsync();
        }

        public async Task<string> GetCarBrandAndModelByRentPriceDailyMaxAsync()
        {
            int pricingId = await context.Pricings.Where(x => x.Name == "Günlük").Select(y => y.Id).FirstOrDefaultAsync();
            decimal amount = await context.CarPricings.Where(y => y.PricingId == pricingId).MaxAsync(x => x.Amount);
            int carId = await context.CarPricings.Where(x => x.Amount == amount).Select(y => y.CarId).FirstOrDefaultAsync();
            return await context.Cars.Where(x => x.Id == carId).Include(y => y.Brand).Select(z => z.Brand.Name + " " + z.Model).FirstOrDefaultAsync();
        }

        public async Task<string> GetCarBrandAndModelByRentPriceDailyMinAsync()
        {
            int pricingId = await context.Pricings.Where(x => x.Name == "Günlük").Select(y => y.Id).FirstOrDefaultAsync();
            decimal amount = await context.CarPricings.Where(y => y.PricingId == pricingId).MinAsync(x => x.Amount);
            int carId = await context.CarPricings.Where(x => x.Amount == amount).Select(y => y.CarId).FirstOrDefaultAsync();
            return await context.Cars.Where(x => x.Id == carId).Include(y => y.Brand).Select(z => z.Brand.Name + " " + z.Model).FirstOrDefaultAsync();
        }

        public async Task<int> GetCarCountAsync()
        {
            return await context.Cars
                .CountAsync();
        }

        public async Task<int> GetCarCountByFuelElectricAsync()
        {
            return await context.Cars
                .Where(x => x.Fuel == "Elektrik")
                .CountAsync();
        }

        public async Task<int> GetCarCountByFuelGasolineOrDieselAsync()
        {
            return await context.Cars
                .Where(x => x.Fuel == "Benzin" || x.Fuel == "Dizel")
                .CountAsync();
        }

        public async Task<int> GetCarCountByKmSmallerThen1000Async()
        {
            return await context.Cars
                .Where(x => x.Km <= 10000)
                .CountAsync();
        }

        public async Task<int> GetCarCountByTranmissionIsAutoAsync()
        {
            return await context.Cars
                .Where(x => x.Transmission == "Otomatik")
                .CountAsync();
        }

        public async Task<int> GetLocationCountAsync()
        {
            return await context.Locations
                .CountAsync();
        }
    }
}

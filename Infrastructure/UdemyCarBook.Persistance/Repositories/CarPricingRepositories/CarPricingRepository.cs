using Microsoft.EntityFrameworkCore;
using UdemyCarBook.Application.Interfaces.CarPricingInterfaces;
using UdemyCarBook.Application.ViewModels;
using UdemyCarBook.Domain.Entities;
using UdemyCarBook.Persistance.Context;

namespace UdemyCarBook.Persistance.Repositories.CarPricingRepositories
{
    public class CarPricingRepository(CarBookContext context) : ICarPricingRepository
    {
        public async Task<List<CarPricing>> GetCarPricingWithCarsAsync()
        {
            return await context.CarPricings
                .Include(x => x.Car)
                    .ThenInclude(x => x.Brand)
                .Include(x => x.Pricing)
                .ToListAsync();
        }

        public List<CarPricingViewModel> GetCarPricingWithTimePeriod1()
        {
            List<CarPricingViewModel> values = new List<CarPricingViewModel>();
            using (var command = context.Database.GetDbConnection().CreateCommand())
            {
                command.CommandText = "Select * From (Select Model,Name,CoverImageUrl,PricingId,Amount From CarPricings Inner Join Cars On Cars.Id=CarPricings.CarId Inner Join Brands On Brands.Id=Cars.BrandId) As SourceTable Pivot (Sum(Amount) For PricingID In ([2],[3],[4])) as PivotTable;";
                command.CommandType = System.Data.CommandType.Text;
                context.Database.OpenConnection();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        CarPricingViewModel carPricingViewModel = new CarPricingViewModel()
                        {
                            Brand = reader["Name"].ToString(),
                            Model = reader["Model"].ToString(),
                            CoverImageUrl = reader["CoverImageUrl"].ToString(),
                            Amounts = new List<decimal>
                    {
                        reader["2"] != DBNull.Value ? Convert.ToDecimal(reader["2"]) : 0m,
                        reader["3"] != DBNull.Value ? Convert.ToDecimal(reader["3"]) : 0m,
                        reader["4"] != DBNull.Value ? Convert.ToDecimal(reader["4"]) : 0m
                    }
                        };
                        values.Add(carPricingViewModel);
                    }
                }
                context.Database.CloseConnection();
                return values;
            }
        }


        public Task<List<CarPricing>> GetCarPricingWithTimePeriodAsync()
        {
            throw new NotImplementedException();
        }
    }
}

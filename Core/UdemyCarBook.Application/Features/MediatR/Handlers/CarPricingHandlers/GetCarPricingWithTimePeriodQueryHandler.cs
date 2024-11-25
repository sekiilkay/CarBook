using MediatR;
using UdemyCarBook.Application.Features.MediatR.Queries.CarPricingQueries;
using UdemyCarBook.Application.Features.MediatR.Results.CarPricingResults;
using UdemyCarBook.Application.Interfaces;
using UdemyCarBook.Application.Interfaces.CarPricingInterfaces;

namespace UdemyCarBook.Application.Features.MediatR.Handlers.CarPricingHandlers
{
    public class GetCarPricingWithTimePeriodQueryHandler(ICarPricingRepository carPricingRepository) : IRequestHandler<GetCarPricingWithTimePeriodQuery, List<GetCarPricingWithTimePeriodQueryResult>>
    {
        public async Task<List<GetCarPricingWithTimePeriodQueryResult>> Handle(GetCarPricingWithTimePeriodQuery request, CancellationToken cancellationToken)
        {
            var values = carPricingRepository.GetCarPricingWithTimePeriod1();
            return values.Select(x => new GetCarPricingWithTimePeriodQueryResult
            {
                Brand = x.Brand,
                Model = x.Model,
                CoverImageUrl = x.CoverImageUrl,
                DailyAmount = x.Amounts[0],
                WeeklyAmount = x.Amounts[1],
                MonthlyAmount = x.Amounts[2],
                
            }).ToList();
        }
    }
}

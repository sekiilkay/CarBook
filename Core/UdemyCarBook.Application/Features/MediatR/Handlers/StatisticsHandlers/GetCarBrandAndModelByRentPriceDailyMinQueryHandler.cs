using MediatR;
using UdemyCarBook.Application.Features.MediatR.Queries.StatisticsQueries;
using UdemyCarBook.Application.Features.MediatR.Results.StatisticsResults;
using UdemyCarBook.Application.Interfaces.StatisticsInterfaces;

namespace UdemyCarBook.Application.Features.MediatR.Handlers.StatisticsHandlers
{
    public class GetCarBrandAndModelByRentPriceDailyMinQueryHandler(IStatisticsRepository statisticsRepository) : IRequestHandler<GetCarBrandAndModelByRentPriceDailyMinQuery, GetCarBrandAndModelByRentPriceDailyMinQueryResult>
    {
        public async Task<GetCarBrandAndModelByRentPriceDailyMinQueryResult> Handle(GetCarBrandAndModelByRentPriceDailyMinQuery request, CancellationToken cancellationToken)
        {
            var value = await statisticsRepository.GetCarBrandAndModelByRentPriceDailyMinAsync();
            return new GetCarBrandAndModelByRentPriceDailyMinQueryResult
            {
                CarBrandAndModelByRentPriceDailyMin = value
            };
        }
    }
}

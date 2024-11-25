using MediatR;
using UdemyCarBook.Application.Features.MediatR.Queries.StatisticsQueries;
using UdemyCarBook.Application.Features.MediatR.Results.StatisticsResults;
using UdemyCarBook.Application.Interfaces.StatisticsInterfaces;

namespace UdemyCarBook.Application.Features.MediatR.Handlers.StatisticsHandlers
{
    public class GetCarCountByFuelElectricQueryHandler(IStatisticsRepository statisticsRepository) : IRequestHandler<GetCarCountByFuelElectricQuery, GetCarCountByFuelElectricQueryResult>
    {
        public async Task<GetCarCountByFuelElectricQueryResult> Handle(GetCarCountByFuelElectricQuery request, CancellationToken cancellationToken)
        {
            var value = await statisticsRepository.GetCarCountByFuelElectricAsync();
            return new GetCarCountByFuelElectricQueryResult
            {
                CarCountByFuelElectric = value
            };
        }
    }
}

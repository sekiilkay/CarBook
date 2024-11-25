using MediatR;
using UdemyCarBook.Application.Features.MediatR.Queries.StatisticsQueries;
using UdemyCarBook.Application.Features.MediatR.Results.StatisticsResults;
using UdemyCarBook.Application.Interfaces.StatisticsInterfaces;

namespace UdemyCarBook.Application.Features.MediatR.Handlers.StatisticsHandlers
{
    public class GetCarCountByFuelGasolineOrDieselQueryHandler(IStatisticsRepository statisticsRepository) : IRequestHandler<GetCarCountByFuelGasolineOrDieselQuery, GetCarCountByFuelGasolineOrDieselQueryResult>
    {
        public async Task<GetCarCountByFuelGasolineOrDieselQueryResult> Handle(GetCarCountByFuelGasolineOrDieselQuery request, CancellationToken cancellationToken)
        {
            var value = await statisticsRepository.GetCarCountByFuelGasolineOrDieselAsync();
            return new GetCarCountByFuelGasolineOrDieselQueryResult
            {
                CarCountByFuelGasolineOrDiesel = value
            };
        }
    }
}

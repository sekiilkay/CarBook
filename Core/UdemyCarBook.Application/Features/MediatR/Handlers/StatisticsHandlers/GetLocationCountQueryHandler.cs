using MediatR;
using UdemyCarBook.Application.Features.MediatR.Queries.StatisticsQueries;
using UdemyCarBook.Application.Features.MediatR.Results.StatisticsResults;
using UdemyCarBook.Application.Interfaces.StatisticsInterfaces;

namespace UdemyCarBook.Application.Features.MediatR.Handlers.StatisticsHandlers
{
    public class GetLocationCountQueryHandler(IStatisticsRepository statisticsRepository) : IRequestHandler<GetLocationCountQuery, GetLocationCountQueryResult>
    {
        public async Task<GetLocationCountQueryResult> Handle(GetLocationCountQuery request, CancellationToken cancellationToken)
        {
            var value = await statisticsRepository.GetLocationCountAsync();
            return new GetLocationCountQueryResult
            {
                LocationCount = value
            };
        }
    }
}

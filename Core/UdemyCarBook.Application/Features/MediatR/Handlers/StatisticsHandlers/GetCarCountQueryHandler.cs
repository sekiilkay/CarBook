using MediatR;
using UdemyCarBook.Application.Features.MediatR.Queries.StatisticsQueries;
using UdemyCarBook.Application.Features.MediatR.Results.StatisticsResults;
using UdemyCarBook.Application.Interfaces.StatisticsInterfaces;

namespace UdemyCarBook.Application.Features.MediatR.Handlers.StatisticsHandlers
{
    public class GetCarCountQueryHandler(IStatisticsRepository statisticsRepository) : IRequestHandler<GetCarCountQuery, GetCarCountQueryResult>
    {
        public async Task<GetCarCountQueryResult> Handle(GetCarCountQuery request, CancellationToken cancellationToken)
        {
            var value = await statisticsRepository.GetCarCountAsync();
            return new GetCarCountQueryResult
            {
                CarCount = value
            };
        }
    }
}

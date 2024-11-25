using MediatR;
using UdemyCarBook.Application.Features.MediatR.Queries.StatisticsQueries;
using UdemyCarBook.Application.Features.MediatR.Results.StatisticsResults;
using UdemyCarBook.Application.Interfaces.StatisticsInterfaces;

namespace UdemyCarBook.Application.Features.MediatR.Handlers.StatisticsHandlers
{
    public class GetBrandCountQueryHandler(IStatisticsRepository statisticsRepository) : IRequestHandler<GetBrandCountQuery, GetBrandCountQueryResult>
    {
        public async Task<GetBrandCountQueryResult> Handle(GetBrandCountQuery request, CancellationToken cancellationToken)
        {
            var value = await statisticsRepository.GetBrandCountAsync();
            return new GetBrandCountQueryResult
            {
                BrandCount = value
            };
        }
    }
}

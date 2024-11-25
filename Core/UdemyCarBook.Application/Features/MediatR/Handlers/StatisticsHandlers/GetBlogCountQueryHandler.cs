using MediatR;
using UdemyCarBook.Application.Features.MediatR.Queries.StatisticsQueries;
using UdemyCarBook.Application.Features.MediatR.Results.StatisticsResults;
using UdemyCarBook.Application.Interfaces.StatisticsInterfaces;

namespace UdemyCarBook.Application.Features.MediatR.Handlers.StatisticsHandlers
{
    public class GetBlogCountQueryHandler(IStatisticsRepository statisticsRepository) : IRequestHandler<GetBlogCountQuery, GetBlogCountQueryResult>
    {
        public async Task<GetBlogCountQueryResult> Handle(GetBlogCountQuery request, CancellationToken cancellationToken)
        {
            var value = await statisticsRepository.GetBlogCountAsync();
            return new GetBlogCountQueryResult
            {
                BlogCount = value
            };
        }
    }
}

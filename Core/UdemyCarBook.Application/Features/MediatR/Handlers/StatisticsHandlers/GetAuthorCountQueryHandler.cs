using MediatR;
using UdemyCarBook.Application.Features.MediatR.Queries.StatisticsQueries;
using UdemyCarBook.Application.Features.MediatR.Results.StatisticsResults;
using UdemyCarBook.Application.Interfaces.StatisticsInterfaces;

namespace UdemyCarBook.Application.Features.MediatR.Handlers.StatisticsHandlers
{
    public class GetAuthorCountQueryHandler(IStatisticsRepository statisticsRepository) : IRequestHandler<GetAuthorCountQuery, GetAuthorCountQueryResult>
    {
        public async Task<GetAuthorCountQueryResult> Handle(GetAuthorCountQuery request, CancellationToken cancellationToken)
        {
            var value = await statisticsRepository.GetAuthorCountAsync();
            return new GetAuthorCountQueryResult
            {
                AuthorCount = value
            };
        }
    }
}

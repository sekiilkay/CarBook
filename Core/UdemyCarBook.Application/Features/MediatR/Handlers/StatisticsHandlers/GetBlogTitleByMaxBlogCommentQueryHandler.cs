using MediatR;
using UdemyCarBook.Application.Features.MediatR.Queries.StatisticsQueries;
using UdemyCarBook.Application.Features.MediatR.Results.StatisticsResults;
using UdemyCarBook.Application.Interfaces.StatisticsInterfaces;

namespace UdemyCarBook.Application.Features.MediatR.Handlers.StatisticsHandlers
{
    public class GetBlogTitleByMaxBlogCommentQueryHandler(IStatisticsRepository statisticsRepository) : IRequestHandler<GetBlogTitleByMaxBlogCommentQuery, GetBlogTitleByMaxBlogCommentQueryResult>
    {
        public async Task<GetBlogTitleByMaxBlogCommentQueryResult> Handle(GetBlogTitleByMaxBlogCommentQuery request, CancellationToken cancellationToken)
        {
            var value = await statisticsRepository.GetBlogTitleByMaxBlogCommentAsync();
            return new GetBlogTitleByMaxBlogCommentQueryResult
            {
                BlogTitleByMaxBlogComment = value
            };
        }
    }
}

using MediatR;
using UdemyCarBook.Application.Features.MediatR.Queries.TagClodQueries;
using UdemyCarBook.Application.Features.MediatR.Results.TagCloudResults;
using UdemyCarBook.Application.Interfaces.TagCloudInterfaces;

namespace UdemyCarBook.Application.Features.MediatR.Handlers.TagCloudHandlers
{
    public class GetTagCloudByBlogIdQueryHandler(ITagCloudRepository tagCloudRepository) : IRequestHandler<GetTagCloudByBlogIdQuery, List<GetTagCloudByBlogIdQueryResult>>
    {
        public async Task<List<GetTagCloudByBlogIdQueryResult>> Handle(GetTagCloudByBlogIdQuery request, CancellationToken cancellationToken)
        {
            var values = await tagCloudRepository.GetTagCloudsByBlogIdAsync(request.Id);
            return values.Select(x => new GetTagCloudByBlogIdQueryResult
            {
                BlogId = x.BlogId,
                Id = x.Id,
                Title = x.Title
            }).ToList();
        }
    }
}

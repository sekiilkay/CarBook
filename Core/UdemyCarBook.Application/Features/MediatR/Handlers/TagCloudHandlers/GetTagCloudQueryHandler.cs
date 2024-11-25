using MediatR;
using UdemyCarBook.Application.Features.MediatR.Queries.TagClodQueries;
using UdemyCarBook.Application.Features.MediatR.Results.TagCloudResults;
using UdemyCarBook.Application.Interfaces;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Features.MediatR.Handlers.TagCloudHandlers
{
    public class GetTagCloudQueryHandler(IRepository<TagCloud> repository) : IRequestHandler<GetTagCloudQuery, List<GetTagCloudQueryResult>>
    {
        public async Task<List<GetTagCloudQueryResult>> Handle(GetTagCloudQuery request, CancellationToken cancellationToken)
        {
            var values = await repository.GetAllAsync();
            return values.Select(x => new GetTagCloudQueryResult
            {
                BlogId = x.BlogId,
                Id = x.Id,
                Title = x.Title
            }).ToList();
        }
    }
}

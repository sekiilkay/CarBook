using MediatR;
using UdemyCarBook.Application.Features.MediatR.Queries.TagClodQueries;
using UdemyCarBook.Application.Features.MediatR.Results.TagCloudResults;
using UdemyCarBook.Application.Interfaces;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Features.MediatR.Handlers.TagCloudHandlers
{
    public class GetTagCloudByIdQueryHandler(IRepository<TagCloud> repository) : IRequestHandler<GetTagCloudByIdQuery, GetTagCloudByIdQueryResult>
    {
        public async Task<GetTagCloudByIdQueryResult> Handle(GetTagCloudByIdQuery request, CancellationToken cancellationToken)
        {
            var value = await repository.GetByIdAsync(request.Id);
            return new GetTagCloudByIdQueryResult
            {
                BlogId = value.BlogId,
                Id = value.Id,
                Title = value.Title
            };
        }
    }
}

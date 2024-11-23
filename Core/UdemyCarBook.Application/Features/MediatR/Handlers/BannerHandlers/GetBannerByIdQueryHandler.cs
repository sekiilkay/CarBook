using MediatR;
using UdemyCarBook.Application.Features.MediatR.Queries.BannerQueries;
using UdemyCarBook.Application.Features.MediatR.Results.BannerResults;
using UdemyCarBook.Application.Interfaces;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Features.MediatR.Handlers.BannerHandlers
{
    public class GetBannerByIdQueryHandler(IRepository<Banner> repository) : IRequestHandler<GetBannerByIdQuery, GetBannerByIdQueryResult>
    {
        public async Task<GetBannerByIdQueryResult> Handle(GetBannerByIdQuery request, CancellationToken cancellationToken)
        {
            var value = await repository.GetByIdAsync(request.Id);
            return new GetBannerByIdQueryResult
            {
                Description = value.Description,
                Id = value.Id,
                Title = value.Title,
                VideoDescription = value.VideoDescription,
                VideoUrl = value.VideoUrl
            };
        }
    }
}

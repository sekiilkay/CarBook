using MediatR;
using UdemyCarBook.Application.Features.MediatR.Queries.BannerQueries;
using UdemyCarBook.Application.Features.MediatR.Results.BannerResults;
using UdemyCarBook.Application.Interfaces;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Features.MediatR.Handlers.BannerHandlers
{
    public class GetBannerQueryHandler(IRepository<Banner> repository) : IRequestHandler<GetBannerQuery, List<GetBannerQueryResult>>
    {
        public async Task<List<GetBannerQueryResult>> Handle(GetBannerQuery request, CancellationToken cancellationToken)
        {
            var values = await repository.GetAllAsync();
            return values.Select(x => new GetBannerQueryResult
            {
                Description = x.Description,
                Id = x.Id,
                Title = x.Title,
                VideoDescription = x.VideoDescription,
                VideoUrl = x.VideoUrl,
            }).ToList();
        }
    }
}

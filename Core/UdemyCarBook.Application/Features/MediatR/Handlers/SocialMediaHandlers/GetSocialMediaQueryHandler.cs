using MediatR;
using UdemyCarBook.Application.Features.MediatR.Queries.SocialMediaQueries;
using UdemyCarBook.Application.Features.MediatR.Results.SocialMediaResults;
using UdemyCarBook.Application.Interfaces;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Features.MediatR.Handlers.SocialMediaHandlers
{
    public class GetSocialMediaQueryHandler(IRepository<SocialMedia> repository) : IRequestHandler<GetSocialMediaQuery, List<GetSocialMediaQueryResult>>
    {
        public async Task<List<GetSocialMediaQueryResult>> Handle(GetSocialMediaQuery request, CancellationToken cancellationToken)
        {
            var values = await repository.GetAllAsync();
            return values.Select(x => new GetSocialMediaQueryResult
            {
                Icon = x.Icon,
                Id = x.Id,
                Name = x.Name,
                Url = x.Url,
            }).ToList();
        }
    }
}

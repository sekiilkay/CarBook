using MediatR;
using UdemyCarBook.Application.Features.MediatR.Queries.SocialMediaQueries;
using UdemyCarBook.Application.Features.MediatR.Results.SocialMediaResults;
using UdemyCarBook.Application.Interfaces;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Features.MediatR.Handlers.SocialMediaHandlers
{
    public class GetSocialMediaByIdQueryHandler(IRepository<SocialMedia> repository) : IRequestHandler<GetSocialMediaByIdQuery, GetSocialMediaByIdQueryResult>
    {
        public async Task<GetSocialMediaByIdQueryResult> Handle(GetSocialMediaByIdQuery request, CancellationToken cancellationToken)
        {
            var value = await repository.GetByIdAsync(request.Id);
            return new GetSocialMediaByIdQueryResult
            {
                Icon = value.Icon,
                Id = value.Id,
                Name = value.Name,
                Url = value.Url,
            };
        }
    }
}

using MediatR;
using UdemyCarBook.Application.Features.MediatR.Results.SocialMediaResults;

namespace UdemyCarBook.Application.Features.MediatR.Queries.SocialMediaQueries
{
    public class GetSocialMediaQuery : IRequest<List<GetSocialMediaQueryResult>>
    {
    }
}

using MediatR;
using UdemyCarBook.Application.Features.MediatR.Results.SocialMediaResults;

namespace UdemyCarBook.Application.Features.MediatR.Queries.SocialMediaQueries
{
    public class GetSocialMediaByIdQuery : IRequest<GetSocialMediaByIdQueryResult>
    {
        public int Id { get; set; }
        public GetSocialMediaByIdQuery(int id)
        {
            Id = id;
        }
    }
}

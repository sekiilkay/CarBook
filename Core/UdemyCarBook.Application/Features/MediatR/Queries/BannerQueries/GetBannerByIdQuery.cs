using MediatR;
using UdemyCarBook.Application.Features.MediatR.Results.BannerResults;

namespace UdemyCarBook.Application.Features.MediatR.Queries.BannerQueries
{
    public class GetBannerByIdQuery : IRequest<GetBannerByIdQueryResult>
    {
        public int Id { get; set; }
        public GetBannerByIdQuery(int id)
        {
            Id = id;
        }
    }
}

using MediatR;
using UdemyCarBook.Application.Features.MediatR.Results.BannerResults;

namespace UdemyCarBook.Application.Features.MediatR.Queries.BannerQueries
{
    public class GetBannerQuery : IRequest<List<GetBannerQueryResult>>
    {
    }
}

using MediatR;
using UdemyCarBook.Application.Features.MediatR.Results.FooterAddressResults;

namespace UdemyCarBook.Application.Features.MediatR.Queries.FooterAddressQueries
{
    public class GetFooterAddressQuery : IRequest<List<GetFooterAddressQueryResult>>
    {
    }
}

using MediatR;
using UdemyCarBook.Application.Features.MediatR.Results.FooterAddressResults;

namespace UdemyCarBook.Application.Features.MediatR.Queries.FooterAddressQueries
{
    public class GetFooterAddressByIdQuery : IRequest<GetFooterAddressByIdQueryResult>
    {
        public int Id { get; set; }
        public GetFooterAddressByIdQuery(int id)
        {
            Id = id;
        }
    }
}

using MediatR;
using UdemyCarBook.Application.Features.MediatR.Results.PricingResults;

namespace UdemyCarBook.Application.Features.MediatR.Queries.PricingQueries
{
    public class GetPricingByIdQuery : IRequest<GetPricingByIdQueryResult>
    {
        public int Id { get; set; }
        public GetPricingByIdQuery(int id)
        {
            Id = id;
        }
    }
}

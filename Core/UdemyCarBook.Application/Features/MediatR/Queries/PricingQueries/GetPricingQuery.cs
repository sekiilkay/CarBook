using MediatR;
using UdemyCarBook.Application.Features.MediatR.Results.PricingResults;

namespace UdemyCarBook.Application.Features.MediatR.Queries.PricingQueries
{
    public class GetPricingQuery : IRequest<List<GetPricingQueryResult>>
    {
    }
}

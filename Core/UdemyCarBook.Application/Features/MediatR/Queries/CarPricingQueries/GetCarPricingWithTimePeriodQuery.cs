using MediatR;
using UdemyCarBook.Application.Features.MediatR.Results.CarPricingResults;

namespace UdemyCarBook.Application.Features.MediatR.Queries.CarPricingQueries
{
    public class GetCarPricingWithTimePeriodQuery : IRequest<List<GetCarPricingWithTimePeriodQueryResult>>
    {
    }
}

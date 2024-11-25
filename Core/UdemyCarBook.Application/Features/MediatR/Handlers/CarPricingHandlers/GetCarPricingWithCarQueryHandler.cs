using MediatR;
using UdemyCarBook.Application.Features.MediatR.Queries.CarPricingQueries;
using UdemyCarBook.Application.Features.MediatR.Results.CarPricingResults;
using UdemyCarBook.Application.Interfaces.CarPricingInterfaces;

namespace UdemyCarBook.Application.Features.MediatR.Handlers.CarPricingHandlers
{
    public class GetCarPricingWithCarQueryHandler(ICarPricingRepository carPricingRepository) : IRequestHandler<GetCarPricingWithCarQuery, List<GetCarPricingWithCarQueryResult>>
    {
        public async Task<List<GetCarPricingWithCarQueryResult>> Handle(GetCarPricingWithCarQuery request, CancellationToken cancellationToken)
        {
            var values = await carPricingRepository.GetCarPricingWithCarsAsync();
            return values.Select(x => new GetCarPricingWithCarQueryResult
            {
                Amount = x.Amount,
                Brand = x.Car.Brand.Name,
                CarId = x.Car.Id,
                CarPricingId = x.Id,
                CoverImageUrl = x.Car.CoverImageUrl,
                Model = x.Car.Model,
                PricingName = x.Pricing.Name
            }).ToList();
        }
    }
}

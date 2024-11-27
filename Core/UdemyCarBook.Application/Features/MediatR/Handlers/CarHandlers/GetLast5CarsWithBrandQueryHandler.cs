using MediatR;
using UdemyCarBook.Application.Features.MediatR.Queries.CarQueries;
using UdemyCarBook.Application.Features.MediatR.Results.CarResults;
using UdemyCarBook.Application.Interfaces;
using UdemyCarBook.Application.Interfaces.CarInterfaces;

namespace UdemyCarBook.Application.Features.MediatR.Handlers.CarHandlers
{
    public class GetLast5CarsWithBrandQueryHandler(ICarRepository carRepository) : IRequestHandler<GetLast5CarsWithBrandQuery, List<GetLast5CarsWithBrandQueryResult>>
    {
        public async Task<List<GetLast5CarsWithBrandQueryResult>> Handle(GetLast5CarsWithBrandQuery request, CancellationToken cancellationToken)
        {
            var values = await carRepository.GetLast5CarsWithBrandsAsync();
            return values.Select(x => new GetLast5CarsWithBrandQueryResult
            {
                BigImageUrl = x.BigImageUrl,
                BrandId = x.BrandId,
                BrandName = x.Brand.Name,
                CoverImageUrl = x.CoverImageUrl,
                Fuel = x.Fuel,
                Id = x.Id,
                Km = x.Km,
                Luggage = x.Luggage,
                Model = x.Model,
                Seat = x.Seat,
                Transmission = x.Transmission,
                Price = x.CarPricings.Select(x => x.Amount).FirstOrDefault()
            }).ToList();
        }
    }
}

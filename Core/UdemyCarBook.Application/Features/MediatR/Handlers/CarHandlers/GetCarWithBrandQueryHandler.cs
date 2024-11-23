using MediatR;
using UdemyCarBook.Application.Features.MediatR.Queries.CarQueries;
using UdemyCarBook.Application.Features.MediatR.Results.CarResults;
using UdemyCarBook.Application.Interfaces.CarInterfaces;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Features.MediatR.Handlers.CarHandlers
{
    public class GetCarWithBrandQueryHandler(ICarRepository carRepository) : IRequestHandler<GetCarWithBrandNameQuery, List<GetCarWithBrandNameQueryResult>>
    {
        public async Task<List<GetCarWithBrandNameQueryResult>> Handle(GetCarWithBrandNameQuery request, CancellationToken cancellationToken)
        {
            var values = await carRepository.GetCarsListWithBrandsAsync();
            return values.Select(x => new GetCarWithBrandNameQueryResult
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
            }).ToList();
        }
    }
}

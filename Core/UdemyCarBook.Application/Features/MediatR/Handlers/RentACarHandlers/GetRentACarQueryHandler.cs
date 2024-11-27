using MediatR;
using UdemyCarBook.Application.Features.MediatR.Queries.RentACarQueries;
using UdemyCarBook.Application.Features.MediatR.Results.RentACarResults;
using UdemyCarBook.Application.Interfaces.RentACarInterfaces;

namespace UdemyCarBook.Application.Features.MediatR.Handlers.RentACarHandlers
{
    public class GetRentACarQueryHandler(IRentACarRepository rentACarRepository) : IRequestHandler<GetRentACarQuery, List<GetRentACarQueryResult>>
    {
        public async Task<List<GetRentACarQueryResult>> Handle(GetRentACarQuery request, CancellationToken cancellationToken)
        {
            var values = await rentACarRepository.GetByFilterAsync(x=>x.LocationId == request.LocationId);
            return values.Select(x => new GetRentACarQueryResult
            {
                CarId = x.CarId,
                Brand = x.Car.Brand.Name,
                Model = x.Car.Model,
                CoverImageUrl = x.Car.CoverImageUrl,
                Amount = x.Car.CarPricings.Where(y=>y.CarId == x.CarId).Select(x=>x.Amount).FirstOrDefault()
            }).ToList();
        }
    }
}

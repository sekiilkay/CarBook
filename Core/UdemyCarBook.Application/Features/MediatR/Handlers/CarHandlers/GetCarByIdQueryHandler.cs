using MediatR;
using UdemyCarBook.Application.Features.MediatR.Queries.CarQueries;
using UdemyCarBook.Application.Features.MediatR.Results.CarResults;
using UdemyCarBook.Application.Interfaces;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Features.MediatR.Handlers.CarHandlers
{
    public class GetCarByIdQueryHandler(IRepository<Car> repository) : IRequestHandler<GetCarByIdQuery, GetCarByIdQueryResult>
    {
        public async Task<GetCarByIdQueryResult> Handle(GetCarByIdQuery request, CancellationToken cancellationToken)
        {
            var value = await repository.GetByIdAsync(request.Id);
            return new GetCarByIdQueryResult
            {
                BigImageUrl = value.BigImageUrl,
                BrandId = value.BrandId,
                CoverImageUrl = value.CoverImageUrl,
                Fuel = value.Fuel,
                Id = value.Id,
                Km = value.Km,
                Luggage = value.Luggage,
                Model = value.Model,
                Seat = value.Seat,
                Transmission = value.Transmission,
            };
        }
    }
}

using MediatR;
using UdemyCarBook.Application.Features.MediatR.Commands.CarCommands;
using UdemyCarBook.Application.Interfaces;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Features.MediatR.Handlers.CarHandlers
{
    public class CreateCarCommandHandler(IRepository<Car> repository) : IRequestHandler<CreateCarCommand>
    {
        public async Task Handle(CreateCarCommand request, CancellationToken cancellationToken)
        {
            await repository.CreateAsync(new Car
            {
                BigImageUrl = request.BigImageUrl,
                BrandId = request.BrandId,
                CoverImageUrl = request.CoverImageUrl,
                Fuel = request.Fuel,
                Transmission = request.Transmission,
                Seat = request.Seat,
                Model = request.Model,
                Luggage = request.Luggage,
                Km = request.Km
            });
        }
    }
}

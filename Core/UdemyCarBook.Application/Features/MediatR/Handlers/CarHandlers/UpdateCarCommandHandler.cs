using MediatR;
using UdemyCarBook.Application.Features.MediatR.Commands.CarCommands;
using UdemyCarBook.Application.Interfaces;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Features.MediatR.Handlers.CarHandlers
{
    public class UpdateCarCommandHandler(IRepository<Car> repository) : IRequestHandler<UpdateCarCommand>
    {
        public async Task Handle(UpdateCarCommand request, CancellationToken cancellationToken)
        {
            var value = await repository.GetByIdAsync(request.Id);
            value.Transmission = request.Transmission;
            value.Seat = request.Seat;
            value.BigImageUrl = request.BigImageUrl;
            value.Model = request.Model;
            value.BrandId = request.BrandId;
            value.CoverImageUrl = request.CoverImageUrl;
            value.Luggage = request.Luggage;
            value.Km = request.Km;
            value.Fuel = request.Fuel;
            await repository.UpdateAsync(value);
        }
    }
}

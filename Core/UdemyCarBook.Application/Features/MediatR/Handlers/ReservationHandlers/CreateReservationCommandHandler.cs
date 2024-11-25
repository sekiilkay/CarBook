using MediatR;
using UdemyCarBook.Application.Features.MediatR.Commands.ReservationCommands;
using UdemyCarBook.Application.Interfaces;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Features.MediatR.Handlers.ReservationHandlers
{
    public class CreateReservationCommandHandler(IRepository<Reservation> repository) : IRequestHandler<CreateReservationCommand>
    {
        public async Task Handle(CreateReservationCommand request, CancellationToken cancellationToken)
        {
            await repository.CreateAsync(new Reservation
            {
                Age = request.Age,
                CarId = request.CarId,
                Description = request.Description,
                Email = request.Email,
                DriverLicenseYear = request.DriverLicenseYear,
                DropOffLocationId = request.DropOffLocationId,
                Name = request.Name,
                Phone = request.Phone,
                PickUpLocationId = request.PickUpLocationId,
                Status = "Rezervasyon Alındı",
                Surname = request.Surname
            });
        }
    }
}

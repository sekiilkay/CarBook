using MediatR;
using UdemyCarBook.Application.Features.MediatR.Commands.CarFeatureCommands;
using UdemyCarBook.Application.Interfaces.CarFeatureInterfaces;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Features.MediatR.Handlers.CarFeatureHandlers
{
    public class CreateCarFeatureByCarCommandHandler(ICarFeatureRepository carFeatureRepository) : IRequestHandler<CreateCarFeatureByCarCommand>
    {
        public async Task Handle(CreateCarFeatureByCarCommand request, CancellationToken cancellationToken)
        {
            await carFeatureRepository.CreateCarFeatureByCarAsync(new CarFeature
            {
                Available = false,
                CarId = request.CarId,
                FeatureId = request.FeatureId,
            });
        }
    }
}

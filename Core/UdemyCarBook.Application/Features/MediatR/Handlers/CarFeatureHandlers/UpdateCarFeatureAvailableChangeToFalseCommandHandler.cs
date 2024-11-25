using MediatR;
using UdemyCarBook.Application.Features.MediatR.Commands.CarFeatureCommands;
using UdemyCarBook.Application.Interfaces.CarFeatureInterfaces;

namespace UdemyCarBook.Application.Features.MediatR.Handlers.CarFeatureHandlers
{
    public class UpdateCarFeatureAvailableChangeToFalseCommandHandler(ICarFeatureRepository carFeatureRepository) : IRequestHandler<UpdateCarFeatureAvailableChangeToFalseCommand>
    {
        public async Task Handle(UpdateCarFeatureAvailableChangeToFalseCommand request, CancellationToken cancellationToken)
        {
            carFeatureRepository.ChangeCarFeatureAvailableToFalse(request.Id);
        }
    }
}

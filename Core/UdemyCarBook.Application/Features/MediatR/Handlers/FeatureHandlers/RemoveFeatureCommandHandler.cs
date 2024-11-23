using MediatR;
using UdemyCarBook.Application.Features.MediatR.Commands.FeatureCommands;
using UdemyCarBook.Application.Interfaces;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Features.MediatR.Handlers.FeatureHandlers
{
    public class RemoveFeatureCommandHandler(IRepository<Feature> repository) : IRequestHandler<RemoveFeatureCommand>
    {
        public async Task Handle(RemoveFeatureCommand request, CancellationToken cancellationToken)
        {
            var value = await repository.GetByIdAsync(request.Id);
            await repository.DeleteAsync(value);
        }
    }
}

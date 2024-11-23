using MediatR;
using UdemyCarBook.Application.Features.MediatR.Commands.FeatureCommands;
using UdemyCarBook.Application.Interfaces;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Features.MediatR.Handlers.FeatureHandlers
{
    public class CreateFeatureCommandHandler(IRepository<Feature> repository) : IRequestHandler<CreateFeatureCommand>
    {
        public async Task Handle(CreateFeatureCommand request, CancellationToken cancellationToken)
        {
            await repository.CreateAsync(new Feature
            {
                Name = request.Name,
            });
        }
    }
}

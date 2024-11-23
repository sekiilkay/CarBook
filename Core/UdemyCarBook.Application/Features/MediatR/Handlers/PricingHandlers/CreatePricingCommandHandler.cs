using MediatR;
using UdemyCarBook.Application.Features.MediatR.Commands.PricingCommands;
using UdemyCarBook.Application.Interfaces;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Features.MediatR.Handlers.PricingHandlers
{
    public class CreatePricingCommandHandler(IRepository<Pricing> repository) : IRequestHandler<CreatePricingCommand>
    {
        public async Task Handle(CreatePricingCommand request, CancellationToken cancellationToken)
        {
            await repository.CreateAsync(new Pricing
            {
                Name = request.Name
            });
        }
    }
}

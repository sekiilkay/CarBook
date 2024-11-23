using MediatR;
using UdemyCarBook.Application.Features.MediatR.Commands.PricingCommands;
using UdemyCarBook.Application.Interfaces;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Features.MediatR.Handlers.PricingHandlers
{
    public class RemovePricingCommandHandler(IRepository<Pricing> repository) : IRequestHandler<RemovePricingCommand>
    {
        public async Task Handle(RemovePricingCommand request, CancellationToken cancellationToken)
        {
            var value = await repository.GetByIdAsync(request.Id);
            await repository.DeleteAsync(value);
        }
    }
}

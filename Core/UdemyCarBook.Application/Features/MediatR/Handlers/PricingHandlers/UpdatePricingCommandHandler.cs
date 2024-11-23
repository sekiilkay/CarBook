using MediatR;
using UdemyCarBook.Application.Features.MediatR.Commands.PricingCommands;
using UdemyCarBook.Application.Interfaces;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Features.MediatR.Handlers.PricingHandlers
{
    public class UpdatePricingCommandHandler(IRepository<Pricing> repository) : IRequestHandler<UpdatePricingCommand>
    {
        public async Task Handle(UpdatePricingCommand request, CancellationToken cancellationToken)
        {
            var value = await repository.GetByIdAsync(request.Id);
            value.Name = request.Name;
            await repository.UpdateAsync(value);
        }
    }
}

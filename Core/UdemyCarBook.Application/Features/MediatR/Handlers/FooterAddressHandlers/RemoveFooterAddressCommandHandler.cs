using MediatR;
using UdemyCarBook.Application.Features.MediatR.Commands.FooterAddressCommands;
using UdemyCarBook.Application.Interfaces;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Features.MediatR.Handlers.FooterAddressHandlers
{
    public class RemoveFooterAddressCommandHandler(IRepository<FooterAddress> repository) : IRequestHandler<RemoveFooterAddressCommand>
    {
        public async Task Handle(RemoveFooterAddressCommand request, CancellationToken cancellationToken)
        {
            var value = await repository.GetByIdAsync(request.Id);
            await repository.DeleteAsync(value);
        }
    }
}

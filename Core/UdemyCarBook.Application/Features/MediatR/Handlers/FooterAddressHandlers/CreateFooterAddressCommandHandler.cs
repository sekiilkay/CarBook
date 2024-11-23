using MediatR;
using UdemyCarBook.Application.Features.MediatR.Commands.FooterAddressCommands;
using UdemyCarBook.Application.Interfaces;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Features.MediatR.Handlers.FooterAddressHandlers
{
    public class CreateFooterAddressCommandHandler(IRepository<FooterAddress> repository) : IRequestHandler<CreateFooterAddressCommand>
    {
        public async Task Handle(CreateFooterAddressCommand request, CancellationToken cancellationToken)
        {
            await repository.CreateAsync(new FooterAddress
            {
                Address = request.Address,
                Description = request.Description,
                Email = request.Email,
                Phone = request.Phone,
            });
        }
    }
}

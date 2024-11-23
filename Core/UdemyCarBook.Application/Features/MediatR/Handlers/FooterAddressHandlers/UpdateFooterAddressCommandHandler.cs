using MediatR;
using UdemyCarBook.Application.Features.MediatR.Commands.FooterAddressCommands;
using UdemyCarBook.Application.Interfaces;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Features.MediatR.Handlers.FooterAddressHandlers
{
    public class UpdateFooterAddressCommandHandler(IRepository<FooterAddress> repository) : IRequestHandler<UpdateFooterAddressCommand>
    {
        public async Task Handle(UpdateFooterAddressCommand request, CancellationToken cancellationToken)
        {
            var value = await repository.GetByIdAsync(request.Id);
            value.Description = request.Description;
            value.Address = request.Address;
            value.Phone = request.Phone;
            value.Email = request.Email;
            await repository.UpdateAsync(value);
        }
    }
}

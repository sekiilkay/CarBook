using MediatR;
using UdemyCarBook.Application.Features.MediatR.Commands.ContactCommands;
using UdemyCarBook.Application.Interfaces;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Features.MediatR.Handlers.ContactHandlers
{
    public class UpdateContactCommandHandler(IRepository<Contact> repository) : IRequestHandler<UpdateContactCommand>
    {
        public async Task Handle(UpdateContactCommand request, CancellationToken cancellationToken)
        {
            var value = await repository.GetByIdAsync(request.Id);
            value.SendDate = request.SendDate;
            value.Subject = request.Subject;
            value.Email = request.Email;
            value.Message = request.Message;
            await repository.UpdateAsync(value);
        }
    }
}

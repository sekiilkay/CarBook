using MediatR;
using UdemyCarBook.Application.Features.MediatR.Commands.ContactCommands;
using UdemyCarBook.Application.Interfaces;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Features.MediatR.Handlers.ContactHandlers
{
    public class CreateContactCommandHandler(IRepository<Contact> repository) : IRequestHandler<CreateContactCommand>
    {
        public async Task Handle(CreateContactCommand request, CancellationToken cancellationToken)
        {
            await repository.CreateAsync(new Contact
            {
                Email = request.Email,
                Message = request.Message,
                Name = request.Name,
                SendDate = request.SendDate,
                Subject = request.Subject
            });
        }
    }
}

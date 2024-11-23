using MediatR;
using UdemyCarBook.Application.Features.MediatR.Commands.ContactCommands;
using UdemyCarBook.Application.Interfaces;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Features.MediatR.Handlers.ContactHandlers
{
    public class RemoveContactCommandHandler(IRepository<Contact> repository) : IRequestHandler<RemoveContactCommand>
    {
        public async Task Handle(RemoveContactCommand request, CancellationToken cancellationToken)
        {
            var value = await repository.GetByIdAsync(request.Id);
            await repository.DeleteAsync(value);
        }
    }
}

using MediatR;
using UdemyCarBook.Application.Features.MediatR.Commands.ServiceCommands;
using UdemyCarBook.Application.Interfaces;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Features.MediatR.Handlers.ServiceHandlers
{
    public class RemoveServiceCommandHandler(IRepository<Service> repository) : IRequestHandler<RemoveServiceCommand>
    {
        public async Task Handle(RemoveServiceCommand request, CancellationToken cancellationToken)
        {
            var value = await repository.GetByIdAsync(request.Id);
            await repository.DeleteAsync(value);
        }
    }
}

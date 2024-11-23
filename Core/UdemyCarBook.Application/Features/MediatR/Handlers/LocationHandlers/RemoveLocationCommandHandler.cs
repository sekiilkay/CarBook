using MediatR;
using UdemyCarBook.Application.Features.MediatR.Commands.LocationCommands;
using UdemyCarBook.Application.Interfaces;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Features.MediatR.Handlers.LocationHandlers
{
    public class RemoveLocationCommandHandler(IRepository<Location> repository) : IRequestHandler<RemoveLocationCommand>
    {
        public async Task Handle(RemoveLocationCommand request, CancellationToken cancellationToken)
        {
            var value = await repository.GetByIdAsync(request.Id);
            await repository.DeleteAsync(value);
        }
    }
}

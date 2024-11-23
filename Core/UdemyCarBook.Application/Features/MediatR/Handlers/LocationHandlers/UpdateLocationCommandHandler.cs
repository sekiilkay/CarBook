using MediatR;
using UdemyCarBook.Application.Features.MediatR.Commands.LocationCommands;
using UdemyCarBook.Application.Interfaces;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Features.MediatR.Handlers.LocationHandlers
{
    public class UpdateLocationCommandHandler(IRepository<Location> repository) : IRequestHandler<UpdateLocationCommand>
    {
        public async Task Handle(UpdateLocationCommand request, CancellationToken cancellationToken)
        {
            var value = await repository.GetByIdAsync(request.Id);
            value.Name = request.Name;
            await repository.UpdateAsync(value);
        }
    }
}

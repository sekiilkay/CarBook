using MediatR;
using UdemyCarBook.Application.Features.MediatR.Commands.CarCommands;
using UdemyCarBook.Application.Interfaces;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Features.MediatR.Handlers.CarHandlers
{
    public class RemoveCarCommandHandler(IRepository<Car> repository) : IRequestHandler<RemoveCarCommand>
    {
        public async Task Handle(RemoveCarCommand request, CancellationToken cancellationToken)
        {
            var value = await repository.GetByIdAsync(request.Id);
            await repository.DeleteAsync(value);
        }
    }
}

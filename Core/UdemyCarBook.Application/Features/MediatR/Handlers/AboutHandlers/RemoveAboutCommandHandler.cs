using MediatR;
using UdemyCarBook.Application.Features.MediatR.Commands.AboutCommands;
using UdemyCarBook.Application.Interfaces;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Features.MediatR.Handlers.AboutHandlers
{
    public class RemoveAboutCommandHandler(IRepository<About> repository) : IRequestHandler<RemoveAboutCommand>
    {
        public async Task Handle(RemoveAboutCommand request, CancellationToken cancellationToken)
        {
            var value = await repository.GetByIdAsync(request.Id);
            await repository.DeleteAsync(value);
        }
    }
}

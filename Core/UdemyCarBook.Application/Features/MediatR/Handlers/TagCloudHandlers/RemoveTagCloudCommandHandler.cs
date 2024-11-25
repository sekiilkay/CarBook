using MediatR;
using UdemyCarBook.Application.Features.MediatR.Commands.TagCloudCommands;
using UdemyCarBook.Application.Interfaces;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Features.MediatR.Handlers.TagCloudHandlers
{
    public class RemoveTagCloudCommandHandler(IRepository<TagCloud> repository) : IRequestHandler<RemoveTagCloudCommand>
    {
        public async Task Handle(RemoveTagCloudCommand request, CancellationToken cancellationToken)
        {
            var value = await repository.GetByIdAsync(request.Id);
            await repository.DeleteAsync(value);
        }
    }
}

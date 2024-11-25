using MediatR;
using UdemyCarBook.Application.Features.MediatR.Commands.TagCloudCommands;
using UdemyCarBook.Application.Interfaces;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Features.MediatR.Handlers.TagCloudHandlers
{
    internal class CreateTagCloudCommandHandler(IRepository<TagCloud> repository) : IRequestHandler<CreateTagCloudCommand>
    {
        public async Task Handle(CreateTagCloudCommand request, CancellationToken cancellationToken)
        {
            await repository.CreateAsync(new TagCloud
            {
                BlogId = request.BlogId,
                Title = request.Title,
            });
        }
    }
}

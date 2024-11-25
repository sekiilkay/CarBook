using MediatR;
using UdemyCarBook.Application.Features.MediatR.Commands.TagCloudCommands;
using UdemyCarBook.Application.Interfaces;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Features.MediatR.Handlers.TagCloudHandlers
{
    public class UpdateTagCloudCommandHandler(IRepository<TagCloud> repository) : IRequestHandler<UpdateTagCloudCommand>
    {
        public async Task Handle(UpdateTagCloudCommand request, CancellationToken cancellationToken)
        {
            var values = await repository.GetByIdAsync(request.Id);
            values.Title = request.Title;
            values.BlogId = request.BlogId;
            await repository.UpdateAsync(values);
        }
    }
}

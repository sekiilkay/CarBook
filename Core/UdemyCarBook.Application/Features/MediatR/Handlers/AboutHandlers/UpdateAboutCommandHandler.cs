using MediatR;
using UdemyCarBook.Application.Features.MediatR.Commands.AboutCommands;
using UdemyCarBook.Application.Interfaces;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Features.MediatR.Handlers.AboutHandlers
{
    public class UpdateAboutCommandHandler(IRepository<About> repository) : IRequestHandler<UpdateAboutCommand>
    {
        public async Task Handle(UpdateAboutCommand request, CancellationToken cancellationToken)
        {
            var value = await repository.GetByIdAsync(request.Id);
            value.Title = request.Title;
            value.Description = request.Description;
            value.ImageUrl = request.ImageUrl;
            await repository.UpdateAsync(value);
        }
    }
}

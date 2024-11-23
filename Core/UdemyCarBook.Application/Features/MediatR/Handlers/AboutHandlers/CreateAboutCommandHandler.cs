using MediatR;
using UdemyCarBook.Application.Features.MediatR.Commands.AboutCommands;
using UdemyCarBook.Application.Interfaces;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Features.MediatR.Handlers.AboutHandlers
{
    public class CreateAboutCommandHandler(IRepository<About> repository) : IRequestHandler<CreateAboutCommand>
    {
        public async Task Handle(CreateAboutCommand request, CancellationToken cancellationToken)
        {
            await repository.CreateAsync(new About
            {
                Description = request.Description,
                ImageUrl = request.ImageUrl,
                Title = request.Title,
            });
        }
    }
}

using MediatR;
using UdemyCarBook.Application.Features.MediatR.Commands.AuthorCommands;
using UdemyCarBook.Application.Interfaces;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Features.MediatR.Handlers.AuthorHandlers
{
    public class CreateAuthorCommandHandler(IRepository<Author> repository) : IRequestHandler<CreateAuthorCommand>
    {
        public async Task Handle(CreateAuthorCommand request, CancellationToken cancellationToken)
        {
            await repository.CreateAsync(new Author
            {
                Description = request.Description,
                ImageUrl = request.ImageUrl,
                Name = request.Name,
            });
        }
    }
}

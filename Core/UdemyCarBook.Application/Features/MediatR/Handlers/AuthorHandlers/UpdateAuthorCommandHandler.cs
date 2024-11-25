using MediatR;
using UdemyCarBook.Application.Features.MediatR.Commands.AuthorCommands;
using UdemyCarBook.Application.Interfaces;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Features.MediatR.Handlers.AuthorHandlers
{
    public class UpdateAuthorCommandHandler(IRepository<Author> repository) : IRequestHandler<UpdateAuthorCommand>
    {
        public async Task Handle(UpdateAuthorCommand request, CancellationToken cancellationToken)
        {
            var value = await repository.GetByIdAsync(request.Id);
            value.Description = request.Description;
            value.Name = request.Name;
            value.ImageUrl = request.ImageUrl;
            await repository.UpdateAsync(value);
        }
    }
}

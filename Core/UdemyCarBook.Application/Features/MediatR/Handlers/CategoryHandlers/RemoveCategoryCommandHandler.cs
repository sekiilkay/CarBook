using MediatR;
using UdemyCarBook.Application.Features.MediatR.Commands.CategoryCommands;
using UdemyCarBook.Application.Interfaces;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Features.MediatR.Handlers.CategoryHandlers
{
    public class RemoveCategoryCommandHandler(IRepository<Category> repository) : IRequestHandler<RemoveCategoryCommand>
    {
        public async Task Handle(RemoveCategoryCommand request, CancellationToken cancellationToken)
        {
            var value = await repository.GetByIdAsync(request.Id);
            await repository.DeleteAsync(value);
        }
    }
}

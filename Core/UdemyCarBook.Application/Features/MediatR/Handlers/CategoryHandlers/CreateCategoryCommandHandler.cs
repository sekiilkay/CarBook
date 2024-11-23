using MediatR;
using UdemyCarBook.Application.Features.MediatR.Commands.CategoryCommands;
using UdemyCarBook.Application.Interfaces;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Features.MediatR.Handlers.CategoryHandlers
{
    public class CreateCategoryCommandHandler(IRepository<Category> repository) : IRequestHandler<CreateCategoryCommand>
    {
        public async Task Handle(CreateCategoryCommand request, CancellationToken cancellationToken)
        {
            await repository.CreateAsync(new Category
            {
                Name = request.Name
            });
        }
    }
}

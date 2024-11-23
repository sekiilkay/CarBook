using MediatR;
using UdemyCarBook.Application.Features.MediatR.Commands.CategoryCommands;
using UdemyCarBook.Application.Interfaces;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Features.MediatR.Handlers.CategoryHandlers
{
    public class UpdateCategoryCommandHandler(IRepository<Category> repository) : IRequestHandler<UpdateCategoryCommand>
    {
        public async Task Handle(UpdateCategoryCommand request, CancellationToken cancellationToken)
        {
            var value = await repository.GetByIdAsync(request.Id);
            value.Name = request.Name;
            await repository.UpdateAsync(value);
        }
    }
}

using MediatR;
using UdemyCarBook.Application.Features.MediatR.Commands.BrandCommands;
using UdemyCarBook.Application.Interfaces;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Features.MediatR.Handlers.BrandHandlers
{
    public class UpdateBrandCommandHandler(IRepository<Brand> repository) : IRequestHandler<UpdateBrandCommand>
    {
        public async Task Handle(UpdateBrandCommand request, CancellationToken cancellationToken)
        {
            var value = await repository.GetByIdAsync(request.Id);
            value.Name = request.Name;
            await repository.UpdateAsync(value);
        }
    }
}

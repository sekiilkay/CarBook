using MediatR;
using UdemyCarBook.Application.Features.MediatR.Commands.BrandCommands;
using UdemyCarBook.Application.Interfaces;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Features.MediatR.Handlers.BrandHandlers
{
    public class RemoveBrandCommandHandler(IRepository<Brand> repository) : IRequestHandler<RemoveBrandCommand>
    {
        public async Task Handle(RemoveBrandCommand request, CancellationToken cancellationToken)
        {
            var value = await repository.GetByIdAsync(request.Id);
            await repository.DeleteAsync(value);
        }
    }
}

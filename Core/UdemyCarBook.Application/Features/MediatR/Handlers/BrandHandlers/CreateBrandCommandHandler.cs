using MediatR;
using UdemyCarBook.Application.Features.MediatR.Commands.BrandCommands;
using UdemyCarBook.Application.Interfaces;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Features.MediatR.Handlers.BrandHandlers
{
    public class CreateBrandCommandHandler(IRepository<Brand> repository) : IRequestHandler<CreateBrandCommand>
    {
        public async Task Handle(CreateBrandCommand request, CancellationToken cancellationToken)
        {
            await repository.CreateAsync(new Brand
            {
                Name = request.Name
            });
        }
    }
}

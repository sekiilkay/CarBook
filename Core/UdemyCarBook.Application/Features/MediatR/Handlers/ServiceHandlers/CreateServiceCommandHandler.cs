using MediatR;
using UdemyCarBook.Application.Features.MediatR.Commands.ServiceCommands;
using UdemyCarBook.Application.Interfaces;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Features.MediatR.Handlers.ServiceHandlers
{
    public class CreateServiceCommandHandler(IRepository<Service> repository) : IRequestHandler<CreateServiceCommand>
    {
        public async Task Handle(CreateServiceCommand request, CancellationToken cancellationToken)
        {
            await repository.CreateAsync(new Service
            {
                Description = request.Description,
                IconUrl = request.IconUrl,
                Title = request.Title,
            });
        }
    }
}

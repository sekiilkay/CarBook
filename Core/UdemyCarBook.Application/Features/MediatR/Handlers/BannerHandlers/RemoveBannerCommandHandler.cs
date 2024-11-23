using MediatR;
using UdemyCarBook.Application.Features.MediatR.Commands.BannerCommands;
using UdemyCarBook.Application.Interfaces;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Features.MediatR.Handlers.BannerHandlers
{
    public class RemoveBannerCommandHandler(IRepository<Banner> repository) : IRequestHandler<RemoveBannerCommand>
    {
        public async Task Handle(RemoveBannerCommand request, CancellationToken cancellationToken)
        {
            var value = await repository.GetByIdAsync(request.Id);
            await repository.DeleteAsync(value);
        }
    }
}

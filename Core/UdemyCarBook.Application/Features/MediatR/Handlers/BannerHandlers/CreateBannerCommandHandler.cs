using MediatR;
using UdemyCarBook.Application.Features.MediatR.Commands.BannerCommands;
using UdemyCarBook.Application.Interfaces;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Features.MediatR.Handlers.BannerHandlers
{
    public class CreateBannerCommandHandler(IRepository<Banner> repository) : IRequestHandler<CreateBannerCommand>
    {
        public async Task Handle(CreateBannerCommand request, CancellationToken cancellationToken)
        {
            await repository.CreateAsync(new Banner
            {
                Description = request.Description,
                Title = request.Title,
                VideoDescription = request.VideoDescription,
                VideoUrl = request.VideoUrl
            });
        }
    }
}

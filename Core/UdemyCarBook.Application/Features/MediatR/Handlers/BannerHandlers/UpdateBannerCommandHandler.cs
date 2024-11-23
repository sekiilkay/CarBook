using MediatR;
using UdemyCarBook.Application.Features.MediatR.Commands.BannerCommands;
using UdemyCarBook.Application.Interfaces;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Features.MediatR.Handlers.BannerHandlers
{
    public class UpdateBannerCommandHandler(IRepository<Banner> repository) : IRequestHandler<UpdateBannerCommand>
    {
        public async Task Handle(UpdateBannerCommand request, CancellationToken cancellationToken)
        {
            var value = await repository.GetByIdAsync(request.Id);
            value.VideoDescription = request.VideoDescription;
            value.Title = request.Title;
            value.VideoUrl = request.VideoUrl;
            value.Description = request.Description;
            await repository.UpdateAsync(value);
        }
    }
}

using MediatR;
using UdemyCarBook.Application.Features.MediatR.Commands.SocialMediaCommands;
using UdemyCarBook.Application.Interfaces;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Features.MediatR.Handlers.SocialMediaHandlers
{
    public class UpdateSocialMediaCommandHandler(IRepository<SocialMedia> repository) : IRequestHandler<UpdateSocialMediaCommand>
    {
        public async Task Handle(UpdateSocialMediaCommand request, CancellationToken cancellationToken)
        {
            var value = await repository.GetByIdAsync(request.Id);
            value.Url = request.Url;
            value.Name = request.Name;
            value.Icon = request.Icon;
            await repository.UpdateAsync(value);
        }
    }
}

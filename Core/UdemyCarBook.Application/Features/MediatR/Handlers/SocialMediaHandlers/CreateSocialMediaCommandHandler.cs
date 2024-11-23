using MediatR;
using UdemyCarBook.Application.Features.MediatR.Commands.SocialMediaCommands;
using UdemyCarBook.Application.Interfaces;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Features.MediatR.Handlers.SocialMediaHandlers
{
    public class CreateSocialMediaCommandHandler(IRepository<SocialMedia> repository) : IRequestHandler<CreateSocialMediaCommand>
    {
        public async Task Handle(CreateSocialMediaCommand request, CancellationToken cancellationToken)
        {
            await repository.CreateAsync(new SocialMedia
            {
                Icon = request.Icon,
                Name = request.Name,
                Url = request.Url,
            });
        }
    }
}

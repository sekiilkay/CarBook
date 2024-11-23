using MediatR;
using UdemyCarBook.Application.Features.MediatR.Commands.SocialMediaCommands;
using UdemyCarBook.Application.Interfaces;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Features.MediatR.Handlers.SocialMediaHandlers
{
    public class RemoveSocialMediaCommandHandler(IRepository<SocialMedia> repository) : IRequestHandler<RemoveSocialMediaCommand>
    {
        public async Task Handle(RemoveSocialMediaCommand request, CancellationToken cancellationToken)
        {
            var value = await repository.GetByIdAsync(request.Id);
            await repository.DeleteAsync(value);
        }
    }
}

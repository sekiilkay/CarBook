using MediatR;
using UdemyCarBook.Application.Enums;
using UdemyCarBook.Application.Features.MediatR.Commands.AppUserCommands;
using UdemyCarBook.Application.Interfaces;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Features.MediatR.Handlers.AppUserHandlers
{
    public class CreateAppUserCommandHandler(IRepository<AppUser> repository) : IRequestHandler<CreateAppUserCommand>
    {
        public async Task Handle(CreateAppUserCommand request, CancellationToken cancellationToken)
        {
            await repository.CreateAsync(new AppUser
            {
                Password = request.Password,
                UserName = request.UserName,
                AppRoleId = (int)ERolesType.Member,
                Email = request.Email,
                Name = request.Name,
                Surname = request.Surname
            });
        }
    }
}

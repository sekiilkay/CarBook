using MediatR;
using UdemyCarBook.Application.Features.MediatR.Queries.AppUserQueries;
using UdemyCarBook.Application.Features.MediatR.Results.AppUserResults;
using UdemyCarBook.Application.Interfaces;
using UdemyCarBook.Application.Interfaces.AppUserInterfaces;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Features.MediatR.Handlers.AppUserHandlers
{
    public class GetCheckAppUserQueryHandler(IRepository<AppUser> userRepository, IRepository<AppRole> roleRepository) : IRequestHandler<GetCheckAppUserQuery, GetCheckAppUserQueryResult>
    {
        public async Task<GetCheckAppUserQueryResult> Handle(GetCheckAppUserQuery request, CancellationToken cancellationToken)
        {
            var values = new GetCheckAppUserQueryResult();
            var user = await userRepository.GetByFilterAsync(x => x.UserName == request.UserName && x.Password == request.Password);
            if (user == null)
            {
                values.IsExist = false;
            }
            else
            {
                values.IsExist = true;
                values.UserName = user.UserName;
                values.Role = (await roleRepository.GetByFilterAsync(x => x.Id == user.AppRoleId)).AppRoleName;
                values.Id = user.Id;
            }
            return values;
        }
    }
}

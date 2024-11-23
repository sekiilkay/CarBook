using MediatR;
using UdemyCarBook.Application.Features.MediatR.Queries.ContactQueries;
using UdemyCarBook.Application.Features.MediatR.Results.ContactResults;
using UdemyCarBook.Application.Interfaces;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Features.MediatR.Handlers.ContactHandlers
{
    public class GetContactQueryHandler(IRepository<Contact> repository) : IRequestHandler<GetContactQuery, List<GetContactQueryResult>>
    {
        public async Task<List<GetContactQueryResult>> Handle(GetContactQuery request, CancellationToken cancellationToken)
        {
            var values = await repository.GetAllAsync();
            return values.Select(x => new GetContactQueryResult
            {
                Email = x.Email,
                Id = x.Id,
                Message = x.Message,
                Name = x.Name,
                SendDate = x.SendDate,
                Subject = x.Subject,
            }).ToList();
        }
    }
}

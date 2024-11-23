using MediatR;
using UdemyCarBook.Application.Features.MediatR.Queries.ContactQueries;
using UdemyCarBook.Application.Features.MediatR.Results.ContactResults;
using UdemyCarBook.Application.Interfaces;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Features.MediatR.Handlers.ContactHandlers
{
    public class GetContactByIdQueryHandler(IRepository<Contact> repository) : IRequestHandler<GetContactByIdQuery, GetContactByIdQueryResult>
    {
        public async Task<GetContactByIdQueryResult> Handle(GetContactByIdQuery request, CancellationToken cancellationToken)
        {
            var value = await repository.GetByIdAsync(request.Id);
            return new GetContactByIdQueryResult
            {
                Email = value.Email,
                Id = value.Id,
                Message = value.Message,
                Name = value.Name,
                SendDate = value.SendDate,
                Subject = value.Subject,
            };
        }
    }
}

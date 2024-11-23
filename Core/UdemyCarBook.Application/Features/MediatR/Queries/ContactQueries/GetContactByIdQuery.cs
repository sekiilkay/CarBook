using MediatR;
using UdemyCarBook.Application.Features.MediatR.Results.ContactResults;

namespace UdemyCarBook.Application.Features.MediatR.Queries.ContactQueries
{
    public class GetContactByIdQuery : IRequest<GetContactByIdQueryResult>
    {
        public int Id { get; set; }
        public GetContactByIdQuery(int id)
        {
            Id = id;
        }
    }
}

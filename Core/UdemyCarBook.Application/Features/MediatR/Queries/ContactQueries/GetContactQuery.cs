using MediatR;
using UdemyCarBook.Application.Features.MediatR.Results.ContactResults;

namespace UdemyCarBook.Application.Features.MediatR.Queries.ContactQueries
{
    public class GetContactQuery : IRequest<List<GetContactQueryResult>>
    {
    }
}

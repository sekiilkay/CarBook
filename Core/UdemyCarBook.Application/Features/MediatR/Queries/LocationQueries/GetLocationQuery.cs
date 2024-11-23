using MediatR;
using UdemyCarBook.Application.Features.MediatR.Results.LocationResults;

namespace UdemyCarBook.Application.Features.MediatR.Queries.LocationQueries
{
    public class GetLocationQuery : IRequest<List<GetLocationQueryResult>>
    {
    }
}

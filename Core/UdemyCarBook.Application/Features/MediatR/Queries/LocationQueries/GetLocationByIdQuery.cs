using MediatR;
using UdemyCarBook.Application.Features.MediatR.Results.LocationResults;

namespace UdemyCarBook.Application.Features.MediatR.Queries.LocationQueries
{
    public class GetLocationByIdQuery : IRequest<GetLocationByIdQueryResult>
    {
        public int Id { get; set; }
        public GetLocationByIdQuery(int id)
        {
            Id = id;
        }
    }
}

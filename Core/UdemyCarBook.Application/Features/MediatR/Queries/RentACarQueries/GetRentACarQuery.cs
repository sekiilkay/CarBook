using MediatR;
using UdemyCarBook.Application.Features.MediatR.Results.RentACarResults;

namespace UdemyCarBook.Application.Features.MediatR.Queries.RentACarQueries
{
    public class GetRentACarQuery : IRequest<List<GetRentACarQueryResult>>
    {
        public int LocationId { get; set; }
        public bool Available { get; set; }
    }
}

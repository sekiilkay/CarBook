using MediatR;
using UdemyCarBook.Application.Features.MediatR.Results.CarResults;

namespace UdemyCarBook.Application.Features.MediatR.Queries.CarQueries
{
    public class GetCarByIdQuery : IRequest<GetCarByIdQueryResult>
    {
        public int Id { get; set; }
        public GetCarByIdQuery(int id)
        {
            Id = id;
        }
    }
}

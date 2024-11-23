using MediatR;
using UdemyCarBook.Application.Features.MediatR.Results.ServiceResults;

namespace UdemyCarBook.Application.Features.MediatR.Queries.ServiceQueries
{
    public class GetServiceByIdQuery : IRequest<GetServiceByIdQueryResult>
    {
        public int Id { get; set; }
        public GetServiceByIdQuery(int id)
        {
            Id = id;
        }
    }
}

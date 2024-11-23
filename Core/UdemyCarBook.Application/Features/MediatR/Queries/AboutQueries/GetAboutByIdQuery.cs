using MediatR;
using UdemyCarBook.Application.Features.MediatR.Results.AboutResults;

namespace UdemyCarBook.Application.Features.MediatR.Queries.AboutQueries
{
    public class GetAboutByIdQuery : IRequest<GetAboutByIdQueryResult>
    {
        public int Id { get; set; }
        public GetAboutByIdQuery(int id)
        {
            Id = id;
        }
    }
}

using MediatR;
using UdemyCarBook.Application.Features.MediatR.Results.AuthorResults;

namespace UdemyCarBook.Application.Features.MediatR.Queries.AuthorQueries
{
    public class GetAuthorByIdQuery : IRequest<GetAuthorByIdQueryResult>
    {
        public int Id { get; set; }

        public GetAuthorByIdQuery(int id)
        {
            Id = id;
        }
    }
}

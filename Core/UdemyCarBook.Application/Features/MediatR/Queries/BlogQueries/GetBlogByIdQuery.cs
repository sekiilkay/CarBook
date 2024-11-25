using MediatR;
using UdemyCarBook.Application.Features.MediatR.Results.BlogResults;

namespace UdemyCarBook.Application.Features.MediatR.Queries.BlogQueries
{
    public class GetBlogByIdQuery : IRequest<GetBlogByIdQueryResult>
    {
        public int Id { get; set; }

        public GetBlogByIdQuery(int id)
        {
            Id = id;
        }
    }
}

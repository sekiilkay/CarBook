using MediatR;
using UdemyCarBook.Application.Features.MediatR.Results.AuthorResults;

namespace UdemyCarBook.Application.Features.MediatR.Queries.AuthorQueries
{
    public class GetAuthorQuery : IRequest<List<GetAuthorQueryResult>>
    {
    }
}

using MediatR;
using UdemyCarBook.Application.Features.MediatR.Results.BlogResults;

namespace UdemyCarBook.Application.Features.MediatR.Queries.BlogQueries
{
    public class GetAllBlogsWithAuthorQuery : IRequest<List<GetAllBlogsWithAuthorQueryResult>>
    {
    }
}

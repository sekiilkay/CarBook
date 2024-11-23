using MediatR;
using UdemyCarBook.Application.Features.MediatR.Results.CategoryResults;

namespace UdemyCarBook.Application.Features.MediatR.Queries.CategoryQueries
{
    public class GetCategoryQuery : IRequest<List<GetCategoryQueryResult>>
    {
    }
}

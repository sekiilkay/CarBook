using MediatR;
using UdemyCarBook.Application.Features.MediatR.Results.CategoryResults;

namespace UdemyCarBook.Application.Features.MediatR.Queries.CategoryQueries
{
    public class GetCategoryByIdQuery : IRequest<GetCategoryByIdQueryResult>
    {
        public int Id { get; set; }
        public GetCategoryByIdQuery(int id)
        {
            Id = id;
        }
    }
}

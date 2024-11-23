using MediatR;
using UdemyCarBook.Application.Features.MediatR.Results.BrandResults;

namespace UdemyCarBook.Application.Features.MediatR.Queries.BrandQueries
{
    public class GetBrandByIdQuery : IRequest<GetBrandByIdQueryResult>
    {
        public int Id { get; set; }
        public GetBrandByIdQuery(int id)
        {
            Id = id;
        }
    }
}

using MediatR;
using UdemyCarBook.Application.Features.MediatR.Results.BrandResults;

namespace UdemyCarBook.Application.Features.MediatR.Queries.BrandQueries
{
    public class GetBrandQuery : IRequest<List<GetBrandQueryResult>>
    {
    }
}

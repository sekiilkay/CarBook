using MediatR;
using UdemyCarBook.Application.Features.MediatR.Results.FeatureResults;

namespace UdemyCarBook.Application.Features.MediatR.Queries.FeatureQueries
{
    public class GetFeatureQuery : IRequest<List<GetFeatureQueryResult>>
    {
    }
}

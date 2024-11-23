using MediatR;
using UdemyCarBook.Application.Features.MediatR.Results.FeatureResults;

namespace UdemyCarBook.Application.Features.MediatR.Queries.FeatureQueries
{
    public class GetFeatureByIdQuery : IRequest<GetFeatureByIdQueryResult>
    {
        public int Id { get; set; }

        public GetFeatureByIdQuery(int id)
        {
            Id = id;
        }
    }
}

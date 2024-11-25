using MediatR;
using UdemyCarBook.Application.Features.MediatR.Results.CarFeatureResults;

namespace UdemyCarBook.Application.Features.MediatR.Queries.CarFeatureQueries
{
    public class GetCarFeatureByCarIdQuery : IRequest<List<GetCarFeatureByCarIdQueryResult>>
    {
        public int Id { get; set; }

        public GetCarFeatureByCarIdQuery(int id)
        {
            Id = id;
        }
    }
}

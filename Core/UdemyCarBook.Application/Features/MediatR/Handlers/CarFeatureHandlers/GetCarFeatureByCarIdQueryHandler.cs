using MediatR;
using UdemyCarBook.Application.Features.MediatR.Queries.CarFeatureQueries;
using UdemyCarBook.Application.Features.MediatR.Results.CarFeatureResults;
using UdemyCarBook.Application.Interfaces.CarFeatureInterfaces;

namespace UdemyCarBook.Application.Features.MediatR.Handlers.CarFeatureHandlers
{
    public class GetCarFeatureByCarIdQueryHandler(ICarFeatureRepository carFeatureRepository) : IRequestHandler<GetCarFeatureByCarIdQuery, List<GetCarFeatureByCarIdQueryResult>>
    {
        public async Task<List<GetCarFeatureByCarIdQueryResult>> Handle(GetCarFeatureByCarIdQuery request, CancellationToken cancellationToken)
        {
            var values = await carFeatureRepository.GetCarFeaturesByCarIdAsync(request.Id);
            return values.Select(x => new GetCarFeatureByCarIdQueryResult
            {
                Available = x.Available,
                CarFeatureId = x.Id,
                FeatureId = x.FeatureId,
                FeatureName = x.Feature.Name
            }).ToList();
        }
    }
}

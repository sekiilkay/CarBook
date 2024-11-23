using MediatR;
using UdemyCarBook.Application.Features.MediatR.Queries.FeatureQueries;
using UdemyCarBook.Application.Features.MediatR.Results.FeatureResults;
using UdemyCarBook.Application.Interfaces;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Features.MediatR.Handlers.FeatureHandlers
{
    public class GetFeatureQueryHandler(IRepository<Feature> repository) : IRequestHandler<GetFeatureQuery, List<GetFeatureQueryResult>>
    {
        public async Task<List<GetFeatureQueryResult>> Handle(GetFeatureQuery request, CancellationToken cancellationToken)
        {
            var values = await repository.GetAllAsync();
            return values.Select(x => new GetFeatureQueryResult
            {
                Id = x.Id,
                Name = x.Name
            }).ToList();
        }
    }
}

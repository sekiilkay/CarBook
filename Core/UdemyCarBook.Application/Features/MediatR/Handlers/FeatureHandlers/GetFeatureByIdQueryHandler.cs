using MediatR;
using UdemyCarBook.Application.Features.MediatR.Queries.FeatureQueries;
using UdemyCarBook.Application.Features.MediatR.Results.FeatureResults;
using UdemyCarBook.Application.Interfaces;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Features.MediatR.Handlers.FeatureHandlers
{
    public class GetFeatureByIdQueryHandler(IRepository<Feature> repository) : IRequestHandler<GetFeatureByIdQuery, GetFeatureByIdQueryResult>
    {
        public async Task<GetFeatureByIdQueryResult> Handle(GetFeatureByIdQuery request, CancellationToken cancellationToken)
        {
            var value = await repository.GetByIdAsync(request.Id);
            return new GetFeatureByIdQueryResult
            {
                Id = value.Id,
                Name = value.Name
            };
        }
    }
}

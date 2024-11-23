using MediatR;
using UdemyCarBook.Application.Features.MediatR.Queries.PricingQueries;
using UdemyCarBook.Application.Features.MediatR.Results.PricingResults;
using UdemyCarBook.Application.Interfaces;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Features.MediatR.Handlers.PricingHandlers
{
    public class GetPricingQueryHandler(IRepository<Pricing> repository) : IRequestHandler<GetPricingQuery, List<GetPricingQueryResult>>
    {
        public async Task<List<GetPricingQueryResult>> Handle(GetPricingQuery request, CancellationToken cancellationToken)
        {
            var values = await repository.GetAllAsync();
            return values.Select(x => new GetPricingQueryResult
            {
                Id = x.Id,
                Name = x.Name,
            }).ToList();
        }
    }
}

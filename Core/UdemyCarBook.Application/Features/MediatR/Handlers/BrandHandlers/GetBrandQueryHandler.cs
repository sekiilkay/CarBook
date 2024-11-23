using MediatR;
using UdemyCarBook.Application.Features.MediatR.Queries.BrandQueries;
using UdemyCarBook.Application.Features.MediatR.Results.BrandResults;
using UdemyCarBook.Application.Interfaces;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Features.MediatR.Handlers.BrandHandlers
{
    public class GetBrandQueryHandler(IRepository<Brand> repository) : IRequestHandler<GetBrandQuery, List<GetBrandQueryResult>>
    {
        public async Task<List<GetBrandQueryResult>> Handle(GetBrandQuery request, CancellationToken cancellationToken)
        {
            var values = await repository.GetAllAsync();
            return values.Select(x => new GetBrandQueryResult
            {
                Id = x.Id,
                Name = x.Name,
            }).ToList();
        }
    }
}

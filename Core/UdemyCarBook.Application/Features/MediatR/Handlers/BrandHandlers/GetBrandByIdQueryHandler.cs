using MediatR;
using UdemyCarBook.Application.Features.MediatR.Queries.BrandQueries;
using UdemyCarBook.Application.Features.MediatR.Results.BrandResults;
using UdemyCarBook.Application.Interfaces;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Features.MediatR.Handlers.BrandHandlers
{
    public class GetBrandByIdQueryHandler(IRepository<Brand> repository) : IRequestHandler<GetBrandByIdQuery, GetBrandByIdQueryResult>
    {
        public async Task<GetBrandByIdQueryResult> Handle(GetBrandByIdQuery request, CancellationToken cancellationToken)
        {
            var value = await repository.GetByIdAsync(request.Id);
            return new GetBrandByIdQueryResult
            {
                Id = value.Id,
                Name = value.Name
            };
        }
    }
}

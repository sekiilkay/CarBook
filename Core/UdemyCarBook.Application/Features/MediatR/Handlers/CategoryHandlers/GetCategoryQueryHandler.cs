using MediatR;
using UdemyCarBook.Application.Features.MediatR.Queries.CategoryQueries;
using UdemyCarBook.Application.Features.MediatR.Results.CategoryResults;
using UdemyCarBook.Application.Interfaces;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Features.MediatR.Handlers.CategoryHandlers
{
    public class GetCategoryQueryHandler(IRepository<Category> repository) : IRequestHandler<GetCategoryQuery, List<GetCategoryQueryResult>>
    {
        public async Task<List<GetCategoryQueryResult>> Handle(GetCategoryQuery request, CancellationToken cancellationToken)
        {
            var values = await repository.GetAllAsync();
            return values.Select(x => new GetCategoryQueryResult
            {
                Id = x.Id,
                Name = x.Name,
            }).ToList();
        }
    }
}

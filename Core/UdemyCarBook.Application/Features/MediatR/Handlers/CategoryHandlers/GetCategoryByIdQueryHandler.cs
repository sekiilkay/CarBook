using MediatR;
using UdemyCarBook.Application.Features.MediatR.Queries.CategoryQueries;
using UdemyCarBook.Application.Features.MediatR.Results.CategoryResults;
using UdemyCarBook.Application.Interfaces;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Features.MediatR.Handlers.CategoryHandlers
{
    public class GetCategoryByIdQueryHandler(IRepository<Category> repository) : IRequestHandler<GetCategoryByIdQuery, GetCategoryByIdQueryResult>
    {
        public async Task<GetCategoryByIdQueryResult> Handle(GetCategoryByIdQuery request, CancellationToken cancellationToken)
        {
            var value = await repository.GetByIdAsync(request.Id);
            return new GetCategoryByIdQueryResult
            {
                Id = value.Id,
                Name = value.Name,
            };
        }
    }
}

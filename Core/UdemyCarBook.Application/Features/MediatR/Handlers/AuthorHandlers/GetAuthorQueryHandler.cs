using MediatR;
using UdemyCarBook.Application.Features.MediatR.Queries.AuthorQueries;
using UdemyCarBook.Application.Features.MediatR.Results.AuthorResults;
using UdemyCarBook.Application.Interfaces;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Features.MediatR.Handlers.AuthorHandlers
{
    public class GetAuthorQueryHandler(IRepository<Author> repository) : IRequestHandler<GetAuthorQuery, List<GetAuthorQueryResult>>
    {
        public async Task<List<GetAuthorQueryResult>> Handle(GetAuthorQuery request, CancellationToken cancellationToken)
        {
            var values = await repository.GetAllAsync();
            return values.Select(x => new GetAuthorQueryResult
            {
                Description = x.Description,
                Id = x.Id,
                ImageUrl = x.ImageUrl,
                Name = x.Name,
            }).ToList();
        }
    }
}

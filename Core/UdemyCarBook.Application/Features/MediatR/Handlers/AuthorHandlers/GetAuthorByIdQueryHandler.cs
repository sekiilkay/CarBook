using MediatR;
using UdemyCarBook.Application.Features.MediatR.Queries.AuthorQueries;
using UdemyCarBook.Application.Features.MediatR.Results.AuthorResults;
using UdemyCarBook.Application.Interfaces;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Features.MediatR.Handlers.AuthorHandlers
{
    public class GetAuthorByIdQueryHandler(IRepository<Author> repository) : IRequestHandler<GetAuthorByIdQuery, GetAuthorByIdQueryResult>
    {
        public async Task<GetAuthorByIdQueryResult> Handle(GetAuthorByIdQuery request, CancellationToken cancellationToken)
        {
            var value = await repository.GetByIdAsync(request.Id);
            return new GetAuthorByIdQueryResult
            {
                Description = value.Description,
                Id = value.Id,
                ImageUrl = value.ImageUrl,
                Name = value.Name,
            };
        }
    }
}

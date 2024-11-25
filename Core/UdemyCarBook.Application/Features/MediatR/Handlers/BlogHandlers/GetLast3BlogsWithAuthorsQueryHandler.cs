using MediatR;
using UdemyCarBook.Application.Features.MediatR.Queries.BlogQueries;
using UdemyCarBook.Application.Features.MediatR.Results.BlogResults;
using UdemyCarBook.Application.Interfaces.BlogInterfaces;

namespace UdemyCarBook.Application.Features.MediatR.Handlers.BlogHandlers
{
    public class GetLast3BlogsWithAuthorsQueryHandler(IBlogRepository blogRepository) : IRequestHandler<GetLast3BlogsWithAuthorsQuery, List<GetLast3BlogsWithAuthorsQueryResult>>
    {
        public async Task<List<GetLast3BlogsWithAuthorsQueryResult>> Handle(GetLast3BlogsWithAuthorsQuery request, CancellationToken cancellationToken)
        {
            var values = await blogRepository.GetLast3BlogsWithAuthorsAsync();
            return values.Select(x => new GetLast3BlogsWithAuthorsQueryResult
            {
                AuthorId = x.AuthorId,
                AuthorName = x.Author.Name,
                CategoryId = x.CategoryId,
                CoverImageUrl = x.CoverImageUrl,
                CreatedDate = x.CreatedDate,
                Title = x.Title,
                Id = x.Id,
            }).ToList();
        }
    }
}

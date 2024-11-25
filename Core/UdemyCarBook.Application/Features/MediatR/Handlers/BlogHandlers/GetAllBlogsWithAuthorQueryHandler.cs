using MediatR;
using UdemyCarBook.Application.Features.MediatR.Queries.BlogQueries;
using UdemyCarBook.Application.Features.MediatR.Results.BlogResults;
using UdemyCarBook.Application.Interfaces.BlogInterfaces;

namespace UdemyCarBook.Application.Features.MediatR.Handlers.BlogHandlers
{
    public class GetAllBlogsWithAuthorQueryHandler(IBlogRepository blogRepository) : IRequestHandler<GetAllBlogsWithAuthorQuery, List<GetAllBlogsWithAuthorQueryResult>>
    {
        public async Task<List<GetAllBlogsWithAuthorQueryResult>> Handle(GetAllBlogsWithAuthorQuery request, CancellationToken cancellationToken)
        {
            var values = await blogRepository.GetAllBlogsWithAuthorsAsync();
            return values.Select(x => new GetAllBlogsWithAuthorQueryResult
            {
                AuthorDescription = x.Author.Description,
                AuthorId = x.Author.Id,
                AuthorImageUrl = x.Author.ImageUrl,
                AuthorName = x.Author.Name,
                BlogId = x.Id,
                CategoryId = x.Category.Id,
                CategoryName = x.Category.Name,
                CoverImageUrl = x.CoverImageUrl,
                CreatedDate = x.CreatedDate,
                Description = x.Description,
                Title = x.Title,
            }).ToList();
        }
    }
}

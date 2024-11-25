using MediatR;
using UdemyCarBook.Application.Features.MediatR.Commands.BlogCommands;
using UdemyCarBook.Application.Interfaces;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Features.MediatR.Handlers.BlogHandlers
{
    public class CreateBlogCommandHandler(IRepository<Blog> repository) : IRequestHandler<CreateBlogCommand>
    {
        public async Task Handle(CreateBlogCommand request, CancellationToken cancellationToken)
        {
            await repository.CreateAsync(new Blog
            {
                AuthorId = request.AuthorId,
                CategoryId = request.CategoryId,
                CoverImageUrl = request.CoverImageUrl,
                CreatedDate = request.CreatedDate,
                Title = request.Title,
            });
        }
    }
}

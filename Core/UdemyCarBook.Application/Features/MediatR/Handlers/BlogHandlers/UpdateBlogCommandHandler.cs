using MediatR;
using UdemyCarBook.Application.Features.MediatR.Commands.BlogCommands;
using UdemyCarBook.Application.Interfaces;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Features.MediatR.Handlers.BlogHandlers
{
    public class UpdateBlogCommandHandler(IRepository<Blog> repository) : IRequestHandler<UpdateBlogCommand>
    {
        public async Task Handle(UpdateBlogCommand request, CancellationToken cancellationToken)
        {
            var value = await repository.GetByIdAsync(request.Id);
            value.AuthorId = request.AuthorId;
            value.CreatedDate = request.CreatedDate;
            value.CategoryId = request.CategoryId;
            value.CoverImageUrl = request.CoverImageUrl;
            value.Title = request.Title;
            await repository.UpdateAsync(value);
        }
    }
}

using MediatR;
using UdemyCarBook.Application.Features.MediatR.Commands.CommentCommands;
using UdemyCarBook.Application.Interfaces;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Features.MediatR.Handlers.CommentHandlers
{
    public class CreateCommentCommandHandler(IRepository<Comment> repository) : IRequestHandler<CreateCommentCommand>
    {
        public async Task Handle(CreateCommentCommand request, CancellationToken cancellationToken)
        {
            await repository.CreateAsync(new Comment
            {
                BlogId = request.BlogId,
                CreatedDate = DateTime.Parse(DateTime.Now.ToShortDateString()),
                Name = request.Name,
                Email = request.Email,
                Description = request.Description,
            });
        }
    }
}

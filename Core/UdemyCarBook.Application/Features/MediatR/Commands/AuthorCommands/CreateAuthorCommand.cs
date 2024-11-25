using MediatR;

namespace UdemyCarBook.Application.Features.MediatR.Commands.AuthorCommands
{
    public class CreateAuthorCommand : IRequest
    {
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public string Description { get; set; }
    }
}

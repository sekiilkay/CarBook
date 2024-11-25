using MediatR;

namespace UdemyCarBook.Application.Features.MediatR.Commands.AuthorCommands
{
    public class UpdateAuthorCommand : IRequest
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public string Description { get; set; }
    }
}

using MediatR;

namespace UdemyCarBook.Application.Features.MediatR.Commands.AboutCommands
{
    public class UpdateAboutCommand : IRequest
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
    }
}

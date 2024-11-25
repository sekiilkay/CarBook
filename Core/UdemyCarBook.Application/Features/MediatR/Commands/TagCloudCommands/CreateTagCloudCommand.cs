using MediatR;

namespace UdemyCarBook.Application.Features.MediatR.Commands.TagCloudCommands
{
    public class CreateTagCloudCommand : IRequest
    {
        public string Title { get; set; }
        public int BlogId { get; set; }
    }
}

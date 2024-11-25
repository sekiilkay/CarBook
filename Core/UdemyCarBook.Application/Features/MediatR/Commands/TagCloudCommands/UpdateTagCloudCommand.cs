using MediatR;

namespace UdemyCarBook.Application.Features.MediatR.Commands.TagCloudCommands
{
    public class UpdateTagCloudCommand : IRequest
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int BlogId { get; set; }
    }
}

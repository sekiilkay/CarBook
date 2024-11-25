using MediatR;

namespace UdemyCarBook.Application.Features.MediatR.Commands.TagCloudCommands
{
    public class RemoveTagCloudCommand : IRequest
    {
        public int Id { get; set; }
        public RemoveTagCloudCommand(int id)
        {
            Id = id;
        }
    }
}

using MediatR;

namespace UdemyCarBook.Application.Features.MediatR.Commands.AboutCommands
{
    public class RemoveAboutCommand : IRequest
    {
        public int Id { get; set; }
        public RemoveAboutCommand(int id)
        {
            Id = id;
        }
    }
}

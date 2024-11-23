using MediatR;

namespace UdemyCarBook.Application.Features.MediatR.Commands.ServiceCommands
{
    public class RemoveServiceCommand : IRequest
    {
        public int Id { get; set; }
        public RemoveServiceCommand(int id)
        {
            Id = id;
        }
    }
}

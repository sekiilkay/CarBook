using MediatR;

namespace UdemyCarBook.Application.Features.MediatR.Commands.LocationCommands
{
    public class CreateLocationCommand : IRequest
    {
        public string Name { get; set; }
    }
}

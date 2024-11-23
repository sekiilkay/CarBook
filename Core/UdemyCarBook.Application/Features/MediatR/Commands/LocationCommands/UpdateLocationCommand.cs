using MediatR;

namespace UdemyCarBook.Application.Features.MediatR.Commands.LocationCommands
{
    public class UpdateLocationCommand : IRequest
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}

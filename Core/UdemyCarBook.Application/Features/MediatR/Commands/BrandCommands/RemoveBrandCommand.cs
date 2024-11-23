using MediatR;

namespace UdemyCarBook.Application.Features.MediatR.Commands.BrandCommands
{
    public class RemoveBrandCommand : IRequest
    {
        public int Id { get; set; }
        public RemoveBrandCommand(int id)
        {
            Id = id;
        }
    }
}

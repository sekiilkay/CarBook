using MediatR;

namespace UdemyCarBook.Application.Features.MediatR.Commands.PricingCommands
{
    public class RemovePricingCommand : IRequest
    {
        public int Id { get; set; }
        public RemovePricingCommand(int id)
        {
            Id = id;
        }
    }
}

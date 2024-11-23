using MediatR;

namespace UdemyCarBook.Application.Features.MediatR.Commands.PricingCommands
{
    public class CreatePricingCommand : IRequest
    {
        public string Name { get; set; }
    }
}

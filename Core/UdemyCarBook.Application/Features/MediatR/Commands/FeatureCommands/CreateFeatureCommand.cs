using MediatR;

namespace UdemyCarBook.Application.Features.MediatR.Commands.FeatureCommands
{
    public class CreateFeatureCommand : IRequest
    {
        public string Name { get; set; }
    }
}

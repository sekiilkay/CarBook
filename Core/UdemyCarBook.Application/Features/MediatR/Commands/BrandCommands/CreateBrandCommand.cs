using MediatR;

namespace UdemyCarBook.Application.Features.MediatR.Commands.BrandCommands
{
    public class CreateBrandCommand : IRequest
    {
        public string Name { get; set; }
    }
}

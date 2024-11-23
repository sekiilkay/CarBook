using MediatR;

namespace UdemyCarBook.Application.Features.MediatR.Commands.BrandCommands
{
    public class UpdateBrandCommand : IRequest
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}

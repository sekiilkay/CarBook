using MediatR;

namespace UdemyCarBook.Application.Features.MediatR.Commands.CategoryCommands
{
    public class CreateCategoryCommand : IRequest
    {
        public string Name { get; set; }
    }
}

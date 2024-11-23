using MediatR;

namespace UdemyCarBook.Application.Features.MediatR.Commands.CategoryCommands
{
    public class UpdateCategoryCommand : IRequest
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}

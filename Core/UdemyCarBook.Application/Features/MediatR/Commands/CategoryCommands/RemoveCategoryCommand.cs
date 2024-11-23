using MediatR;

namespace UdemyCarBook.Application.Features.MediatR.Commands.CategoryCommands
{
    public class RemoveCategoryCommand : IRequest
    {
        public int Id { get; set; }
        public RemoveCategoryCommand(int id)
        {
            Id = id;
        }
    }
}

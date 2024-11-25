using MediatR;

namespace UdemyCarBook.Application.Features.MediatR.Commands.AuthorCommands
{
    public class RemoveAuthorCommand : IRequest
    {
        public int Id { get; set; }
        public RemoveAuthorCommand(int id)
        {
            Id = id;
        }
    }
}

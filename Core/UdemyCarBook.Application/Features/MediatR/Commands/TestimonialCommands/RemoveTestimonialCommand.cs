using MediatR;

namespace UdemyCarBook.Application.Features.MediatR.Commands.TestimonialCommands
{
    public class RemoveTestimonialCommand : IRequest
    {
        public int Id { get; set; }
        public RemoveTestimonialCommand(int id)
        {
            Id = id;
        }
    }
}

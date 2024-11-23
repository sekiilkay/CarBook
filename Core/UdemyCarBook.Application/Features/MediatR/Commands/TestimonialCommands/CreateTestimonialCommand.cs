using MediatR;

namespace UdemyCarBook.Application.Features.MediatR.Commands.TestimonialCommands
{
    public class CreateTestimonialCommand : IRequest
    {
        public string Name { get; set; }
        public string Title { get; set; }
        public string Comment { get; set; }
        public string ImageUrl { get; set; }
    }
}

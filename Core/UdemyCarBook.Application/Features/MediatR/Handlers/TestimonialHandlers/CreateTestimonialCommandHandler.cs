using MediatR;
using UdemyCarBook.Application.Features.MediatR.Commands.TestimonialCommands;
using UdemyCarBook.Application.Interfaces;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Features.MediatR.Handlers.TestimonialHandlers
{
    public class CreateTestimonialCommandHandler(IRepository<Testimonial> repository) : IRequestHandler<CreateTestimonialCommand>
    {
        public async Task Handle(CreateTestimonialCommand request, CancellationToken cancellationToken)
        {
            await repository.CreateAsync(new Testimonial
            {
                Comment = request.Comment,
                ImageUrl = request.ImageUrl,
                Name = request.Name,
                Title = request.Title,
            });
        }
    }
}

using MediatR;
using UdemyCarBook.Application.Features.MediatR.Commands.TestimonialCommands;
using UdemyCarBook.Application.Interfaces;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Features.MediatR.Handlers.TestimonialHandlers
{
    public class UpdateTestimonialCommandHandler(IRepository<Testimonial> repository) : IRequestHandler<UpdateTestimonialCommand>
    {
        public async Task Handle(UpdateTestimonialCommand request, CancellationToken cancellationToken)
        {
            var value = await repository.GetByIdAsync(request.Id);
            value.Comment = request.Comment;
            value.Name = request.Name;
            value.Title = request.Title;
            value.ImageUrl = request.ImageUrl;
            await repository.UpdateAsync(value);
        }
    }
}

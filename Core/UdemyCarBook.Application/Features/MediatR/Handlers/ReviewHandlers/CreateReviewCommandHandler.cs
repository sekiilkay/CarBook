using MediatR;
using UdemyCarBook.Application.Features.MediatR.Commands.ReviewCommands;
using UdemyCarBook.Application.Interfaces;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Features.MediatR.Handlers.ReviewHandlers
{
    public class CreateReviewCommandHandler(IRepository<Review> repository) : IRequestHandler<CreateReviewCommand>
    {
        public async Task Handle(CreateReviewCommand request, CancellationToken cancellationToken)
        {
            await repository.CreateAsync(new Review
            {
                CustomerImage = request.CustomerImage,
                CarId = request.CarId,
                Comment = request.Comment,
                CustomerName = request.CustomerName,
                RaytingValue = request.RaytingValue,
                ReviewDate = DateTime.Parse(request.ReviewDate.ToShortDateString()),
            });
        }
    }
}

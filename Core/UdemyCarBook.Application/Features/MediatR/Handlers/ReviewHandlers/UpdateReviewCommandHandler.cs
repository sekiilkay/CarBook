using MediatR;
using UdemyCarBook.Application.Features.MediatR.Commands.ReviewCommands;
using UdemyCarBook.Application.Interfaces;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Features.MediatR.Handlers.ReviewHandlers
{
    public class UpdateReviewCommandHandler(IRepository<Review> repository) : IRequestHandler<UpdateReviewCommand>
    {
        public async Task Handle(UpdateReviewCommand request, CancellationToken cancellationToken)
        {
            var value = await repository.GetByIdAsync(request.Id);
            value.CustomerName = request.CustomerName;
            value.ReviewDate = request.ReviewDate;
            value.Comment = request.Comment;
            value.RaytingValue = request.RaytingValue;
            value.CarId = request.CarId;
            await repository.UpdateAsync(value);
        }
    }
}

using MediatR;
using UdemyCarBook.Application.Features.MediatR.Queries.ReviewQueries;
using UdemyCarBook.Application.Features.MediatR.Results.ReviewResults;
using UdemyCarBook.Application.Interfaces;
using UdemyCarBook.Application.Interfaces.ReviewInterfaces;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Features.MediatR.Handlers.ReviewHandlers
{
    public class GetReviewByCarIdQueryHandler(IReviewRepository reviewRepository) : IRequestHandler<GetReviewByCarIdQuery, List<GetReviewByCarIdQueryResult>>
    {
        public async Task<List<GetReviewByCarIdQueryResult>> Handle(GetReviewByCarIdQuery request, CancellationToken cancellationToken)
        {
            var values = await reviewRepository.GetReviewsByCarIdAsync(request.Id);
            return values.Select(x => new GetReviewByCarIdQueryResult
            {
                CarId = x.CarId,
                Comment = x.Comment,
                CustomerImage = x.CustomerImage,
                CustomerName = x.CustomerName,
                Id = x.Id,
                RaytingValue = x.RaytingValue,
                ReviewDate = x.ReviewDate
            }).ToList();
        }
    }
}

using MediatR;
using UdemyCarBook.Application.Features.MediatR.Results.ReviewResults;

namespace UdemyCarBook.Application.Features.MediatR.Queries.ReviewQueries
{
    public class GetReviewByCarIdQuery : IRequest<List<GetReviewByCarIdQueryResult>>
    {
        public int Id { get; set; }

        public GetReviewByCarIdQuery(int id)
        {
            Id = id;
        }
    }
}

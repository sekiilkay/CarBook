using MediatR;
using UdemyCarBook.Application.Features.MediatR.Results.TestimonialResults;

namespace UdemyCarBook.Application.Features.MediatR.Queries.TestimonialQueries
{
    public class GetTestimonialByIdQuery : IRequest<GetTestimonialByIdQueryResult>
    {
        public int Id { get; set; }
        public GetTestimonialByIdQuery(int id)
        {
            Id = id;
        }
    }
}

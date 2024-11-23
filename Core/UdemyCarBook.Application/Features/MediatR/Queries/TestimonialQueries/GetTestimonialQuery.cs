using MediatR;
using UdemyCarBook.Application.Features.MediatR.Results.TestimonialResults;

namespace UdemyCarBook.Application.Features.MediatR.Queries.TestimonialQueries
{
    public class GetTestimonialQuery : IRequest<List<GetTestimonialQueryResult>>
    {
    }
}

using MediatR;
using UdemyCarBook.Application.Features.MediatR.Queries.TestimonialQueries;
using UdemyCarBook.Application.Features.MediatR.Results.TestimonialResults;
using UdemyCarBook.Application.Interfaces;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Features.MediatR.Handlers.TestimonialHandlers
{
    public class GetTestimonialQueryHandler(IRepository<Testimonial> repository) : IRequestHandler<GetTestimonialQuery, List<GetTestimonialQueryResult>>
    {
        public async Task<List<GetTestimonialQueryResult>> Handle(GetTestimonialQuery request, CancellationToken cancellationToken)
        {
            var values = await repository.GetAllAsync();
            return values.Select(x => new GetTestimonialQueryResult
            {
                Comment = x.Comment,
                Id = x.Id,
                ImageUrl = x.ImageUrl,
                Name = x.Name,
                Title = x.Title,
            }).ToList();
        }
    }
}

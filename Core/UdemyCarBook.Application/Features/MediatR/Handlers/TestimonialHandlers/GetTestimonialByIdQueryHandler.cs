using MediatR;
using UdemyCarBook.Application.Features.MediatR.Queries.TestimonialQueries;
using UdemyCarBook.Application.Features.MediatR.Results.TestimonialResults;
using UdemyCarBook.Application.Interfaces;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Features.MediatR.Handlers.TestimonialHandlers
{
    public class GetTestimonialByIdQueryHandler(IRepository<Testimonial> repository) : IRequestHandler<GetTestimonialByIdQuery, GetTestimonialByIdQueryResult>
    {
        public async Task<GetTestimonialByIdQueryResult> Handle(GetTestimonialByIdQuery request, CancellationToken cancellationToken)
        {
            var value = await repository.GetByIdAsync(request.Id);
            return new GetTestimonialByIdQueryResult
            {
                Id = value.Id,
                Comment = value.Comment,
                ImageUrl = value.ImageUrl,
                Name = value.Name,
                Title = value.Title
            };
        }
    }
}

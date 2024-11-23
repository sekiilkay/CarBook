using MediatR;
using UdemyCarBook.Application.Features.MediatR.Queries.AboutQueries;
using UdemyCarBook.Application.Features.MediatR.Results.AboutResults;
using UdemyCarBook.Application.Interfaces;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Features.MediatR.Handlers.AboutHandlers
{
    public class GetAboutByIdQueryHandler(IRepository<About> repository) : IRequestHandler<GetAboutByIdQuery, GetAboutByIdQueryResult>
    {
        public async Task<GetAboutByIdQueryResult> Handle(GetAboutByIdQuery request, CancellationToken cancellationToken)
        {
            var value = await repository.GetByIdAsync(request.Id);
            return new GetAboutByIdQueryResult
            {
                Id = value.Id,
                Description = value.Description,
                ImageUrl = value.ImageUrl,
                Title = value.Title,
            };
        }
    }
}

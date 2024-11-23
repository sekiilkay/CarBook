using MediatR;
using UdemyCarBook.Application.Features.MediatR.Queries.AboutQueries;
using UdemyCarBook.Application.Features.MediatR.Results.AboutResults;
using UdemyCarBook.Application.Interfaces;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Features.MediatR.Handlers.AboutHandlers
{
    public class GetAboutQueryHandler(IRepository<About> repository) : IRequestHandler<GetAboutQuery, List<GetAboutQueryResult>>
    {
        public async Task<List<GetAboutQueryResult>> Handle(GetAboutQuery request, CancellationToken cancellationToken)
        {
            var values = await repository.GetAllAsync();
            return values.Select(x=> new GetAboutQueryResult
            {
                Description = x.Description,
                Id = x.Id,
                ImageUrl = x.ImageUrl,
                Title = x.Title
            }).ToList();    
        }
    }
}

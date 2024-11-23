using MediatR;
using UdemyCarBook.Application.Features.MediatR.Queries.ServiceQueries;
using UdemyCarBook.Application.Features.MediatR.Results.ServiceResults;
using UdemyCarBook.Application.Interfaces;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Features.MediatR.Handlers.ServiceHandlers
{
    public class GetServiceQueryHandler(IRepository<Service> repository) : IRequestHandler<GetServiceQuery, List<GetServiceQueryResult>>
    {
        public async Task<List<GetServiceQueryResult>> Handle(GetServiceQuery request, CancellationToken cancellationToken)
        {
            var values = await repository.GetAllAsync();
            return values.Select(x => new GetServiceQueryResult
            {
                Description = x.Description,
                IconUrl = x.IconUrl,
                Id = x.Id,
                Title = x.Title
            }).ToList();
        }
    }
}

using MediatR;
using UdemyCarBook.Application.Features.MediatR.Queries.LocationQueries;
using UdemyCarBook.Application.Features.MediatR.Results.LocationResults;
using UdemyCarBook.Application.Interfaces;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Features.MediatR.Handlers.LocationHandlers
{
    public class GetLocationQueryHandler(IRepository<Location> repository) : IRequestHandler<GetLocationQuery, List<GetLocationQueryResult>>
    {
        public async Task<List<GetLocationQueryResult>> Handle(GetLocationQuery request, CancellationToken cancellationToken)
        {
            var values = await repository.GetAllAsync();
            return values.Select(x => new GetLocationQueryResult
            {
                Id = x.Id,
                Name = x.Name
            }).ToList();
        }
    }
}

using MediatR;
using UdemyCarBook.Application.Features.MediatR.Queries.LocationQueries;
using UdemyCarBook.Application.Features.MediatR.Results.LocationResults;
using UdemyCarBook.Application.Interfaces;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Features.MediatR.Handlers.LocationHandlers
{
    public class GetLocationByIdQueryHandler(IRepository<Location> repository) : IRequestHandler<GetLocationByIdQuery, GetLocationByIdQueryResult>
    {
        public async Task<GetLocationByIdQueryResult> Handle(GetLocationByIdQuery request, CancellationToken cancellationToken)
        {
            var value = await repository.GetByIdAsync(request.Id);
            return new GetLocationByIdQueryResult
            {
                Id = value.Id,
                Name = value.Name,
            };
        }
    }
}

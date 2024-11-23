using MediatR;
using UdemyCarBook.Application.Features.MediatR.Queries.ServiceQueries;
using UdemyCarBook.Application.Features.MediatR.Results.ServiceResults;
using UdemyCarBook.Application.Interfaces;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Features.MediatR.Handlers.ServiceHandlers
{
    public class GetServiceByIdQueryHandler(IRepository<Service> repository) : IRequestHandler<GetServiceByIdQuery, GetServiceByIdQueryResult>
    {
        public async Task<GetServiceByIdQueryResult> Handle(GetServiceByIdQuery request, CancellationToken cancellationToken)
        {
            var value = await repository.GetByIdAsync(request.Id);
            return new GetServiceByIdQueryResult
            {
                Description = value.Description,
                IconUrl = value.IconUrl,
                Id = value.Id,
                Title = value.Title,
            };
        }
    }
}

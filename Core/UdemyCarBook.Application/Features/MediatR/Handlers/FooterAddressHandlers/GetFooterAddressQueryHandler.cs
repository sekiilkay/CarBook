using MediatR;
using UdemyCarBook.Application.Features.MediatR.Queries.FooterAddressQueries;
using UdemyCarBook.Application.Features.MediatR.Results.FooterAddressResults;
using UdemyCarBook.Application.Interfaces;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Features.MediatR.Handlers.FooterAddressHandlers
{
    public class GetFooterAddressQueryHandler(IRepository<FooterAddress> repository) : IRequestHandler<GetFooterAddressQuery, List<GetFooterAddressQueryResult>>
    {
        public async Task<List<GetFooterAddressQueryResult>> Handle(GetFooterAddressQuery request, CancellationToken cancellationToken)
        {
            var values = await repository.GetAllAsync();
            return values.Select(x => new GetFooterAddressQueryResult
            {
                Address = x.Address,
                Description = x.Description,
                Email = x.Email,
                Id = x.Id,
                Phone = x.Phone,
            }).ToList();
        }
    }
}

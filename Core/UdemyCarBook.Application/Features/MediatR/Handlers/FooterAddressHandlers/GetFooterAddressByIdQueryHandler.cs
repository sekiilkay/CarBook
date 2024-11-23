using MediatR;
using UdemyCarBook.Application.Features.MediatR.Queries.FooterAddressQueries;
using UdemyCarBook.Application.Features.MediatR.Results.FooterAddressResults;
using UdemyCarBook.Application.Interfaces;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Features.MediatR.Handlers.FooterAddressHandlers
{
    public class GetFooterAddressByIdQueryHandler(IRepository<FooterAddress> repository) : IRequestHandler<GetFooterAddressByIdQuery, GetFooterAddressByIdQueryResult>
    {
        public async Task<GetFooterAddressByIdQueryResult> Handle(GetFooterAddressByIdQuery request, CancellationToken cancellationToken)
        {
            var value = await repository.GetByIdAsync(request.Id);
            return new GetFooterAddressByIdQueryResult
            {
                Id = value.Id,
                Address = value.Address,
                Description = value.Description,
                Email = value.Email,
                Phone = value.Phone
            };
        }
    }
}

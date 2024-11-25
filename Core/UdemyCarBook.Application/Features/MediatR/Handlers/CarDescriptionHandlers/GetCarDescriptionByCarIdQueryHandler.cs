using MediatR;
using UdemyCarBook.Application.Features.MediatR.Queries.CarDescriptionQueries;
using UdemyCarBook.Application.Features.MediatR.Results.CarDescriptionResults;
using UdemyCarBook.Application.Interfaces.CarDescriptionInterfaces;

namespace UdemyCarBook.Application.Features.MediatR.Handlers.CarDescriptionHandlers
{
    public class GetCarDescriptionByCarIdQueryHandler(ICarDescriptionRepository carDescriptionRepository) : IRequestHandler<GetCarDescriptionByCarIdQuery, GetCarDescriptionQueryResult>
    {
        public async Task<GetCarDescriptionQueryResult> Handle(GetCarDescriptionByCarIdQuery request, CancellationToken cancellationToken)
        {
            var value = await carDescriptionRepository.GetCarDescriptionAsync(request.Id);
            return new GetCarDescriptionQueryResult
            {
                CarDescriptionId = value.Id,
                CarId = value.CarId,
                Details = value.Details,
            };
        }
    }
}

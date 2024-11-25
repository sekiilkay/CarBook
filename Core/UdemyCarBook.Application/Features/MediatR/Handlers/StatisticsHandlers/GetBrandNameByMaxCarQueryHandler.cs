using MediatR;
using UdemyCarBook.Application.Features.MediatR.Queries.StatisticsQueries;
using UdemyCarBook.Application.Features.MediatR.Results.StatisticsResults;
using UdemyCarBook.Application.Interfaces.StatisticsInterfaces;

namespace UdemyCarBook.Application.Features.MediatR.Handlers.StatisticsHandlers
{
    public class GetBrandNameByMaxCarQueryHandler(IStatisticsRepository statisticsRepository) : IRequestHandler<GetBrandNameByMaxCarQuery, GetBrandNameByMaxCarQueryResult>
    {
        public async Task<GetBrandNameByMaxCarQueryResult> Handle(GetBrandNameByMaxCarQuery request, CancellationToken cancellationToken)
        {
            var value = await statisticsRepository.GetBrandNameByMaxCarAsync();
            return new GetBrandNameByMaxCarQueryResult
            {
                BrandNameByMaxCar = value
            };
        }
    }
}

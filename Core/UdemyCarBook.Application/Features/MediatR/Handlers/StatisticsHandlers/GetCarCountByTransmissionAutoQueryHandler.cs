using MediatR;
using UdemyCarBook.Application.Features.MediatR.Results.StatisticsResults;
using UdemyCarBook.Application.Features.MediatR.Queries.StatisticsQueries;
using UdemyCarBook.Application.Interfaces.StatisticsInterfaces;

namespace UdemyCarBook.Application.Features.MediatR.Handlers.StatisticsHandlers
{
    internal class GetCarCountByTransmissionAutoQueryHandler(IStatisticsRepository statisticsRepository) : IRequestHandler<GerCarCountByTransmissionAutoQuery, GetCarCountByTranmissionAutoQueryResult>
    {
        public async Task<GetCarCountByTranmissionAutoQueryResult> Handle(GerCarCountByTransmissionAutoQuery request, CancellationToken cancellationToken)
        {
            var value = await statisticsRepository.GetCarCountByTranmissionIsAutoAsync();
            return new GetCarCountByTranmissionAutoQueryResult
            {
                CarCountByTranmissionIsAuto = value
            };
        }
    }
}

using MediatR;
using UdemyCarBook.Application.Features.MediatR.Results.StatisticsResults;

namespace UdemyCarBook.Application.Features.MediatR.Queries.StatisticsQueries
{
    public class GetCarCountByKmSmallerThen1000Query : IRequest<GetCarCountByKmSmallerThen1000QueryResult>
    {
    }
}

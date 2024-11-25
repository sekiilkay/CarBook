using MediatR;
using UdemyCarBook.Application.Features.MediatR.Results.StatisticsResults;

namespace UdemyCarBook.Application.Features.MediatR.Queries.StatisticsQueries
{
    public class GetBrandNameByMaxCarQuery : IRequest<GetBrandNameByMaxCarQueryResult>
    {
    }
}

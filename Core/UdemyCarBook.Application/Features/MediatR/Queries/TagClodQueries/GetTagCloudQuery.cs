using MediatR;
using UdemyCarBook.Application.Features.MediatR.Results.TagCloudResults;

namespace UdemyCarBook.Application.Features.MediatR.Queries.TagClodQueries
{
    public class GetTagCloudQuery : IRequest<List<GetTagCloudQueryResult>>
    {
    }
}

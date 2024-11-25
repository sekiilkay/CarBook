using MediatR;
using UdemyCarBook.Application.Features.MediatR.Results.TagCloudResults;

namespace UdemyCarBook.Application.Features.MediatR.Queries.TagClodQueries
{
    public class GetTagCloudByIdQuery : IRequest<GetTagCloudByIdQueryResult>
    {
        public int Id { get; set; }

        public GetTagCloudByIdQuery(int id)
        {
            Id = id;
        }
    }
}

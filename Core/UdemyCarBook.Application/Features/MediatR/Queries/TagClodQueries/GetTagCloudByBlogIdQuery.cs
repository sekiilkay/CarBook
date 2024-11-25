using MediatR;
using UdemyCarBook.Application.Features.MediatR.Results.TagCloudResults;

namespace UdemyCarBook.Application.Features.MediatR.Queries.TagClodQueries
{
    public class GetTagCloudByBlogIdQuery : IRequest<List<GetTagCloudByBlogIdQueryResult>>
    {
        public int Id { get; set; }

        public GetTagCloudByBlogIdQuery(int id)
        {
            Id = id;
        }
    }
}

using MediatR;
using UdemyCarBook.Application.Features.MediatR.Results.ServiceResults;

namespace UdemyCarBook.Application.Features.MediatR.Queries.ServiceQueries
{
    public class GetServiceQuery : IRequest<List<GetServiceQueryResult>>
    {
    }
}

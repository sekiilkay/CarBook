using MediatR;
using UdemyCarBook.Application.Features.MediatR.Results.AboutResults;

namespace UdemyCarBook.Application.Features.MediatR.Queries.AboutQueries
{
    public class GetAboutQuery : IRequest<List<GetAboutQueryResult>>
    {
    }
}

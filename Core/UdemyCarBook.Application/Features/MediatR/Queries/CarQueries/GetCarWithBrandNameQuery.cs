using MediatR;
using UdemyCarBook.Application.Features.MediatR.Results.CarResults;

namespace UdemyCarBook.Application.Features.MediatR.Queries.CarQueries
{
    public class GetCarWithBrandNameQuery : IRequest<List<GetCarWithBrandNameQueryResult>>
    {
    }
}

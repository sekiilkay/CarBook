using MediatR;
using UdemyCarBook.Application.Features.MediatR.Results.CarDescriptionResults;

namespace UdemyCarBook.Application.Features.MediatR.Queries.CarDescriptionQueries
{
    public class GetCarDescriptionByCarIdQuery : IRequest<GetCarDescriptionQueryResult>
    {
        public int Id { get; set; }

        public GetCarDescriptionByCarIdQuery(int id)
        {
            Id = id;
        }
    }
}

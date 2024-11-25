namespace UdemyCarBook.Application.Features.MediatR.Results.CarDescriptionResults
{
    public class GetCarDescriptionQueryResult
    {
        public int CarDescriptionId { get; set; }
        public int CarId { get; set; }
        public string Details { get; set; }
    }
}

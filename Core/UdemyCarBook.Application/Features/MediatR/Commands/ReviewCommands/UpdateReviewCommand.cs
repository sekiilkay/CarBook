using MediatR;

namespace UdemyCarBook.Application.Features.MediatR.Commands.ReviewCommands
{
    public class UpdateReviewCommand : IRequest
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public string CustomerImage { get; set; }
        public string Comment { get; set; }
        public int RaytingValue { get; set; }
        public DateTime ReviewDate { get; set; }
        public int CarId { get; set; }
    }
}

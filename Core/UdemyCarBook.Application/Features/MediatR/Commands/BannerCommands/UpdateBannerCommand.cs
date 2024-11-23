using MediatR;

namespace UdemyCarBook.Application.Features.MediatR.Commands.BannerCommands
{
    public class UpdateBannerCommand : IRequest
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string VideoDescription { get; set; }
        public string VideoUrl { get; set; }
    }
}

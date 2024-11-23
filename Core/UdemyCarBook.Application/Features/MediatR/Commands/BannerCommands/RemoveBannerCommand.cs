using MediatR;

namespace UdemyCarBook.Application.Features.MediatR.Commands.BannerCommands
{
    public class RemoveBannerCommand : IRequest
    {
        public int Id { get; set; }
        public RemoveBannerCommand(int id)
        {
            Id = id;
        }
    }
}

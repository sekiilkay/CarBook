using MediatR;

namespace UdemyCarBook.Application.Features.MediatR.Commands.CarFeatureCommands
{
    public class UpdateCarFeatureAvailableChangeToTrueCommand : IRequest
    {
        public int Id { get; set; }

        public UpdateCarFeatureAvailableChangeToTrueCommand(int id)
        {
            Id = id;
        }
    }
}

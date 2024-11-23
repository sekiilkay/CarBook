using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UdemyCarBook.Application.Features.MediatR.Commands.LocationCommands;
using UdemyCarBook.Application.Features.MediatR.Queries.LocationQueries;

namespace UdemyCarBook.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LocationsController(IMediator mediator) : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> LocationList()
        {
            var values = await mediator.Send(new GetLocationQuery());
            return Ok(values);
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetLocation(int id)
        {
            var value = await mediator.Send(new GetLocationByIdQuery(id));
            return Ok(value);
        }

        [HttpPost]
        public async Task<IActionResult> CreateLocation(CreateLocationCommand command)
        {
            await mediator.Send(command);
            return Ok("Konum Bilgisi Eklendi");
        }

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> RemoveLocation(int id)
        {
            await mediator.Send(new RemoveLocationCommand(id));
            return Ok("Konum Bilgisi Silindi");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateLocation(UpdateLocationCommand command)
        {
            await mediator.Send(command);
            return Ok("Konum Bilgisi Güncellendi");
        }
    }
}

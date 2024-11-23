using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UdemyCarBook.Application.Features.MediatR.Commands.ServiceCommands;
using UdemyCarBook.Application.Features.MediatR.Queries.ServiceQueries;

namespace UdemyCarBook.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServicesController(IMediator mediator) : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> ServiceList()
        {
            var values = await mediator.Send(new GetServiceQuery());
            return Ok(values);
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetService(int id)
        {
            var value = await mediator.Send(new GetServiceByIdQuery(id));
            return Ok(value);
        }

        [HttpPost]
        public async Task<IActionResult> CreateService(CreateServiceCommand command)
        {
            await mediator.Send(command);
            return Ok("Hizmet Bilgisi Eklendi");
        }

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> RemoveService(int id)
        {
            await mediator.Send(new RemoveServiceCommand(id));
            return Ok("Hizmet Bilgisi Silindi");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateService(UpdateServiceCommand command)
        {
            await mediator.Send(command);
            return Ok("Hizmet Bilgisi Güncellendi");
        }
    }
}

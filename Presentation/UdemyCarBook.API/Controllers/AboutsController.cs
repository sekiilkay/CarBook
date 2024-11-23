using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UdemyCarBook.Application.Features.MediatR.Commands.AboutCommands;
using UdemyCarBook.Application.Features.MediatR.Queries.AboutQueries;

namespace UdemyCarBook.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AboutsController(IMediator mediator) : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> AboutList()
        {
            var values = await mediator.Send(new GetAboutQuery());
            return Ok(values);
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetAbout(int id)
        {
            var value = await mediator.Send(new GetAboutByIdQuery(id));
            return Ok(value);
        }

        [HttpPost]
        public async Task<IActionResult> CreateAbout(CreateAboutCommand command)
        {
            await mediator.Send(command);
            return Ok("Hakkımda Bilgisi Eklendi");
        }

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> RemoveAbout(int id)
        {
            await mediator.Send(new RemoveAboutCommand(id));
            return Ok("Hakkımda Bilgisi Silindi");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateAbout(UpdateAboutCommand command)
        {
            await mediator.Send(command);
            return Ok("Hakkımda Bilgisi Güncellendi");
        }
    }
}

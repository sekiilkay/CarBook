using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UdemyCarBook.Application.Features.MediatR.Commands.SocialMediaCommands;
using UdemyCarBook.Application.Features.MediatR.Queries.SocialMediaQueries;

namespace UdemyCarBook.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SocialMediasController(IMediator mediator) : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> SocialMediaList()
        {
            var values = await mediator.Send(new GetSocialMediaQuery());
            return Ok(values);
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetSocialMedia(int id)
        {
            var value = await mediator.Send(new GetSocialMediaByIdQuery(id));
            return Ok(value);
        }

        [HttpPost]
        public async Task<IActionResult> CreateSocialMedia(CreateSocialMediaCommand command)
        {
            await mediator.Send(command);
            return Ok("Sosyal Medya Bilgisi Eklendi");
        }

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> RemoveSocialMedia(int id)
        {
            await mediator.Send(new RemoveSocialMediaCommand(id));
            return Ok("Sosyal Medya Bilgisi Silindi");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateSocialMedia(UpdateSocialMediaCommand command)
        {
            await mediator.Send(command);
            return Ok("Sosyal Medya Bilgisi Güncellendi");
        }
    }
}

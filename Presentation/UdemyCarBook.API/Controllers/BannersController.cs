using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UdemyCarBook.Application.Features.MediatR.Commands.BannerCommands;
using UdemyCarBook.Application.Features.MediatR.Queries.BannerQueries;

namespace UdemyCarBook.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BannersController(IMediator mediator) : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> BannerList()
        {
            var values = await mediator.Send(new GetBannerQuery());
            return Ok(values);
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetBanner(int id)
        {
            var value = await mediator.Send(new GetBannerByIdQuery(id));
            return Ok(value);
        }

        [HttpPost]
        public async Task<IActionResult> CreateBanner(CreateBannerCommand command)
        {
            await mediator.Send(command);
            return Ok("Banner Bilgisi Eklendi");
        }

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> RemoveBanner(int id)
        {
            await mediator.Send(new RemoveBannerCommand(id));
            return Ok("Banner Bilgisi Silindi");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateBanner(UpdateBannerCommand command)
        {
            await mediator.Send(command);
            return Ok("Banner Bilgisi Güncellendi");
        }
    }
}

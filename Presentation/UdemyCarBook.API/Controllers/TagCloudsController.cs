using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UdemyCarBook.Application.Features.MediatR.Commands.TagCloudCommands;
using UdemyCarBook.Application.Features.MediatR.Queries.TagClodQueries;

namespace UdemyCarBook.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TagCloudsController(IMediator mediator) : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> TagCloudList()
        {
            var values = await mediator.Send(new GetTagCloudQuery());
            return Ok(values);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetTagCloud(int id)
        {
            var value = await mediator.Send(new GetTagCloudByIdQuery(id));
            return Ok(value);
        }

        [HttpPost]
        public async Task<IActionResult> CreateTagCloud(CreateTagCloudCommand command)
        {
            await mediator.Send(command);
            return Ok("Etiket Bulutu başarıyla eklendi");
        }

        [HttpDelete]
        public async Task<IActionResult> RemoveTagCloud(int id)
        {
            await mediator.Send(new RemoveTagCloudCommand(id));
            return Ok("Etiket Bulutu başarıyla silindi");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateTagCloud(UpdateTagCloudCommand command)
        {
            await mediator.Send(command);
            return Ok("Etiket Bulutu başarıyla güncellendi");
        }

        [HttpGet("GetTagClodByBlogId")]
        public async Task<IActionResult> GetTagClodByBlogId(int id)
        {
            var values = await mediator.Send(new GetTagCloudByBlogIdQuery(id));
            return Ok(values);
        }
    }
}

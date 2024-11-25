using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UdemyCarBook.Application.Features.MediatR.Commands.AuthorCommands;
using UdemyCarBook.Application.Features.MediatR.Queries.AuthorQueries;

namespace UdemyCarBook.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorsController(IMediator mediator) : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> AuthorList()
        {
            var values = await mediator.Send(new GetAuthorQuery());
            return Ok(values);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetAuthor(int id)
        {
            var value = await mediator.Send(new GetAuthorByIdQuery(id));
            return Ok(value);
        }

        [HttpPost]
        public async Task<IActionResult> CreateAuthor(CreateAuthorCommand command)
        {
            await mediator.Send(command);
            return Ok("Yazar başarıyla eklendi");
        }

        [HttpDelete("")]
        public async Task<IActionResult> RemoveAuthor(int id)
        {
            await mediator.Send(new RemoveAuthorCommand(id));
            return Ok("Yazar başarıyla silindi");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateAuthor(UpdateAuthorCommand command)
        {
            await mediator.Send(command);
            return Ok("Yazar başarıyla güncellendi");
        }
    }
}

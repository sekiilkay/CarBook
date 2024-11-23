using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UdemyCarBook.Application.Features.MediatR.Commands.CategoryCommands;
using UdemyCarBook.Application.Features.MediatR.Queries.CategoryQueries;

namespace UdemyCarBook.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController(IMediator mediator) : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> CategoryList()
        {
            var values = await mediator.Send(new GetCategoryQuery());
            return Ok(values);
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetCategory(int id)
        {
            var value = await mediator.Send(new GetCategoryByIdQuery(id));
            return Ok(value);
        }

        [HttpPost]
        public async Task<IActionResult> CreateCategory(CreateCategoryCommand command)
        {
            await mediator.Send(command);
            return Ok("Kategori Bilgisi Eklendi");
        }

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> RemoveCategory(int id)
        {
            await mediator.Send(new RemoveCategoryCommand(id));
            return Ok("Kategori Bilgisi Silindi");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateCategory(UpdateCategoryCommand command)
        {
            await mediator.Send(command);
            return Ok("Kategori Bilgisi Güncellendi");
        }
    }
}

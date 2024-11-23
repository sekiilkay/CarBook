using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UdemyCarBook.Application.Features.MediatR.Commands.BrandCommands;
using UdemyCarBook.Application.Features.MediatR.Queries.BrandQueries;

namespace UdemyCarBook.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandsController(IMediator mediator) : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> BrandList()
        {
            var values = await mediator.Send(new GetBrandQuery());
            return Ok(values);
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetBrand(int id)
        {
            var value = await mediator.Send(new GetBrandByIdQuery(id));
            return Ok(value);
        }

        [HttpPost]
        public async Task<IActionResult> CreateBrand(CreateBrandCommand command)
        {
            await mediator.Send(command);
            return Ok("Marka Bilgisi Eklendi");
        }

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> RemoveBrand(int id)
        {
            await mediator.Send(new RemoveBrandCommand(id));
            return Ok("Marka Bilgisi Silindi");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateBrand(UpdateBrandCommand command)
        {
            await mediator.Send(command);
            return Ok("Marka Bilgisi Güncellendi");
        }
    }
}

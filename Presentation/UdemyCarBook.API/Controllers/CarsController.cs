using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UdemyCarBook.Application.Features.MediatR.Commands.CarCommands;
using UdemyCarBook.Application.Features.MediatR.Queries.CarQueries;

namespace UdemyCarBook.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController(IMediator mediator) : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> CarList()
        {
            var values = await mediator.Send(new GetCarQuery());
            return Ok(values);
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetCar(int id)
        {
            var value = await mediator.Send(new GetCarByIdQuery(id));
            return Ok(value);
        }

        [HttpGet("GetCarWithBrand")]
        public async Task<IActionResult> GetCarWithBrand()
        {
            var values = await mediator.Send(new GetCarWithBrandNameQuery());
            return Ok(values);
        }

        [HttpGet("GetLast5CarsWithBrand")]
        public async Task<IActionResult> GetLast5CarsWithBrand()
        {
            var values = await mediator.Send(new GetLast5CarsWithBrandQuery());
            return Ok(values);
        }

        [HttpPost]
        public async Task<IActionResult> CreateCar(CreateCarCommand command)
        {
            await mediator.Send(command);
            return Ok("Araç Bilgisi Eklendi");
        }

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> RemoveCar(int id)
        {
            await mediator.Send(new RemoveCarCommand(id));
            return Ok("Araç Bilgisi Silindi");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateCar(UpdateCarCommand command)
        {
            await mediator.Send(command);
            return Ok("Araç Bilgisi Güncellendi");
        }
    }
}

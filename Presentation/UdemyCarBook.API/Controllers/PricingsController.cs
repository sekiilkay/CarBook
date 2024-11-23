using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UdemyCarBook.Application.Features.MediatR.Commands.PricingCommands;
using UdemyCarBook.Application.Features.MediatR.Queries.PricingQueries;

namespace UdemyCarBook.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PricingsController(IMediator mediator) : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> PricingList()
        {
            var values = await mediator.Send(new GetPricingQuery());
            return Ok(values);
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetPricing(int id)
        {
            var value = await mediator.Send(new GetPricingByIdQuery(id));
            return Ok(value);
        }

        [HttpPost]
        public async Task<IActionResult> CreatePricing(CreatePricingCommand command)
        {
            await mediator.Send(command);
            return Ok("Fiyat Bilgisi Eklendi");
        }

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> RemovePricing(int id)
        {
            await mediator.Send(new RemovePricingCommand(id));
            return Ok("Fiyat Bilgisi Silindi");
        }

        [HttpPut]
        public async Task<IActionResult> UpdatePricing(UpdatePricingCommand command)
        {
            await mediator.Send(command);
            return Ok("Fiyat Bilgisi Güncellendi");
        }
    }
}

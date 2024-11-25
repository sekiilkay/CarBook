using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UdemyCarBook.Application.Features.MediatR.Queries.CarPricingQueries;

namespace UdemyCarBook.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarPricingsController(IMediator mediator) : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetCarPricingWithCarList()
        {
            var values = await mediator.Send(new GetCarPricingWithCarQuery());
            return Ok(values);
        }

        [HttpGet("GetCarPricingWithTimePeriodList")]
        public async Task<IActionResult> GetCarPricingWithTimePeriodList()
        {
            var values = await mediator.Send(new GetCarPricingWithTimePeriodQuery());
            return Ok(values);
        }
    }
}
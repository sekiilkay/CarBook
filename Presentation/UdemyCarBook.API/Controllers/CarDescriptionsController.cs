using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UdemyCarBook.Application.Features.MediatR.Queries.CarDescriptionQueries;

namespace UdemyCarBook.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarDescriptionsController(IMediator mediator) : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> CarDescriptionByCarId(int id)
        {
            var value = await mediator.Send(new GetCarDescriptionByCarIdQuery(id));
            return Ok(value);
        }
    }
}

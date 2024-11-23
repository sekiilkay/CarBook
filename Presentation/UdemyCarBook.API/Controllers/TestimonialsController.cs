using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UdemyCarBook.Application.Features.MediatR.Commands.TestimonialCommands;
using UdemyCarBook.Application.Features.MediatR.Queries.TestimonialQueries;

namespace UdemyCarBook.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestimonialsController(IMediator mediator) : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> TestimonialList()
        {
            var values = await mediator.Send(new GetTestimonialQuery());
            return Ok(values);
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetTestimonial(int id)
        {
            var value = await mediator.Send(new GetTestimonialByIdQuery(id));
            return Ok(value);
        }

        [HttpPost]
        public async Task<IActionResult> CreateTestimonial(CreateTestimonialCommand command)
        {
            await mediator.Send(command);
            return Ok("Referans Bilgisi Eklendi");
        }

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> RemoveTestimonial(int id)
        {
            await mediator.Send(new RemoveTestimonialCommand(id));
            return Ok("Referans Bilgisi Silindi");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateTestimonial(UpdateTestimonialCommand command)
        {
            await mediator.Send(command);
            return Ok("Referans Bilgisi Güncellendi");
        }
    }
}

using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UdemyCarBook.Application.Features.MediatR.Commands.ReviewCommands;
using UdemyCarBook.Application.Features.MediatR.Queries.ReviewQueries;
using UdemyCarBook.Application.ReviewValidators;

namespace UdemyCarBook.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReviewsController(IMediator mediator) : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> ReviewListByCarId(int id)
        {
            var values = await mediator.Send(new GetReviewByCarIdQuery(id));
            return Ok(values);
        }

        [HttpPost]
        public async Task<IActionResult> CreateReview(CreateReviewCommand command)
        {
            CreateReviewValidator validator = new CreateReviewValidator();
            var validationResult = validator.Validate(command);

            if (!validationResult.IsValid)
            {
                return BadRequest(validationResult.Errors);
            }
            await mediator.Send(command);
            return Ok("Ekleme işlemi gerçekleşti");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateReview(UpdateReviewCommand command)
        {
            await mediator.Send(command);
            return Ok("Güncelleme işlemi gerçekleşti");
        }
    }
}

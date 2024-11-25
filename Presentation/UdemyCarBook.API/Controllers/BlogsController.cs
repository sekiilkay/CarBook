using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UdemyCarBook.Application.Features.MediatR.Commands.BlogCommands;
using UdemyCarBook.Application.Features.MediatR.Queries.BlogQueries;

namespace UdemyCarBook.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogsController(IMediator mediator) : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> BlogList()
        {
            var values = await mediator.Send(new GetBlogQuery());
            return Ok(values);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetBlog(int id)
        {
            var value = await mediator.Send(new GetBlogByIdQuery(id));
            return Ok(value);
        }

        [HttpPost]
        public async Task<IActionResult> CreateBlog(CreateBlogCommand command)
        {
            await mediator.Send(command);
            return Ok("Blog başarıyla eklendi");
        }

        [HttpDelete]
        public async Task<IActionResult> RemoveBlog(int id)
        {
            await mediator.Send(new RemoveBlogCommand(id));
            return Ok("Blog başarıyla silindi");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateBlog(UpdateBlogCommand command)
        {
            await mediator.Send(command);
            return Ok("Blog başarıyla güncellendi");
        }

        [HttpGet("GetLast3BlogsWitAuthorsList")]
        public async Task<IActionResult> GetLast3BlogsWitAuthorsList()
        {
            var values = await mediator.Send(new GetLast3BlogsWithAuthorsQuery());
            return Ok(values);
        }

        [HttpGet("GetAllBlogsWithAuthorList")]
        public async Task<IActionResult> GetAllBlogsWithAuthorList()
        {
            var values = await mediator.Send(new GetAllBlogsWithAuthorQuery());
            return Ok(values);
        }

        [HttpGet("GetBlogByAuthorId")]
        public async Task<IActionResult> GetBlogByAuthorId(int id)
        {
            var values = await mediator.Send(new GetBlogByAuthorIdQuery(id));
            return Ok(values);
        }
    }
}

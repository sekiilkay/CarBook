using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UdemyCarBook.Application.Features.MediatR.Commands.CommentCommands;
using UdemyCarBook.Application.Features.RepositoryPattern;
using UdemyCarBook.Domain.Entities;
using UdemyCarBook.Persistance.Repositories.CommentRepositories;

namespace UdemyCarBook.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommentsController(IGenericRepository<Comment> commentRepository, IMediator mediator) : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> CommentList()
        {
            var values = await commentRepository.GetAllAsync();
            return Ok(values);
        }

        [HttpPost]
        public async Task<IActionResult> CreateComment(Comment comment)
        {
            await commentRepository.CreateAsync(comment);
            return Ok("Yorum başarıyla eklendi");
        }

        [HttpDelete]
        public async Task<IActionResult> RemoveComment(int id)
        {
            var value = await commentRepository.GetByIdAsync(id);
            await commentRepository.RemoveAsync(value);
            return Ok("Yorum başarıyla silindi");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateComment(Comment comment)
        {
            await commentRepository.UpdateAsync(comment);
            return Ok("Yorum başarıyla silindi");
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetComment(int id)
        {
            var value = await commentRepository.GetByIdAsync(id);
            return Ok(value);
        }

        [HttpGet("CommentListByBlog")]
        public async Task<IActionResult> CommentListByBlog(int id)
        {
            var value = await commentRepository.GetCommentsByBlogIdAsync(id);
            return Ok(value);
        }

        [HttpGet("CommentCountByBlog")]
        public async Task<IActionResult> CommentCountByBlog(int id)
        {
            var value = await commentRepository.GetCountCommentByBlogAsync(id);
            return Ok(value);
        }

        [HttpPost("CreateCommentWithMediator")]
        public async Task<IActionResult> CreateCommentWithMediator(CreateCommentCommand command)
        {
            await mediator.Send(command);
            return Ok("Yorum başarıyla eklendi");
        }
    }
}

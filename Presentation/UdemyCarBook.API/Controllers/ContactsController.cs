using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UdemyCarBook.Application.Features.MediatR.Commands.ContactCommands;
using UdemyCarBook.Application.Features.MediatR.Queries.ContactQueries;

namespace UdemyCarBook.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactsController(IMediator mediator) : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> ContactList()
        {
            var values = await mediator.Send(new GetContactQuery());
            return Ok(values);
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetContact(int id)
        {
            var value = await mediator.Send(new GetContactByIdQuery(id));
            return Ok(value);
        }

        [HttpPost]
        public async Task<IActionResult> CreateContact(CreateContactCommand command)
        {
            await mediator.Send(command);
            return Ok("İletişim Bilgisi Eklendi");
        }

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> RemoveContact(int id)
        {
            await mediator.Send(new RemoveContactCommand(id));
            return Ok("İletişim Bilgisi Silindi");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateContact(UpdateContactCommand command)
        {
            await mediator.Send(command);
            return Ok("İletişim Bilgisi Güncellendi");
        }
    }
}

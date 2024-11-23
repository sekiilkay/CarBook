using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UdemyCarBook.Application.Features.MediatR.Commands.FooterAddressCommands;
using UdemyCarBook.Application.Features.MediatR.Queries.FooterAddressQueries;

namespace UdemyCarBook.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FooterAddressesController(IMediator mediator) : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> FooterAddressList()
        {
            var values = await mediator.Send(new GetFooterAddressQuery());
            return Ok(values);
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetFooterAddress(int id)
        {
            var value = await mediator.Send(new GetFooterAddressByIdQuery(id));
            return Ok(value);
        }

        [HttpPost]
        public async Task<IActionResult> CreateFooterAddress(CreateFooterAddressCommand command)
        {
            await mediator.Send(command);
            return Ok("Footer Bilgisi Eklendi");
        }

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> RemoveFooterAddress(int id)
        {
            await mediator.Send(new RemoveFooterAddressCommand(id));
            return Ok("Footer Bilgisi Silindi");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateFooterAddress(UpdateFooterAddressCommand command)
        {
            await mediator.Send(command);
            return Ok("Footer Bilgisi Güncellendi");
        }
    }
}

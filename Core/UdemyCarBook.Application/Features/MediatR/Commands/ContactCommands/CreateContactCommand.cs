﻿using MediatR;

namespace UdemyCarBook.Application.Features.MediatR.Commands.ContactCommands
{
    public class CreateContactCommand : IRequest
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
        public DateTime SendDate { get; set; }
    }
}

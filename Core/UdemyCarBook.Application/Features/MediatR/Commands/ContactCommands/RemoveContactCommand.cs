﻿using MediatR;

namespace UdemyCarBook.Application.Features.MediatR.Commands.ContactCommands
{
    public class RemoveContactCommand : IRequest
    {
        public int Id { get; set; }
        public RemoveContactCommand(int id)
        {
            Id = id;
        }
    }
}

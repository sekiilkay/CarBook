﻿using MediatR;

namespace UdemyCarBook.Application.Features.MediatR.Commands.CarCommands
{
    public class RemoveCarCommand : IRequest
    {
        public int Id { get; set; }
        public RemoveCarCommand(int id)
        {
            Id = id;
        }
    }
}

﻿using MediatR;

namespace UdemyCarBook.Application.Features.MediatR.Commands.LocationCommands
{
    public class RemoveLocationCommand : IRequest
    {
        public int Id { get; set; }
        public RemoveLocationCommand(int id)
        {
            Id = id;
        }
    }
}

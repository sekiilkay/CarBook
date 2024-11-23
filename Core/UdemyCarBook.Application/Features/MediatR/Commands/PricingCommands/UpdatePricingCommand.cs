﻿using MediatR;

namespace UdemyCarBook.Application.Features.MediatR.Commands.PricingCommands
{
    public class UpdatePricingCommand : IRequest
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}

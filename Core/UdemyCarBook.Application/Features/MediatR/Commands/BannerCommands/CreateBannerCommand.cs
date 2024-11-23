﻿using MediatR;

namespace UdemyCarBook.Application.Features.MediatR.Commands.BannerCommands
{
    public class CreateBannerCommand : IRequest
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string VideoDescription { get; set; }
        public string VideoUrl { get; set; }
    }
}

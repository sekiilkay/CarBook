﻿using MediatR;

namespace UdemyCarBook.Application.Features.MediatR.Commands.CommentCommands
{
    public class CreateCommentCommand : IRequest
    {
        public string Name { get; set; }
        public DateTime CreatedDate { get; set; }
        public int BlogId { get; set; }
        public string Description { get; set; }
        public string Email { get; set; }
    }
}

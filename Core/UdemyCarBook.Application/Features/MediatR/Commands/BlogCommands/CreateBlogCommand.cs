﻿using MediatR;
namespace UdemyCarBook.Application.Features.MediatR.Commands.BlogCommands
{
    public class CreateBlogCommand : IRequest
    {
        public string Title { get; set; }
        public int AuthorId { get; set; }
        public string CoverImageUrl { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CategoryId { get; set; }
    }
}

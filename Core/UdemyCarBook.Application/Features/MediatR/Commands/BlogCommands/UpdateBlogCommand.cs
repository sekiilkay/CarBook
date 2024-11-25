﻿using MediatR;

namespace UdemyCarBook.Application.Features.MediatR.Commands.BlogCommands
{
    public class UpdateBlogCommand : IRequest
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int AuthorId { get; set; }
        public string CoverImageUrl { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CategoryId { get; set; }
    }
}

﻿namespace UdemyCarBook.Application.Features.MediatR.Results.AuthorResults
{
    public class GetAuthorByIdQueryResult
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public string Description { get; set; }
    }
}
﻿namespace UdemyCarBook.Application.Features.MediatR.Results.TagCloudResults
{
    public class GetTagCloudByIdQueryResult
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int BlogId { get; set; }
    }
}

﻿namespace UdemyCarBook.Dtos.BlogDtos
{
    public class UpdateBlogDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string AuthorName { get; set; }
        public object CategoryName { get; set; }
        public int AuthorId { get; set; }
        public string CoverImageUrl { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CategoryId { get; set; }
        public string Description { get; set; }
        public string AuthorDescription { get; set; }
        public string AuthorImageUrl { get; set; }
    }
}

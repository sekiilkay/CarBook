﻿namespace UdemyCarBook.Dtos.CommentDtos
{
    public class CreateCommentDto
    {
        public string Name { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Description { get; set; }
        public int BlogId { get; set; }
        public string Email { get; set; }
    }
}

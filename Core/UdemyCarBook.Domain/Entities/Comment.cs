﻿namespace UdemyCarBook.Domain.Entities
{
    public class Comment
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Description { get; set; }
        public string Email { get; set; }
        public int BlogId { get; set; }
        public Blog Blog { get; set; }
    }
}

namespace UdemyCarBook.Dtos.CommentDtos
{
    public class ResultCommentDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Description { get; set; }
        public int BlogId { get; set; }
    }
}

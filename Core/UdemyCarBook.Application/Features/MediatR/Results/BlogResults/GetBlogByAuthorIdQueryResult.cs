namespace UdemyCarBook.Application.Features.MediatR.Results.BlogResults
{
    public class GetBlogByAuthorIdQueryResult
    {
        public int Id { get; set; }
        public string AuthorName { get; set; }
        public string AuthorDescription { get; set; }
        public string AuthorImageUrl { get; set; }
        public int AuthorId { get; set; }
    }
}

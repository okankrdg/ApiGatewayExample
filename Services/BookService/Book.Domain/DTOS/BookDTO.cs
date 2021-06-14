namespace Book.Domain.Models
{
    public class BookDTO
    {
        public string ISBN { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public int PageCount { get; set; }
        public string PublisherName { get; set; }
    }
}

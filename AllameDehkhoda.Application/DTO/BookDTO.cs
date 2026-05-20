namespace AllameDehkhoda.Application.DTO
{
    public class BookDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string AuthorName { get; set; }
        public string ISBN { get; set; }
        public int TotalCount { get; set; }
        public int AvailableCount { get; set; }
        public string PublishYear { get; set; }
        public bool IsDeleted { get; set; }
        public int CategoryId { get; set; }
    }
}

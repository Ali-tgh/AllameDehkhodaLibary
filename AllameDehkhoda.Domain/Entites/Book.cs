namespace AllameDehkhoda.Domain.Entites
{
    public class Book : BaseEntity
    {
        public string Title { get; set; }
        public string AuthorName { get; set; }
        public string ISBN { get; set; }
        public int TotalCount { get; set; }
        public int AvailableCount { get; set; }
        public string PublishYear { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public List<Borrow> Borrows { get; set; }


    }
}
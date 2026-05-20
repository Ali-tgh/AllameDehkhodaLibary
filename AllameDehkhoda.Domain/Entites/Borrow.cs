namespace AllameDehkhoda.Domain.Entites
{
    public class Borrow : BaseEntity
    {
        public DateTime BorrowDate { get; set; }
        public DateTime? ReturnDate { get; set; }
        public bool IsReturned { get; set; }
        public DateTime DueDate { get; set; }
        public int MemberId { get; set; }
        public Member Member { get; set; }
        public int BookId { get; set; }
        public Book Book { get; set; }

    }
}
namespace AllameDehkhoda.Application.DTO
{
    public class BorrowDTO
    {
        public int Id {  get; set; }
        public DateTime BorrowDate { get; set; }
        public DateTime? ReturnDate { get; set; }
        public bool IsReturned { get; set; }
        public DateTime DueDate { get; set; }
        public int MemberId { get; set; }
        public int BookId {  get; set; }

    }
}

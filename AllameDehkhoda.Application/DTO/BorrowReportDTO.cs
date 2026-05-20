namespace AllameDehkhoda.Application.DTO
{
    public class BorrowReportDTO
    {
        public int Id { get; set; }
        public string MemberName { get; set; }
        public string SSN { get; set; }
        public string BookTitle { get; set; }
        public string ISBN { get; set; }
        public DateTime BorrowDate { get; set; }
        public DateTime? ReturnDate { get; set; }
        public DateTime DueDate { get; set; }
        public string Status { get; set; }

    }
}

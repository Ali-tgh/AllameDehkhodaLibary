namespace AllameDehkhoda.Application.DTO
{
    public class MemberReportDTO
    {
        public int Id { get; set; }
        public string SSN { get; set; }
        public string FullName { get; set; }
        public string Phone { get; set; }
        public string Address {  get; set; }
        public DateTime RegisterDate {  get; set; }
        public int TotalBorrowCount {  get; set; }
        public int ActiveBorrowCount { get; set; }
        public string Status {  get; set; }

    }
}

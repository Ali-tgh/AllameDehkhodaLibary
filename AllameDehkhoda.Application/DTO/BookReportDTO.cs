namespace AllameDehkhoda.Application.DTO
{
    public class BookReportDTO
    {
        public string Title { get; set; }
        public string AurtherName { get; set; }
        public string ISBN { get; set; }
        public int TotalBorrow { get; set; }
        public int ReturnCount { get; set; }
        public int ActiveCount { get; set; }
        public int OverDueCount { get; set; }

    }
}

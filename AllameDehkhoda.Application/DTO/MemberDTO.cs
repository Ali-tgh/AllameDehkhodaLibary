namespace AllameDehkhoda.Application.DTO
{
    public class MemberDTO
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string SSN { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public DateTime RegisterDate { get; set; }
        public bool IsDeleted {  get; set; }
    }
}

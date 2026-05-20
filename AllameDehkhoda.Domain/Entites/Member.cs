namespace AllameDehkhoda.Domain.Entites
{
    public class Member : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string SocialSecurityNumber { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public DateTime RegisterDate { get; set; }
        public List<Borrow> Borrows { get; set; }

    }
}
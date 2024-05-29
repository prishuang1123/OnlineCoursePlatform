
namespace Project1.DTO
{
    public class MemberDTO
    {
        public int MemberID { get; set; }

        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
		public DateTime Birthday { get; set; }
		public DateTime RegistrationDate { get; set; }
		public string? ResidenceArea { get; set; }
		public bool IsTrainer { get; set; }
		public bool IsAdministrator { get; set; }
	}
}

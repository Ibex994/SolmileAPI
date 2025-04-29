namespace SolmileAPI.DTO
{
    public class ContactDetailDto
    {
            public int ContactId { get; set; }
            public string phone { get; set; }
            public string Email { get; set; }
            public string Address { get; set; }
            public string EmergencyContact { get; set; }
            public string ContactType { get; set; }
    }

    public class CreateConDetDto
    {
        public string phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string EmergencyContact { get; set; }
        public string ContactType { get; set; }
    }


}

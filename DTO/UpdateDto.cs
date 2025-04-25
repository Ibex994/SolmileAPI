using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace SolmileAPI.DTO
{
    public class UpdateDto
    {
       public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Position { get; set; }

        public string Phone { get; set; }
        public string Email { get; set; }
        public DateTime DateOfBirth { get; set; }

        public DateTime HireDate { get; set; }

        public bool Status { get; set; }

        public string Gender { get; set; }
    }

    public class UpdateCust
    {
        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }
        public string Nationality { get; set; }
        public string Phone { get; set; }
        [EmailAddress]
        public string Email { get; set; }
    }
}

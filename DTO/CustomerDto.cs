using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace SolmileAPI.DTO
{
    public class CustomerDto
    {
        [JsonIgnore] 
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

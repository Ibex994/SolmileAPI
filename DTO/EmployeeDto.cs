using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace SolmileAPI.DTO
{
    public class EmployeeDto
    {
        public string FirstName { get; set; } 
        public string LastName { get; set; }
        public string Position { get; set; } 
        public string Phone { get; set; } 
        public string Email { get; set; }
        [JsonIgnore]
        public string? Username { get; set; }
        [JsonIgnore]
        public string? Password { get; set; } 
        public DateTime DateOfBirth { get; set; }
        public DateTime HireDate { get; set; }
        public bool Status { get; set; }
        public string Gender { get; set; } 

    }
}

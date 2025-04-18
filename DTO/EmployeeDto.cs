using System.ComponentModel.DataAnnotations;

namespace SolmileAPI.DTO
{
    public class EmployeeDto
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        
        public string Position { get; set; } = string.Empty;
        
        public string Phone { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
      
        public DateTime DateOfBirth { get; set; }
   
        public DateTime HireDate { get; set; }
        
        public bool Status { get; set; }
    
        public string Gender { get; set; } = string.Empty;

    }
}

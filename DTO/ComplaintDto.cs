using System.Text.Json.Serialization;

namespace SolmileAPI.DTO
{
    public class ComplaintDto
    {
            public int ComplaintId { get; set; }
            public string Details { get; set; }
            public string? Status { get; set; }
            public int CustomerId { get; set; }
            public int? EmployeeId { get; set; }

        public class CreateCompDto
        {
            public string Details { get; set; }
        }

        public class UpdateCompDto
        {
            public bool status { get; set; }
        }

    }
}

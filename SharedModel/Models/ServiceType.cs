using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SolmileGuesthouseAPI.Data.Models
{
    public class ServiceType
    {
        [Key]
        public int ServiceTypeId { get; set; }

        [Required]
        public string ServiceTypeName { get; set; }
        public ICollection<ServiceRequest> ServiceRequests { get; set; }
    }
}
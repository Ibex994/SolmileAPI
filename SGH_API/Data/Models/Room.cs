using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SolmileGuesthouseAPI.Data.Models
{
    public class Room
    {
        [Key]
        public string RoomId { get; set; }

        [ForeignKey("RoomNumberAssignment")]
        public int RoomNumberAssignmentId { get; set; }
        public RoomNumberAssignment RoomNumberAssignment { get; set; }

        [Required]
        public string Status { get; set; }

        [ForeignKey("RoomType")]
        public int TypeId { get; set; }
        public RoomType RoomType { get; set; }

        // Navigation property
        public ICollection<Reservation> Reservations { get; set; }
    }
}
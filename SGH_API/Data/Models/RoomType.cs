using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SolmileGuesthouseAPI.Data.Models
{
    public class RoomType
    {
        [Key]
        public int TypeId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public string Amenities { get; set; }

        [Required]
        public float PricePerNight { get; set; }

        [Required]
        public string Capacity { get; set; }

        [Required]
        public byte[]? ImageUrl { get; set; }

        // Navigation property
        public ICollection<Room> Rooms { get; set; }
    }
}
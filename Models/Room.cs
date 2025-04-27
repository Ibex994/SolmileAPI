using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solmile.Models
{
    public class Room
    {
        [Key]
        public string RoomID { get; set; }
        public int RoomNumberAssignmentId { get; set; }
        public string Status { get; set; }
        public int RoomType { get; set; }
        public int RoomTypeId { get; set; }

        public virtual Reservation Reservation { get; set; }
        public virtual Branch Branch { get; set; }
        public virtual RoomTypes RoomTypes { get; set; }
    }
        public class RoomTypes
        {
            [Key]
            public int RoomTypeId { get; set; }
            public string TypeName { get; set; }
            public float PricePerNight { get; set; }
    }
    
}

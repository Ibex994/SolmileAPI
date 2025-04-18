using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solmile.DTO
{
    class ReceptionRoomViewDto
    {
            public string RoomID { get; set; }
            public int RoomNumber { get; set; } 
            public string Status { get; set; }
            public string RoomType { get; set; }  // More useful than TypeId for reception
            public int CurrentOccupancy { get; set; }
        }
 }


namespace SolmileAPI.DTO
{
    public class RoomDto
    {
        public string RoomID { get; set; }
        public int RoomNumberAssignmentId { get; set; }
        public string Status { get; set; }
        public int RoomTypeId { get; set; }
        public string BranchName { get; set; }
        public string RoomTypeName { get; set; }
    }
    public class CreateRoomDto
    {
        public string RoomID { get; set; }
        public int RoomNumberAssignmentId { get; set; }
        public int RoomTypeId { get; set; }
        public int BranchId { get; set; }

    }
}

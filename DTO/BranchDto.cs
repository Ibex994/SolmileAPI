namespace SolmileAPI.DTO
{
    public class BranchDto
    {
        public int BranchId { get; set; } 
        public string Name { get; set; }
        public string Location { get; set; }
        public int ContactId { get; set; }
    }
    public class CreateBranchDto
    {
        public string Name { get; set; }
        public string Location { get; set; }
    }

    public class UpdateBranchDto
    {
        public string Name { get; set; }
        public string Location { get; set; }
    }
    public class BranchDetailsDto
    {
        public int BranchId { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public int ContactId { get; set; }
        public List<RoomAssignmentDto> RoomAssignments { get; set; } = new List<RoomAssignmentDto>();
    }
    public class AssignBranchDto
    {
        public int BranchId { get; set; }
    }
}

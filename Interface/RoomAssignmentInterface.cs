using Solmile.Models;

namespace SolmileAPI.Interface
{
    public interface RoomAssignmentInterface
    {
        // Assign room number to a branch
        Task<bool> AssignRoomNumberAsync(int branchId, int roomNumber);

        // Update room assignment with a new room number
        Task<bool> UpdateRoomAssignmentAsync(int assignmentId, int newRoomNumber);

        // Delete room assignment by RoomNumberAssignmentId
        Task<bool> DeleteRoomAssignmentAsync(int assignmentId);

        // Get all room assignments for a specific branch
        Task<List<RoomAssignment>> GetRoomAssignmentsByBranchAsync(int branchId);
        public Task<bool> CheckBranchExistsAsync(int branchId);
        public Task<bool> CheckRoomExistsAsync(string roomId);
        public Task<bool> RoomAssignmentExistsAsync(int assignmentId);
    }
}

using Solmile.Models;

namespace SolmileAPI.Interface
{
    public interface RoomInterface
    {
        Task<bool> UpdateRoomStatusAsync(string roomId, string status);
        Task<bool> IsAvailableAsync(string roomId, DateTime checkInDate, DateTime checkOutDate);
        Task<bool> AssignGuestAsync(string roomId, int customerId);
        Task<Room> GetRoomDetailsAsync(string roomId);
        Task<bool> AddRoomAsync(Room room);
        Task<bool> DeleteRoomAsync(string roomId);
        Task<bool> UpdateRoomAsync(string roomId, Room updatedRoom);
        Task<bool> CheckBranchExistsAsync(int branchId);
        Task<bool> CheckRoomExistsAsync(string roomId);
        Task<bool> CheckRoomAssignmentExistsAsync(string roomId);


        Task SaveAsync();
    }

}

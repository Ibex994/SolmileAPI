using Microsoft.EntityFrameworkCore;
using Solmile;
using Solmile.Models;
using SolmileAPI.Interface;

namespace SolmileAPI.Repository
{
    public class RoomRepo : RoomInterface
    {
        private readonly DataContext _context;

        public RoomRepo(DataContext context)
        {
            _context = context;
        }

        public async Task<bool> UpdateRoomStatusAsync(string roomId, string status)
        {
            var room = await _context.Room.FirstOrDefaultAsync(r => r.RoomID == roomId);
            if (room == null) return false;

            room.Status = status;
            await SaveAsync();
            return true;
        }

        public async Task<bool> IsAvailableAsync(string roomId, DateTime checkInDate, DateTime checkOutDate)
        {
            var room = await _context.Room
                .Include(r => r.Reservation)
                .FirstOrDefaultAsync(r => r.RoomID == roomId);

            if (room == null) return false;

            return room.Status.ToLower() == "available";
        }

        public async Task<bool> AssignGuestAsync(string roomId, int customerId)
        {
            var room = await _context.Room.FirstOrDefaultAsync(r => r.RoomID == roomId);
            if (room == null) return false;

            room.Status = "occupied";
            await SaveAsync();
            return true;
        }

        public async Task<Room> GetRoomDetailsAsync(string roomId)
        {
            return await _context.Room
                .Include(r => r.RoomTypes)
                .Include(r => r.Branch)
                .Include(r => r.Reservation)
                .FirstOrDefaultAsync(r => r.RoomID == roomId);
        }

        public async Task<bool> AddRoomAsync(Room room)
        {
            var branchExists = await _context.Branch
                .AnyAsync(b => b.BranchId == room.BranchId);

            if (!branchExists)
            {
                throw new Exception($"Branch with ID {room.BranchId} does not exist.");
            }

            await _context.Room.AddAsync(room);
            await SaveAsync();

            return true;
        }


        public async Task<bool> CheckBranchExistsAsync(int branchId)
        {
            return await _context.Branch.AnyAsync(b => b.BranchId == branchId);
        }
        public async Task<bool> DeleteRoomAsync(string roomId)
        {
            var room = await _context.Room.FirstOrDefaultAsync(r => r.RoomID == roomId);
            if (room == null) return false;

            _context.Room.Remove(room);
            await SaveAsync();
            return true;
        }

        public async Task<bool> UpdateRoomAsync(string roomId, Room updatedRoom)
        {
            var room = await _context.Room.FirstOrDefaultAsync(r => r.RoomID == roomId);
            if (room == null) return false;

            room.RoomNumberAssignmentId = updatedRoom.RoomNumberAssignmentId;
            room.Status = updatedRoom.Status;
            room.RoomTypeId = updatedRoom.RoomTypeId;

            await SaveAsync();
            return true;
        }
        public async Task<bool> CheckRoomExistsAsync(string roomId)
        {
            return await _context.Room.AnyAsync(r => r.RoomID == roomId);
        }
        public async Task<bool> CheckRoomAssignmentExistsAsync(string roomId)
        {
            return await _context.RoomAssignments.AnyAsync(ra => ra.RoomID == roomId);
        }

        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}

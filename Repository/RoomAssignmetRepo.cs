using Solmile.Models;
using Solmile;
using SolmileAPI.Interface;
using Microsoft.EntityFrameworkCore;

namespace SolmileAPI.Repository
{
    public class RoomAssignmetRepo : RoomAssignmentInterface
    {
        private readonly DataContext _context;

        public RoomAssignmetRepo(DataContext context)
        {
            _context = context;
        }

        // 1. Assign room number to a branch
        public async Task<bool> AssignRoomNumberAsync(int branchId, int roomNumber)
        {
            // Check if the RoomAssignment already exists for the branch and room number
            var existingAssignment = await _context.RoomAssignments
                .FirstOrDefaultAsync(ra => ra.BranchId == branchId && ra.RoomID == roomNumber.ToString());

            if (existingAssignment != null)
            {
                // Room is already assigned to this branch
                return false;
            }

            // Create a new RoomAssignment
            var roomAssignment = new RoomAssignment
            {
                BranchId = branchId,
                RoomID = roomNumber.ToString(),
                Status = "Available", // Default status if not provided
                                      // Set RoomTypeId and other properties as required
            };

            // Add to the context and save changes
            _context.RoomAssignments.Add(roomAssignment);
            await _context.SaveChangesAsync();

            return true;
        }

        // 2. Update room assignment with a new room number
        public async Task<bool> UpdateRoomAssignmentAsync(int assignmentId, int newRoomNumber)
        {
            // Find the RoomAssignment by its RoomNumberAssignmentId
            var roomAssignment = await _context.RoomAssignments
                .FirstOrDefaultAsync(ra => ra.RoomNumberAssignmentId == assignmentId);

            if (roomAssignment == null)
            {
                // Assignment does not exist
                return false;
            }

            // Update the RoomNumber (roomID)
            roomAssignment.RoomID = newRoomNumber.ToString();

            // Save changes to the database
            await _context.SaveChangesAsync();

            return true;
        }

        // 3. Delete room assignment by RoomNumberAssignmentId
        public async Task<bool> DeleteRoomAssignmentAsync(int assignmentId)
        {
            var roomAssignment = await _context.RoomAssignments
                                                .FirstOrDefaultAsync(ra => ra.RoomNumberAssignmentId == assignmentId);

            if (roomAssignment == null)
            {
                // If the room assignment doesn't exist, return false
                return false;
            }

            _context.RoomAssignments.Remove(roomAssignment);
            await _context.SaveChangesAsync();

            return true;
        }

        // 4. Get all room assignments for a specific branch
        public async Task<List<RoomAssignment>> GetRoomAssignmentsByBranchAsync(int branchId)
        {
            // Fetch room assignments for the given branch
            var roomAssignments = await _context.RoomAssignments
                .Where(ra => ra.BranchId == branchId)
                .Include(ra => ra.Room)      // Include Room details
                .Include(ra => ra.Branch)    // Include Branch details
                .Include(ra => ra.RoomType)  // Include RoomType details
                .ToListAsync();

            return roomAssignments;
        }
        public async Task<bool> CheckBranchExistsAsync(int branchId)
        {
            // Check if the branch exists in the Branches table
            return await _context.Branch.AnyAsync(b => b.BranchId == branchId);
        }
        public async Task<bool> CheckRoomExistsAsync(string roomId)
        {
            // Check if the room exists in the Rooms table
            return await _context.Room.AnyAsync(r => r.RoomID == roomId);
        }

        public async Task<bool> RoomAssignmentExistsAsync(int assignmentId)
        {
            // Check if any RoomAssignment exists with the given RoomNumberAssignmentId
            return await _context.RoomAssignments
                                 .AnyAsync(ra => ra.RoomNumberAssignmentId == assignmentId);
        }


    }
}

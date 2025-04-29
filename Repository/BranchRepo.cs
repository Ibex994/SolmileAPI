using Solmile.Models;
using SolmileAPI.Interface;
  using Microsoft.EntityFrameworkCore;
using Solmile;

    namespace SolmileAPI.Repository
    {
        public class BranchRepo : BranchInterface
        {
            private readonly DataContext _context;

            public BranchRepo(DataContext context)
            {
                _context = context;
            }

        public async Task<bool> CheckBranchExistsAsync(int branchId)
        {
            var branch = await _context.Branch.FindAsync(branchId);
            return branch != null;
        }
        public async Task<bool> AddBranchAsync(string location, string name)
            {
                var branch = new Branch
                {
                    Location = location,
                    Name = name
                };

                _context.Branch.Add(branch);
                return await _context.SaveChangesAsync() > 0;
            }

            public async Task<bool> UpdateBranchAsync(int branchId, Branch updatedBranch)
            {
                var branch = await _context.Branch.FindAsync(branchId);
                if (branch == null)
                    return false;

                branch.Name = updatedBranch.Name;
                branch.Location = updatedBranch.Location;

                return await _context.SaveChangesAsync() > 0;
            }

            public async Task<bool> DeleteBranchAsync(int branchId)
            {
                var branch = await _context.Branch.FindAsync(branchId);
                if (branch == null)
                    return false;

                _context.Branch.Remove(branch);
                return await _context.SaveChangesAsync() > 0;
            }

            public async Task<Branch?> ViewBranchDetailsAsync(int branchId)
            {
                return await _context.Branch
                    .Include(b => b.RoomAssignments)
                    .FirstOrDefaultAsync(b => b.BranchId == branchId);
            }

            public async Task<bool> AssignContactDetailsAsync(int branchId, int contactId)
            {
                var branch = await _context.Branch.FindAsync(branchId);
                if (branch == null)
                    return false;

                branch.ContactId = contactId;
                return await _context.SaveChangesAsync() > 0;
            }
        }
}


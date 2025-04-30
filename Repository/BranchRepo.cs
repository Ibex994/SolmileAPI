using Solmile.Models;
using SolmileAPI.Interface;
using Microsoft.EntityFrameworkCore;
using Solmile;
using SolmileAPI.Enum;

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

        public async Task<AssignContactResults> AssignContactDetailsAsync(int branchId, int contactId)
        {
            var branch = await _context.Branch.FindAsync(branchId);
            if (branch == null)
                return AssignContactResults.BranchNotFound;

            var contact = await _context.ContactDetails.FindAsync(contactId);
            if (contact == null)
                return AssignContactResults.ContactNotFound;

            if (branch.ContactId != null)
                return AssignContactResults.BranchAlreadyAssigned;

            if (contact.BranchId != null)
                return AssignContactResults.ContactAlreadyAssigned;

            branch.ContactId = contactId;
            contact.BranchId = branchId;

            await _context.SaveChangesAsync();
            return AssignContactResults.Success;
        }

        public async Task<UnassignContactResult> UnassignContactFromBranchAsync(int contactId, int branchId)
        {
            var contact = await _context.ContactDetails.FindAsync(contactId);
            if (contact == null)
            {
                return UnassignContactResult.ContactNotFound;
            }

            if (!contact.BranchId.HasValue)
            {
                return UnassignContactResult.ContactAlreadyUnassigned;
            }

            if (contact.BranchId != branchId)
            {
                return UnassignContactResult.BranchContactMismatch;
            }

            var branch = await _context.Branch.FindAsync(branchId);
            if (branch == null)
            {
                return UnassignContactResult.BranchNotFound;
            }

            branch.ContactId = null;
            _context.Branch.Update(branch);

            contact.BranchId = null;
            _context.ContactDetails.Update(contact);

            await _context.SaveChangesAsync();

            return UnassignContactResult.Success;
        }
    }



    }


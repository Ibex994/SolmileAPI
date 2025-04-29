using Microsoft.EntityFrameworkCore;
using Solmile.Models;

namespace SolmileAPI.Interface
{
    public interface BranchInterface
    {
       public Task<bool> AddBranchAsync(string location, string name);
       public Task<bool> UpdateBranchAsync(int branchId, Branch updatedBranch);
        public Task<bool> DeleteBranchAsync(int branchId);
        public Task<Branch?> ViewBranchDetailsAsync(int branchId);
        public Task<bool> AssignContactDetailsAsync(int branchId, int contactId);
        public Task<bool> CheckBranchExistsAsync(int branchId);
    }
}

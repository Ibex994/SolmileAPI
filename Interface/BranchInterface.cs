using Microsoft.EntityFrameworkCore;
using Solmile.Models;
using SolmileAPI.Enum;

namespace SolmileAPI.Interface
{
    public interface BranchInterface
    {
       public Task<bool> AddBranchAsync(string location, string name);
       public Task<bool> UpdateBranchAsync(int branchId, Branch updatedBranch);
        public Task<bool> DeleteBranchAsync(int branchId);
        public Task<Branch?> ViewBranchDetailsAsync(int branchId);
        Task<AssignContactResults> AssignContactDetailsAsync(int branchId, int contactId);
        public Task<bool> CheckBranchExistsAsync(int branchId);
        Task<UnassignContactResult> UnassignContactFromBranchAsync(int contactId, int branchId);
    }
}

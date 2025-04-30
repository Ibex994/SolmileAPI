using SolmileAPI.Enum;
using SolmileAPI.Models;

namespace SolmileAPI.Interface
{
    public interface ContactDetailInterface
    {
        Task<bool> UpdateContactDetailsAsync(int branchId, ContactDetail updatedDetails);
        Task<ContactDetail?> GetContactDetailsAsync(int contactId);
        bool ValidateContactDetails(ContactDetail details);
        Task<bool> CreateContactDetailsAsync(ContactDetail newDetails);
        Task<bool> DeleteContactDetailsAsync(int contactId);
        Task<AssignBranchResult> AssignBranchToContactAsync(int contactId, int branchId);
    }
}

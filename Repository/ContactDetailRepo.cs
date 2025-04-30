using Microsoft.EntityFrameworkCore;
using Solmile;
using SolmileAPI.Enum;
using SolmileAPI.Interface;
using SolmileAPI.Models;

namespace SolmileAPI.Repository
{
    public class ContactDetailRepo : ContactDetailInterface
    {
        private readonly DataContext _context;

        public ContactDetailRepo(DataContext context)
        {
            _context = context;
        }
        public async Task<ContactDetail?> GetContactDetailsAsync(int contactId)
        {
            var contact = await _context.ContactDetails
                .FirstOrDefaultAsync(cd => cd.ContactId == contactId);
            return contact;
        }

        public async Task<bool> UpdateContactDetailsAsync(int branchId, ContactDetail updatedDetails)
        {
            var existingContact = await _context.ContactDetails
                .FirstOrDefaultAsync(cd => cd.ContactId == updatedDetails.ContactId && cd.BranchId == branchId);

            if (existingContact == null)
            {
                return false;
            }

            existingContact.Phone = updatedDetails.Phone;
            existingContact.Email = updatedDetails.Email;
            existingContact.Address = updatedDetails.Address;
            existingContact.EmergencyContact = updatedDetails.EmergencyContact;
            existingContact.ContactType = updatedDetails.ContactType;

            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> CreateContactDetailsAsync(ContactDetail newDetails)
        {
            _context.ContactDetails.Add(newDetails);

            return await _context.SaveChangesAsync() > 0; 
        }
        public async Task<bool> DeleteContactDetailsAsync(int contactId)
        {
            var contact = await _context.ContactDetails.FirstOrDefaultAsync(cd => cd.ContactId == contactId);
            if (contact == null)
            {
                return false;
            }
            var branches = await _context.Branch
                .Where(b => b.ContactId == contactId)
                .ToListAsync();
            if (branches.Count > 0)
            {
                foreach (var branch in branches)
                {
                    branch.ContactId = null;
                }
                await _context.SaveChangesAsync();
            }
            _context.ContactDetails.Remove(contact);
            var saveChangesResult = await _context.SaveChangesAsync();
            return saveChangesResult > 0;
        }

        public async Task<AssignBranchResult> AssignBranchToContactAsync(int contactId, int branchId)
        {
            var contact = await _context.ContactDetails
                .FirstOrDefaultAsync(cd => cd.ContactId == contactId);
            if (contact == null)
                return AssignBranchResult.ContactNotFound;

            var branch = await _context.Branch
                .FirstOrDefaultAsync(b => b.BranchId == branchId);
            if (branch == null)
                return AssignBranchResult.BranchNotFound;

            if (branch.ContactId != null)
                return AssignBranchResult.BranchAlreadyAssigned;

            contact.BranchId = branchId;
            branch.ContactId = contactId;

            await _context.SaveChangesAsync();
            return AssignBranchResult.Success;
        }


        public bool ValidateContactDetails(ContactDetail details)
        {
            if (string.IsNullOrEmpty(details.Phone))
                return false;

            if (string.IsNullOrEmpty(details.Email) || !details.Email.Contains('@'))
                return false;

            if (string.IsNullOrEmpty(details.Address))
                return false;

            if (string.IsNullOrEmpty(details.EmergencyContact))
                return false;

            if (string.IsNullOrEmpty(details.ContactType))
                return false;

            return true;
        }

    }
}

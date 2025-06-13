using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Generic;
using static SolmileGuesthouseAPI.DTO.NavigatorModel.DTOs;
using Newtonsoft.Json;

namespace SolmileGuestHouseUI.Forms.AdminForms
{
    public partial class ContactDetails : UserControl
    {
        private readonly HttpClient _httpClient;
        private int? selectedContactId = null;
        private const string baseUrl = "https://localhost:7107/api/ContactDetails";

        public ContactDetails()
        {
            InitializeComponent();
            _httpClient = new HttpClient();
            dgvContacts.SelectionChanged += DgvContacts_SelectionChanged;
            btnSave.Click += BtnSave_Click;
            btnUpdate.Click += BtnUpdate_Click;
            btnDelete.Click += BtnDelete_Click;
            btnLoad.Click += btnLoad_Click;
            btnLoad.Click += btnLoad_Click;
            BtnClear.Click += BtnClear_Click;
            LoadContacts();
        }

        private async void LoadContacts()
        {
            try
            {
                var contacts = await _httpClient.GetFromJsonAsync<List<ContactDetailsDto>>(baseUrl);
                dgvContacts.DataSource = contacts;
                dgvContacts.ClearSelection();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unable to load contacts at this time.\nDetails: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void BtnSave_Click(object sender, EventArgs e)
        {
            var newContact = new UInsertionContactDetailsDto
            {
                Phone = txtPhone.Text,
                Email = txtEmail.Text,
                Address = txtAddress.Text,
                EmergencyContact = txtEmergencyContact.Text
            };

            try
            {
                var response = await _httpClient.PostAsJsonAsync(baseUrl, newContact);
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Contact has been successfully added to the system.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearFields();
                    LoadContacts();
                }
                else
                {
                    MessageBox.Show("Failed to add contact. Please check your input and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while adding the contact.\nDetails: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedContactId == null)
            {
                MessageBox.Show("No contact selected. Please select a contact from the list before attempting to update.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var updatedContact = new UInsertionContactDetailsDto
            {
                Phone = txtPhone.Text,
                Email = txtEmail.Text,
                Address = txtAddress.Text,
                EmergencyContact = txtEmergencyContact.Text
            };

            try
            {
                var response = await _httpClient.PutAsJsonAsync($"{baseUrl}/{selectedContactId}", updatedContact);
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Contact details have been updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearFields();
                    LoadContacts();
                }
                else
                {
                    MessageBox.Show("Failed to update the contact. Please verify the information and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while updating the contact.\nDetails: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void BtnDelete_Click(object sender, EventArgs e)
        {
            if (selectedContactId == null)
            {
                MessageBox.Show("No contact selected. Please select a contact from the list to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirm = MessageBox.Show(
                "Are you sure you want to delete the selected contact? This action cannot be undone.",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirm != DialogResult.Yes) return;

            try
            {
                var response = await _httpClient.DeleteAsync($"{baseUrl}/{selectedContactId}");
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Contact has been successfully deleted.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearFields();
                    LoadContacts();
                }
                else
                {
                    MessageBox.Show("Failed to delete the contact. Please try again later.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while deleting the contact.\nDetails: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DgvContacts_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvContacts.SelectedRows.Count > 0)
            {
                var row = dgvContacts.SelectedRows[0];
                if (row.DataBoundItem is ContactDetailsDto contact)
                {
                    selectedContactId = contact.ContactId;
                    txtPhone.Text = contact.Phone;
                    txtEmail.Text = contact.Email;
                    txtAddress.Text = contact.Address;
                    txtEmergencyContact.Text = contact.EmergencyContact;
                }
            }
        }

        private void ClearFields()
        {
            txtPhone.Clear();
            txtEmail.Clear();
            txtAddress.Clear();
            txtEmergencyContact.Clear();
            selectedContactId = null;
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadContacts();
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void dgvContacts_SelectionChanged_1(object sender, EventArgs e)
        {
            if (dgvContacts.CurrentRow == null) return;

            txtPhone.Text = dgvContacts.CurrentRow.Cells["phone"].Value?.ToString();
            txtEmail.Text = dgvContacts.CurrentRow.Cells["email"].Value?.ToString();
            txtAddress.Text = dgvContacts.CurrentRow.Cells["address"].Value?.ToString();
            txtEmergencyContact.Text = dgvContacts.CurrentRow.Cells["emergencyContact"].Value?.ToString();
        }
        private async Task<object> GetContactAsync(int id)
        {
            try
            {
                var response = await _httpClient.GetAsync($"{baseUrl}/findContactDetailsById/{id}");
                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<ContactDetailsDto>(json);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            return null;
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            var searchForm = new SearchByIdForm("Search Contact", GetContactAsync);
            if (searchForm.ShowDialog() == DialogResult.OK)
            {
                var contact = searchForm.SelectedItem as ContactDetailsDto;
                if (contact != null)
                {
                    dgvContacts.DataSource = new List<ContactDetailsDto> { contact };
                }
            }
        }
    }
}

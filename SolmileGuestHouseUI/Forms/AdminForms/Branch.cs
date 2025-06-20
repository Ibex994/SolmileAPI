using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using static SolmileGuesthouseAPI.DTO.NavigatorModel.DTOs;

namespace SolmileGuestHouseUI.Forms.AdminForms
{
    public partial class Branch : UserControl
    {
        private readonly HttpClient _httpClient = new HttpClient();
        private const string BaseUrl = "https://localhost:7107/api/Branches";

        public Branch()
        {
            InitializeComponent();
            _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            LoadBranches();
        }

        private async void LoadBranches()
        {
            try
            {
                var response = await _httpClient.GetAsync(BaseUrl);
                response.EnsureSuccessStatusCode();

                var json = await response.Content.ReadAsStringAsync();
                var branches = JsonConvert.DeserializeObject<List<BranchDto>>(json);
                dgvBranches.DataSource = branches;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"🔌 Failed to load branches.\n\nDetails: {ex.Message}", "Load Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs()) return;

            if (!int.TryParse(txtContactId.Text, out int contactId))
            {
                MessageBox.Show("⚠️ Contact ID must be a valid number.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var newBranch = new UInsertionBranchDto
            {
                Name = txtBranchName.Text.Trim(),
                Location = txtLocation.Text.Trim(),
                ContactId = contactId
            };

            try
            {
                var json = JsonConvert.SerializeObject(newBranch);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                var response = await _httpClient.PostAsync(BaseUrl, content);
                response.EnsureSuccessStatusCode();

                MessageBox.Show("✅ Branch added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadBranches();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"❌ Failed to add branch.\nMake sure the Contact ID exists and is not used already.\n\nDetails: {ex.Message}",
                    "Add Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvBranches.CurrentRow == null)
            {
                MessageBox.Show("⚠️ Please select a branch to update.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidateInputs()) return;

            int id = Convert.ToInt32(dgvBranches.CurrentRow.Cells["branchId"].Value);

            if (!int.TryParse(txtContactId.Text, out int contactId))
            {
                MessageBox.Show("⚠️ Contact ID must be a valid number.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var updateBranch = new UInsertionBranchDto
            {
                Name = txtBranchName.Text.Trim(),
                Location = txtLocation.Text.Trim(),
                ContactId = contactId
            };

            try
            {
                var json = JsonConvert.SerializeObject(updateBranch);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                var response = await _httpClient.PutAsync($"{BaseUrl}/{id}", content);
                response.EnsureSuccessStatusCode();

                MessageBox.Show("✅ Branch details updated successfully.", "Update Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadBranches();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"❌ Failed to update branch.\nCheck if the contact is valid or already in use.\n\nDetails: {ex.Message}",
                    "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvBranches.CurrentRow == null)
            {
                MessageBox.Show("⚠️ Please select a branch to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int id = Convert.ToInt32(dgvBranches.CurrentRow.Cells["branchId"].Value);

            var confirm = MessageBox.Show("Are you sure you want to delete this branch?", "Confirm Deletion",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm != DialogResult.Yes) return;

            try
            {
                var response = await _httpClient.DeleteAsync($"{BaseUrl}/{id}");
                response.EnsureSuccessStatusCode();

                MessageBox.Show("🗑️ Branch deleted successfully.", "Delete Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadBranches();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"❌ Failed to delete branch.\nIt may be linked to other data.\n\nDetails: {ex.Message}",
                    "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvBranches_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvBranches.CurrentRow == null) return;

            txtBranchName.Text = dgvBranches.CurrentRow.Cells["name"].Value?.ToString();
            txtLocation.Text = dgvBranches.CurrentRow.Cells["location"].Value?.ToString();
            txtContactId.Text = dgvBranches.CurrentRow.Cells["contactId"].Value?.ToString();
        }

        private void btnRefresh_Click(object sender, EventArgs e) => LoadBranches();

        private void btnLoad_Click(object sender, EventArgs e) => LoadBranches();

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
            MessageBox.Show("🧹 Form cleared. Ready for new entry or update.", "Form Reset", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ClearForm()
        {
            txtBranchName.Text = "";
            txtLocation.Text = "";
            txtContactId.Text = "";
            dgvBranches.ClearSelection();
        }

        private void dgvBranches_CellClick(object sender, EventArgs e)
        {
            if (dgvBranches.CurrentRow != null)
            {
                txtBranchName.Text = dgvBranches.CurrentRow.Cells["name"].Value?.ToString();
                txtLocation.Text = dgvBranches.CurrentRow.Cells["location"].Value?.ToString();
                txtContactId.Text = dgvBranches.CurrentRow.Cells["contactId"].Value?.ToString();
            }
        }

        private async Task<object> GetBranchByInputAsync(string input)
        {
            try
            {
                var response = await _httpClient.GetAsync($"{BaseUrl}/find-by-location/{input}");
                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<List<BranchDto>>(json);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"🔍 Search failed.\n\nDetails: {ex.Message}", "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return null;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var searchForm = new SearchByInputForm("Search Branch", GetBranchByInputAsync);
            if (searchForm.ShowDialog() == DialogResult.OK)
            {
                var branch = searchForm.SelectedItem as BranchDto;
                if (branch != null)
                {
                    dgvBranches.DataSource = new List<BranchDto> { branch };
                }
            }
        }

        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(txtBranchName.Text) ||
                string.IsNullOrWhiteSpace(txtLocation.Text) ||
                string.IsNullOrWhiteSpace(txtContactId.Text))
            {
                MessageBox.Show("⚠️ All fields are required. Please fill in branch name, location, and contact ID.",
                    "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }
    }
}

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
                MessageBox.Show("Unable to load the list of branches. Please check your network connection or try again later.",
                    "Loading Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            var newBranch = new UInsertionBranchDto
            {
                Name = txtBranchName.Text,
                Location = txtLocation.Text,
                ContactId = int.Parse(txtContactId.Text)
            };

            try
            {
                var json = JsonConvert.SerializeObject(newBranch);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                var response = await _httpClient.PostAsync(BaseUrl, content);
                response.EnsureSuccessStatusCode();

                MessageBox.Show("Branch has been added successfully.", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadBranches();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to add branch. Make sure the Contact ID exists and is not already linked to another branch.",
                    "Add Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvBranches.CurrentRow == null) return;

            int id = Convert.ToInt32(dgvBranches.CurrentRow.Cells["branchId"].Value);

            var updateBranch = new UInsertionBranchDto
            {
                Name = txtBranchName.Text,
                Location = txtLocation.Text,
                ContactId = int.Parse(txtContactId.Text)
            };

            try
            {
                var json = JsonConvert.SerializeObject(updateBranch);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                var response = await _httpClient.PutAsync($"{BaseUrl}/{id}", content);
                response.EnsureSuccessStatusCode();

                MessageBox.Show("Branch details updated successfully.", "Update Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadBranches();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to update branch. Ensure the Contact ID is valid and not already used by another branch.",
                    "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvBranches.CurrentRow == null) return;

            int id = Convert.ToInt32(dgvBranches.CurrentRow.Cells["branchId"].Value);

            var confirm = MessageBox.Show("Are you sure you want to delete this branch?", "Confirm Deletion",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm != DialogResult.Yes) return;

            try
            {
                var response = await _httpClient.DeleteAsync($"{BaseUrl}/{id}");
                response.EnsureSuccessStatusCode();

                MessageBox.Show("Branch has been deleted successfully.", "Delete Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadBranches();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to delete branch. It may be linked with other records.",
                    "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //// ✅ Optional: GET by ID
        //private async Task<BranchDto> GetBranchById(int id)
        //{
        //    try
        //    {
        //        var response = await _httpClient.GetAsync($"{BaseUrl}/findBranchById/{id}");
        //        response.EnsureSuccessStatusCode();

        //        var json = await response.Content.ReadAsStringAsync();
        //        return JsonConvert.DeserializeObject<BranchDto>(json);
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Unable to find the branch with the specified ID. Please verify and try again.",
        //            "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        return null;
        //    }
        //}

        private void dgvBranches_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvBranches.CurrentRow == null) return;

            txtBranchName.Text = dgvBranches.CurrentRow.Cells["name"].Value?.ToString();
            txtLocation.Text = dgvBranches.CurrentRow.Cells["location"].Value?.ToString();
            txtContactId.Text = dgvBranches.CurrentRow.Cells["contactId"].Value?.ToString();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadBranches();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadBranches();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtBranchName.Text = "";
            txtLocation.Text = "";
            txtContactId.Text = "";
            dgvBranches.ClearSelection();

            MessageBox.Show("Form has been cleared. You can now add or update a new branch.",
                "Form Reset", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        private async Task<object> GetBranchAsync(int id)
        {
            try
            {
                var response = await _httpClient.GetAsync($"{BaseUrl}/findBranchById/{id}");
                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<BranchDto>(json);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            return null;
        }
        private async void btnSearch_Click(object sender, EventArgs e)
        {
            var searchForm = new SearchByIdForm("Search Branch", GetBranchAsync);
            if (searchForm.ShowDialog() == DialogResult.OK)
            {
                var branch = searchForm.SelectedItem as BranchDto;
                if (branch != null)
                {
                    dgvBranches.DataSource = new List<BranchDto> { branch };
                }
            }
        }

    }

}

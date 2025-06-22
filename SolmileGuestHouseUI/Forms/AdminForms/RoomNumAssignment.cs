using Newtonsoft.Json;
using System.Net.Http;
using System.Text;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Threading.Tasks;
using static SolmileGuesthouseAPI.DTO.NavigatorModel.DTOs;
using System;
using Task = System.Threading.Tasks.Task;

namespace SolmileGuestHouseUI.Forms.AdminForms
{
    public partial class RoomNumAssignment : UserControl
    {
        private readonly HttpClient _httpClient = new HttpClient();
        private int? selectedId = null;
        private const string BaseUrl = "https://localhost:7107/api/RoomNumberAssignments";
        private const string BranchUrl = "https://localhost:7107/api/Branches";

        public RoomNumAssignment()
        {
            InitializeComponent();
            _ = LoadBranchesAsync();
            LoadRoomNumberAssignments();
        }

        private async Task LoadBranchesAsync()
        {
            try
            {
                var response = await _httpClient.GetAsync(BranchUrl);
                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    var branches = JsonConvert.DeserializeObject<List<BranchDto>>(json);

                    cmbBranchList.DataSource = branches;
                    cmbBranchList.DisplayMember = "Name"; // Correct property from your BranchDto
                    cmbBranchList.ValueMember = "BranchId";
                }
                else
                {
                    MessageBox.Show("Failed to load branches.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading branches:\n{ex.Message}", "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void LoadRoomNumberAssignments()
        {
            try
            {
                var response = await _httpClient.GetAsync(BaseUrl);
                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    var data = JsonConvert.DeserializeObject<List<RoomNumberAssignmentDto>>(json);
                    dgvRoomNumAssign.DataSource = data;
                }
            }
            catch
            {
                MessageBox.Show("Unable to load room assignments. Please check your internet connection or server status.", "Load Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearFields()
        {
            cmbBranchList.SelectedIndex = -1;
            txtRoomNumber.Clear();
            assignId.Clear();
            selectedId = null;
            dgvRoomNumAssign.ClearSelection();
        }

        private void dgvRoomNumAssign_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgvRoomNumAssign.Rows[e.RowIndex];
                selectedId = Convert.ToInt32(row.Cells["RoomNumberAssignmentId"].Value);
                cmbBranchList.SelectedValue = Convert.ToInt32(row.Cells["BranchId"].Value);
                txtRoomNumber.Text = row.Cells["RoomNumber"].Value.ToString();
                assignId.Text = selectedId.ToString();
            }
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            var searchForm = new SearchByIdForm("Search Room Assignment", GetRoomAssignmentByIdAsync);
            if (searchForm.ShowDialog() == DialogResult.OK)
            {
                var assignment = searchForm.SelectedItem as RoomNumberAssignmentDto;
                if (assignment != null)
                {
                    dgvRoomNumAssign.DataSource = new List<RoomNumberAssignmentDto> { assignment };
                }
                else
                {
                    MessageBox.Show("No matching room assignment found.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private async Task<object> GetRoomAssignmentByIdAsync(int id)
        {
            try
            {
                var response = await _httpClient.GetAsync($"{BaseUrl}/findRoomNumberAssignmentById/{id}");
                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<RoomNumberAssignmentDto>(json);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while searching.\n\nDetails: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return null;
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            if (cmbBranchList.SelectedIndex == -1 || string.IsNullOrWhiteSpace(txtRoomNumber.Text))
            {
                MessageBox.Show("Please select a branch and enter a room number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtRoomNumber.Text.Trim(), out int roomNumber))
            {
                MessageBox.Show("Room number must be a valid number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var dto = new
                {
                    BranchId = (int)cmbBranchList.SelectedValue,
                    RoomNumber = roomNumber
                };

                var json = JsonConvert.SerializeObject(dto);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                var response = await _httpClient.PostAsync(BaseUrl, content);
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Room assignment added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadRoomNumberAssignments();
                    ClearFields();
                }
                else
                {
                    var error = await response.Content.ReadAsStringAsync();
                    MessageBox.Show($"Failed to add room assignment.\nDetails: {error}", "Add Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occurred while adding the assignment.\n\nDetails: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedId == null)
            {
                MessageBox.Show("Please select a room assignment from the list to update.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtRoomNumber.Text.Trim(), out int roomNumber))
            {
                MessageBox.Show("Room number must be a valid number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var dto = new
                {
                    RoomNumberAssignmentId = selectedId.Value,
                    BranchId = (int)cmbBranchList.SelectedValue,
                    RoomNumber = roomNumber
                };

                var json = JsonConvert.SerializeObject(dto);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                var response = await _httpClient.PutAsync($"{BaseUrl}/{selectedId.Value}", content);
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Room assignment updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadRoomNumberAssignments();
                    ClearFields();
                }
                else
                {
                    var error = await response.Content.ReadAsStringAsync();
                    MessageBox.Show($"Failed to update room assignment.\nDetails: {error}", "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occurred while updating the assignment.\n\nDetails: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedId == null)
            {
                MessageBox.Show("Please select a room assignment from the list to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirm = MessageBox.Show("Are you sure you want to delete this room assignment?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes) return;

            try
            {
                var response = await _httpClient.DeleteAsync($"{BaseUrl}/{selectedId.Value}");
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Room assignment deleted successfully!", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadRoomNumberAssignments();
                    ClearFields();
                }
                else
                {
                    var error = await response.Content.ReadAsStringAsync();
                    MessageBox.Show($"Failed to delete room assignment.\nDetails: {error}", "Delete Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occurred while deleting the assignment.\n\nDetails: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
            LoadRoomNumberAssignments();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadRoomNumberAssignments();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using SolmileGuesthouseAPI.DTO.NavigatorModel;
using SolmileGuestHouseUI.Forms.AdminForms;
using static SolmileGuesthouseAPI.DTO.NavigatorModel.DTOs;

namespace SolmileGuestHouseUI.Forms.ManagerForms
{
    public partial class Complaint : UserControl
    {
        private readonly HttpClient _client;

        public Complaint()
        {
            InitializeComponent();

            _client = new HttpClient();
            _client.BaseAddress = new Uri("https://localhost:7107/"); // Set your API base URL here
            _client.DefaultRequestHeaders.Accept.Clear();
            _client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            //LoadStatusDropdown();
            _ = LoadHandlersAsync();
            _ = LoadComplaintsAsync();
        }
        private async Task LoadComplaintsAsync()
        {
            try
            {
                var response = await _client.GetAsync("api/Complaints");
                response.EnsureSuccessStatusCode();

                var json = await response.Content.ReadAsStringAsync();
                var complaints = JsonSerializer.Deserialize<List<ComplaintDto>>(json, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

                dgvComplaints.DataSource = complaints;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading complaints: {ex.Message}");
            }
        }


        private async Task LoadHandlersAsync()
        {
            try
            {
                var response = await _client.GetAsync("api/Employees");
                response.EnsureSuccessStatusCode();

                var json = await response.Content.ReadAsStringAsync();
                var employees = JsonSerializer.Deserialize<List<EmployeeDto>>(json, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

                // Map to a simplified list for the ComboBox
                var handlers = employees.Select(e => new
                {
                    Id = e.Id,
                    FullName = $"{e.FirstName} {e.LastName}"
                }).ToList();

                cmbHandler.DataSource = handlers;
                cmbHandler.DisplayMember = "FullName";
                cmbHandler.ValueMember = "Id";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading handlers: {ex.Message}");
            }
        }

        private void dgvComplaints_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgvComplaints.Rows[e.RowIndex];
                txtComplaintId.Text = row.Cells["ComplaintId"].Value?.ToString();
                txtCustomerId.Text = row.Cells["CustomerId"].Value?.ToString();
                txtDescription.Text = row.Cells["Details"].Value?.ToString();

                var status = row.Cells["Status"].Value?.ToString();
                cmbStatus.SelectedItem = status;

                var employeeId = row.Cells["EmployeeId"].Value;
                if (employeeId != null && int.TryParse(employeeId.ToString(), out var empId))
                {
                    cmbHandler.SelectedValue = empId;
                }
                else
                {
                    cmbHandler.SelectedIndex = -1;
                }
            }
        }

        private async void btnUpdateStatus_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtComplaintId.Text, out var complaintId))
            {
                MessageBox.Show("Select a valid complaint.");
                return;
            }

            if (cmbStatus.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a complaint status.");
                return;
            }

            btnUpdateStatus.Enabled = false;  // disable button to prevent multiple clicks

            var selectedStatus = cmbStatus.SelectedItem?.ToString();
            var updateDto = new UpdateCompDto { status = selectedStatus };

            try
            {
                var content = new StringContent(JsonSerializer.Serialize(updateDto), Encoding.UTF8, "application/json");
                var response = await _client.PutAsync($"api/Complaints/UpdateStatus/{complaintId}", content);

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Complaint status updated.");
                    await LoadComplaintsAsync();
                }
                else
                {
                    string error = await response.Content.ReadAsStringAsync();
                    MessageBox.Show($"Failed to update complaint status.\n\n{error}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating status: {ex.Message}");
            }
            finally
            {
                btnUpdateStatus.Enabled = true;
                ClearForm();
            }
        }

        private async void btnAssignHandler_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtComplaintId.Text, out var complaintId))
            {
                MessageBox.Show("Select a valid complaint.");
                return;
            }

            if (!(cmbHandler.SelectedValue is int employeeId))
            {
                MessageBox.Show("Select a valid handler.");
                return;
            }

            try
            {
                var response = await _client.PutAsync($"api/Complaints/AssignHandler?complaintId={complaintId}&employeeId={employeeId}", null);

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Handler assigned.");
                    await LoadComplaintsAsync();
                }
                else
                {
                    MessageBox.Show("Failed to assign handler.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error assigning handler: {ex.Message}");
            }
            ClearForm();
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtComplaintId.Text, out var complaintId))
            {
                MessageBox.Show("Select a valid complaint.");
                return;
            }

            var confirm = MessageBox.Show("Are you sure you want to delete this complaint?", "Confirm Delete", MessageBoxButtons.YesNo);
            if (confirm != DialogResult.Yes) return;

            try
            {
                var response = await _client.DeleteAsync($"api/Complaints/Delete/{complaintId}");
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Complaint deleted.");
                    await LoadComplaintsAsync();
                }
                else
                {
                    MessageBox.Show("Failed to delete complaint.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting complaint: {ex.Message}");
            }
        }

        private async void btnResolve_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtComplaintId.Text, out var complaintId))
            {
                MessageBox.Show("Please select a valid complaint to resolve.");
                return;
            }

            var confirm = MessageBox.Show("Are you sure you want to mark this complaint as resolved?",
                                           "Confirm Resolution", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes)
                return;

            try
            {
                var response = await _client.PutAsync($"api/Complaints/Resolve/{complaintId}", null);

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Complaint marked as resolved.");
                    await LoadComplaintsAsync();
                }
                else if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
                {
                    MessageBox.Show("Complaint not found.");
                }
                else
                {
                    MessageBox.Show("Failed to resolve complaint.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error resolving complaint: {ex.Message}");
            }
            ClearForm();
        }
        private void ClearForm()
        {
            txtComplaintId.Clear();
            txtCustomerId.Clear();
            txtDescription.Clear();
            cmbStatus.SelectedIndex = -1;
            cmbHandler.SelectedIndex = -1;
            dgvComplaints.ClearSelection();
        }

        private async void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
            await LoadComplaintsAsync();
        }

        private async void btnHistory_Click(object sender, EventArgs e)
        {
            var searchForm = new SearchByInputForm(
                "Search by Customer ID",
                async (input) =>
                {
                    if (!int.TryParse(input, out int customerId))
                        return null;

                    string url = $"api/complaints/History/{customerId}";

                    try
                    {
                        var response = await _client.GetAsync(url);
                        if (!response.IsSuccessStatusCode)
                            return null;

                        var json = await response.Content.ReadAsStringAsync();
                        var complaints = Newtonsoft.Json.JsonConvert.DeserializeObject<List<ComplaintDto>>(json);
                        return complaints;
                    }
                    catch
                    {
                        return null;
                    }
                });

            if (searchForm.ShowDialog() == DialogResult.OK &&
                searchForm.SelectedItem is List<ComplaintDto> complaintList)
            {
                dgvComplaints.DataSource = complaintList;
            }

            ClearForm();
        }

        private void Complaint_Load(object sender, EventArgs e)
        {
            var statuses = new List<string>
    {
        "-- Select Status --", 
        "Pending",
        "In Progress",
        "Resolved",
        "Closed",
        "Rejected"
    };

            cmbStatus.DataSource = statuses;
            cmbStatus.SelectedIndex = 0;

            cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
        }

    }
}

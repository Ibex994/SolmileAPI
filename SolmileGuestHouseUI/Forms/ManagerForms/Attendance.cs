using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SolmileGuesthouseAPI.DTO.NavigatorModel;

namespace SolmileGuestHouseUI.Forms.ManagerForms
{
    public partial class Attendance : UserControl
    {
        private readonly HttpClient httpClient = new HttpClient
        {
            BaseAddress = new Uri("https://localhost:7107/Attendance/") // Put your real API base URL here
        };

        public Attendance()
        {
            InitializeComponent();
        }
        private async void btnGetAll_Click(object sender, EventArgs e)
        {
            try
            {
                var response = await httpClient.GetAsync("all");
                response.EnsureSuccessStatusCode();

                var json = await response.Content.ReadAsStringAsync();
                var attendances = Newtonsoft.Json.JsonConvert.DeserializeObject<List<EmployeeAttendanceDto>>(json);

                dgvAttendance.DataSource = attendances;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching all attendance: " + ex.Message);
            }
        }

        private async void btnGetByEmployeeAndDate_Click(object sender, EventArgs e)
        {
            try
            {
                int employeeId = int.Parse(txtEmployeeId.Text);
                DateTime date = dtpAttendanceDate.Value;

                string url = $"employee/{employeeId}/date/{date:yyyy-MM-dd}";
                var response = await httpClient.GetAsync(url);

                if (!response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Attendance not found.");
                    return;
                }

                var json = await response.Content.ReadAsStringAsync();
                var attendance = Newtonsoft.Json.JsonConvert.DeserializeObject<EmployeeAttendanceDto>(json);

                // Display data in controls or grid
                txtStatus.Text = attendance.Reason;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching attendance: " + ex.Message);
            }
        }

        private async void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                // Example: Create attendance for a single employee (wrap in list)
                var createDto = new AttendanceCreateDto
                {
                    AttendanceDate = dtpAttendanceDate.Value,
                    EmployeeAttendances = new List<EmployeeAttendanceDto>
            {
                new EmployeeAttendanceDto
                {
                    EmployeeId = int.Parse(txtEmployeeId.Text),
                }
            }
                };

                var json = Newtonsoft.Json.JsonConvert.SerializeObject(createDto);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                var response = await httpClient.PostAsync("create", content);

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Attendance created successfully.");
                    btnGetAll_Click(null, null); // refresh data
                }
                else
                {
                    var err = await response.Content.ReadAsStringAsync();
                    MessageBox.Show("Failed to create attendance: " + err);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error creating attendance: " + ex.Message);
            }
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                var updateDto = new UpdateEmployeeAttendanceDto
                {
                    
                    EmployeeId = int.Parse(txtEmployeeId.Text),
                    AttendanceDate = dtpAttendanceDate.Value,
                };

                var json = Newtonsoft.Json.JsonConvert.SerializeObject(updateDto);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                var response = await httpClient.PutAsync("update", content);

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Attendance updated successfully.");
                    btnGetAll_Click(null, null);
                }
                else
                {
                    var err = await response.Content.ReadAsStringAsync();
                    MessageBox.Show("Failed to update attendance: " + err);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating attendance: " + ex.Message);
            }
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int employeeId = int.Parse(txtEmployeeId.Text);
                DateTime attendanceDate = dtpAttendanceDate.Value;

                string url = $"employee/{employeeId}/date/{attendanceDate:yyyy-MM-dd}";
                var response = await httpClient.DeleteAsync(url);

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Attendance deleted successfully.");
                    btnGetAll_Click(null, null);
                }
                else
                {
                    MessageBox.Show("Failed to delete attendance.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting attendance: " + ex.Message);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Net;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using SolmileGuesthouseAPI.DTO.NavigatorModel;
using SolmileGuestHouseUI.Forms.AdminForms;

namespace SolmileGuestHouseUI.Forms.ManagerForms
{
    public partial class Attendance : UserControl
    {
        private const string BaseUrl = "https://localhost:7107/api/Attendance/";
        private readonly HttpClient httpClient;
        private List<DailyAttendCreateDto> savedDates = new();

        public Attendance()
        {
            InitializeComponent();
            cmbIsPresent.SelectedIndex = 0;
            httpClient = new HttpClient
            {
                BaseAddress = new Uri(BaseUrl)
            };
        }

        private async Task GetAllAttendanceAsync()
        {
            try
            {
                var response = await httpClient.GetAsync("all").ConfigureAwait(false);

                if (!response.IsSuccessStatusCode)
                {
                    var error = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    Invoke(() => ShowUserFriendlyError("Couldn't load attendance records", error));
                    return;
                }

                var json = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                var attendances = JsonConvert.DeserializeObject<List<EmployeeAttendanceCreateDto>>(json);

                Invoke(() =>
                {
                    dgvAttendance.DataSource = attendances ?? new List<EmployeeAttendanceCreateDto>();
                });
            }
            catch (Exception ex)
            {
                Invoke(() => ShowUserFriendlyError("Unexpected Error", GetUserFriendlyError(ex)));
            }
        }

        private async Task GetAttendanceByEmployeeAndDateAsync()
        {
            if (!int.TryParse(txtEmployeeId.Text.Trim(), out int employeeId))
            {
                ShowUserFriendlyError("Invalid Input", "Enter a valid Employee ID.");
                return;
            }
            ClearForm();
            try
            {
                DateTime date = dtpAttendanceDate.Value;
                string url = $"employee/{employeeId}/date/{date:yyyy-MM-dd}";
                var response = await httpClient.GetAsync(url).ConfigureAwait(false);

                if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
                {
                    Invoke(() =>
                    {
                        ShowUserFriendlyError("Not Found", "No attendance found for the selected date.");
                        txtReason.Clear();
                        cmbIsPresent.SelectedIndex = 0;
                    });
                    return;
                    ClearForm();
                }

                response.EnsureSuccessStatusCode();
                var json = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                var attendance = JsonConvert.DeserializeObject<EmployeeAttendanceCreateDto>(json);

                Invoke(() =>
                {
                    if (attendance == null)
                    {
                        ShowUserFriendlyError("Not Found", "Attendance record is empty.");
                        txtReason.Clear();
                        cmbIsPresent.SelectedIndex = 0;
                        return;        
                    }
                    txtReason.Text = attendance.Reason ?? "";
                    cmbIsPresent.SelectedIndex = attendance.IsPresent ? 0 : 1;
                });
            }
            catch (Exception ex)
            {
                Invoke(() => ShowUserFriendlyError("Search Failed", GetUserFriendlyError(ex)));
            }
            ClearForm();
        }

        private async Task CreateAttendanceAsync()
        {
            if (!int.TryParse(txtEmployeeId.Text.Trim(), out int employeeId))
            {
                ShowUserFriendlyError("Invalid ID", "Enter a valid Employee ID.");
                return;
            }
            try
            {
                bool isPresent = cmbIsPresent.SelectedIndex == 0;
                string reason = txtReason.Text.Trim();

                var createDto = new AttendanceCreateDto
                {
                    AttendanceDate = dtpAttendanceDate.Value,
                    EmployeeAttendances = new List<EmployeeAttendanceCreateDto>
            {
                new EmployeeAttendanceCreateDto
                {
                    EmployeeId = employeeId,
                    AttendanceDate = dtpAttendanceDate.Value,
                    IsPresent = isPresent,
                    Reason = reason
                }
            }
                };

                var response = await httpClient.PostAsJsonAsync("DailyEmployee", createDto).ConfigureAwait(false);

                if (response.StatusCode == System.Net.HttpStatusCode.Conflict)
                {
                    var conflictMsg = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    Invoke(() => ShowUserFriendlyError("Duplicate Attendance", conflictMsg));
                    return;
                }

                if (!response.IsSuccessStatusCode)
                {
                    var error = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    Invoke(() => ShowUserFriendlyError("Creation Failed", error));
                    return;
                }

                Invoke(() =>
                {
                    MessageBox.Show("Attendance created successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _ = GetAllAttendanceAsync();
                });
            }
            catch (Exception ex)
            {
                Invoke(() => ShowUserFriendlyError("Error", GetUserFriendlyError(ex)));
            }
            ClearForm();
        }
        private async Task UpdateAttendanceAsync()
        {
            if (!int.TryParse(txtEmployeeId.Text.Trim(), out int employeeId))
            {
                MessageBox.Show("Invalid Employee ID.");
                return;
            }

            try
            {
                bool isPresent = cmbIsPresent.SelectedIndex == 0;

                var updateDto = new UpdateEmployeeAttendanceDto
                {
                    EmployeeId = employeeId,
                    AttendanceDate = dtpAttendanceDate.Value,
                    IsPresent = isPresent,
                    Reason = txtReason.Text?.Trim()
                };


                var json = JsonConvert.SerializeObject(updateDto);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                var response = await httpClient.PutAsync("update", content).ConfigureAwait(false);

                if (!response.IsSuccessStatusCode)
                {
                    var error = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    Invoke(() => MessageBox.Show("Update failed: " + error));
                    return;
                }

                Invoke(() =>
                {
                    MessageBox.Show("Attendance updated.");
                    _ = GetAllAttendanceAsync();
                });
            }
            catch (Exception ex)
            {
                Invoke(() => MessageBox.Show("Error: " + GetUserFriendlyError(ex)));
            }
            ClearForm();
        }

        private async Task DeleteAttendanceAsync()
        {
            if (!int.TryParse(txtEmployeeId.Text.Trim(), out int employeeId))
            {
                MessageBox.Show("Invalid Employee ID.");
                return;
            }

            var confirmResult = MessageBox.Show(
                "Are you sure you want to delete the attendance record for this employee on the selected date?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (confirmResult != DialogResult.Yes)
            {
                return;
            }

            try
            {
                var date = dtpAttendanceDate.Value;
                string url = $"employee/{employeeId}/date/{date:yyyy-MM-dd}";

                var response = await httpClient.DeleteAsync(url).ConfigureAwait(false);

                if (!response.IsSuccessStatusCode)
                {
                    var error = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    Invoke(() => MessageBox.Show("Delete failed: " + error));
                    return;
                }

                Invoke(() =>
                {
                    MessageBox.Show("Deleted successfully.");
                    _ = GetAllAttendanceAsync(); // Refresh grid or list
                });
            }
            catch (Exception ex)
            {
                Invoke(() => MessageBox.Show("Error: " + GetUserFriendlyError(ex)));
            }
            ClearForm();
        }

        private void ShowUserFriendlyError(string title, string message)
        {
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private string GetUserFriendlyError(Exception ex)
        {
            switch (ex)
            {
                case HttpRequestException httpEx:
                    return $"Network Error:\n{httpEx.Message}\n\nPlease check your internet connection or try again later.";

                case System.Text.Json.JsonException jsonEx:
                    return $"Data Processing Error:\n{jsonEx.Message}\n\nThe server response could not be processed.";

                default:
                    if (ex.InnerException != null)
                        return $"Internal Error:\n{ex.InnerException.Message}";

                    return $"Unexpected Error:\n{ex.Message}\n\nPlease contact support if the problem continues.";
            }
        }


        private async void btnGetAll_Click(object sender, EventArgs e)
        {
            btnGetAll.Enabled = false;
            await GetAllAttendanceAsync();
            btnGetAll.Enabled = true;
        }

        private async void btnGetByEmployeeAndDate_Click(object sender, EventArgs e)
        {
            btnGetByEmployeeAndDate.Enabled = false;
            await GetAttendanceByEmployeeAndDateAsync();
            btnGetByEmployeeAndDate.Enabled = true;
        }

        private async void btnCreate_Click(object sender, EventArgs e)
        {
            btnCreate.Enabled = false;
            await CreateAttendanceAsync();
            btnCreate.Enabled = true;
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            btnUpdate.Enabled = false;
            await UpdateAttendanceAsync();
            btnUpdate.Enabled = true;
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            btnDelete.Enabled = false;
            await DeleteAttendanceAsync();
            btnDelete.Enabled = true;
        }

        private async Task<bool> SaveAttendanceDateAsync(DateTime attendanceDate)
        {
            var createDto = new DailyAttendCreateDto
            {
                AttendanceDate = attendanceDate
            };

            var response = await httpClient.PostAsJsonAsync("DailyAttendance", createDto).ConfigureAwait(false);

            if (!response.IsSuccessStatusCode)
            {
                var error = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                Invoke(() => ShowUserFriendlyError("Save Failed", error));
                return false;
            }

            Invoke(() =>
            {
                savedDates.Add(createDto);
                dgvMultipleAttendance.DataSource = null;
                dgvMultipleAttendance.DataSource = savedDates;
                MessageBox.Show($"Attendance For {attendanceDate.ToString("MM/dd/yyyy")} date saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            });
            return true;
        }

        private async void btnMultipleSave_Click(object sender, EventArgs e)
        {
            btnMultipleSave.Enabled = false;

            try
            {
                var attendanceDate = dateTime2.Value.Date;

                await SaveAttendanceDateAsync(attendanceDate);
            }
            catch (Exception ex)
            {
                Invoke(() => ShowUserFriendlyError("Error", GetUserFriendlyError(ex)));
            }
            finally
            {
                btnMultipleSave.Enabled = true;
            }
        }

        private async Task LoadAttendanceDatesAsync()
        {
            try
            {
                HttpResponseMessage response = await httpClient.GetAsync("all-dates");

                if (response.IsSuccessStatusCode)
                {
                    var dateDtos = await response.Content.ReadFromJsonAsync<List<DailyAttendCreateDto>>();
                    var dates = dateDtos.Select(x => x.AttendanceDate).ToList();
                    dgvMultipleAttendance.DataSource = dates.Select(d => new { AttendanceDate = d }).ToList();

                }
                else
                {
                    string error = await response.Content.ReadAsStringAsync();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error occurred while loading dates.\n\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private async void Attendance_Load(object sender, EventArgs e)
        {
            await GetAllAttendanceAsync();
            await LoadAttendanceDatesAsync();

        }

        private async void btnLoad_Click(object sender, EventArgs e)
        {
            await LoadAttendanceDatesAsync();
        }

        private void dgvAttendance_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= dgvAttendance.Rows.Count)
                return;
            var selectedRow = dgvAttendance.Rows[e.RowIndex];
            txtEmployeeId.Text = selectedRow.Cells["EmployeeId"].Value?.ToString();
            txtReason.Text = selectedRow.Cells["Reason"].Value?.ToString() ?? "";
            if (DateTime.TryParse(selectedRow.Cells["AttendanceDate"].Value?.ToString(), out DateTime selectedDate))
            {
                dtpAttendanceDate.Value = selectedDate;
            }
            if (bool.TryParse(selectedRow.Cells["IsPresent"].Value?.ToString(), out bool isPresent))
            {
                cmbIsPresent.SelectedIndex = isPresent ? 0 : 1;
            }
        }

        private async void btnById_Click(object sender, EventArgs e)
        {
            var searchForm = new SearchByInputForm(
                "Search by Employee ID",
                async (input) =>
                {
                    if (!int.TryParse(input, out int employeeId))
                        return null;

                    var date = dtpAttendanceDate.Value.Date;
                    string url = $"employee/{employeeId}/date/{date:yyyy-MM-dd}";

                    try
                    {
                        var response = await httpClient.GetAsync(url);
                        if (!response.IsSuccessStatusCode)
                            return null;

                        var json = await response.Content.ReadAsStringAsync();
                        var attendance = JsonConvert.DeserializeObject<EmployeeAttendanceCreateDto>(json);
                        return attendance;
                    }
                    catch
                    {
                        return null;
                    }
                });

            if (searchForm.ShowDialog() == DialogResult.OK)
            {
                if (searchForm.SelectedItem is EmployeeAttendanceCreateDto attendance)
                {
                    //txtEmployeeId.Text = attendance.EmployeeId.ToString();
                    //dtpAttendanceDate.Value = attendance.AttendanceDate;
                    //txtReason.Text = attendance.Reason ?? "";
                    //cmbIsPresent.SelectedIndex = attendance.IsPresent ? 0 : 1;
                    dgvAttendance.DataSource = new List<EmployeeAttendanceCreateDto> { attendance };
                }
            }
            ClearForm();
        }

        private async void btnGenerateSummary_Click(object sender, EventArgs e)
        {

            var selectedDate = dateTime2.Value.Date;
            string yearMonth = selectedDate.ToString("yyyy-MM");

            try
            {
                var generateResponse = await httpClient.PostAsync($"monthly-summary/{yearMonth}", null);
                if (!generateResponse.IsSuccessStatusCode)
                {
                    MessageBox.Show(
                        $"❗ Could not generate monthly summary for {yearMonth}.\n" +
                        $"Please ensure attendance records exist for that month and try again.",
                        "Generation Failed",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                    return;
                }

                var summaryResponse = await httpClient.GetAsync($"monthly-summary/{yearMonth}");
                if (!summaryResponse.IsSuccessStatusCode)
                {
                    MessageBox.Show("Summary was generated but could not be loaded.\nPlease try refreshing.", "Load Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var summaryList = await summaryResponse.Content.ReadFromJsonAsync<List<MonthlyAttendanceSummaryDto>>();

                if (summaryList != null && summaryList.Any())
                {
                    dgvMonthlySummary.DataSource = summaryList.Select(s => new
                    {
                        s.EmployeeId,
                        s.EmployeeFullName,
                        s.YearMonth,
                        s.TotalDaysPresent
                    }).ToList();
                }
                else
                {
                    MessageBox.Show("No summary data available for the selected month.", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error occurred:\n\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private async void btnGetIdDate_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtEmpId.Text.Trim(), out int employeeId))
            {
                MessageBox.Show("Please enter a valid numeric Employee ID.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string yearMonth = dateTimePicker1.Value.ToString("yyyy-MM");

            try
            {
                string url = $"monthly-summary/employee/{employeeId}/year-month/{yearMonth}";
                HttpResponseMessage response = await httpClient.GetAsync(url);

                if (response.IsSuccessStatusCode)
                {
                    var summary = await response.Content.ReadFromJsonAsync<MonthlyAttendanceSummaryDto>();
                    dgvMonthlySummary.DataSource = new List<MonthlyAttendanceSummaryDto> { summary };
                    ClearForm();
                }
                else if (response.StatusCode == HttpStatusCode.NotFound)
                {
                    MessageBox.Show(
                        $"No summary data found for Employee ID {employeeId} in {yearMonth}.",
                        "No Data Found",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                    
                }
                else
                {
                    string error = await response.Content.ReadAsStringAsync();
                    MessageBox.Show($"Unexpected server error:\n{error}", "Server Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred:\n\n{ex.Message}", "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            ClearForm();
        }

        private void ClearForm()
        {
            txtEmpId.Text = string.Empty;
            txtEmployeeId.Text = string.Empty;
            dateTimePicker1.Value = DateTime.Today;
            dateTimePicker2.Value = DateTime.Today;
            dtpAttendanceDate.Value = DateTime.Today;
            txtEmpId.Focus();
            txtEmployeeId.Focus();
        }

        private void btnClear_Click_1(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void clear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }
    }
}

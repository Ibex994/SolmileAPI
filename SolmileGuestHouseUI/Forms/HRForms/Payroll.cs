using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using SolmileGuesthouseAPI.DTO.NavigatorModel;
using SolmileGuestHouseUI.Forms.AdminForms;

namespace SolmileGuestHouseUI.Forms.HRForms
{
    public partial class Payroll : UserControl
    {
        private readonly HttpClient _httpClient = new HttpClient()
        {
            BaseAddress = new Uri("https://localhost:7107/api/Payroll/")
        };

        public Payroll()
        {
            InitializeComponent();

            btnSearch.Click += BtnSearch_Click;
            btnSavePayroll.Click += BtnSavePayroll_Click;
            btnDownloadPayslip.Click += BtnDownloadPayslip_Click;
            btnDownloadPDFByDate.Click += BtnDownloadPDFByDate_Click;
            dgvPayrolls.CellClick += DgvPayrolls_CellClick;

            LoadPayrollListAsync();
        }

        private async Task LoadPayrollListAsync()
        {
            try
            {
                var payrolls = await _httpClient.GetFromJsonAsync<List<PayrollResponseDto>>("");
                dgvPayrolls.DataSource = payrolls;
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading payrolls: {ex.Message}");
            }
        }

        private async void BtnSearch_Click(object sender, EventArgs e)
        {
            async Task<object> SearchPayrollById(string input)
            {
                if (!int.TryParse(input, out int payrollId))
                    return null;

                try
                {
                    // Request payroll by ID (e.g., /api/Payroll/123)
                    var response = await _httpClient.GetAsync($"{payrollId}");

                    if (!response.IsSuccessStatusCode)
                    {
                        var errorContent = await response.Content.ReadAsStringAsync();
                        MessageBox.Show($"API Error: {errorContent}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return null;
                    }

                    var content = await response.Content.ReadAsStringAsync();
                    var payroll = System.Text.Json.JsonSerializer.Deserialize<PayrollResponseDto>(content);

                    return payroll is not null ? new List<PayrollResponseDto> { payroll } : null;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error occurred: {ex.Message}", "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
            }
            using var searchForm = new SearchByInputForm("Enter Payroll ID", SearchPayrollById);
            var result = searchForm.ShowDialog();

            if (result == DialogResult.OK && searchForm.SelectedItem is List<PayrollResponseDto> payrolls)
            {
                dgvPayrolls.DataSource = payrolls;
                ClearForm();
            }
        }

        private async void BtnSavePayroll_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(txtEmpId.Text, out int empId))
                {
                    MessageBox.Show("Invalid Employee ID", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!decimal.TryParse(txtBasicSalary.Text, out decimal basicSalary) ||
                    !decimal.TryParse(txtAllowances.Text, out decimal allowances) ||
                    !decimal.TryParse(txtDeductions.Text, out decimal deductions))
                {
                    MessageBox.Show("Please enter valid numeric values for salary, allowances, and deductions.",
                                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var payrollCreateDto = new PayrollCreateDto
                {
                    EmployeeId = empId,
                    PayPeriod = dtpPayPeriodInput.Value.Date,
                    BasicSalary = (float)basicSalary,
                    Allowances = (float)allowances,
                    Deductions = (float)deductions,
                    DeductionReason = txtDeductReason.Text
                };

                int? payrollId = GetSelectedPayrollId();

                string apiUrl = "https://localhost:7107/api/Payroll";
                HttpResponseMessage response;

                if (payrollId.HasValue)
                {
                    response = await _httpClient.PutAsJsonAsync($"{apiUrl}/{payrollId.Value}", payrollCreateDto);
                }
                else
                {
                    response = await _httpClient.PostAsJsonAsync(apiUrl, payrollCreateDto);
                }

                if (response.IsSuccessStatusCode)
                {
                    string successMessage = payrollId.HasValue
                        ? "Payroll updated successfully!"
                        : "Payroll created successfully!";
                    MessageBox.Show(successMessage, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    await LoadPayrollListAsync();
                }
                else
                {
                    var error = await response.Content.ReadAsStringAsync();
                    MessageBox.Show($"Error saving payroll:\nStatus: {response.StatusCode}\nDetails: {error}",
                                    "API Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unexpected error occurred:\n{ex.Message}", "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private async void BtnDownloadPayslip_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textEmpId.Text, out int empId))
            {
                MessageBox.Show("Invalid Employee ID");
                return;
            }

            try
            {
                var response = await _httpClient.GetAsync($"payslip/{empId}");
                if (response.IsSuccessStatusCode)
                {
                    var bytes = await response.Content.ReadAsByteArrayAsync();
                    var savePath = $"Payslip_{empId}_{DateTime.Now:yyyyMMddHHmmss}.pdf";

                    System.IO.File.WriteAllBytes(savePath, bytes);
                    MessageBox.Show($"Payslip saved to {savePath}");
                }
                else
                {
                    MessageBox.Show($"Failed to download payslip: {response.ReasonPhrase}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error downloading payslip: {ex.Message}");
            }
        }

        private async void BtnDownloadPDFByDate_Click(object sender, EventArgs e)
        {
            try
            {
                var date = dtpPayPeriod.Value.Date;
                var response = await _httpClient.GetAsync($"download-pdf-by-date?payPeriod={date:yyyy-MM-dd}");

                if (response.IsSuccessStatusCode)
                {
                    var bytes = await response.Content.ReadAsByteArrayAsync();
                    var savePath = $"Payrolls_{date:yyyyMMdd}.pdf";

                    System.IO.File.WriteAllBytes(savePath, bytes);
                    MessageBox.Show($"Payroll PDF saved to {savePath}");
                }
                else
                {
                    MessageBox.Show("No payroll records found for the specified pay period.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error downloading payroll PDF: {ex.Message}");
            }
        }

        private void DgvPayrolls_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvPayrolls.Rows[e.RowIndex].DataBoundItem is PayrollResponseDto selectedPayroll)
            {
                PopulateFormFromPayroll(selectedPayroll);
            }
        }

        private void PopulateFormFromPayroll(PayrollResponseDto payroll)
        {
            txtEmpId.Text = payroll.EmployeeId.ToString();
            dtpPayPeriodInput.Value = payroll.PayPeriod;
            txtBasicSalary.Text = payroll.BasicSalary.ToString();
            txtAllowances.Text = payroll.Allowances.ToString();
            txtDeductions.Text = payroll.Deductions.ToString();
            txtDeductReason.Text = payroll.DeductionReason;
        }

        private int? GetSelectedPayrollId()
        {
            if (dgvPayrolls.CurrentRow?.DataBoundItem is PayrollResponseDto payroll)
                return payroll.PayrollId;
            return null;
        }

        private void ClearForm()
        {
            txtEmpId.Clear();
            txtBasicSalary.Clear();
            txtAllowances.Clear();
            txtDeductions.Clear();
            txtDeductReason.Clear();
            dtpPayPeriodInput.Value = DateTime.Today;
            dgvPayrolls.ClearSelection();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Delete)
            {
                DeleteSelectedPayrollAsync();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private async void DeleteSelectedPayrollAsync()
        {
            var payrollId = GetSelectedPayrollId();
            if (!payrollId.HasValue)
            {
                MessageBox.Show("Select a payroll record to delete.");
                return;
            }

            var confirm = MessageBox.Show("Are you sure you want to delete the selected payroll?", "Confirm Delete", MessageBoxButtons.YesNo);
            if (confirm != DialogResult.Yes) return;

            try
            {
                var response = await _httpClient.DeleteAsync($"{payrollId.Value}");
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Payroll deleted successfully.");
                    await LoadPayrollListAsync();
                }
                else
                {
                    MessageBox.Show($"Failed to delete payroll: {response.ReasonPhrase}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting payroll: {ex.Message}");
            }
        }

        private async void btnSaveDeduction_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(txtDeductionEmpId.Text, out int empId))
                {
                    MessageBox.Show("Invalid Employee ID", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (!float.TryParse(txtDeductionAmount.Text, out float amount))
                {
                    MessageBox.Show("Invalid deduction amount", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string reason = txtDeductionReason.Text.Trim();
                if (string.IsNullOrWhiteSpace(reason))
                {
                    MessageBox.Show("Please provide a reason for the deduction.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DateTime payPeriod = dtpDeductionPeriod.Value.Date;

                var deduction = new DeductionRequestDto
                {
                    Amount = amount,
                    PayPeriod = payPeriod,
                    Reason = reason
                };

                // Assuming the route is like: POST /api/Payroll/add-deduction/{employeeId}
                var response = await _httpClient.PostAsJsonAsync($"{empId}/deductions", deduction);

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Deduction saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtDeductionEmpId.Clear();
                    txtDeductionAmount.Clear();
                    txtDeductionReason.Clear();
                    dtpDeductionPeriod.Value = DateTime.Today;
                }
                else
                {
                    var errorDetails = await response.Content.ReadAsStringAsync();
                    MessageBox.Show($"Failed to save deduction.\nStatus: {response.StatusCode}\nDetails: {errorDetails}",
                                    "API Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unexpected error occurred:\n{ex.Message}", "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            LoadPayrollListAsync();
        }
    }
}

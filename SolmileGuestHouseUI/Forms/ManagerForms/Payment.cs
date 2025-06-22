using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using SolmileGuesthouseAPI.DTO.NavigatorModel;
using SolmileGuestHouseUI.Forms.AdminForms;

namespace SolmileGuestHouseUI.Forms.ManagerForms
{
    public partial class Payment : UserControl
    {
        private readonly HttpClient _httpClient = new HttpClient();
        private const string ApiUrl = "https://localhost:7107/api/Payment";

        public Payment()
        {
            InitializeComponent();
            WireUpEvents();
            LoadPaymentMethodsAsync();
        }

        private void WireUpEvents()
        {
            btnGetAll.Click += btnGetAll_Click;
            btnGetById.Click += btnGetById_Click;
            btnAdd.Click += btnAdd_Click;
            btnUpdate.Click += btnUpdate_Click;
            btnDelete.Click += btnDelete_Click;
            btnProcess.Click += btnProcess_Click;
            btnClear.Click += btnClear_Click;
            dgvPayments.CellClick += dgvPayments_CellClick;
        }

        private async void btnGetAll_Click(object sender, EventArgs e)
        {
            try
            {
                var response = await _httpClient.GetAsync(ApiUrl);
                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    var payments = JsonConvert.DeserializeObject<List<PaymentDto>>(json);
                    dgvPayments.DataSource = payments;
                }
                else
                {
                    MessageBox.Show("Failed to retrieve payment list.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error occurred.\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnGetById_Click(object sender, EventArgs e)
        {
            async Task<object> SearchPaymentsByReservationId(string input)
            {
                try
                {
                    var response = await _httpClient.GetAsync($"{ApiUrl}/reservation/{input}");
                    if (!response.IsSuccessStatusCode)
                        return null;

                    var json = await response.Content.ReadAsStringAsync();
                    var payments = JsonConvert.DeserializeObject<List<PaymentDto>>(json);

                    return payments?.FirstOrDefault();
                }
                catch
                {
                    return null;
                }
            }

            using var searchForm = new SearchByInputForm("Enter Reservation ID", SearchPaymentsByReservationId);
            var result = searchForm.ShowDialog();

            if (result == DialogResult.OK && searchForm.SelectedItem is PaymentDto payment)
            {
                txtBookingId.Text = payment.ReservationId;
                txtAmount.Text = payment.Amount.ToString("F2");
                payDate.Value = payment.PaymentDate;
                cmbPayMethod.SelectedValue = payment.MethodId;
            }
        }


        private async void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                var newPayment = new CreatePaymentDto
                {
                    ReservationId = txtBookingId.Text.Trim(),
                    Amount = float.Parse(txtAmount.Text),
                    PaymentDate = payDate.Value,
                    MethodId = (int)cmbPayMethod.SelectedValue
                };

                var response = await _httpClient.PostAsJsonAsync(ApiUrl, newPayment);
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Payment was successfully recorded.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnGetAll.PerformClick();
                    ClearForm();
                }
                else
                {
                    var errorContent = await response.Content.ReadAsStringAsync();
                    if (errorContent.Contains("FOREIGN KEY constraint") && errorContent.Contains("ReservationId"))
                    {
                        MessageBox.Show("The specified Reservation ID does not exist. Please verify it.", "Reservation Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        MessageBox.Show($"Unable to add payment.\nDetails: {errorContent}", "Add Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid amount.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error occurred.\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtPaymentId.Text, out int id))
            {
                MessageBox.Show("Please enter a valid Payment ID.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var updateDto = new CreatePaymentDto
                {
                    ReservationId = txtBookingId.Text.Trim(),
                    Amount = float.Parse(txtAmount.Text),
                    PaymentDate = payDate.Value,
                    MethodId = (int)cmbPayMethod.SelectedValue
                };

                var response = await _httpClient.PutAsJsonAsync($"{ApiUrl}/{id}", updateDto);
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Payment updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnGetAll.PerformClick();
                    ClearForm();
                }
                else
                {
                    var errorMsg = await response.Content.ReadAsStringAsync();
                    if (errorMsg.Contains("FOREIGN KEY constraint") && errorMsg.Contains("ReservationId"))
                    {
                        MessageBox.Show("Update failed. The specified Reservation ID was not found.", "Reservation Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        MessageBox.Show($"Failed to update the payment.\nDetails: {errorMsg}", "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid amount.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error occurred.\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private async void btnDelete_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtPaymentId.Text, out int id))
            {
                MessageBox.Show("Please enter a valid Payment ID.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var response = await _httpClient.DeleteAsync($"{ApiUrl}/{id}");
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Payment deleted successfully.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnGetAll.PerformClick();
                    ClearForm();
                }
                else
                {
                    var errorMsg = await response.Content.ReadAsStringAsync();
                    MessageBox.Show($"Failed to delete payment.\nReason: {errorMsg}", "Delete Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while deleting the payment.\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnProcess_Click(object sender, EventArgs e)
        {
            try
            {
                var processDto = new ProcessPaymentDto
                {
                    ReservationId = txtBookingId.Text.Trim(),
                    MethodId = (int)cmbPayMethod.SelectedValue
                };

                var response = await _httpClient.PostAsJsonAsync($"{ApiUrl}/process", processDto);
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Payment has been processed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearForm();
                }
                else
                {
                    var errorMsg = await response.Content.ReadAsStringAsync();
                    if (errorMsg.Contains("ReservationId"))
                    {
                        MessageBox.Show("Processing failed. The Reservation ID you entered was not found.", "Reservation Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        MessageBox.Show($"Payment processing failed.\nDetails: {errorMsg}", "Process Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid amount.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error occurred.\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private async Task LoadPaymentMethodsAsync()
        {
            try
            {
                var response = await _httpClient.GetAsync("https://localhost:7107/api/PaymentMethod");
                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    var methods = JsonConvert.DeserializeObject<List<PaymentMethodDto>>(json);
                    cmbPayMethod.DataSource = methods;
                    cmbPayMethod.DisplayMember = "MethodName";
                    cmbPayMethod.ValueMember = "MethodId";
                }
                else
                {
                    MessageBox.Show("Failed to load payment methods.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading payment methods.\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ClearForm()
        {
            txtPaymentId.Clear();
            txtBookingId.Clear();
            txtAmount.Clear();
            payDate.Value = DateTime.Today;
            cmbPayMethod.SelectedIndex = -1;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }
        private async void dgvPayments_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    DataGridViewRow row = dgvPayments.Rows[e.RowIndex];
                    if (row.Cells["PaymentId"].Value != null && int.TryParse(row.Cells["PaymentId"].Value.ToString(), out int paymentId))
                    {
                        var response = await _httpClient.GetAsync($"{ApiUrl}/{paymentId}");
                        if (response.IsSuccessStatusCode)
                        {
                            var json = await response.Content.ReadAsStringAsync();
                            var payment = JsonConvert.DeserializeObject<PaymentDto>(json);

                            // Set form fields with the fetched payment data
                            txtPaymentId.Text = payment.PaymentID.ToString();
                            txtBookingId.Text = payment.ReservationId?.ToString();
                            txtAmount.Text = payment.Amount.ToString("F2");
                            payDate.Value = payment.PaymentDate;
                            cmbPayMethod.SelectedValue = payment.MethodId;
                        }
                        else
                        {
                            MessageBox.Show("Failed to retrieve payment details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid Payment ID selected.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading payment data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using SolmileGuesthouseAPI.DTO.NavigatorModel;
using SolmileGuestHouseUI.Forms.AdminForms;

namespace SolmileGuestHouseUI.Forms.ManagerForms
{
    public partial class PaymentMethod : UserControl
    {
        private readonly HttpClient _httpClient = new HttpClient
        {
            BaseAddress = new Uri("https://localhost:7107/api/")
        };

        public PaymentMethod()
        {
            InitializeComponent();
            btnGetAll.Click += async (s, e) => await LoadAllAsync();
            btnGetById.Click += async (s, e) => await LoadByIdAsync();
            btnAdd.Click += async (s, e) => await AddAsync();
            btnUpdate.Click += async (s, e) => await UpdateAsync();
            btnDelete.Click += async (s, e) => await DeleteAsync();
            dgvPaymentMethods.CellClick += dgvPaymentMethods_CellClick;
            _ = LoadAllAsync();
        }

        private async Task LoadAllAsync()
        {
            try
            {
                var response = await _httpClient.GetAsync("PaymentMethod");
                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    var data = JsonConvert.DeserializeObject<List<PaymentMethodDto>>(json);
                    dgvPaymentMethods.DataSource = data;
                }
                else
                {
                    MessageBox.Show("Unable to load payment methods at this time. Please try again later.", "Load Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error occurred while loading payment methods:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task LoadByIdAsync()
        {
            var searchForm = new SearchByInputForm("Enter Payment Method ID", async (input) =>
            {
                if (!int.TryParse(input, out int id)) return null;

                var response = await _httpClient.GetAsync($"PaymentMethod/{id}");
                if (!response.IsSuccessStatusCode) return null;

                var json = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<PaymentMethodDto>(json);
            });

            if (searchForm.ShowDialog() == DialogResult.OK && searchForm.SelectedItem is PaymentMethodDto method)
            {
                txtMethodId.Text = method.MethodId.ToString();
                txtMethodName.Text = method.MethodName;
            }
            else
            {
                MessageBox.Show("No payment method found with the specified ID.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private async Task AddAsync()
        {
            if (string.IsNullOrWhiteSpace(txtMethodName.Text))
            {
                MessageBox.Show("Please enter a payment method name before adding.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMethodName.Focus();
                return;
            }

            var dto = new CreatePaymentMethodDto { MethodName = txtMethodName.Text.Trim() };

            try
            {
                var json = JsonConvert.SerializeObject(dto);
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                var response = await _httpClient.PostAsync("PaymentMethod", content);

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Payment method added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearFormFields();
                    await LoadAllAsync();
                }
                else
                {
                    MessageBox.Show("Failed to add the payment method. Please try again.", "Add Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while adding the payment method:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task UpdateAsync()
        {
            if (!int.TryParse(txtMethodId.Text, out int id))
            {
                MessageBox.Show("Please select a valid payment method to update.", "Invalid ID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtMethodName.Text))
            {
                MessageBox.Show("Please enter a payment method name before updating.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMethodName.Focus();
                return;
            }

            var dto = new UpdatePaymentMethodDto { MethodName = txtMethodName.Text.Trim() };

            try
            {
                var json = JsonConvert.SerializeObject(dto);
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                var response = await _httpClient.PutAsync($"PaymentMethod/{id}", content);

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Payment method updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearFormFields();
                    await LoadAllAsync();
                }
                else
                {
                    MessageBox.Show("Failed to update the payment method. Please check if the method exists and try again.", "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while updating the payment method:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task DeleteAsync()
        {
            if (!int.TryParse(txtMethodId.Text, out int id))
            {
                MessageBox.Show("Please select a valid payment method to delete.", "Invalid ID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirm = MessageBox.Show("Are you sure you want to delete this payment method?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes)
                return;

            try
            {
                var response = await _httpClient.DeleteAsync($"PaymentMethod/{id}");
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Payment method deleted successfully.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearFormFields();
                    await LoadAllAsync();
                }
                else
                {
                    MessageBox.Show("Failed to delete the payment method. It may not exist anymore.", "Delete Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while deleting the payment method:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearFormFields()
        {
            txtMethodId.Clear();
            txtMethodName.Clear();
        }

        private void dgvPaymentMethods_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvPaymentMethods.Rows[e.RowIndex].DataBoundItem is PaymentMethodDto selected)
            {
                txtMethodId.Text = selected.MethodId.ToString();
                txtMethodName.Text = selected.MethodName;
            }
        }
    }
}

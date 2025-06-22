using System;
using System.Collections.Generic;
using System.Drawing;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using SolmileGuestHouseUI.Forms.AdminForms;
using static SolmileGuesthouseAPI.DTO.NavigatorModel.DTOs;

namespace SolmileGuestHouseUI.Forms.ManagerForms
{
    public partial class ServiceType : UserControl
    {
        private readonly HttpClient _httpClient = new HttpClient();
        private const string BaseApiUrl = "https://localhost:7107/api/ServiceTypes/";

        public ServiceType()
        {
            InitializeComponent();
            LoadAllAsync();
        }


        private async Task LoadAllAsync()
        {
            try
            {
                var services = await _httpClient.GetFromJsonAsync<List<ServiceTypeDto>>(BaseApiUrl);
                dgvServiceTypes.DataSource = services;
                //ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to load service types.\n\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task AddAsync()
        {
            var name = txtName.Text.Trim();
            var idText = txtId.Text.Trim();

            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(idText))
            {
                MessageBox.Show("Please enter both ID and Name.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(idText, out int id))
            {
                MessageBox.Show("Invalid ID. Please enter a valid number.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var newService = new ServiceTypeDto
            {
                ServiceTypeId = id,
                ServiceTypeName = name
            };

            var response = await _httpClient.PostAsJsonAsync(BaseApiUrl, newService);
            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("New service type added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                await LoadAllAsync();
            }
            else
            {
                var error = await response.Content.ReadAsStringAsync();
                MessageBox.Show($"Failed to add the service type.\n\n{error}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task UpdateAsync()
        {
            if (!int.TryParse(txtId.Text, out int id))
            {
                MessageBox.Show("Invalid service type ID.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var name = txtName.Text.Trim();
            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Please enter a service name.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var updateDto = new { ServiceTypeName = name };

            var response = await _httpClient.PutAsJsonAsync($"{BaseApiUrl}{id}", updateDto);
            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Service type updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                await LoadAllAsync();
            }
            else
            {
                MessageBox.Show("Failed to update the service type.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task DeleteAsync()
        {
            if (!int.TryParse(txtId.Text, out int id))
            {
                MessageBox.Show("Please enter a valid ID to delete.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirm = MessageBox.Show("Are you sure you want to delete this service type?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                var response = await _httpClient.DeleteAsync($"{BaseApiUrl}{id}");
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Service type deleted successfully.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    await LoadAllAsync();
                }
                else
                {
                    MessageBox.Show("Failed to delete the service type.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private async Task GetListForCustomerAsync()
        {
            try
            {
                var services = await _httpClient.GetFromJsonAsync<List<string>>($"{BaseApiUrl}GetServiceListForCustomer");
                MessageBox.Show(string.Join(Environment.NewLine, services), "Service Types for Customers");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Could not retrieve the service list.\n\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task SearchAndShowServiceTypeAsync()
        {
            async Task<object> SearchFunc(string input)
            {
                try
                {
                    if (int.TryParse(input, out int id))
                    {
                        return await _httpClient.GetFromJsonAsync<ServiceTypeDto>($"{BaseApiUrl}{id}");
                    }

                    int serviceTypeId = await _httpClient.GetFromJsonAsync<int>($"{BaseApiUrl}GetServiceTypeIdByName/{input}");
                    if (serviceTypeId == -1)
                        return null;
                    return await _httpClient.GetFromJsonAsync<ServiceTypeDto>($"{BaseApiUrl}{serviceTypeId}");
                }
                catch
                {
                    return null;
                }
            }

            using (var searchForm = new SearchByInputForm("Enter Service ID or Name", SearchFunc))
            {
                if (searchForm.ShowDialog() == DialogResult.OK && searchForm.SelectedItem is ServiceTypeDto service)
                {
                    txtId.Text = service.ServiceTypeId.ToString();
                    txtName.Text = service.ServiceTypeName;

                    foreach (DataGridViewRow row in dgvServiceTypes.Rows)
                    {
                        if (row.DataBoundItem is ServiceTypeDto dto && dto.ServiceTypeId == service.ServiceTypeId)
                        {
                            dgvServiceTypes.ClearSelection();
                            row.Selected = true;
                            dgvServiceTypes.FirstDisplayedScrollingRowIndex = row.Index;
                            break;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("No service type found for the provided input.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void DgvServiceTypes_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvServiceTypes.CurrentRow?.DataBoundItem is ServiceTypeDto selected)
            {
                txtId.Text = selected.ServiceTypeId.ToString();
                txtName.Text = selected.ServiceTypeName;
            }
        }

        private void ClearForm()
        {
            txtId.Clear();
            txtName.Clear();
            dgvServiceTypes.ClearSelection();
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            await AddAsync();
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            await DeleteAsync();
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            await UpdateAsync();
        }

        private async void btnGetAll_Click(object sender, EventArgs e)
        {
            await LoadAllAsync(); 
        }

        private async void btnFindByIdOrName_Click(object sender, EventArgs e)
        {
            await SearchAndShowServiceTypeAsync();
        }

        private async void btnGetListForCustomer_Click(object sender, EventArgs e)
        {
            await GetListForCustomerAsync();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
             ClearForm();
        }
    }
}
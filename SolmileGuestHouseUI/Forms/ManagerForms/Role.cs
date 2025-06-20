using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SolmileGuesthouseAPI.DTO.NavigatorModel;

namespace SolmileGuestHouseUI.Forms.ManagerForms
{
    public partial class Role : UserControl
    {
        private readonly HttpClient _httpClient;

        public Role()
        {
            InitializeComponent();
            _httpClient = new HttpClient
            {
                BaseAddress = new Uri("https://localhost:7107/api/")
            };

            btnGetAll.Click += async (s, e) => await LoadRolesAsync();
            btnAdd.Click += async (s, e) => await AddRoleAsync();
            btnDelete.Click += async (s, e) => await DeleteRoleAsync();
            dgvRoles.SelectionChanged += DgvRoles_SelectionChanged;
        }

        private async Task LoadRolesAsync()
        {
            try
            {
                var roles = await _httpClient.GetFromJsonAsync<List<RoleReadDto>>("role");
                dgvRoles.DataSource = roles;
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading roles: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task AddRoleAsync()
        {
            string roleName = txtRoleName.Text.Trim();

            if (string.IsNullOrEmpty(roleName))
            {
                MessageBox.Show("Please enter a role name.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var newRole = new RoleCreateDto { Name = roleName };

            try
            {
                var response = await _httpClient.PostAsJsonAsync("role", newRole);
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Role added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    await LoadRolesAsync();
                    ClearForm();
                }
                else if (response.StatusCode == System.Net.HttpStatusCode.Conflict)
                {
                    MessageBox.Show("Role already exists.", "Conflict", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Failed to add role.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding role: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task DeleteRoleAsync()
        {
            if (!int.TryParse(txtRoleId.Text, out int roleId))
            {
                MessageBox.Show("Please select a valid role to delete.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirmResult = MessageBox.Show("Are you sure you want to delete this role?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmResult != DialogResult.Yes) return;

            try
            {
                var response = await _httpClient.DeleteAsync($"role/{roleId}");
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Role deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    await LoadRolesAsync();
                    ClearForm();
                }
                else
                {
                    MessageBox.Show("Failed to delete role.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting role: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DgvRoles_SelectionChanged(object? sender, EventArgs e)
        {
            if (dgvRoles.CurrentRow?.DataBoundItem is RoleReadDto selectedRole)
            {
                txtRoleId.Text = selectedRole.Id.ToString();
                txtRoleName.Text = selectedRole.Name;
            }
        }

        private void ClearForm()
        {
            txtRoleId.Text = "";
            txtRoleName.Text = "";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private async void Role_Load(object sender, EventArgs e)
        {
            await LoadRolesAsync();
        }
    }
}

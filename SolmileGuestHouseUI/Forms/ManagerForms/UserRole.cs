using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http.Json;
using SolmileGuesthouseAPI.DTO.NavigatorModel;
using System.Text.Json;

namespace SolmileGuestHouseUI.Forms.ManagerForms
{
    public partial class UserRole : UserControl
    {
        private readonly HttpClient _httpClient = new HttpClient();
        private const string BaseUrl = "https://localhost:7107/api/userroles";

        // Cache users and roles to avoid reloading on every cell click
        private List<User> _users = new List<User>();
        private List<Role> _roles = new List<Role>();

        public UserRole()
        {
            InitializeComponent();
            _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            InitializeAsync();
        }

        public async Task InitializeAsync()
        {
            await LoadUserRolesAsync();
            await LoadUsersAsync();
            await LoadRolesAsync();

            btnAssign.Click -= BtnAssign_Click;
            btnAssign.Click += BtnAssign_Click;

            btnRemove.Click -= BtnRemove_Click;
            btnRemove.Click += BtnRemove_Click;

            dgvUserRoles.CellClick -= dgvUserRoles_CellClick;
            dgvUserRoles.CellClick += dgvUserRoles_CellClick;
        }

        private async Task LoadUsersAsync()
        {
            try
            {
                _users = await _httpClient.GetFromJsonAsync<List<User>>("https://localhost:7107/api/Users");
                cbUsers.DataSource = _users;
                cbUsers.DisplayMember = "Username";
                cbUsers.ValueMember = "UserId";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading users:\n{ex.Message}", "Load Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task LoadRolesAsync()
        {
            try
            {
                _roles = await _httpClient.GetFromJsonAsync<List<Role>>("https://localhost:7107/api/Role");
                cbRoles.DataSource = _roles;
                cbRoles.DisplayMember = "Name";
                cbRoles.ValueMember = "RoleId";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading roles:\n{ex.Message}", "Load Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task LoadUserRolesAsync()
        {
            try
            {
                var userRoles = await _httpClient.GetFromJsonAsync<List<UserRoleDto>>($"{BaseUrl}/all");
                dgvUserRoles.DataSource = userRoles;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading user roles:\n{ex.Message}", "Load Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void BtnAssign_Click(object sender, EventArgs e)
        {
            await UpdateRoleAsync();
        }

        private async void BtnRemove_Click(object sender, EventArgs e)
        {
            await RemoveRoleAsync();
        }

        private async Task UpdateRoleAsync()
        {
            // Validate selections
            if (cbUsers.SelectedItem is not User user || cbRoles.SelectedItem is not Role role)
            {
                ShowMessage("Please select both a user and role", "Missing Selection", MessageBoxIcon.Information);
                return;
            }

            // Validate role name (prevent empty strings)
            if (string.IsNullOrWhiteSpace(role.Name))
            {
                ShowMessage("Selected role has no name", "Invalid Role", MessageBoxIcon.Error);
                return;
            }

            var payload = new UpdateRoleAssignRequest
            {
                UserName = user.Username,
                RoleName = role.Name.Trim() 
            };

            try
            {
                // Clear previous request headers
                _httpClient.DefaultRequestHeaders.Remove("Authorization");

                var response = await _httpClient.PutAsJsonAsync($"{BaseUrl}/update", payload);

                if (!response.IsSuccessStatusCode)
                {
                    var errorResponse = await response.Content.ReadFromJsonAsync<ApiErrorResponse>();
                    ShowMessage(
                        $"API Error ({response.StatusCode}): {errorResponse?.Message ?? "Unknown error"}",
                        "Update Failed",
                        MessageBoxIcon.Error);
                    return;
                }

                var successResponse = await response.Content.ReadFromJsonAsync<ApiSuccessResponse>();
                ShowMessage(
                    $"Assigned {role.Name} to {user.Username}\nNew Position: {successResponse?.Position}",
                    "Success",
                    MessageBoxIcon.Information);

                await LoadUserRolesAsync();
            }
            catch (HttpRequestException ex)
            {
                ShowMessage(
                    $"Network error: {ex.Message}\nCheck connection and retry.",
                    "Network Issue",
                    MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                ShowMessage(
                    $"Unexpected error: {ex.Message}",
                    "Error",
                    MessageBoxIcon.Error);
            }
        }
        private void ShowMessage(string text, string caption, MessageBoxIcon icon)
        {
            MessageBox.Show(text, caption, MessageBoxButtons.OK, icon);
        }
        private async Task RemoveRoleAsync()
        {
            if (dgvUserRoles.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a role assignment from the list to remove it.");
                return;
            }

            var selected = (UserRoleDto)dgvUserRoles.SelectedRows[0].DataBoundItem;

            var confirm = MessageBox.Show(
                $"Are you sure you want to remove the role '{selected.RoleName}' from user '{selected.Username}'?",
                "Confirm Removal",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirm != DialogResult.Yes)
                return;

            try
            {
                var requestPayload = new
                {
                    UserId = selected.UserId,
                    RoleId = selected.RoleId
                };

                var requestMessage = new HttpRequestMessage(HttpMethod.Delete, $"{BaseUrl}/remove")
                {
                    Content = JsonContent.Create(requestPayload)
                };

                var response = await _httpClient.SendAsync(requestMessage);
                response.EnsureSuccessStatusCode();

                MessageBox.Show(
                    $"The role '{selected.RoleName}' has been removed from user '{selected.Username}'.",
                    "Removal Successful",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                await LoadUserRolesAsync();
            }
            catch (HttpRequestException)
            {
                MessageBox.Show("Failed to connect to the server. Check your network connection.", "Network Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unexpected error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvUserRoles_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvUserRoles.Rows[e.RowIndex];
                int selectedUserId = Convert.ToInt32(row.Cells["UserId"].Value);
                int selectedRoleId = Convert.ToInt32(row.Cells["RoleId"].Value);

                // Set the selected values on the already loaded ComboBoxes
                cbUsers.SelectedValue = selectedUserId;
                cbRoles.SelectedValue = selectedRoleId;
            }
        }

        public class User
        {
            public int UserId { get; set; }
            public string Username { get; set; }
            public override string ToString() => Username;
        }

        public class Role
        {
            public int RoleId { get; set; }
            public string Name { get; set; }
            public override string ToString() => Name;
        }
    }
}

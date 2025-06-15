using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using SolmileGuestHouseUI.Forms.AdminForms;
using static SolmileGuesthouseAPI.DTO.NavigatorModel.DTOs;

namespace SolmileGuestHouseUI.Forms.ManagerForms
{
    public partial class User : UserControl
    {
        public InputUserDto SelectedItem { get; private set; }
        private readonly HttpClient _client = new HttpClient { BaseAddress = new Uri("https://localhost:7107/") };

        public User()
        {
            InitializeComponent();
            dgvUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            LoadUsersAsync();
        }

        private async void btnLoadUsers_Click(object sender, EventArgs e)
        {
            await LoadUsersAsync();
        }
        private async Task LoadUsersAsync()
        {
            btnLoadUsers.Enabled = false;

            try
            {
                var response = await _client.GetAsync("api/Users");
                response.EnsureSuccessStatusCode();

                var json = await response.Content.ReadAsStringAsync();
                var users = JsonSerializer.Deserialize<List<UserDto>>(json, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

                dgvUsers.DataSource = users;
                if (dgvUsers.Columns["Password"] != null)
                    dgvUsers.Columns["Password"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading users: {ex.Message}");
            }
            finally
            {
                btnLoadUsers.Enabled = true;
            }
        }
        private async Task<object> GetUserByInputAsync(string input)
        {
            HttpResponseMessage response;

            if (int.TryParse(input, out int id))
            {
                response = await _client.GetAsync($"api/Users/{id}");
            }
            else
            {
                var payload = new { Username = input };
                var content = new StringContent(JsonSerializer.Serialize(payload), Encoding.UTF8, "application/json");
                response = await _client.PostAsync("api/Users/find-by-username", content);
            }

            if (!response.IsSuccessStatusCode)
                return null;

            var json = await response.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<UserDto>(json, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
        }

        private async void btnDeleteUser_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtUserId.Text, out int id))
            {
                MessageBox.Show("Invalid User ID");
                return;
            }

            btnDeleteUser.Enabled = false;
            try
            {
                var response = await _client.DeleteAsync($"api/Users/{id}");
                if (response.IsSuccessStatusCode)
                    MessageBox.Show("User deleted successfully");
                else
                    MessageBox.Show("Delete failed");
                ClearFormFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting user: {ex.Message}");
            }
            finally
            {
                btnDeleteUser.Enabled = true;
            }
        }

        private async void btnUpdateUser_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtUserId.Text, out int id))
            {
                MessageBox.Show("Invalid User ID");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtUsername.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Username and Password cannot be empty");
                return;
            }

            btnUpdateUser.Enabled = false;
            try
            {
                var userDto = new
                {
                    Username = txtUsername.Text,
                    Password = txtPassword.Text
                };

                var content = new StringContent(JsonSerializer.Serialize(userDto), Encoding.UTF8, "application/json");
                var response = await _client.PutAsync($"api/Users/UpdateUser/{id}", content);

                if (response.IsSuccessStatusCode)
                    MessageBox.Show("User updated successfully");

                else
                    MessageBox.Show("Update failed");
                ClearFormFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating user: {ex.Message}");
            }
            finally
            {
                btnUpdateUser.Enabled = true;
            }
        }
        private async void btnLock_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtUserId.Text, out int id))
            {
                MessageBox.Show("Invalid User ID");
                return;
            }

            btnLock.Enabled = false;
            try
            {
                var response = await _client.PostAsync($"api/Users/lock?userId={id}", null);
                var message = await response.Content.ReadAsStringAsync();
                MessageBox.Show(message);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error locking user: {ex.Message}");
            }
            finally
            {
                btnLock.Enabled = true;
            }
        }

        private async void btnUnlock_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtUserId.Text, out int id))
            {
                MessageBox.Show("Invalid User ID");
                return;
            }

            btnUnlock.Enabled = false;
            try
            {
                int adminId = 1;
                var response = await _client.PostAsync($"api/Users/unlock?adminId={adminId}&userId={id}", null);
                var message = await response.Content.ReadAsStringAsync();
                MessageBox.Show(message);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error unlocking user: {ex.Message}");
            }
            finally
            {
                btnUnlock.Enabled = true;
            }
        }

        private async void btnIsLocked_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtUserId.Text, out int id))
            {
                MessageBox.Show("Invalid User ID");
                return;
            }

            btnIsLocked.Enabled = false;
            try
            {
                var response = await _client.GetAsync($"api/Users/IsLocked/{id}");
                response.EnsureSuccessStatusCode();

                var message = await response.Content.ReadAsStringAsync();
                MessageBox.Show(message);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error checking lock status: {ex.Message}");
            }
            finally
            {
                btnIsLocked.Enabled = true;
            }
        }

        private async void btnGetLockedUsers_Click(object sender, EventArgs e)
        {
            btnGetLockedUsers.Enabled = false;
            try
            {
                var response = await _client.GetAsync("api/Users/Locked");
                response.EnsureSuccessStatusCode();

                var json = await response.Content.ReadAsStringAsync();
                var users = JsonSerializer.Deserialize<List<UserDto>>(json, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

                dgvUsers.DataSource = users;
                if (dgvUsers.Columns["Password"] != null)
                    dgvUsers.Columns["Password"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading locked users: {ex.Message}");
            }
            finally
            {
                btnGetLockedUsers.Enabled = true;
            }
        }
        private async void btnCheckUsername_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                MessageBox.Show("Please enter a username");
                return;
            }

            btnCheckUsername.Enabled = false;
            try
            {
                var payload = new { Username = txtUsername.Text };
                var content = new StringContent(JsonSerializer.Serialize(payload), Encoding.UTF8, "application/json");
                var response = await _client.PostAsync("api/Users/check-exists", content);
                response.EnsureSuccessStatusCode();

                var message = await response.Content.ReadAsStringAsync();
                MessageBox.Show(message);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error checking username: {ex.Message}");
            }
            finally
            {
                btnCheckUsername.Enabled = true;
            }
        }
        private void dgvUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgvUsers.Rows[e.RowIndex];

                if (row.DataBoundItem is UserDto user)
                {
                    txtUserId.Text = user.Id.ToString();
                    txtUsername.Text = user.Username;
                    txtPassword.Text = user.Password;
                }
            }
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFormFields();
            LoadUsersAsync();
        }
        private void ClearFormFields()
        {
            txtUserId.Clear();
            txtUsername.Clear();
            txtPassword.Clear();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var searchForm = new SearchByInputForm("Search User by ID or Username", GetUserByInputAsync);
            if (searchForm.ShowDialog() == DialogResult.OK)
            {
                var user = searchForm.SelectedItem as InputUserDto;
                if (user != null)
                {
                    MessageBox.Show($"User found: {user.Username}");
                    dgvUsers.DataSource = new List<InputUserDto> { user };
                }
                else
                {
                    MessageBox.Show("No user selected or found.");
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using SolmileGuestHouseUI.Forms.AdminForms;
using static SolmileGuesthouseAPI.DTO.NavigatorModel.DTOs;
using System.Drawing;
using Twilio.TwiML.Messaging;

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

        private void ShowSuccessMessage(string message)
        {
            MessageBox.Show(message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ShowErrorMessage(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void ShowWarningMessage(string message)
        {
            MessageBox.Show(message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private async void btnLoadUsers_Click(object sender, EventArgs e)
        {
            await LoadUsersAsync();
        }

        private async Task LoadUsersAsync()
        {
            btnLoadUsers.Enabled = false;
            btnLoadUsers.Text = "Loading...";

            try
            {
                var response = await _client.GetAsync("api/Users");
                response.EnsureSuccessStatusCode();

                var json = await response.Content.ReadAsStringAsync();
                var users = JsonSerializer.Deserialize<List<UserDto>>(json, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

                dgvUsers.DataSource = users;
                if (dgvUsers.Columns["Password"] != null)
                    dgvUsers.Columns["Password"].Visible = false;

                //ShowSuccessMessage($"Successfully loaded {users.Count} user(s)");
            }
            catch (Exception ex)
            {
                ShowErrorMessage($"Failed to load users.\n\nError details: {ex.Message}");
            }
            finally
            {
                btnLoadUsers.Enabled = true;
                btnLoadUsers.Text = "Load Users";
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
                ShowWarningMessage("Please enter a valid numeric User ID.");
                return;
            }

            var confirmResult = MessageBox.Show($"Are you sure you want to delete user with ID {id}?",
                                             "Confirm Deletion",
                                             MessageBoxButtons.YesNo,
                                             MessageBoxIcon.Question);
            if (confirmResult != DialogResult.Yes)
                return;

            btnDeleteUser.Enabled = false;
            btnDeleteUser.Text = "Deleting...";

            try
            {
                var response = await _client.DeleteAsync($"api/Users/{id}");
                if (response.IsSuccessStatusCode)
                {
                    ShowSuccessMessage($"User with ID {id} was deleted successfully");
                    await LoadUsersAsync();
                }
                else
                {
                    ShowErrorMessage($"Delete failed. Server returned: {response.StatusCode}");
                }

                ClearFormFields();
            }
            catch (Exception ex)
            {
                ShowErrorMessage($"Failed to delete user.\n\nError details: {ex.Message}");
            }
            finally
            {
                btnDeleteUser.Enabled = true;
                btnDeleteUser.Text = "Delete User";
            }
        }

        private async void btnUpdateUser_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtUserId.Text, out int id))
            {
                ShowWarningMessage("Please enter a valid numeric User ID.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtUsername.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                ShowWarningMessage("Both Username and Password fields are required.");
                return;
            }

            btnUpdateUser.Enabled = false;
            btnUpdateUser.Text = "Updating...";

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
                {
                    ShowSuccessMessage($"User with ID {id} was updated successfully");
                    await LoadUsersAsync();
                }
                else
                {
                    ShowErrorMessage($"Update failed. Server returned: {response.StatusCode}");
                }

                ClearFormFields();
            }
            catch (Exception ex)
            {
                ShowErrorMessage($"Failed to update user.\n\nError details: {ex.Message}");
            }
            finally
            {
                btnUpdateUser.Enabled = true;
                btnUpdateUser.Text = "Update User";
            }
        }

        private async void btnLock_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtUserId.Text, out int id))
            {
                ShowWarningMessage("Please enter a valid numeric User ID.");
                return;
            }

            btnLock.Enabled = false;
            btnLock.Text = "Locking...";

            try
            {
                var response = await _client.PostAsync($"api/Users/lock?userId={id}", null);
                var message = await response.Content.ReadAsStringAsync();

                if (response.IsSuccessStatusCode)
                    ShowSuccessMessage($"User locked successfully.\n\nServer response: {message}");
                else
                    ShowErrorMessage($"Lock operation failed.\n\nServer response: {message}");
            }
            catch (Exception ex)
            {
                ShowErrorMessage($"Failed to lock user.\n\nError details: {ex.Message}");
            }
            finally
            {
                btnLock.Enabled = true;
                btnLock.Text = "Lock User";
            }
        }

        private async void btnUnlock_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtUserId.Text, out int id))
            {
                ShowWarningMessage("Please enter a valid numeric User ID.");
                return;
            }

            btnUnlock.Enabled = false;
            btnUnlock.Text = "Unlocking...";

            try
            {
                int adminId = 1;
                var response = await _client.PostAsync($"api/Users/unlock?adminId={adminId}&userId={id}", null);
                var message = await response.Content.ReadAsStringAsync();

                if (response.IsSuccessStatusCode)
                    ShowSuccessMessage($"User unlocked successfully.\n\nServer response: {message}");
                else
                    ShowErrorMessage($"Unlock operation failed.\n\nServer response: {message}");
            }
            catch (Exception ex)
            {
                ShowErrorMessage($"Failed to unlock user.\n\nError details: {ex.Message}");
            }
            finally
            {
                btnUnlock.Enabled = true;
                btnUnlock.Text = "Unlock User";
            }
        }

        private async void btnIsLocked_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtUserId.Text, out int id))
            {
                ShowWarningMessage("Please enter a valid numeric User ID.");
                return;
            }

            btnIsLocked.Enabled = false;
            btnIsLocked.Text = "Checking...";

            try
            {
                var response = await _client.GetAsync($"api/Users/IsLocked/{id}");
                response.EnsureSuccessStatusCode();

                var message = await response.Content.ReadAsStringAsync();
                var status = bool.Parse(message) ? "LOCKED" : "NOT LOCKED";
                ShowSuccessMessage($"User with ID {id} is currently: {status}");
            }
            catch (Exception ex)
            {
                ShowErrorMessage($"Failed to check lock status.\n\nError details: {ex.Message}");
            }
            finally
            {
                btnIsLocked.Enabled = true;
                btnIsLocked.Text = "Check Lock Status";
            }
        }

        private async void btnGetLockedUsers_Click(object sender, EventArgs e)
        {
            btnGetLockedUsers.Enabled = false;
            btnGetLockedUsers.Text = "Loading...";

            try
            {
                var response = await _client.GetAsync("api/Users/Locked");
                response.EnsureSuccessStatusCode();

                var json = await response.Content.ReadAsStringAsync();
                var users = JsonSerializer.Deserialize<List<UserDto>>(json, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

                dgvUsers.DataSource = users;
                if (dgvUsers.Columns["Password"] != null)
                    dgvUsers.Columns["Password"].Visible = false;

                ShowSuccessMessage($"Found {users.Count} locked user(s)");
            }
            catch (Exception ex)
            {
                ShowErrorMessage($"Failed to load locked users.\n\nError details: {ex.Message}");
            }
            finally
            {
                btnGetLockedUsers.Enabled = true;
                btnGetLockedUsers.Text = "Get Locked Users";
            }
        }
        private async void btnCheckUsername_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                ShowWarningMessage("Please enter a username to check.");
                return;
            }

            btnCheckUsername.Enabled = false;
            btnCheckUsername.Text = "Checking...";

            try
            {
                var payload = new { Username = txtUsername.Text };
                var content = new StringContent(JsonSerializer.Serialize(payload), Encoding.UTF8, "application/json");
                var response = await _client.PostAsync("api/Users/check-exists", content);
                response.EnsureSuccessStatusCode();

                var json = await response.Content.ReadAsStringAsync();
                var result = JsonSerializer.Deserialize<CheckUsernameResult>(json, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
                string status = result.Exists ? "already exists" : "is Not available";
                ShowSuccessMessage($"Username '{txtUsername.Text}' {status}.");
            }
            catch (Exception ex)
            {
                ShowErrorMessage($"Failed to check username.\n\nError details: {ex.Message}");
            }
            finally
            {
                btnCheckUsername.Enabled = true;
                btnCheckUsername.Text = "Check Username";
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
                    ShowSuccessMessage($"User found!\n\nID: {user.Id}\nUsername: {user.Username}");
                    dgvUsers.DataSource = new List<InputUserDto> { user };
                }
                else
                {
                    ShowWarningMessage("No user found with the specified criteria.");
                }
            }
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabControl.SelectedIndex)
            {
                case 0:
                    dgvUsers.Location = new Point(10, 144);
                    tabManageUsers.Controls.Add(dgvUsers);
                    txtUsername.Location = new Point(10, 40);
                    tabManageUsers.Controls.Add(txtUsername);
                    LoadUsersAsync();
                    break;
                case 1:
                    dgvUsers.Location = new Point(10, 131);
                    tabLockUnlock.Controls.Add(dgvUsers);
                    txtUsername.Location = new Point(32, 21);
                    tabLockUnlock.Controls.Add(txtUsername);
                    LoadUsersAsync();
                    break;
                case 2:
                    dgvUsers.Location = new Point(10, 115);
                    tabUtility.Controls.Add(dgvUsers);
                    txtUsername.Location = new Point(30, 20);
                    tabUtility.Controls.Add(txtUsername);
                    LoadUsersAsync();
                    break;
            }
        }
        private class CheckUsernameResult
        {
            public bool Exists { get; set; }
        }
    }
}

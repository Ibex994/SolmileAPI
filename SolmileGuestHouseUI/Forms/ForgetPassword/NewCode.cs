using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SolmileGuestHouseUI.Forms.ForgetPassword
{
    public partial class NewCode : UserControl
    {
        public string UsernameForReset { get; set; }
        public string UsernameToVerify { get; set; }
        public string ResetToken { get; set; }

        public event EventHandler PasswordResetSuccess;

        public NewCode()
        {
            InitializeComponent();
        }
        private async void resetPasswordBtn_Click(object sender, EventArgs e)
        {
            string newPassword = NewPassTxt.Text.Trim();
            string confirmPassword = ConPassTxt.Text.Trim();

            if (string.IsNullOrEmpty(newPassword) || string.IsNullOrEmpty(confirmPassword))
            {
                MessageBox.Show("Please enter and confirm your new password.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (newPassword.Length < 8 ||
                !Regex.IsMatch(newPassword, @"[A-Z]") ||
                !Regex.IsMatch(newPassword, @"[a-z]") ||
                !Regex.IsMatch(newPassword, @"\d") ||
                !Regex.IsMatch(newPassword, @"[!@#$%^&*()_+=\[{\]};:<>|./?,-]")
               )
            {
                MessageBox.Show("Password must be at least 8 characters long and include at least one uppercase letter, one lowercase letter, one digit, and one special character.",
                                "Weak Password", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                NewPassTxt.Focus();
                NewPassTxt.SelectAll();
                return;
            }

            if (newPassword != confirmPassword)
            {
                MessageBox.Show("New password and confirm password do not match.", "Input Mismatch", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                NewPassTxt.Focus();
                ConPassTxt.SelectAll();
                return;
            }

            if (string.IsNullOrEmpty(ResetToken) || string.IsNullOrEmpty(UsernameForReset))
            {
                MessageBox.Show("Required information (username or reset token) is missing. Please restart the password reset process.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            resetPasswordBtn.Enabled = false;
            resetPasswordBtn.Text = "Resetting...";

            bool passwordChangeSuccessful = await ChangePasswordApi(UsernameForReset, ResetToken, newPassword, confirmPassword);

            resetPasswordBtn.Enabled = true;
            resetPasswordBtn.Text = "Reset Password";

            if (passwordChangeSuccessful)
            {
                MessageBox.Show("Your password has been successfully reset. You can now log in with your new password.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                PasswordResetSuccess?.Invoke(this, EventArgs.Empty);
            }
            else
            {
                NewPassTxt.Clear();
                usernameDisplayTxt.Clear();
                NewPassTxt.Focus();
            }
        }
        private async Task<bool> ChangePasswordApi(string username, string resetToken, string newPassword, string confirmPassword)
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:7107/");
                string apiUrl = "api/Users/reset-password";

                var requestBody = new
                {
                    username = username,
                    resetToken = resetToken,
                    newPassword = newPassword,
                    confirmPassword = confirmPassword
                };

                string jsonBody = JsonSerializer.Serialize(requestBody);
                var content = new StringContent(jsonBody, Encoding.UTF8, "application/json");

                try
                {
                    HttpResponseMessage response = await client.PostAsync(apiUrl, content);
                    string responseContent = await response.Content.ReadAsStringAsync();

                    if (response.IsSuccessStatusCode)
                    {
                        return true;
                    }
                    else
                    {
                        string errorMessage = "Failed to reset password.";
                        try
                        {
                            using (JsonDocument doc = JsonDocument.Parse(responseContent))
                            {
                                JsonElement root = doc.RootElement;
                                if (root.TryGetProperty("message", out JsonElement messageElement) && messageElement.ValueKind == JsonValueKind.String)
                                {
                                    errorMessage = messageElement.GetString();
                                }
                                else if (root.TryGetProperty("error", out JsonElement errorElement) && errorElement.ValueKind == JsonValueKind.String)
                                {
                                    errorMessage = errorElement.GetString();
                                }
                                else if (root.TryGetProperty("errors", out JsonElement errorsElement) && errorsElement.ValueKind == JsonValueKind.Object)
                                {
                                    var errorMessages = new List<string>();
                                    foreach (var prop in errorsElement.EnumerateObject())
                                    {
                                        if (prop.Value.ValueKind == JsonValueKind.Array)
                                        {
                                            foreach (var item in prop.Value.EnumerateArray())
                                            {
                                                errorMessages.Add(item.GetString());
                                            }
                                        }
                                    }
                                    if (errorMessages.Any())
                                    {
                                        errorMessage = string.Join(Environment.NewLine, errorMessages);
                                    }
                                }
                            }
                        }
                        catch (JsonException)
                        {
                            errorMessage = $"API responded with status code {response.StatusCode}. Content: {responseContent}";
                        }

                        MessageBox.Show($"Password Reset Failed: {errorMessage}", "API Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
                catch (HttpRequestException httpEx)
                {
                    MessageBox.Show($"Could not connect to the server: {httpEx.Message}", "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An unexpected error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }
        private void NewCode_Load_1(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(UsernameForReset))
            {
                usernameDisplayTxt.Text = UsernameForReset;
                usernameDisplayTxt.Enabled = false;
            }

            MessageBox.Show($"Received Username: {UsernameForReset}, Token: {ResetToken}");
        }
    }
}

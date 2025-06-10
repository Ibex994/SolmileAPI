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
    {// These properties will be set by the calling form (ForgetPassword.cs)
        public string UsernameForReset { get; set; }
        public string UsernameToVerify { get; set; }
        public string ResetToken { get; set; }

        // Event to signal the parent form (or application) that the password reset is complete
        public event EventHandler PasswordResetSuccess;

        public NewCode()
        {
            InitializeComponent();
        }

        private async void resetPasswordBtn_Click(object sender, EventArgs e)
        {
            string newPassword = NewPassTxt.Text.Trim();
            string confirmPassword = ConPassTxt.Text.Trim();

            // --- Input Validation ---
            if (string.IsNullOrEmpty(newPassword) || string.IsNullOrEmpty(confirmPassword))
            {
                MessageBox.Show("Please enter and confirm your new password.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            } 
            if (newPassword.Length < 8 ||
                !Regex.IsMatch(newPassword, @"[A-Z]") || // At least one uppercase
                !Regex.IsMatch(newPassword, @"[a-z]") || // At least one lowercase
                !Regex.IsMatch(newPassword, @"\d") ||    // At least one digit
                !Regex.IsMatch(newPassword, @"[!@#$%^&*()_+=\[{\]};:<>|./?,-]") // At least one special character
               )
            {
                MessageBox.Show("Password must be at least 8 characters long and include at least one uppercase letter, one lowercase letter, one digit, and one special character.",
                                "Weak Password", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                NewPassTxt.Focus();
                NewPassTxt.SelectAll();
                return;
            }

            if (newPassword != confirmPassword) // This is the line causing your error
            {
                MessageBox.Show("New password and confirm password do not match.", "Input Mismatch", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                NewPassTxt.Focus();
                ConPassTxt.SelectAll();
                return; // Stops the method execution here
            }


            // Ensure ResetToken and UsernameForReset are available
            if (string.IsNullOrEmpty(ResetToken) || string.IsNullOrEmpty(UsernameForReset))
            {
                MessageBox.Show("Required information (username or reset token) is missing. Please restart the password reset process.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // --- Disable UI during API call ---
            resetPasswordBtn.Enabled = false;
            resetPasswordBtn.Text = "Resetting...";

            // --- API Call to Change Password ---
            bool passwordChangeSuccessful = await ChangePasswordApi(UsernameForReset, ResetToken, newPassword, confirmPassword);

            // --- Re-enable UI and handle result ---
            resetPasswordBtn.Enabled = true;
            resetPasswordBtn.Text = "Reset Password";

            if (passwordChangeSuccessful)
            {
                MessageBox.Show("Your password has been successfully reset. You can now log in with your new password.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Raise the event to notify the parent form (ForgetPasswordForm)
                PasswordResetSuccess?.Invoke(this, EventArgs.Empty);

                // *** CRITICAL: DO NOT call Close() here in NewCode.cs ***
                // *** Leave it commented or remove it completely. ***
                // this.FindForm()?.Close(); // <--- This line should NOT be here if you want parent to control closing
            }
            else
            {
                // API call failed, keep the form open for user to retry
                NewPassTxt.Clear();
                usernameDisplayTxt.Clear();
                NewPassTxt.Focus();
            }
        }

        private async Task<bool> ChangePasswordApi(string username, string resetToken, string newPassword, string confirmPassword)
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:7107/"); // Your API base URL
                string apiUrl = "api/Users/reset-password"; // Your specific API endpoint

                var requestBody = new
                {
                    username = username, // Include username if your API requires it for reset (often it does)
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
                                // Check for common validation errors from API (e.g., from ModelState)
                                else if (root.TryGetProperty("errors", out JsonElement errorsElement) && errorsElement.ValueKind == JsonValueKind.Object)
                                {
                                    // This handles typical ASP.NET Core validation errors
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
            // You can use UsernameForReset to display a label, e.g.:
            if (!string.IsNullOrEmpty(UsernameForReset))
            {
                // Assuming you have a Label control named 'usernameDisplayTxt' on your NewCode designer
                usernameDisplayTxt.Text = UsernameForReset;
                usernameDisplayTxt.Enabled = false;
            }
            // For debugging: show if token is received
            MessageBox.Show($"Received Username: {UsernameForReset}, Token: {ResetToken}");
        }
    }
}

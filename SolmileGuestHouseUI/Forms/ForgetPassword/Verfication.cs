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
using System.Net.Http; // Make sure this is included for HttpClient

namespace SolmileGuestHouseUI.Forms.ForgetPassword
{
    public partial class Verfication : UserControl
    {
        private readonly Form _forgetPassword;
        public string UsernameToVerify { get; set; }
        public string VerifiedOtpCode { get; private set; }
        public string VerifiedResetToken { get; private set; }
        public string EnteredUsername
        {
            get { return usernametxt.Text.Trim(); }
        }

        // REMOVE THIS LINE: public TextBox usernameTxt;
        // The textbox named 'usernametxt' (or whatever you named it in the designer)
        // is already declared in the designer-generated .Designer.cs file for this partial class.
        // If your designer textbox is actually named 'usernameTxt' (with a capital T),
        // ensure consistent casing when referring to it.
        // Assuming your designer textbox is named 'usernametxt' (all lowercase 't') based on your usage in methods.

        public event EventHandler OtpVerificationSuccess;

        // Default constructor
        public Verfication()
        {
            InitializeComponent(); // Initialize all designer components
            // No need to set usernameTxt.Text here. Use the OnLoad event.
        }

        // Constructor to pass the parent form
        public Verfication(Form forgetPassword) : this() // Call the default constructor first, which calls InitializeComponent()
        {
            // Do NOT call InitializeComponent() again here. It's already done by :this().
            _forgetPassword = forgetPassword;
            this.AutoSize = false;
            // No need to set usernameTxt.Text here. Use the OnLoad event.
        }

        // Use the Load event to set properties that depend on controls being initialized
        private void Verfication_Load(object sender, EventArgs e)
        {
            this.AutoSize = false;
            // You called base.OnLoad(e); here, but it's not strictly necessary in a simple Load event handler.
            // However, if you had overridden OnLoad in the UserControl itself, you would keep it.
            // For a simple event handler, it's fine as is.

            if (!string.IsNullOrEmpty(UsernameToVerify))
            {
                // Ensure 'usernametxt' matches the actual name of your TextBox control in the designer.
                usernametxt.Text = UsernameToVerify;
                usernametxt.Enabled = false; // Optional: disable if pre-filled
            }
        }

        private void Backbtn_Click(object sender, EventArgs e)
        {
            if (this.Parent is Form currentHostForm && _forgetPassword != null)
            {
                currentHostForm.Hide();
                _forgetPassword.Show();
                currentHostForm.Close();
            }
            else
            {
                this.Hide();
            }
        }

        private async void checkOTPbtn_Click(object sender, EventArgs e)
        {
            // Ensure 'usernametxt' here matches the actual name of your TextBox control in the designer.
            string username = usernametxt.Text.Trim();
            string otpCode = otpTxt.Text.Trim(); // Assuming otpTxt is correctly named in designer

            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Please enter your username.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                usernametxt.Focus();
                return;
            }

            if (string.IsNullOrEmpty(otpCode))
            {
                MessageBox.Show("Please enter the OTP.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                otpTxt.Focus();
                return;
            }

            if (!Regex.IsMatch(otpCode, @"^\d+$"))
            {
                MessageBox.Show("The OTP should contain only digits.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                otpTxt.Focus();
                otpTxt.SelectAll();
                return;
            }

            const int expectedOtpLength = 6;
            if (otpCode.Length != expectedOtpLength)
            {
                MessageBox.Show($"The OTP must be {expectedOtpLength} digits long.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                otpTxt.Focus();
                otpTxt.SelectAll();
                return;
            }

            checkOTPbtn.Enabled = false;
            checkOTPbtn.Text = "Verifying OTP...";
            checkOTPbtn.Size = new Size(150, 26);
            checkOTPbtn.Location = new Point(252, 222); // Adjusted position to match the original button

            bool otpVerified = await VerifyOtpOnly(username, otpCode);

            if (otpVerified)
            {
                MessageBox.Show("OTP verified successfully! You can now set your new password.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                OtpVerificationSuccess?.Invoke(this, EventArgs.Empty);
            }
            else
            {
                checkOTPbtn.Enabled = true;
                checkOTPbtn.Text = "Verify OTP";
                otpTxt.Focus();
                otpTxt.SelectAll();
            }
        }

        private async Task<bool> VerifyOtpOnly(string username, string otpCode)
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:7107/");
                string apiUrl = "api/Users/verify-otp";

                var requestBody = new { username = username, code = otpCode };
                string jsonBody = JsonSerializer.Serialize(requestBody);
                var content = new StringContent(jsonBody, Encoding.UTF8, "application/json");

                try
                {
                    HttpResponseMessage response = await client.PostAsync(apiUrl, content);
                    string responseContent = await response.Content.ReadAsStringAsync();

                    if (response.IsSuccessStatusCode)
                    {
                        using (JsonDocument doc = JsonDocument.Parse(responseContent))
                        {
                            var root = doc.RootElement;
                            if (root.TryGetProperty("resetToken", out JsonElement tokenElement))
                            {
                                VerifiedResetToken = tokenElement.GetString();
                                VerifiedOtpCode = otpCode; // Store the OTP code if needed, though reset token is primary
                            }
                        }
                        return true;
                    }
                    else
                    {
                        string errorMessage = "Failed to verify OTP.";
                        try
                        {
                            using (JsonDocument doc = JsonDocument.Parse(responseContent))
                            {
                                JsonElement root = doc.RootElement;
                                if (root.TryGetProperty("message", out JsonElement messageElement))
                                    errorMessage = messageElement.GetString();
                            }
                        }
                        catch (JsonException) { /* Handle cases where response is not valid JSON */ }

                        MessageBox.Show($"OTP Verification Failed: {errorMessage}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    MessageBox.Show($"Unexpected error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }
    }
}
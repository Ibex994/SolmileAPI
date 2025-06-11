using System;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        public event EventHandler OtpVerificationSuccess;
        public Verfication()
        {
            InitializeComponent();
        }
        public Verfication(Form forgetPassword) : this()
        {
            _forgetPassword = forgetPassword;
            this.AutoSize = false;
        }
        private void Verfication_Load(object sender, EventArgs e)
        {
            this.AutoSize = false;

            if (!string.IsNullOrEmpty(UsernameToVerify))
            {
                usernametxt.Text = UsernameToVerify;
                usernametxt.Enabled = false;
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
            string username = usernametxt.Text.Trim();
            string otpCode = otpTxt.Text.Trim();

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
            checkOTPbtn.Size = new System.Drawing.Size(150, 28);
            checkOTPbtn.Location = new System.Drawing.Point(252, 222);

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
                                VerifiedOtpCode = otpCode;
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
                        catch (JsonException) { }

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

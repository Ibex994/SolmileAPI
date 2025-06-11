using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
    namespace SolmileGuestHouseUI.Forms.ForgetPassword
    {
    public partial class ForgetPassword : Form
    {
        private Form _loginForm;

        public ForgetPassword(Form loginForm)
        {
            InitializeComponent();
            _loginForm = loginForm;
        }

        private void pictureBoxMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Backbtn_Click(object sender, EventArgs e)
        {
            this.Close();
            _loginForm.Show();
        }
        private async void Otpbtn_Click(object sender, EventArgs e)
        {
            string identifier = usertxtbox.Text.Trim();

            if (string.IsNullOrEmpty(identifier))
            {
                MessageBox.Show("Please enter your username.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                usertxtbox.Focus();
                return;
            }
            Otpbtn.Enabled = false;
            Otpbtn.Text = "Sending OTP...";
            Otpbtn.Size = new Size(150, 28);
            Otpbtn.Location = new Point(252, 222);

            bool otpRequestSuccessful = await RequestOtpThroughForgotPasswordApi(identifier);

            Otpbtn.Enabled = true;
            Otpbtn.Text = "Get OTP";

            if (otpRequestSuccessful)
            {
                Verfication verifyControl = new Verfication(this);

                verifyControl.UsernameToVerify = identifier;

                verifyControl.OtpVerificationSuccess += VerificationControl_OtpVerificationSuccess;
                Form verificationContainerForm = new Form();
                verificationContainerForm.Text = "Verify OTP";
                verificationContainerForm.Controls.Add(verifyControl);
                verifyControl.Dock = DockStyle.Fill;
                verificationContainerForm.Size = verifyControl.MinimumSize.IsEmpty ? new System.Drawing.Size(400, 300) : verifyControl.MinimumSize;
                verificationContainerForm.StartPosition = FormStartPosition.CenterScreen;

                this.Hide(); 
                verificationContainerForm.ShowDialog(); 
                if (!verificationContainerForm.IsDisposed) 
                {
                    this.Show();
                }
                else
                {
                    this.Close();
                }
            }
        }

        private async Task<bool> RequestOtpThroughForgotPasswordApi(string identifier)
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:7107/");
                string apiUrl = "api/Users/forgot-password";
                var requestBody = new { username = identifier };
                string jsonBody = JsonSerializer.Serialize(requestBody);
                var content = new StringContent(jsonBody, Encoding.UTF8, "application/json");

                try
                {
                    HttpResponseMessage response = await client.PostAsync(apiUrl, content);
                    string responseContent = await response.Content.ReadAsStringAsync();

                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("OTP sent successfully! Please check your email or phone for the verification code.",
                                        "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return true;
                    }
                    else
                    {
                        string errorMessage = "An unknown error occurred.";
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
                            }
                        }
                        catch (JsonException)
                        {
                            errorMessage = $"API responded with status code {response.StatusCode}. Content: {responseContent}";
                        }

                        MessageBox.Show($"Failed to send OTP: {errorMessage}", "API Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
                catch (HttpRequestException httpEx)
                {
                    MessageBox.Show($"Could not connect to the server. Please check your internet connection or try again later. Details: {httpEx.Message}",
                                    "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An unexpected error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }
        private void NewCodeControl_PasswordResetSuccess(object sender, EventArgs e)
        {
            if (sender is NewCode newCodeControl)
            {
                Form hostForm = newCodeControl.FindForm();
                if (hostForm != null)
                {
                    hostForm.Close();
                }
            }
            this.Close();

            if (_loginForm != null && !_loginForm.IsDisposed)
            {
                _loginForm.Show();
            }
            else
            {
                MessageBox.Show("Login form reference is invalid. Please restart the application.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit(); 
            }
        }
        private void VerificationControl_OtpVerificationSuccess(object sender, EventArgs e)
        {
            if (sender is Verfication verifiedOtpControl)
            {
                string username = verifiedOtpControl.EnteredUsername; 
                string resetToken = verifiedOtpControl.VerifiedResetToken;
                NewCode newCodeControl = new NewCode();
                newCodeControl.PasswordResetSuccess += NewCodeControl_PasswordResetSuccess;
                newCodeControl.UsernameForReset = username;
                newCodeControl.ResetToken = resetToken;
                Form newPasswordContainerForm = new Form();
                newPasswordContainerForm.Text = "Set New Password";
                newPasswordContainerForm.Controls.Add(newCodeControl);
                newCodeControl.Dock = DockStyle.Fill;
                newPasswordContainerForm.Size = newCodeControl.MinimumSize.IsEmpty ? new System.Drawing.Size(400, 300) : newCodeControl.MinimumSize;
                newPasswordContainerForm.StartPosition = FormStartPosition.CenterScreen;

                Form currentVerificationHostForm = verifiedOtpControl.FindForm();
                if (currentVerificationHostForm != null)
                {
                    currentVerificationHostForm.Hide();
                    currentVerificationHostForm.Dispose(); 
                }
                newPasswordContainerForm.ShowDialog();
            }
        }
    }
}

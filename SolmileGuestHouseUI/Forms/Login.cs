using System.Data.Common;
using System.IdentityModel.Tokens.Jwt;
using System.Net.Http.Json;
using System.Text.Json;
using Solmile.Forms;
using Solmile.Forms.ManagerForms;
using Solmile.Interface;
using Solmile.Service;
using SolmileGuesthouseAPI.DTO.NavigatorModel;

namespace Solmile
{
    public partial class Login : Form
    {
        private readonly IUserService _userService;
        public Login(IUserService userService)
        {
            InitializeComponent();
            _userService = userService;
        }



        private void pictureBoxShow_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBoxShow, "Show Password");
        }

        private void pictureBoxHide_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBoxHide, "Hide Password");
        }

        private void pictureBoxShow_Click(object sender, EventArgs e)
        {
            pictureBoxShow.Hide();
            textBoxPassword.UseSystemPasswordChar = false;
            pictureBoxHide.Show();
        }

        private void pictureBoxHide_Click(object sender, EventArgs e)
        {
            pictureBoxHide.Hide();
            textBoxPassword.UseSystemPasswordChar = true;
            pictureBoxShow.Show();
        }

        private async void buttonLogin_Click(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text.Trim();
            string password = textBoxPassword.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Username and password cannot be empty.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var httpClient = new HttpClient();
                var loginData = new
                {
                    Username = username,
                    Password = password,
                    
                };

                string apiUrl = "https://localhost:7107/api/Users/Login";
                var response = await httpClient.PostAsJsonAsync(apiUrl, loginData);

                if (response.IsSuccessStatusCode)
                {
                    string jsonResponse = await response.Content.ReadAsStringAsync();
                    MessageBox.Show(jsonResponse, "Raw API Response");

                    // Then parse it manually
                    var loginResult = JsonSerializer.Deserialize<UserLoginResponse>(jsonResponse, new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    });

                if (string.IsNullOrWhiteSpace(loginResult?.Token))
                    {
                        MessageBox.Show("No token returned from the server.", "Token Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    

                    string token = loginResult.Token;
                    MessageBox.Show("Received token:\n" + token);  // Add this to debug
                    string role = GetRoleFromToken(token);         // This is where it was crashing

                    // Show a form based on role
                    Form nextForm = role switch
                    {
                        "Admin" => new ReceptionForm(),
                        "Reception" => new ReceptionForm(),
                        "Manager" => new ManagerForms(),
                        _ => null
                    };

                    if (nextForm != null)
                    {
                        MessageBox.Show($"Welcome {username}! You are logged in as {role}.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        textBoxUsername.Clear();
                        textBoxPassword.Clear();
                        nextForm.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Unknown role. Access denied.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (HttpRequestException httpEx)
            {
                MessageBox.Show($"HTTP error: {httpEx.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unexpected error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Method to extract role from JWT token
        private string GetRoleFromToken(string token)
        {
            if (string.IsNullOrWhiteSpace(token))
                throw new ArgumentException("JWT token is null or empty.", nameof(token));

            var handler = new JwtSecurityTokenHandler();
            var jwtToken = handler.ReadJwtToken(token);

            var claims = jwtToken.Claims.ToList();
            string debugClaims = string.Join(Environment.NewLine, claims.Select(c => $"{c.Type}: {c.Value}"));
            MessageBox.Show(debugClaims, "JWT Claims");

            var roleClaim = claims.FirstOrDefault(c =>
                c.Type == "http://schemas.microsoft.com/ws/2008/06/identity/claims/role"
                || c.Type == "role" || c.Type == "Role");

            return roleClaim?.Value ?? throw new Exception("Role claim not found in token.");
        }




        private void pictureBoxMinimize_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBoxClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBoxMinimize_MouseHover_1(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBoxShow, "Show Password");
        }

        private void pictureBoxClose_MouseHover_1(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBoxClose, "Close");
        }
    }
}

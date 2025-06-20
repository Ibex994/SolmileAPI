using System;
using System.Collections.Generic;
using System.Drawing;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using Solmile;
using Solmile.Forms.Themes;
using Solmile.Interface;
using SolmileGuestHouseUI.Forms.ManagerForms;

namespace SolmileGuestHouseUI.Forms.AdminForms
{
    public partial class AdminForm : Form
    {
        public string username;
        private Button? currentButton;
        private readonly Random random;
        private int tempIndex;
        private Form? activeForm = null;
        private UserControl? activeControl = null;
        private readonly IUserService _userService;
        private readonly HttpClient _httpClient;

        public AdminForm(IUserService userService)
        {
            InitializeComponent();

            random = new Random();
            btnCloseChildForm.Visible = false;
            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

            _httpClient = new HttpClient
            {
                BaseAddress = new Uri("https://localhost:7107/")
            };

            _userService = userService;
        }

        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn is Button)
                {
                    previousBtn.BackColor = Color.Transparent;
                    previousBtn.ForeColor = Color.Black;
                    previousBtn.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
                }
            }
        }

        private void ActivateButton(object btnSender)
        {
            if (btnSender is Button button && currentButton != button)
            {
                DisableButton();
                Color color = SelectThemeColor();
                currentButton = button;
                currentButton.BackColor = color;
                currentButton.ForeColor = Color.White;
                currentButton.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
                panelTitleBar.BackColor = color;
                panelLogo.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                ThemeColor.PrimaryColor = color;
                ThemeColor.SecondaryColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                btnCloseChildForm.Visible = true;
            }
        }

        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while (tempIndex == index)
            {
                index = random.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            activeForm?.Close();
            ActivateButton(btnSender);

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            panelDesktopPane.Controls.Add(childForm);
            panelDesktopPane.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitle.Text = childForm.Text;
        }

        private void OpenChildForm(UserControl childControl, object btnSender)
        {
            if (activeControl != null)
                panelDesktopPane.Controls.Remove(activeControl);

            ActivateButton(btnSender);
            activeControl = childControl;
            childControl.Dock = DockStyle.Fill;
            panelDesktopPane.Controls.Add(childControl);
            panelDesktopPane.Tag = childControl;
            childControl.BringToFront();
            lblTitle.Text = childControl.Name;
        }

        private void Reset()
        {
            DisableButton();
            lblTitle.Text = "HOME";
            panelTitleBar.BackColor = Color.Transparent;
            panelLogo.BackColor = Color.Transparent;
            currentButton = null;
            btnCloseChildForm.Visible = false;
        }

        private void btnCloseChildForm_Click(object sender, EventArgs e)
        {
            activeForm?.Close();
            activeControl?.Hide();
            Reset();
        }

        private void btnBranch_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Branch(), sender);
        }

        private void btnConDet_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ContactDetails(), sender);
        }

        private void btnRoom_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Room(), sender);
        }

        private void btnRoomnumAssign_Click(object sender, EventArgs e)
        {
            OpenChildForm(new RoomNumAssignment(), sender);
        }

        private void btnRoomType_Click(object sender, EventArgs e)
        {
            OpenChildForm(new RoomType(), sender);
        }

        private void btnUserRole_Click(object sender, EventArgs e)
        {
            OpenChildForm(new UserRole(), sender);
        }

        private async void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are You Sure You Want To LogOut?", "LogOut", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                // Fade out
                for (double opacity = 1.0; opacity > 0; opacity -= 0.1)
                {
                    this.Opacity = opacity;
                    await Task.Delay(50);
                }

                var loginForm = new Login(_userService);
                loginForm.Show();
                this.Close();
            }
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBoxMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelDateTime.Text = DateTime.Now.ToString("dd-MM-yyyy hh:mm:ss tt");
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            timer1.Start();
            labelUsername.Text = username;
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.ManagerForms.User(), sender);
        }
    }
}

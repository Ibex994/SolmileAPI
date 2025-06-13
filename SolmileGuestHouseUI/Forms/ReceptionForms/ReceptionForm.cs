using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using Solmile.Forms.ReceptionForms;
using Solmile.Forms.Themes;
using Solmile.Interface;
using Solmile.Service;

namespace Solmile.Forms
{
    public partial class ReceptionForm : Form
    {
        public string username;
        private Button? currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;
        private UserControl activeControl;
        private readonly IUserService _userService;
        public ReceptionForm()
        {
            InitializeComponent();
            random = new Random();
            btnCloseChildForm.Visible = false;
            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            username = labelUsername.Text;
        }
        //Methods
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
        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    panelTitleBar.BackColor = color;
                    panelLogo.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    ThemeColor.PrimaryColor = color;
                    ThemeColor.SecondaryColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    btnCloseChildForm.Visible = true;
                }
            }
        }
        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.Transparent;
                    previousBtn.ForeColor = Color.Black;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktopPane.Controls.Add(childForm);
            this.panelDesktopPane.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitle.Text = childForm.Text;

        }
        private void OpenChildForm(UserControl childControl, object btnSender)
        {
            if (activeControl != null)
                this.panelDesktopPane.Controls.Remove(activeControl);

            ActivateButton(btnSender);
            activeControl = childControl;

            childControl.Dock = DockStyle.Fill;
            this.panelDesktopPane.Controls.Add(childControl);
            this.panelDesktopPane.Tag = childControl;
            childControl.BringToFront();
            childControl.Show();

            lblTitle.Text = childControl.Name;
        }
        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.ReceptionForms.CheckIn(), sender);
        }
        private void btncheckOut_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.ReceptionForms.CheckOut(), sender);
        }
        private void btnReserv_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.ReceptionForms.ManageReservation(), sender);
        }
        private void btnNotify_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.ReceptionForms.NotifyChauffer(), sender);
        }
        private void btnReport_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.ReceptionForms.Report(), sender);
        }
        private void btnService_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.ReceptionForms.ServiceRequest(), sender);
        }

        private void pictureBoxMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnCloseChildForm_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
            if (activeControl != null)
                activeControl.Hide();
            Reset();
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelDateTime.Text = DateTime.Now.ToString("dd-MM-yyyy hh:mm:ss tt");
        }

        private void ReceptionForm_Load(object sender, EventArgs e)
        {
            timer1.Start();
            labelUsername.Text = username;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are You Sure You Want To LogOut", "LogOut", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Task.Run(() =>
            {
                for (double opacity = 1.0; opacity > 0; opacity -= 0.1)
                {

                    this.Invoke((MethodInvoker)delegate
                    {
                        this.Opacity = opacity;
                    });
                }
                this.Invoke((MethodInvoker)delegate
                {
                    var LoginForm = new Login(_userService);
                    LoginForm.Show();
                    this.Close();
                });
            });

            }
        }
    }

}

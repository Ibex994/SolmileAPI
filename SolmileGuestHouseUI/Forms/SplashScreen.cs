using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Solmile.Interface;
using Solmile.Service;

namespace Solmile.Forms
{
    public partial class SplashScreen : Form
    {
        IUserService userService = new UserService();
        public SplashScreen()
        {
            InitializeComponent();
        }

        private void SplashScreen_Load(object sender, EventArgs e)
        {
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 350;
            progressBar1.Value = 0;
            progressBar1.Style = ProgressBarStyle.Continuous;
            timer1.Interval = 50; // 50ms for smoother progress
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                // Prevent overflow
                int newValue = Math.Min(progressBar1.Value + 5, progressBar1.Maximum);
                progressBar1.Value = newValue;

                if (progressBar1.Value >= progressBar1.Maximum)
                {
                    timer1.Stop();
                    Login loginForm = new Login(userService);
                    loginForm.FormClosed += (s, args) => Application.Exit();
                    loginForm.Show();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                // Log or display errors
                timer1.Stop();
                MessageBox.Show($"Error loading application: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

    }
}

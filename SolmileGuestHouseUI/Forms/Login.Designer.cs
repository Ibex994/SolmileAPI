namespace Solmile
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        public void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            toolTip1 = new ToolTip(components);
            label1 = new Label();
            groupBox1 = new GroupBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            buttonLogin = new Button();
            label4 = new Label();
            textBoxPassword = new TextBox();
            textBoxUsername = new TextBox();
            pictureBoxHide = new PictureBox();
            pictureBoxShow = new PictureBox();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            pictureBoxMinimize = new PictureBox();
            pictureBoxClose = new PictureBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxHide).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxShow).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMinimize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxClose).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, 323);
            label1.Name = "label1";
            label1.Size = new Size(235, 16);
            label1.TabIndex = 0;
            label1.Text = "Copyright © 2017 All Right Reserved";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(pictureBox3);
            groupBox1.Controls.Add(pictureBox2);
            groupBox1.Controls.Add(buttonLogin);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(textBoxPassword);
            groupBox1.Controls.Add(textBoxUsername);
            groupBox1.Controls.Add(pictureBoxHide);
            groupBox1.Controls.Add(pictureBoxShow);
            groupBox1.FlatStyle = FlatStyle.Flat;
            groupBox1.Location = new Point(274, 46);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(359, 326);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Please Login First";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(34, 110);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(33, 40);
            pictureBox3.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox3.TabIndex = 5;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(34, 170);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(30, 38);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // buttonLogin
            // 
            buttonLogin.Anchor = AnchorStyles.None;
            buttonLogin.BackColor = Color.FromArgb(37, 198, 218);
            buttonLogin.FlatAppearance.BorderSize = 0;
            buttonLogin.FlatStyle = FlatStyle.Flat;
            buttonLogin.ForeColor = Color.Cornsilk;
            buttonLogin.Location = new Point(107, 224);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(134, 23);
            buttonLogin.TabIndex = 2;
            buttonLogin.Text = "LogIn";
            buttonLogin.UseVisualStyleBackColor = false;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Cursor = Cursors.Hand;
            label4.ForeColor = Color.Red;
            label4.Location = new Point(103, 255);
            label4.Name = "label4";
            label4.Size = new Size(138, 18);
            label4.TabIndex = 1;
            label4.Text = "Forget Password?";
            // 
            // textBoxPassword
            // 
            textBoxPassword.Anchor = AnchorStyles.None;
            textBoxPassword.Location = new Point(73, 183);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PlaceholderText = "Password";
            textBoxPassword.Size = new Size(182, 26);
            textBoxPassword.TabIndex = 1;
            textBoxPassword.UseSystemPasswordChar = true;
            // 
            // textBoxUsername
            // 
            textBoxUsername.Anchor = AnchorStyles.None;
            textBoxUsername.BackColor = SystemColors.Window;
            textBoxUsername.Location = new Point(73, 125);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.PlaceholderText = "UserName";
            textBoxUsername.Size = new Size(182, 26);
            textBoxUsername.TabIndex = 0;
            // 
            // pictureBoxHide
            // 
            pictureBoxHide.BorderStyle = BorderStyle.FixedSingle;
            pictureBoxHide.Cursor = Cursors.Hand;
            pictureBoxHide.Image = (Image)resources.GetObject("pictureBoxHide.Image");
            pictureBoxHide.Location = new Point(261, 183);
            pictureBoxHide.Name = "pictureBoxHide";
            pictureBoxHide.Size = new Size(27, 26);
            pictureBoxHide.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxHide.TabIndex = 4;
            pictureBoxHide.TabStop = false;
            pictureBoxHide.Click += pictureBoxHide_Click;
            pictureBoxHide.MouseHover += pictureBoxHide_MouseHover;
            // 
            // pictureBoxShow
            // 
            pictureBoxShow.BorderStyle = BorderStyle.FixedSingle;
            pictureBoxShow.Cursor = Cursors.Hand;
            pictureBoxShow.Image = (Image)resources.GetObject("pictureBoxShow.Image");
            pictureBoxShow.Location = new Point(261, 183);
            pictureBoxShow.Name = "pictureBoxShow";
            pictureBoxShow.Size = new Size(27, 26);
            pictureBoxShow.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxShow.TabIndex = 4;
            pictureBoxShow.TabStop = false;
            pictureBoxShow.Click += pictureBoxShow_Click;
            pictureBoxShow.MouseHover += pictureBoxShow_MouseHover;
            // 
            // panel2
            // 
            panel2.Controls.Add(label1);
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(0, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(260, 344);
            panel2.TabIndex = 6;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            //pictureBox1.Image = Properties.Resources.OIP;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(260, 344);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // pictureBoxMinimize
            // 
            pictureBoxMinimize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBoxMinimize.Cursor = Cursors.Hand;
            pictureBoxMinimize.Image = (Image)resources.GetObject("pictureBoxMinimize.Image");
            pictureBoxMinimize.Location = new Point(619, 2);
            pictureBoxMinimize.Name = "pictureBoxMinimize";
            pictureBoxMinimize.Size = new Size(27, 18);
            pictureBoxMinimize.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxMinimize.TabIndex = 8;
            pictureBoxMinimize.TabStop = false;
            pictureBoxMinimize.Click += pictureBoxMinimize_Click_1;
            pictureBoxMinimize.MouseHover += pictureBoxMinimize_MouseHover_1;
            // 
            // pictureBoxClose
            // 
            pictureBoxClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBoxClose.Cursor = Cursors.Hand;
            pictureBoxClose.Image = (Image)resources.GetObject("pictureBoxClose.Image");
            pictureBoxClose.Location = new Point(642, 2);
            pictureBoxClose.Name = "pictureBoxClose";
            pictureBoxClose.Size = new Size(29, 18);
            pictureBoxClose.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxClose.TabIndex = 7;
            pictureBoxClose.TabStop = false;
            pictureBoxClose.Click += pictureBoxClose_Click_1;
            pictureBoxClose.MouseHover += pictureBoxClose_MouseHover_1;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.FromArgb(55, 57, 93);
            ClientSize = new Size(670, 394);
            Controls.Add(pictureBoxMinimize);
            Controls.Add(pictureBoxClose);
            Controls.Add(panel2);
            Controls.Add(groupBox1);
            Font = new Font("Arial Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LogIn";
            WindowState = FormWindowState.Minimized;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxHide).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxShow).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMinimize).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxClose).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private ToolTip toolTip1;
        private Label label1;
        private GroupBox groupBox1;
        private Button buttonLogin;
        private TextBox textBoxUsername;
        private Label label4;
        private TextBox textBoxPassword;
        private PictureBox pictureBoxShow;
        private PictureBox pictureBoxHide;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private Panel panel2;
        private PictureBox pictureBox1;
        private PictureBox pictureBoxMinimize;
        private PictureBox pictureBoxClose;
    }
}

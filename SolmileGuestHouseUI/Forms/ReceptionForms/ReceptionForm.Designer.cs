namespace Solmile.Forms
{
    partial class ReceptionForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReceptionForm));
            panelMenu = new Panel();
            btnGust = new Button();
            btnRoom = new Button();
            btnLogout = new Button();
            btnService = new Button();
            btnReport = new Button();
            btnNotify = new Button();
            btnReserv = new Button();
            btncheckOut = new Button();
            btnCheckIn = new Button();
            panelLogo = new Panel();
            panel1 = new Panel();
            btnCloseChildForm = new Button();
            lblTitle = new Label();
            panelTitleBar = new Panel();
            labelUsername = new Label();
            label1 = new Label();
            labelDateTime = new Label();
            pictureBoxMinimize = new PictureBox();
            pictureBoxClose = new PictureBox();
            panelDesktopPane = new Panel();
            pictureBox1 = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            panelMenu.SuspendLayout();
            panelLogo.SuspendLayout();
            panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMinimize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxClose).BeginInit();
            panelDesktopPane.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.Transparent;
            panelMenu.Controls.Add(btnGust);
            panelMenu.Controls.Add(btnRoom);
            panelMenu.Controls.Add(btnLogout);
            panelMenu.Controls.Add(btnService);
            panelMenu.Controls.Add(btnReport);
            panelMenu.Controls.Add(btnNotify);
            panelMenu.Controls.Add(btnReserv);
            panelMenu.Controls.Add(btncheckOut);
            panelMenu.Controls.Add(btnCheckIn);
            panelMenu.Controls.Add(panelLogo);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Font = new Font("Cambria", 9.75F);
            panelMenu.Location = new Point(0, 0);
            panelMenu.Margin = new Padding(4, 0, 4, 4);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(208, 633);
            panelMenu.TabIndex = 0;
            // 
            // btnGust
            // 
            btnGust.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnGust.Cursor = Cursors.Hand;
            btnGust.FlatAppearance.BorderSize = 0;
            btnGust.FlatStyle = FlatStyle.Flat;
            btnGust.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            btnGust.ForeColor = Color.Black;
            btnGust.Image = (Image)resources.GetObject("btnGust.Image");
            btnGust.ImageAlign = ContentAlignment.MiddleLeft;
            btnGust.Location = new Point(0, 457);
            btnGust.Margin = new Padding(4, 12, 4, 4);
            btnGust.Name = "btnGust";
            btnGust.Padding = new Padding(15, 0, 0, 0);
            btnGust.Size = new Size(208, 53);
            btnGust.TabIndex = 11;
            btnGust.Text = "Service";
            btnGust.TextAlign = ContentAlignment.MiddleLeft;
            btnGust.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnGust.UseVisualStyleBackColor = true;
            // 
            // btnRoom
            // 
            btnRoom.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnRoom.Cursor = Cursors.Hand;
            btnRoom.FlatAppearance.BorderSize = 0;
            btnRoom.FlatStyle = FlatStyle.Flat;
            btnRoom.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            btnRoom.ForeColor = Color.Black;
            btnRoom.Image = (Image)resources.GetObject("btnRoom.Image");
            btnRoom.ImageAlign = ContentAlignment.MiddleLeft;
            btnRoom.Location = new Point(0, 392);
            btnRoom.Margin = new Padding(4, 12, 4, 4);
            btnRoom.Name = "btnRoom";
            btnRoom.Padding = new Padding(15, 0, 0, 0);
            btnRoom.Size = new Size(208, 57);
            btnRoom.TabIndex = 10;
            btnRoom.Text = "Room";
            btnRoom.TextAlign = ContentAlignment.MiddleLeft;
            btnRoom.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnRoom.UseVisualStyleBackColor = true;
            // 
            // btnLogout
            // 
            btnLogout.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnLogout.Cursor = Cursors.Hand;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Microsoft Sans Serif", 11.25F);
            btnLogout.ForeColor = Color.Black;
            btnLogout.Image = (Image)resources.GetObject("btnLogout.Image");
            btnLogout.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogout.Location = new Point(0, 583);
            btnLogout.Margin = new Padding(4, 12, 4, 4);
            btnLogout.Name = "btnLogout";
            btnLogout.Padding = new Padding(15, 0, 0, 0);
            btnLogout.Size = new Size(208, 57);
            btnLogout.TabIndex = 8;
            btnLogout.Text = "LogOut";
            btnLogout.TextAlign = ContentAlignment.MiddleLeft;
            btnLogout.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnService
            // 
            btnService.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnService.Cursor = Cursors.Hand;
            btnService.FlatAppearance.BorderSize = 0;
            btnService.FlatStyle = FlatStyle.Flat;
            btnService.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            btnService.ForeColor = Color.Black;
            btnService.Image = (Image)resources.GetObject("btnService.Image");
            btnService.ImageAlign = ContentAlignment.MiddleLeft;
            btnService.Location = new Point(0, 518);
            btnService.Margin = new Padding(4, 12, 4, 4);
            btnService.Name = "btnService";
            btnService.Padding = new Padding(15, 0, 0, 0);
            btnService.Size = new Size(208, 57);
            btnService.TabIndex = 7;
            btnService.Text = "Service";
            btnService.TextAlign = ContentAlignment.MiddleLeft;
            btnService.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnService.UseVisualStyleBackColor = true;
            btnService.Click += btnService_Click;
            // 
            // btnReport
            // 
            btnReport.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnReport.Cursor = Cursors.Hand;
            btnReport.FlatAppearance.BorderSize = 0;
            btnReport.FlatStyle = FlatStyle.Flat;
            btnReport.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            btnReport.ForeColor = Color.Black;
            btnReport.Image = (Image)resources.GetObject("btnReport.Image");
            btnReport.ImageAlign = ContentAlignment.MiddleLeft;
            btnReport.Location = new Point(0, 331);
            btnReport.Margin = new Padding(4, 12, 4, 4);
            btnReport.Name = "btnReport";
            btnReport.Padding = new Padding(15, 0, 0, 0);
            btnReport.Size = new Size(208, 53);
            btnReport.TabIndex = 5;
            btnReport.Text = "Report";
            btnReport.TextAlign = ContentAlignment.MiddleLeft;
            btnReport.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnReport.UseVisualStyleBackColor = true;
            btnReport.Click += btnReport_Click;
            // 
            // btnNotify
            // 
            btnNotify.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnNotify.Cursor = Cursors.Hand;
            btnNotify.FlatAppearance.BorderSize = 0;
            btnNotify.FlatStyle = FlatStyle.Flat;
            btnNotify.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            btnNotify.ForeColor = Color.Black;
            btnNotify.Image = (Image)resources.GetObject("btnNotify.Image");
            btnNotify.ImageAlign = ContentAlignment.MiddleLeft;
            btnNotify.Location = new Point(0, 270);
            btnNotify.Margin = new Padding(4, 12, 4, 4);
            btnNotify.Name = "btnNotify";
            btnNotify.Padding = new Padding(15, 0, 0, 0);
            btnNotify.Size = new Size(208, 53);
            btnNotify.TabIndex = 4;
            btnNotify.Text = "Notify Chauffer";
            btnNotify.TextAlign = ContentAlignment.MiddleLeft;
            btnNotify.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnNotify.UseVisualStyleBackColor = true;
            btnNotify.Click += btnNotify_Click;
            // 
            // btnReserv
            // 
            btnReserv.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnReserv.Cursor = Cursors.Hand;
            btnReserv.FlatAppearance.BorderSize = 0;
            btnReserv.FlatStyle = FlatStyle.Flat;
            btnReserv.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            btnReserv.ForeColor = Color.Black;
            btnReserv.Image = (Image)resources.GetObject("btnReserv.Image");
            btnReserv.ImageAlign = ContentAlignment.MiddleLeft;
            btnReserv.Location = new Point(0, 209);
            btnReserv.Margin = new Padding(4, 12, 4, 4);
            btnReserv.Name = "btnReserv";
            btnReserv.Padding = new Padding(15, 0, 0, 0);
            btnReserv.Size = new Size(208, 53);
            btnReserv.TabIndex = 3;
            btnReserv.Text = "Manage Reservation";
            btnReserv.TextAlign = ContentAlignment.MiddleLeft;
            btnReserv.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnReserv.UseVisualStyleBackColor = true;
            btnReserv.Click += btnReserv_Click;
            // 
            // btncheckOut
            // 
            btncheckOut.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btncheckOut.Cursor = Cursors.Hand;
            btncheckOut.FlatAppearance.BorderSize = 0;
            btncheckOut.FlatStyle = FlatStyle.Flat;
            btncheckOut.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            btncheckOut.ForeColor = Color.Black;
            btncheckOut.Image = (Image)resources.GetObject("btncheckOut.Image");
            btncheckOut.ImageAlign = ContentAlignment.MiddleLeft;
            btncheckOut.Location = new Point(0, 148);
            btncheckOut.Margin = new Padding(4, 12, 4, 4);
            btncheckOut.Name = "btncheckOut";
            btncheckOut.Padding = new Padding(15, 0, 0, 0);
            btncheckOut.Size = new Size(208, 53);
            btncheckOut.TabIndex = 2;
            btncheckOut.Text = "Check-Out";
            btncheckOut.TextAlign = ContentAlignment.MiddleLeft;
            btncheckOut.TextImageRelation = TextImageRelation.ImageBeforeText;
            btncheckOut.UseVisualStyleBackColor = true;
            btncheckOut.Click += btncheckOut_Click;
            // 
            // btnCheckIn
            // 
            btnCheckIn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnCheckIn.Cursor = Cursors.Hand;
            btnCheckIn.FlatAppearance.BorderSize = 0;
            btnCheckIn.FlatStyle = FlatStyle.Flat;
            btnCheckIn.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            btnCheckIn.ForeColor = Color.Black;
            btnCheckIn.Image = (Image)resources.GetObject("btnCheckIn.Image");
            btnCheckIn.ImageAlign = ContentAlignment.MiddleLeft;
            btnCheckIn.Location = new Point(0, 87);
            btnCheckIn.Margin = new Padding(4, 12, 4, 4);
            btnCheckIn.Name = "btnCheckIn";
            btnCheckIn.Padding = new Padding(15, 0, 0, 0);
            btnCheckIn.Size = new Size(208, 53);
            btnCheckIn.TabIndex = 1;
            btnCheckIn.Text = "Check-In";
            btnCheckIn.TextAlign = ContentAlignment.MiddleLeft;
            btnCheckIn.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCheckIn.UseVisualStyleBackColor = true;
            btnCheckIn.Click += btnCheckIn_Click;
            // 
            // panelLogo
            // 
            panelLogo.BackColor = Color.Transparent;
            panelLogo.Controls.Add(panel1);
            panelLogo.Controls.Add(btnCloseChildForm);
            panelLogo.Controls.Add(lblTitle);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Margin = new Padding(4);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(208, 87);
            panelLogo.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Location = new Point(208, 50);
            panel1.Name = "panel1";
            panel1.Size = new Size(859, 583);
            panel1.TabIndex = 0;
            // 
            // btnCloseChildForm
            // 
            btnCloseChildForm.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnCloseChildForm.BackColor = Color.Transparent;
            btnCloseChildForm.Cursor = Cursors.Hand;
            btnCloseChildForm.FlatAppearance.BorderSize = 0;
            btnCloseChildForm.FlatStyle = FlatStyle.Flat;
            btnCloseChildForm.ForeColor = Color.Transparent;
            //btnCloseChildForm.Image = Assets.icons8_hotel_48;
            btnCloseChildForm.Location = new Point(168, 50);
            btnCloseChildForm.Name = "btnCloseChildForm";
            btnCloseChildForm.Size = new Size(40, 34);
            btnCloseChildForm.TabIndex = 6;
            btnCloseChildForm.Text = "  ";
            btnCloseChildForm.UseVisualStyleBackColor = false;
            btnCloseChildForm.Click += btnCloseChildForm_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.Black;
            lblTitle.Location = new Point(0, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(63, 22);
            lblTitle.TabIndex = 2;
            lblTitle.Text = "Home";
            // 
            // panelTitleBar
            // 
            panelTitleBar.BackColor = Color.Transparent;
            panelTitleBar.Controls.Add(labelUsername);
            panelTitleBar.Controls.Add(label1);
            panelTitleBar.Controls.Add(labelDateTime);
            panelTitleBar.Controls.Add(pictureBoxMinimize);
            panelTitleBar.Controls.Add(pictureBoxClose);
            panelTitleBar.Dock = DockStyle.Top;
            panelTitleBar.Location = new Point(208, 0);
            panelTitleBar.Name = "panelTitleBar";
            panelTitleBar.Size = new Size(859, 50);
            panelTitleBar.TabIndex = 1;
            // 
            // labelUsername
            // 
            labelUsername.AutoSize = true;
            labelUsername.BackColor = Color.Transparent;
            labelUsername.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelUsername.ForeColor = Color.White;
            labelUsername.Location = new Point(76, 23);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(19, 20);
            labelUsername.TabIndex = 4;
            labelUsername.Text = "?";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(3, 23);
            label1.Name = "label1";
            label1.Size = new Size(79, 20);
            label1.TabIndex = 4;
            label1.Text = "Welcome:";
            // 
            // labelDateTime
            // 
            labelDateTime.AutoSize = true;
            labelDateTime.BackColor = Color.Transparent;
            labelDateTime.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelDateTime.Location = new Point(0, 0);
            labelDateTime.Name = "labelDateTime";
            labelDateTime.Size = new Size(15, 16);
            labelDateTime.TabIndex = 4;
            labelDateTime.Text = "?";
            // 
            // pictureBoxMinimize
            // 
            pictureBoxMinimize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBoxMinimize.Cursor = Cursors.Hand;
            pictureBoxMinimize.Image = (Image)resources.GetObject("pictureBoxMinimize.Image");
            pictureBoxMinimize.Location = new Point(806, 0);
            pictureBoxMinimize.Name = "pictureBoxMinimize";
            pictureBoxMinimize.Size = new Size(27, 18);
            pictureBoxMinimize.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxMinimize.TabIndex = 3;
            pictureBoxMinimize.TabStop = false;
            pictureBoxMinimize.Click += pictureBoxMinimize_Click;
            // 
            // pictureBoxClose
            // 
            pictureBoxClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBoxClose.Cursor = Cursors.Hand;
            pictureBoxClose.Image = (Image)resources.GetObject("pictureBoxClose.Image");
            pictureBoxClose.Location = new Point(830, 0);
            pictureBoxClose.Name = "pictureBoxClose";
            pictureBoxClose.Size = new Size(29, 18);
            pictureBoxClose.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxClose.TabIndex = 2;
            pictureBoxClose.TabStop = false;
            pictureBoxClose.Click += pictureBoxClose_Click;
            // 
            // panelDesktopPane
            // 
            panelDesktopPane.BackColor = Color.Transparent;
            panelDesktopPane.Controls.Add(pictureBox1);
            panelDesktopPane.Dock = DockStyle.Fill;
            panelDesktopPane.Location = new Point(208, 50);
            panelDesktopPane.Name = "panelDesktopPane";
            panelDesktopPane.Size = new Size(859, 583);
            panelDesktopPane.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Dock = DockStyle.Fill;
            //pictureBox1.Image = Properties.Resources.OIP;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(859, 583);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // ReceptionForm
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(1067, 633);
            Controls.Add(panelDesktopPane);
            Controls.Add(panelTitleBar);
            Controls.Add(panelMenu);
            Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "ReceptionForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ReceptionForm";
            WindowState = FormWindowState.Minimized;
            Load += ReceptionForm_Load;
            panelMenu.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            panelLogo.PerformLayout();
            panelTitleBar.ResumeLayout(false);
            panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMinimize).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxClose).EndInit();
            panelDesktopPane.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private Button btnCheckIn;
        private Button btnNotify;
        private Button btnReserv;
        private Button btncheckOut;
        private Button btnReport;
        private Panel panelLogo;
        private Panel panelTitleBar;
        private PictureBox pictureBoxMinimize;
        private PictureBox pictureBoxClose;
        private Label lblTitle;
        private Button btnCloseChildForm;
        private Panel panelDesktopPane;
        private Label labelDateTime;
        private Label labelUsername;
        private Label label1;
        private System.Windows.Forms.Timer timer1;
        private Button btnLogout;
        private Button btnService;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Button btnRoom;
        private Button btnGust;
    }
}
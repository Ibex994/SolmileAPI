namespace Solmile.Forms.ManagerForms
{
    partial class ManagerForms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagerForms));
            timer1 = new System.Windows.Forms.Timer(components);
            pictureBoxClose = new PictureBox();
            label1 = new Label();
            labelDateTime = new Label();
            pictureBoxMinimize = new PictureBox();
            panelLogo = new Panel();
            panel1 = new Panel();
            btnCloseChildForm = new Button();
            lblTitle = new Label();
            panelDesktopPane = new Panel();
            pictureBox1 = new PictureBox();
            panelTitleBar = new Panel();
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
            labelUsername = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxClose).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMinimize).BeginInit();
            panelLogo.SuspendLayout();
            panelDesktopPane.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelTitleBar.SuspendLayout();
            panelMenu.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBoxClose
            // 
            pictureBoxClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBoxClose.Cursor = Cursors.Hand;
            pictureBoxClose.Image = (Image)resources.GetObject("pictureBoxClose.Image");
            pictureBoxClose.Location = new Point(826, 0);
            pictureBoxClose.Name = "pictureBoxClose";
            pictureBoxClose.Size = new Size(29, 18);
            pictureBoxClose.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxClose.TabIndex = 2;
            pictureBoxClose.TabStop = false;
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
            pictureBoxMinimize.Location = new Point(802, 0);
            pictureBoxMinimize.Name = "pictureBoxMinimize";
            pictureBoxMinimize.Size = new Size(27, 18);
            pictureBoxMinimize.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxMinimize.TabIndex = 3;
            pictureBoxMinimize.TabStop = false;
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
            panelLogo.Size = new Size(208, 57);
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
            btnCloseChildForm.Location = new Point(156, 23);
            btnCloseChildForm.Name = "btnCloseChildForm";
            btnCloseChildForm.Size = new Size(52, 34);
            btnCloseChildForm.TabIndex = 6;
            btnCloseChildForm.Text = "  ";
            btnCloseChildForm.UseVisualStyleBackColor = false;
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
            // panelDesktopPane
            // 
            panelDesktopPane.BackColor = Color.Transparent;
            panelDesktopPane.Controls.Add(pictureBox1);
            panelDesktopPane.Dock = DockStyle.Fill;
            panelDesktopPane.Location = new Point(208, 50);
            panelDesktopPane.Name = "panelDesktopPane";
            panelDesktopPane.Size = new Size(855, 690);
            panelDesktopPane.TabIndex = 5;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = SolmileGuestHouseUI.Properties.Resources.Black_and_Gold_Vintage_Luxury_Hotel_Logo__1__removebg_preview;
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(855, 690);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
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
            panelTitleBar.Size = new Size(855, 50);
            panelTitleBar.TabIndex = 4;
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.Transparent;
            panelMenu.Controls.Add(btnGust);
            panelMenu.Controls.Add(btnRoom);
            panelMenu.Controls.Add(btnLogout);
            panelMenu.Controls.Add(button3);
            panelMenu.Controls.Add(button5);
            panelMenu.Controls.Add(button4);
            panelMenu.Controls.Add(button2);
            panelMenu.Controls.Add(button1);
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
            panelMenu.Size = new Size(208, 740);
            panelMenu.TabIndex = 3;
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
            btnGust.Location = new Point(0, 346);
            btnGust.Margin = new Padding(4, 12, 4, 4);
            btnGust.Name = "btnGust";
            btnGust.Padding = new Padding(15, 0, 0, 0);
            btnGust.Size = new Size(208, 47);
            btnGust.TabIndex = 20;
            btnGust.Text = "Payment Method";
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
            btnRoom.Location = new Point(0, 293);
            btnRoom.Margin = new Padding(4, 12, 4, 4);
            btnRoom.Name = "btnRoom";
            btnRoom.Padding = new Padding(15, 0, 0, 0);
            btnRoom.Size = new Size(208, 55);
            btnRoom.TabIndex = 19;
            btnRoom.Text = "Payment";
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
            btnLogout.Location = new Point(0, 692);
            btnLogout.Margin = new Padding(4, 12, 4, 4);
            btnLogout.Name = "btnLogout";
            btnLogout.Padding = new Padding(15, 0, 0, 0);
            btnLogout.Size = new Size(208, 48);
            btnLogout.TabIndex = 18;
            btnLogout.Text = "LogOut";
            btnLogout.TextAlign = ContentAlignment.MiddleLeft;
            btnLogout.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLogout.UseVisualStyleBackColor = true;
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
            btnService.Location = new Point(0, 390);
            btnService.Margin = new Padding(4, 12, 4, 4);
            btnService.Name = "btnService";
            btnService.Padding = new Padding(15, 0, 0, 0);
            btnService.Size = new Size(208, 51);
            btnService.TabIndex = 17;
            btnService.Text = "Rating";
            btnService.TextAlign = ContentAlignment.MiddleLeft;
            btnService.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnService.UseVisualStyleBackColor = true;
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
            btnReport.Location = new Point(0, 250);
            btnReport.Margin = new Padding(4, 12, 4, 4);
            btnReport.Name = "btnReport";
            btnReport.Padding = new Padding(15, 0, 0, 0);
            btnReport.Size = new Size(208, 49);
            btnReport.TabIndex = 16;
            btnReport.Text = "Log";
            btnReport.TextAlign = ContentAlignment.MiddleLeft;
            btnReport.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnReport.UseVisualStyleBackColor = true;
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
            btnNotify.Location = new Point(0, 205);
            btnNotify.Margin = new Padding(4, 12, 4, 4);
            btnNotify.Name = "btnNotify";
            btnNotify.Padding = new Padding(15, 0, 0, 0);
            btnNotify.Size = new Size(208, 50);
            btnNotify.TabIndex = 15;
            btnNotify.Text = "FeedBack";
            btnNotify.TextAlign = ContentAlignment.MiddleLeft;
            btnNotify.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnNotify.UseVisualStyleBackColor = true;
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
            btnReserv.Location = new Point(0, 158);
            btnReserv.Margin = new Padding(4, 12, 4, 4);
            btnReserv.Name = "btnReserv";
            btnReserv.Padding = new Padding(15, 0, 0, 0);
            btnReserv.Size = new Size(208, 51);
            btnReserv.TabIndex = 14;
            btnReserv.Text = "Employee";
            btnReserv.TextAlign = ContentAlignment.MiddleLeft;
            btnReserv.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnReserv.UseVisualStyleBackColor = true;
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
            btncheckOut.Location = new Point(0, 106);
            btncheckOut.Margin = new Padding(4, 12, 4, 4);
            btncheckOut.Name = "btncheckOut";
            btncheckOut.Padding = new Padding(15, 0, 0, 0);
            btncheckOut.Size = new Size(208, 51);
            btncheckOut.TabIndex = 13;
            btncheckOut.Text = "Complaint";
            btncheckOut.TextAlign = ContentAlignment.MiddleLeft;
            btncheckOut.TextImageRelation = TextImageRelation.ImageBeforeText;
            btncheckOut.UseVisualStyleBackColor = true;
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
            btnCheckIn.Location = new Point(0, 50);
            btnCheckIn.Margin = new Padding(4, 12, 4, 4);
            btnCheckIn.Name = "btnCheckIn";
            btnCheckIn.Padding = new Padding(15, 0, 0, 0);
            btnCheckIn.Size = new Size(208, 51);
            btnCheckIn.TabIndex = 12;
            btnCheckIn.Text = "Attendance";
            btnCheckIn.TextAlign = ContentAlignment.MiddleLeft;
            btnCheckIn.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCheckIn.UseVisualStyleBackColor = true;
            // 
            // labelUsername
            // 
            labelUsername.AutoSize = true;
            labelUsername.BackColor = Color.Transparent;
            labelUsername.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelUsername.ForeColor = Color.White;
            labelUsername.Location = new Point(79, 23);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(19, 20);
            labelUsername.TabIndex = 5;
            labelUsername.Text = "?";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            button1.ForeColor = Color.Black;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(0, 439);
            button1.Margin = new Padding(4, 12, 4, 4);
            button1.Name = "button1";
            button1.Padding = new Padding(15, 0, 0, 0);
            button1.Size = new Size(208, 49);
            button1.TabIndex = 17;
            button1.Text = "Reservation";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.TextImageRelation = TextImageRelation.ImageBeforeText;
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            button2.ForeColor = Color.Black;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(0, 492);
            button2.Margin = new Padding(4, 12, 4, 4);
            button2.Name = "button2";
            button2.Padding = new Padding(15, 0, 0, 0);
            button2.Size = new Size(208, 57);
            button2.TabIndex = 17;
            button2.Text = "Role";
            button2.TextAlign = ContentAlignment.MiddleLeft;
            button2.TextImageRelation = TextImageRelation.ImageBeforeText;
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button3.Cursor = Cursors.Hand;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            button3.ForeColor = Color.Black;
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(0, 543);
            button3.Margin = new Padding(4, 12, 4, 4);
            button3.Name = "button3";
            button3.Padding = new Padding(15, 0, 0, 0);
            button3.Size = new Size(208, 49);
            button3.TabIndex = 17;
            button3.Text = "Service Type";
            button3.TextAlign = ContentAlignment.MiddleLeft;
            button3.TextImageRelation = TextImageRelation.ImageBeforeText;
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button4.Cursor = Cursors.Hand;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            button4.ForeColor = Color.Black;
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.Location = new Point(0, 593);
            button4.Margin = new Padding(4, 12, 4, 4);
            button4.Name = "button4";
            button4.Padding = new Padding(15, 0, 0, 0);
            button4.Size = new Size(208, 50);
            button4.TabIndex = 17;
            button4.Text = "User";
            button4.TextAlign = ContentAlignment.MiddleLeft;
            button4.TextImageRelation = TextImageRelation.ImageBeforeText;
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button5.Cursor = Cursors.Hand;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            button5.ForeColor = Color.Black;
            button5.Image = (Image)resources.GetObject("button5.Image");
            button5.ImageAlign = ContentAlignment.MiddleLeft;
            button5.Location = new Point(0, 641);
            button5.Margin = new Padding(4, 12, 4, 4);
            button5.Name = "button5";
            button5.Padding = new Padding(15, 0, 0, 0);
            button5.Size = new Size(208, 50);
            button5.TabIndex = 17;
            button5.Text = "User Role";
            button5.TextAlign = ContentAlignment.MiddleLeft;
            button5.TextImageRelation = TextImageRelation.ImageBeforeText;
            button5.UseVisualStyleBackColor = true;
            // 
            // ManagerForms
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1063, 740);
            Controls.Add(panelDesktopPane);
            Controls.Add(panelTitleBar);
            Controls.Add(panelMenu);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ManagerForms";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ManagerForms";
            ((System.ComponentModel.ISupportInitialize)pictureBoxClose).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMinimize).EndInit();
            panelLogo.ResumeLayout(false);
            panelLogo.PerformLayout();
            panelDesktopPane.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelTitleBar.ResumeLayout(false);
            panelTitleBar.PerformLayout();
            panelMenu.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private PictureBox pictureBoxClose;
        private Label label1;
        private Label labelDateTime;
        private PictureBox pictureBoxMinimize;
        private Panel panelLogo;
        private Panel panel1;
        private Button btnCloseChildForm;
        private Label lblTitle;
        private Panel panelDesktopPane;
        private PictureBox pictureBox1;
        private Panel panelTitleBar;
        private Panel panelMenu;
        private Button btnGust;
        private Button btnRoom;
        private Button btnLogout;
        private Button btnService;
        private Button btnReport;
        private Button btnNotify;
        private Button btnReserv;
        private Button btncheckOut;
        private Button btnCheckIn;
        private Label labelUsername;
        private Button button3;
        private Button button2;
        private Button button1;
        private Button button4;
        private Button button5;
    }
}
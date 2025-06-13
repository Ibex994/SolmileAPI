namespace SolmileGuestHouseUI.Forms.SupervisorForms
{
    partial class SupervisorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SupervisorForm));
            timer1 = new System.Windows.Forms.Timer(components);
            panelDesktopPane = new Panel();
            pictureBox1 = new PictureBox();
            labelUsername = new Label();
            label1 = new Label();
            labelDateTime = new Label();
            pictureBoxMinimize = new PictureBox();
            pictureBoxClose = new PictureBox();
            panelTitleBar = new Panel();
            panelLogo = new Panel();
            panel1 = new Panel();
            btnCloseChildForm = new Button();
            lblTitle = new Label();
            btnTask = new Button();
            btnAttendance = new Button();
            btnComplaint = new Button();
            btnLogout = new Button();
            btnService = new Button();
            btnServiceRequest = new Button();
            panelMenu = new Panel();
            panelDesktopPane.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMinimize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxClose).BeginInit();
            panelTitleBar.SuspendLayout();
            panelLogo.SuspendLayout();
            panelMenu.SuspendLayout();
            SuspendLayout();
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
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
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.Black_and_Gold_Vintage_Luxury_Hotel_Logo__1__removebg_preview1;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(855, 690);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // labelUsername
            // 
            labelUsername.AutoSize = true;
            labelUsername.BackColor = Color.Transparent;
            labelUsername.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelUsername.ForeColor = Color.Black;
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
            pictureBoxMinimize.Location = new Point(803, 0);
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
            pictureBoxClose.Location = new Point(826, 0);
            pictureBoxClose.Name = "pictureBoxClose";
            pictureBoxClose.Size = new Size(29, 18);
            pictureBoxClose.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxClose.TabIndex = 2;
            pictureBoxClose.TabStop = false;
            pictureBoxClose.Click += pictureBoxClose_Click;
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
            btnCloseChildForm.Image = Properties.Resources.icons8_home_30;
            btnCloseChildForm.Location = new Point(152, 53);
            btnCloseChildForm.Name = "btnCloseChildForm";
            btnCloseChildForm.Size = new Size(56, 31);
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
            // btnTask
            // 
            btnTask.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnTask.Cursor = Cursors.Hand;
            btnTask.FlatAppearance.BorderSize = 0;
            btnTask.FlatStyle = FlatStyle.Flat;
            btnTask.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            btnTask.ForeColor = Color.Black;
            btnTask.Image = Properties.Resources.icons8_task_48;
            btnTask.ImageAlign = ContentAlignment.MiddleLeft;
            btnTask.Location = new Point(0, 289);
            btnTask.Margin = new Padding(4, 12, 4, 4);
            btnTask.Name = "btnTask";
            btnTask.Padding = new Padding(15, 0, 0, 0);
            btnTask.Size = new Size(208, 61);
            btnTask.TabIndex = 2;
            btnTask.Text = "Task";
            btnTask.TextAlign = ContentAlignment.MiddleLeft;
            btnTask.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnTask.UseVisualStyleBackColor = true;
            btnTask.Click += btnTask_Click_1;
            // 
            // btnAttendance
            // 
            btnAttendance.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnAttendance.Cursor = Cursors.Hand;
            btnAttendance.FlatAppearance.BorderSize = 0;
            btnAttendance.FlatStyle = FlatStyle.Flat;
            btnAttendance.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            btnAttendance.ForeColor = Color.Black;
            btnAttendance.Image = (Image)resources.GetObject("btnAttendance.Image");
            btnAttendance.ImageAlign = ContentAlignment.MiddleLeft;
            btnAttendance.Location = new Point(0, 91);
            btnAttendance.Margin = new Padding(4, 12, 4, 4);
            btnAttendance.Name = "btnAttendance";
            btnAttendance.Padding = new Padding(15, 0, 0, 0);
            btnAttendance.Size = new Size(208, 64);
            btnAttendance.TabIndex = 11;
            btnAttendance.Text = "Attendance";
            btnAttendance.TextAlign = ContentAlignment.MiddleLeft;
            btnAttendance.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAttendance.UseVisualStyleBackColor = true;
            btnAttendance.Click += btnAttendance_Click_1;
            // 
            // btnComplaint
            // 
            btnComplaint.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnComplaint.Cursor = Cursors.Hand;
            btnComplaint.FlatAppearance.BorderSize = 0;
            btnComplaint.FlatStyle = FlatStyle.Flat;
            btnComplaint.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            btnComplaint.ForeColor = Color.Black;
            btnComplaint.Image = Properties.Resources.icons8_complaint_48;
            btnComplaint.ImageAlign = ContentAlignment.MiddleLeft;
            btnComplaint.Location = new Point(0, 155);
            btnComplaint.Margin = new Padding(4, 12, 4, 4);
            btnComplaint.Name = "btnComplaint";
            btnComplaint.Padding = new Padding(15, 0, 0, 0);
            btnComplaint.Size = new Size(208, 75);
            btnComplaint.TabIndex = 10;
            btnComplaint.Text = "Complaint";
            btnComplaint.TextAlign = ContentAlignment.MiddleLeft;
            btnComplaint.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnComplaint.UseVisualStyleBackColor = true;
            btnComplaint.Click += btnComplaint_Click_1;
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
            btnLogout.Location = new Point(0, 350);
            btnLogout.Margin = new Padding(4, 12, 4, 4);
            btnLogout.Name = "btnLogout";
            btnLogout.Padding = new Padding(15, 0, 0, 0);
            btnLogout.Size = new Size(208, 58);
            btnLogout.TabIndex = 8;
            btnLogout.Text = "LogOut";
            btnLogout.TextAlign = ContentAlignment.MiddleLeft;
            btnLogout.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click_1;
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
            btnService.Location = new Point(0, 676);
            btnService.Margin = new Padding(4, 12, 4, 4);
            btnService.Name = "btnService";
            btnService.Padding = new Padding(15, 0, 0, 0);
            btnService.Size = new Size(216, 539);
            btnService.TabIndex = 7;
            btnService.Text = "Service";
            btnService.TextAlign = ContentAlignment.MiddleLeft;
            btnService.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnService.UseVisualStyleBackColor = true;
            // 
            // btnServiceRequest
            // 
            btnServiceRequest.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnServiceRequest.Cursor = Cursors.Hand;
            btnServiceRequest.FlatAppearance.BorderSize = 0;
            btnServiceRequest.FlatStyle = FlatStyle.Flat;
            btnServiceRequest.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            btnServiceRequest.ForeColor = Color.Black;
            btnServiceRequest.Image = Properties.Resources.icons8_service_48;
            btnServiceRequest.ImageAlign = ContentAlignment.MiddleLeft;
            btnServiceRequest.Location = new Point(0, 230);
            btnServiceRequest.Margin = new Padding(4, 12, 4, 4);
            btnServiceRequest.Name = "btnServiceRequest";
            btnServiceRequest.Padding = new Padding(15, 0, 0, 0);
            btnServiceRequest.Size = new Size(208, 59);
            btnServiceRequest.TabIndex = 4;
            btnServiceRequest.Text = "Service Request";
            btnServiceRequest.TextAlign = ContentAlignment.MiddleLeft;
            btnServiceRequest.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnServiceRequest.UseVisualStyleBackColor = true;
            btnServiceRequest.Click += btnServiceRequest_Click_1;
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.Transparent;
            panelMenu.Controls.Add(btnAttendance);
            panelMenu.Controls.Add(btnComplaint);
            panelMenu.Controls.Add(btnLogout);
            panelMenu.Controls.Add(btnService);
            panelMenu.Controls.Add(btnServiceRequest);
            panelMenu.Controls.Add(btnTask);
            panelMenu.Controls.Add(panelLogo);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Font = new Font("Cambria", 9.75F);
            panelMenu.Location = new Point(0, 0);
            panelMenu.Margin = new Padding(4, 0, 4, 4);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(208, 740);
            panelMenu.TabIndex = 3;
            // 
            // SupervisorForm
            // 
            BackColor = Color.White;
            ClientSize = new Size(1063, 740);
            Controls.Add(panelDesktopPane);
            Controls.Add(panelTitleBar);
            Controls.Add(panelMenu);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "SupervisorForm";
            StartPosition = FormStartPosition.CenterScreen;
            Load += SupervisorForm_Load;
            panelDesktopPane.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMinimize).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxClose).EndInit();
            panelTitleBar.ResumeLayout(false);
            panelTitleBar.PerformLayout();
            panelLogo.ResumeLayout(false);
            panelLogo.PerformLayout();
            panelMenu.ResumeLayout(false);
            ResumeLayout(false);


        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private Panel panelDesktopPane;
        private PictureBox pictureBox1;
        private Label labelUsername;
        private Label label1;
        private Label labelDateTime;
        private PictureBox pictureBoxMinimize;
        private PictureBox pictureBoxClose;
        private Panel panelTitleBar;
        private Panel panelLogo;
        private Panel panel1;
        private Button btnCloseChildForm;
        private Label lblTitle;
        private Button btnTask;
        private Button btnAttendance;
        private Button btnComplaint;
        private Button btnLogout;
        private Button btnService;
        private Button btnServiceRequest;
        private Panel panelMenu;
    }
}
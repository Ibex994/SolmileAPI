namespace Solmile.Forms.ManagerForms
{
    partial class ManagerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagerForm));
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
            labelUsername = new Label();
            panelMenu = new Panel();
            btnPaymentMeth = new Button();
            btnPayment = new Button();
            btnLogout = new Button();
            btnServType = new Button();
            btnUserRole = new Button();
            btnUser = new Button();
            btnRole = new Button();
            btnRes = new Button();
            btnRating = new Button();
            btnLog = new Button();
            btnfeedBack = new Button();
            btnEmp = new Button();
            btnComplaint = new Button();
            btnAttendance = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxClose).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMinimize).BeginInit();
            panelLogo.SuspendLayout();
            panelDesktopPane.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelTitleBar.SuspendLayout();
            panelMenu.SuspendLayout();
            SuspendLayout();
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
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
            btnCloseChildForm.Image = SolmileGuestHouseUI.Properties.Resources.icons8_home_30;
            btnCloseChildForm.Location = new Point(156, 12);
            btnCloseChildForm.Name = "btnCloseChildForm";
            btnCloseChildForm.Size = new Size(52, 45);
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
            // panelMenu
            // 
            panelMenu.BackColor = Color.Transparent;
            panelMenu.Controls.Add(btnPaymentMeth);
            panelMenu.Controls.Add(btnPayment);
            panelMenu.Controls.Add(btnLogout);
            panelMenu.Controls.Add(btnServType);
            panelMenu.Controls.Add(btnUserRole);
            panelMenu.Controls.Add(btnUser);
            panelMenu.Controls.Add(btnRole);
            panelMenu.Controls.Add(btnRes);
            panelMenu.Controls.Add(btnRating);
            panelMenu.Controls.Add(btnLog);
            panelMenu.Controls.Add(btnfeedBack);
            panelMenu.Controls.Add(btnEmp);
            panelMenu.Controls.Add(btnComplaint);
            panelMenu.Controls.Add(btnAttendance);
            panelMenu.Controls.Add(panelLogo);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Font = new Font("Cambria", 9.75F);
            panelMenu.Location = new Point(0, 0);
            panelMenu.Margin = new Padding(4, 0, 4, 4);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(208, 740);
            panelMenu.TabIndex = 3;
            // 
            // btnPaymentMeth
            // 
            btnPaymentMeth.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnPaymentMeth.Cursor = Cursors.Hand;
            btnPaymentMeth.FlatAppearance.BorderSize = 0;
            btnPaymentMeth.FlatStyle = FlatStyle.Flat;
            btnPaymentMeth.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            btnPaymentMeth.ForeColor = Color.Black;
            btnPaymentMeth.Image = SolmileGuestHouseUI.Properties.Resources.icons8_payment_method_48;
            btnPaymentMeth.ImageAlign = ContentAlignment.MiddleLeft;
            btnPaymentMeth.Location = new Point(0, 346);
            btnPaymentMeth.Margin = new Padding(4, 12, 4, 4);
            btnPaymentMeth.Name = "btnPaymentMeth";
            btnPaymentMeth.Padding = new Padding(15, 0, 0, 0);
            btnPaymentMeth.Size = new Size(208, 47);
            btnPaymentMeth.TabIndex = 20;
            btnPaymentMeth.Text = "Payment Method";
            btnPaymentMeth.TextAlign = ContentAlignment.MiddleLeft;
            btnPaymentMeth.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnPaymentMeth.UseVisualStyleBackColor = true;
            btnPaymentMeth.Click += btnPaymentMeth_Click;
            // 
            // btnPayment
            // 
            btnPayment.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnPayment.Cursor = Cursors.Hand;
            btnPayment.FlatAppearance.BorderSize = 0;
            btnPayment.FlatStyle = FlatStyle.Flat;
            btnPayment.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            btnPayment.ForeColor = Color.Black;
            btnPayment.Image = SolmileGuestHouseUI.Properties.Resources.icons8_payment_48;
            btnPayment.ImageAlign = ContentAlignment.MiddleLeft;
            btnPayment.Location = new Point(0, 293);
            btnPayment.Margin = new Padding(4, 12, 4, 4);
            btnPayment.Name = "btnPayment";
            btnPayment.Padding = new Padding(15, 0, 0, 0);
            btnPayment.Size = new Size(208, 55);
            btnPayment.TabIndex = 19;
            btnPayment.Text = "Payment";
            btnPayment.TextAlign = ContentAlignment.MiddleLeft;
            btnPayment.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnPayment.UseVisualStyleBackColor = true;
            btnPayment.Click += btnPayment_Click;
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
            btnLogout.Click += btnLogout_Click;
            // 
            // btnServType
            // 
            btnServType.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnServType.Cursor = Cursors.Hand;
            btnServType.FlatAppearance.BorderSize = 0;
            btnServType.FlatStyle = FlatStyle.Flat;
            btnServType.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            btnServType.ForeColor = Color.Black;
            btnServType.Image = SolmileGuestHouseUI.Properties.Resources.icons8_service_48__2_;
            btnServType.ImageAlign = ContentAlignment.MiddleLeft;
            btnServType.Location = new Point(0, 543);
            btnServType.Margin = new Padding(4, 12, 4, 4);
            btnServType.Name = "btnServType";
            btnServType.Padding = new Padding(15, 0, 0, 0);
            btnServType.Size = new Size(208, 49);
            btnServType.TabIndex = 17;
            btnServType.Text = "Service Type";
            btnServType.TextAlign = ContentAlignment.MiddleLeft;
            btnServType.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnServType.UseVisualStyleBackColor = true;
            btnServType.Click += btnServType_Click;
            // 
            // btnUserRole
            // 
            btnUserRole.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnUserRole.Cursor = Cursors.Hand;
            btnUserRole.FlatAppearance.BorderSize = 0;
            btnUserRole.FlatStyle = FlatStyle.Flat;
            btnUserRole.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            btnUserRole.ForeColor = Color.Black;
            btnUserRole.Image = SolmileGuestHouseUI.Properties.Resources.icons8_role_48;
            btnUserRole.ImageAlign = ContentAlignment.MiddleLeft;
            btnUserRole.Location = new Point(0, 641);
            btnUserRole.Margin = new Padding(4, 12, 4, 4);
            btnUserRole.Name = "btnUserRole";
            btnUserRole.Padding = new Padding(15, 0, 0, 0);
            btnUserRole.Size = new Size(208, 50);
            btnUserRole.TabIndex = 17;
            btnUserRole.Text = "User Role";
            btnUserRole.TextAlign = ContentAlignment.MiddleLeft;
            btnUserRole.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnUserRole.UseVisualStyleBackColor = true;
            btnUserRole.Click += btnUserRole_Click;
            // 
            // btnUser
            // 
            btnUser.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnUser.Cursor = Cursors.Hand;
            btnUser.FlatAppearance.BorderSize = 0;
            btnUser.FlatStyle = FlatStyle.Flat;
            btnUser.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            btnUser.ForeColor = Color.Black;
            btnUser.Image = SolmileGuestHouseUI.Properties.Resources.icons8_user_481;
            btnUser.ImageAlign = ContentAlignment.MiddleLeft;
            btnUser.Location = new Point(0, 593);
            btnUser.Margin = new Padding(4, 12, 4, 4);
            btnUser.Name = "btnUser";
            btnUser.Padding = new Padding(15, 0, 0, 0);
            btnUser.Size = new Size(208, 50);
            btnUser.TabIndex = 17;
            btnUser.Text = "User";
            btnUser.TextAlign = ContentAlignment.MiddleLeft;
            btnUser.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnUser.UseVisualStyleBackColor = true;
            btnUser.Click += btnUser_Click;
            // 
            // btnRole
            // 
            btnRole.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnRole.Cursor = Cursors.Hand;
            btnRole.FlatAppearance.BorderSize = 0;
            btnRole.FlatStyle = FlatStyle.Flat;
            btnRole.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            btnRole.ForeColor = Color.Black;
            btnRole.Image = SolmileGuestHouseUI.Properties.Resources.icons8_roles_48;
            btnRole.ImageAlign = ContentAlignment.MiddleLeft;
            btnRole.Location = new Point(0, 492);
            btnRole.Margin = new Padding(4, 12, 4, 4);
            btnRole.Name = "btnRole";
            btnRole.Padding = new Padding(15, 0, 0, 0);
            btnRole.Size = new Size(208, 57);
            btnRole.TabIndex = 17;
            btnRole.Text = "Role";
            btnRole.TextAlign = ContentAlignment.MiddleLeft;
            btnRole.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnRole.UseVisualStyleBackColor = true;
            btnRole.Click += btnRole_Click;
            // 
            // btnRes
            // 
            btnRes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnRes.Cursor = Cursors.Hand;
            btnRes.FlatAppearance.BorderSize = 0;
            btnRes.FlatStyle = FlatStyle.Flat;
            btnRes.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            btnRes.ForeColor = Color.Black;
            btnRes.Image = SolmileGuestHouseUI.Properties.Resources.icons8_reservation_48;
            btnRes.ImageAlign = ContentAlignment.MiddleLeft;
            btnRes.Location = new Point(0, 439);
            btnRes.Margin = new Padding(4, 12, 4, 4);
            btnRes.Name = "btnRes";
            btnRes.Padding = new Padding(15, 0, 0, 0);
            btnRes.Size = new Size(208, 49);
            btnRes.TabIndex = 17;
            btnRes.Text = "Reservation";
            btnRes.TextAlign = ContentAlignment.MiddleLeft;
            btnRes.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnRes.UseVisualStyleBackColor = true;
            btnRes.Click += btnRes_Click;
            // 
            // btnRating
            // 
            btnRating.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnRating.Cursor = Cursors.Hand;
            btnRating.FlatAppearance.BorderSize = 0;
            btnRating.FlatStyle = FlatStyle.Flat;
            btnRating.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            btnRating.ForeColor = Color.Black;
            btnRating.Image = SolmileGuestHouseUI.Properties.Resources.icons8_ratings_48;
            btnRating.ImageAlign = ContentAlignment.MiddleLeft;
            btnRating.Location = new Point(0, 390);
            btnRating.Margin = new Padding(4, 12, 4, 4);
            btnRating.Name = "btnRating";
            btnRating.Padding = new Padding(15, 0, 0, 0);
            btnRating.Size = new Size(208, 51);
            btnRating.TabIndex = 17;
            btnRating.Text = "Rating";
            btnRating.TextAlign = ContentAlignment.MiddleLeft;
            btnRating.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnRating.UseVisualStyleBackColor = true;
            btnRating.Click += btnRating_Click;
            // 
            // btnLog
            // 
            btnLog.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnLog.Cursor = Cursors.Hand;
            btnLog.FlatAppearance.BorderSize = 0;
            btnLog.FlatStyle = FlatStyle.Flat;
            btnLog.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            btnLog.ForeColor = Color.Black;
            btnLog.Image = SolmileGuestHouseUI.Properties.Resources.icons8_log_48;
            btnLog.ImageAlign = ContentAlignment.MiddleLeft;
            btnLog.Location = new Point(0, 250);
            btnLog.Margin = new Padding(4, 12, 4, 4);
            btnLog.Name = "btnLog";
            btnLog.Padding = new Padding(15, 0, 0, 0);
            btnLog.Size = new Size(208, 49);
            btnLog.TabIndex = 16;
            btnLog.Text = "Log";
            btnLog.TextAlign = ContentAlignment.MiddleLeft;
            btnLog.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLog.UseVisualStyleBackColor = true;
            btnLog.Click += btnLog_Click;
            // 
            // btnfeedBack
            // 
            btnfeedBack.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnfeedBack.Cursor = Cursors.Hand;
            btnfeedBack.FlatAppearance.BorderSize = 0;
            btnfeedBack.FlatStyle = FlatStyle.Flat;
            btnfeedBack.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            btnfeedBack.ForeColor = Color.Black;
            btnfeedBack.Image = SolmileGuestHouseUI.Properties.Resources.icons8_feedback_48;
            btnfeedBack.ImageAlign = ContentAlignment.MiddleLeft;
            btnfeedBack.Location = new Point(0, 205);
            btnfeedBack.Margin = new Padding(4, 12, 4, 4);
            btnfeedBack.Name = "btnfeedBack";
            btnfeedBack.Padding = new Padding(15, 0, 0, 0);
            btnfeedBack.Size = new Size(208, 50);
            btnfeedBack.TabIndex = 15;
            btnfeedBack.Text = "FeedBack";
            btnfeedBack.TextAlign = ContentAlignment.MiddleLeft;
            btnfeedBack.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnfeedBack.UseVisualStyleBackColor = true;
            btnfeedBack.Click += btnfeedBack_Click;
            // 
            // btnEmp
            // 
            btnEmp.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnEmp.Cursor = Cursors.Hand;
            btnEmp.FlatAppearance.BorderSize = 0;
            btnEmp.FlatStyle = FlatStyle.Flat;
            btnEmp.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            btnEmp.ForeColor = Color.Black;
            btnEmp.Image = SolmileGuestHouseUI.Properties.Resources.icons8_employee_48;
            btnEmp.ImageAlign = ContentAlignment.MiddleLeft;
            btnEmp.Location = new Point(0, 158);
            btnEmp.Margin = new Padding(4, 12, 4, 4);
            btnEmp.Name = "btnEmp";
            btnEmp.Padding = new Padding(15, 0, 0, 0);
            btnEmp.Size = new Size(208, 51);
            btnEmp.TabIndex = 14;
            btnEmp.Text = "Employee";
            btnEmp.TextAlign = ContentAlignment.MiddleLeft;
            btnEmp.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEmp.UseVisualStyleBackColor = true;
            btnEmp.Click += btnEmp_Click;
            // 
            // btnComplaint
            // 
            btnComplaint.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnComplaint.Cursor = Cursors.Hand;
            btnComplaint.FlatAppearance.BorderSize = 0;
            btnComplaint.FlatStyle = FlatStyle.Flat;
            btnComplaint.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            btnComplaint.ForeColor = Color.Black;
            btnComplaint.Image = SolmileGuestHouseUI.Properties.Resources.icons8_complaint_48;
            btnComplaint.ImageAlign = ContentAlignment.MiddleLeft;
            btnComplaint.Location = new Point(0, 106);
            btnComplaint.Margin = new Padding(4, 12, 4, 4);
            btnComplaint.Name = "btnComplaint";
            btnComplaint.Padding = new Padding(15, 0, 0, 0);
            btnComplaint.Size = new Size(208, 51);
            btnComplaint.TabIndex = 13;
            btnComplaint.Text = "Complaint";
            btnComplaint.TextAlign = ContentAlignment.MiddleLeft;
            btnComplaint.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnComplaint.UseVisualStyleBackColor = true;
            btnComplaint.Click += btnComplaint_Click;
            // 
            // btnAttendance
            // 
            btnAttendance.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnAttendance.Cursor = Cursors.Hand;
            btnAttendance.FlatAppearance.BorderSize = 0;
            btnAttendance.FlatStyle = FlatStyle.Flat;
            btnAttendance.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            btnAttendance.ForeColor = Color.Black;
            btnAttendance.Image = SolmileGuestHouseUI.Properties.Resources.icons8_attendance_48;
            btnAttendance.ImageAlign = ContentAlignment.MiddleLeft;
            btnAttendance.Location = new Point(0, 50);
            btnAttendance.Margin = new Padding(4, 12, 4, 4);
            btnAttendance.Name = "btnAttendance";
            btnAttendance.Padding = new Padding(15, 0, 0, 0);
            btnAttendance.Size = new Size(208, 51);
            btnAttendance.TabIndex = 12;
            btnAttendance.Text = "Attendance";
            btnAttendance.TextAlign = ContentAlignment.MiddleLeft;
            btnAttendance.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAttendance.UseVisualStyleBackColor = true;
            btnAttendance.Click += btnAttendance_Click;
            // 
            // ManagerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1063, 740);
            Controls.Add(panelDesktopPane);
            Controls.Add(panelTitleBar);
            Controls.Add(panelMenu);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ManagerForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ManagerForms";
            Load += ManagerForm_Load;
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
        private Button btnPaymentMeth;
        private Button btnPayment;
        private Button btnLogout;
        private Button btnRating;
        private Button btnLog;
        private Button btnfeedBack;
        private Button btnEmp;
        private Button btnComplaint;
        private Button btnAttendance;
        private Label labelUsername;
        private Button btnServType;
        private Button btnRole;
        private Button btnRes;
        private Button btnUser;
        private Button btnUserRole;
    }
}
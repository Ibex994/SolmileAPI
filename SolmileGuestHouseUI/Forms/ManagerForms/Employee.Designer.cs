namespace SolmileGuestHouseUI.Forms.ManagerForms
{
    partial class Employee
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.GroupBox grpEmployeeDetails;
        private System.Windows.Forms.Label lblEmployeeId;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.GroupBox grpActions;
        private System.Windows.Forms.Button btnCreateAccount;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnFindById;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpDateOfBirth;
        private System.Windows.Forms.DateTimePicker dtpHireDate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.ComboBox cmbBranch;
        private System.Windows.Forms.RadioButton chkStatus;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;

        private System.Windows.Forms.GroupBox grpSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;

        private System.Windows.Forms.DataGridView dgvEmployees;
        private System.Windows.Forms.ToolTip toolTip;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
                toolTip.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            grpEmployeeDetails = new GroupBox();
            grpStatus = new GroupBox();
            rbtnActive = new RadioButton();
            rbtnInactive = new RadioButton();
            cmbPosition = new ComboBox();
            txtPhone = new TextBox();
            txtEmail = new TextBox();
            txtLastName = new TextBox();
            txtFirstName = new TextBox();
            txtEmployeeId = new TextBox();
            cmbGender = new ComboBox();
            cmbBranch = new ComboBox();
            dtpHireDate = new DateTimePicker();
            dtpDateOfBirth = new DateTimePicker();
            label12 = new Label();
            label11 = new Label();
            lblEmployeeId = new Label();
            label10 = new Label();
            label9 = new Label();
            lblFirstName = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            lblLastName = new Label();
            lblEmail = new Label();
            lblPhone = new Label();
            lblPosition = new Label();
            grpActions = new GroupBox();
            btnClear = new Button();
            btnCreateAccount = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnFindById = new Button();
            grpSearch = new GroupBox();
            txtSearch = new TextBox();
            btnSearch = new Button();
            dgvEmployees = new DataGridView();
            toolTip = new ToolTip(components);
            grpEmployeeDetails.SuspendLayout();
            grpStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            grpActions.SuspendLayout();
            grpSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEmployees).BeginInit();
            SuspendLayout();
            // 
            // grpEmployeeDetails
            // 
            grpEmployeeDetails.BackColor = Color.Transparent;
            grpEmployeeDetails.Controls.Add(grpStatus);
            grpEmployeeDetails.Controls.Add(cmbPosition);
            grpEmployeeDetails.Controls.Add(txtPhone);
            grpEmployeeDetails.Controls.Add(txtEmail);
            grpEmployeeDetails.Controls.Add(txtLastName);
            grpEmployeeDetails.Controls.Add(txtFirstName);
            grpEmployeeDetails.Controls.Add(txtEmployeeId);
            grpEmployeeDetails.Controls.Add(cmbGender);
            grpEmployeeDetails.Controls.Add(cmbBranch);
            grpEmployeeDetails.Controls.Add(dtpHireDate);
            grpEmployeeDetails.Controls.Add(dtpDateOfBirth);
            grpEmployeeDetails.Controls.Add(label12);
            grpEmployeeDetails.Controls.Add(label11);
            grpEmployeeDetails.Controls.Add(lblEmployeeId);
            grpEmployeeDetails.Controls.Add(label10);
            grpEmployeeDetails.Controls.Add(label9);
            grpEmployeeDetails.Controls.Add(lblFirstName);
            grpEmployeeDetails.Controls.Add(pictureBox1);
            grpEmployeeDetails.Controls.Add(label2);
            grpEmployeeDetails.Controls.Add(lblLastName);
            grpEmployeeDetails.Controls.Add(lblEmail);
            grpEmployeeDetails.Controls.Add(lblPhone);
            grpEmployeeDetails.Controls.Add(lblPosition);
            grpEmployeeDetails.FlatStyle = FlatStyle.Flat;
            grpEmployeeDetails.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            grpEmployeeDetails.ForeColor = Color.FromArgb(45, 45, 48);
            grpEmployeeDetails.Location = new Point(14, 15);
            grpEmployeeDetails.Name = "grpEmployeeDetails";
            grpEmployeeDetails.Padding = new Padding(20);
            grpEmployeeDetails.Size = new Size(666, 300);
            grpEmployeeDetails.TabIndex = 0;
            grpEmployeeDetails.TabStop = false;
            grpEmployeeDetails.Text = "Employee Details";
            // 
            // grpStatus
            // 
            grpStatus.Controls.Add(rbtnActive);
            grpStatus.Controls.Add(rbtnInactive);
            grpStatus.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpStatus.Location = new Point(333, 106);
            grpStatus.Name = "grpStatus";
            grpStatus.Size = new Size(171, 43);
            grpStatus.TabIndex = 10;
            grpStatus.TabStop = false;
            // 
            // rbtnActive
            // 
            rbtnActive.AutoSize = true;
            rbtnActive.Checked = true;
            rbtnActive.Location = new Point(15, 19);
            rbtnActive.Name = "rbtnActive";
            rbtnActive.Size = new Size(64, 20);
            rbtnActive.TabIndex = 0;
            rbtnActive.TabStop = true;
            rbtnActive.Text = "Active";
            rbtnActive.UseVisualStyleBackColor = true;
            // 
            // rbtnInactive
            // 
            rbtnInactive.AutoSize = true;
            rbtnInactive.Location = new Point(100, 20);
            rbtnInactive.Name = "rbtnInactive";
            rbtnInactive.Size = new Size(75, 20);
            rbtnInactive.TabIndex = 1;
            rbtnInactive.Text = "Inactive";
            rbtnInactive.UseVisualStyleBackColor = true;
            // 
            // cmbPosition
            // 
            cmbPosition.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPosition.Font = new Font("Arial Narrow", 8.25F, FontStyle.Bold);
            cmbPosition.FormattingEnabled = true;
            cmbPosition.Location = new Point(115, 234);
            cmbPosition.Name = "cmbPosition";
            cmbPosition.Size = new Size(116, 23);
            cmbPosition.TabIndex = 17;
            // 
            // txtPhone
            // 
            txtPhone.Font = new Font("Arial Narrow", 8.25F, FontStyle.Bold);
            txtPhone.Location = new Point(115, 194);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(116, 20);
            txtPhone.TabIndex = 16;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Arial Narrow", 8.25F, FontStyle.Bold);
            txtEmail.Location = new Point(115, 155);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(116, 20);
            txtEmail.TabIndex = 16;
            // 
            // txtLastName
            // 
            txtLastName.Font = new Font("Arial Narrow", 8.25F, FontStyle.Bold);
            txtLastName.Location = new Point(115, 115);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(116, 20);
            txtLastName.TabIndex = 16;
            // 
            // txtFirstName
            // 
            txtFirstName.Font = new Font("Arial Narrow", 8.25F, FontStyle.Bold);
            txtFirstName.Location = new Point(115, 76);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(116, 20);
            txtFirstName.TabIndex = 16;
            // 
            // txtEmployeeId
            // 
            txtEmployeeId.Enabled = false;
            txtEmployeeId.Font = new Font("Arial Narrow", 8.25F, FontStyle.Bold);
            txtEmployeeId.Location = new Point(115, 38);
            txtEmployeeId.Name = "txtEmployeeId";
            txtEmployeeId.Size = new Size(116, 20);
            txtEmployeeId.TabIndex = 16;
            // 
            // cmbGender
            // 
            cmbGender.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGender.Font = new Font("Arial Narrow", 8.25F, FontStyle.Bold);
            cmbGender.FormattingEnabled = true;
            cmbGender.Items.AddRange(new object[] { "Male", "Female" });
            cmbGender.Location = new Point(333, 38);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(121, 23);
            cmbGender.TabIndex = 15;
            // 
            // cmbBranch
            // 
            cmbBranch.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBranch.Font = new Font("Arial Narrow", 8.25F, FontStyle.Bold);
            cmbBranch.FormattingEnabled = true;
            cmbBranch.Location = new Point(333, 77);
            cmbBranch.Name = "cmbBranch";
            cmbBranch.Size = new Size(121, 23);
            cmbBranch.TabIndex = 15;
            // 
            // dtpHireDate
            // 
            dtpHireDate.Font = new Font("Arial Narrow", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpHireDate.Location = new Point(382, 160);
            dtpHireDate.Name = "dtpHireDate";
            dtpHireDate.Size = new Size(197, 22);
            dtpHireDate.TabIndex = 13;
            // 
            // dtpDateOfBirth
            // 
            dtpDateOfBirth.Font = new Font("Arial Narrow", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpDateOfBirth.Location = new Point(382, 204);
            dtpDateOfBirth.Name = "dtpDateOfBirth";
            dtpDateOfBirth.Size = new Size(197, 22);
            dtpDateOfBirth.TabIndex = 13;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Arial", 11.25F, FontStyle.Bold);
            label12.ForeColor = Color.Goldenrod;
            label12.Location = new Point(257, 38);
            label12.Name = "label12";
            label12.Size = new Size(70, 18);
            label12.TabIndex = 0;
            label12.Text = "Gender :";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Arial", 11.25F, FontStyle.Bold);
            label11.ForeColor = Color.Goldenrod;
            label11.Location = new Point(257, 77);
            label11.Name = "label11";
            label11.Size = new Size(67, 18);
            label11.TabIndex = 0;
            label11.Text = "Branch :";
            // 
            // lblEmployeeId
            // 
            lblEmployeeId.AutoSize = true;
            lblEmployeeId.Font = new Font("Arial", 11.25F, FontStyle.Bold);
            lblEmployeeId.ForeColor = Color.Goldenrod;
            lblEmployeeId.Location = new Point(25, 38);
            lblEmployeeId.Name = "lblEmployeeId";
            lblEmployeeId.Size = new Size(100, 18);
            lblEmployeeId.TabIndex = 0;
            lblEmployeeId.Text = "Employee ID:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Arial", 11.25F, FontStyle.Bold);
            label10.ForeColor = Color.Goldenrod;
            label10.Location = new Point(257, 116);
            label10.Name = "label10";
            label10.Size = new Size(61, 18);
            label10.TabIndex = 0;
            label10.Text = "Status :";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial", 11.25F, FontStyle.Bold);
            label9.ForeColor = Color.Goldenrod;
            label9.Location = new Point(257, 160);
            label9.Name = "label9";
            label9.Size = new Size(94, 18);
            label9.TabIndex = 0;
            label9.Text = "Hired Birth :";
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Font = new Font("Arial", 11.25F, FontStyle.Bold);
            lblFirstName.ForeColor = Color.Goldenrod;
            lblFirstName.Location = new Point(25, 80);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(88, 18);
            lblFirstName.TabIndex = 2;
            lblFirstName.Text = "First Name:";
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Image = Properties.Resources.icons8_user_48;
            pictureBox1.Location = new Point(557, 17);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(109, 118);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBoxEmployee_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 11.25F, FontStyle.Bold);
            label2.ForeColor = Color.Goldenrod;
            label2.Location = new Point(257, 204);
            label2.Name = "label2";
            label2.Size = new Size(109, 18);
            label2.TabIndex = 0;
            label2.Text = "Date Of Birth :";
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Font = new Font("Arial", 11.25F, FontStyle.Bold);
            lblLastName.ForeColor = Color.Goldenrod;
            lblLastName.Location = new Point(25, 120);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(86, 18);
            lblLastName.TabIndex = 4;
            lblLastName.Text = "Last Name:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Arial", 11.25F, FontStyle.Bold);
            lblEmail.ForeColor = Color.Goldenrod;
            lblEmail.Location = new Point(25, 160);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(50, 18);
            lblEmail.TabIndex = 6;
            lblEmail.Text = "Email:";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Font = new Font("Arial", 11.25F, FontStyle.Bold);
            lblPhone.ForeColor = Color.Goldenrod;
            lblPhone.Location = new Point(25, 200);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(58, 18);
            lblPhone.TabIndex = 8;
            lblPhone.Text = "Phone:";
            // 
            // lblPosition
            // 
            lblPosition.AutoSize = true;
            lblPosition.Font = new Font("Arial", 11.25F, FontStyle.Bold);
            lblPosition.ForeColor = Color.Goldenrod;
            lblPosition.Location = new Point(25, 240);
            lblPosition.Name = "lblPosition";
            lblPosition.Size = new Size(70, 18);
            lblPosition.TabIndex = 10;
            lblPosition.Text = "Position:";
            // 
            // grpActions
            // 
            grpActions.BackColor = Color.White;
            grpActions.Controls.Add(btnClear);
            grpActions.Controls.Add(btnCreateAccount);
            grpActions.Controls.Add(btnUpdate);
            grpActions.Controls.Add(btnDelete);
            grpActions.Controls.Add(btnFindById);
            grpActions.FlatStyle = FlatStyle.Flat;
            grpActions.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            grpActions.ForeColor = Color.FromArgb(45, 45, 48);
            grpActions.Location = new Point(686, 15);
            grpActions.Name = "grpActions";
            grpActions.Padding = new Padding(20);
            grpActions.Size = new Size(164, 257);
            grpActions.TabIndex = 1;
            grpActions.TabStop = false;
            grpActions.Text = "Actions";
            // 
            // btnClear
            // 
            btnClear.FlatStyle = FlatStyle.Popup;
            btnClear.Font = new Font("Arial Narrow", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClear.ForeColor = Color.Black;
            btnClear.Location = new Point(124, 233);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(40, 23);
            btnClear.TabIndex = 4;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnCreateAccount
            // 
            btnCreateAccount.BackColor = Color.FromArgb(39, 174, 96);
            btnCreateAccount.Cursor = Cursors.Hand;
            btnCreateAccount.FlatAppearance.BorderSize = 0;
            btnCreateAccount.FlatStyle = FlatStyle.Flat;
            btnCreateAccount.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnCreateAccount.ForeColor = Color.White;
            btnCreateAccount.Location = new Point(17, 31);
            btnCreateAccount.Name = "btnCreateAccount";
            btnCreateAccount.Size = new Size(134, 31);
            btnCreateAccount.TabIndex = 0;
            btnCreateAccount.Text = "Create Account";
            toolTip.SetToolTip(btnCreateAccount, "Add new employee record");
            btnCreateAccount.UseVisualStyleBackColor = false;
            btnCreateAccount.Click += btnCreateAccount_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(241, 196, 15);
            btnUpdate.Cursor = Cursors.Hand;
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(17, 80);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(134, 31);
            btnUpdate.TabIndex = 1;
            btnUpdate.Text = "Update";
            toolTip.SetToolTip(btnUpdate, "Modify selected employee");
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(231, 76, 60);
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(17, 132);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(134, 31);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete";
            toolTip.SetToolTip(btnDelete, "Delete selected employee");
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnFindById
            // 
            btnFindById.BackColor = Color.FromArgb(52, 152, 219);
            btnFindById.Cursor = Cursors.Hand;
            btnFindById.FlatAppearance.BorderSize = 0;
            btnFindById.FlatStyle = FlatStyle.Flat;
            btnFindById.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnFindById.ForeColor = Color.Black;
            btnFindById.Location = new Point(17, 183);
            btnFindById.Name = "btnFindById";
            btnFindById.Size = new Size(134, 31);
            btnFindById.TabIndex = 3;
            btnFindById.Text = "Find by ID";
            toolTip.SetToolTip(btnFindById, "Find employee by their ID");
            btnFindById.UseVisualStyleBackColor = false;
            btnFindById.Click += btnFindById_Click;
            // 
            // grpSearch
            // 
            grpSearch.BackColor = Color.White;
            grpSearch.Controls.Add(txtSearch);
            grpSearch.Controls.Add(btnSearch);
            grpSearch.FlatStyle = FlatStyle.Flat;
            grpSearch.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            grpSearch.ForeColor = Color.FromArgb(45, 45, 48);
            grpSearch.Location = new Point(15, 330);
            grpSearch.Name = "grpSearch";
            grpSearch.Padding = new Padding(20);
            grpSearch.Size = new Size(835, 70);
            grpSearch.TabIndex = 2;
            grpSearch.TabStop = false;
            grpSearch.Text = "Search Employees";
            // 
            // txtSearch
            // 
            txtSearch.BorderStyle = BorderStyle.FixedSingle;
            txtSearch.Font = new Font("Segoe UI", 10F);
            txtSearch.Location = new Point(25, 32);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(650, 25);
            txtSearch.TabIndex = 0;
            toolTip.SetToolTip(txtSearch, "Enter employee name, email, or phone to search");
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(52, 152, 219);
            btnSearch.Cursor = Cursors.Hand;
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(690, 30);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(120, 30);
            btnSearch.TabIndex = 1;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // dgvEmployees
            // 
            dgvEmployees.AllowUserToAddRows = false;
            dgvEmployees.AllowUserToDeleteRows = false;
            dgvEmployees.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEmployees.BackgroundColor = Color.White;
            dgvEmployees.Font = new Font("Segoe UI", 9F);
            dgvEmployees.Location = new Point(15, 410);
            dgvEmployees.MultiSelect = false;
            dgvEmployees.Name = "dgvEmployees";
            dgvEmployees.ReadOnly = true;
            dgvEmployees.RowHeadersVisible = false;
            dgvEmployees.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEmployees.Size = new Size(835, 219);
            dgvEmployees.TabIndex = 3;
            dgvEmployees.CellClick += dgvEmployees_CellClick;
            // 
            // Employee
            // 
            BackColor = Color.White;
            Controls.Add(grpEmployeeDetails);
            Controls.Add(grpActions);
            Controls.Add(grpSearch);
            Controls.Add(dgvEmployees);
            Font = new Font("Segoe UI", 9F);
            ForeColor = Color.Black;
            Name = "Employee";
            Size = new Size(870, 637);
            grpEmployeeDetails.ResumeLayout(false);
            grpEmployeeDetails.PerformLayout();
            grpStatus.ResumeLayout(false);
            grpStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            grpActions.ResumeLayout(false);
            grpSearch.ResumeLayout(false);
            grpSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEmployees).EndInit();
            ResumeLayout(false);

        }

        #endregion


        private Button btnClear;
        private TextBox txtPhone;
        private TextBox txtEmail;
        private TextBox txtLastName;
        private TextBox txtFirstName;
        private TextBox txtEmployeeId;
        private ComboBox cmbPosition;
        private GroupBox grpStatus;
        private RadioButton rbtnActive;
        private RadioButton rbtnInactive;
    }
}

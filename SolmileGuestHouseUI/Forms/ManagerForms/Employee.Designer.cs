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

        private System.Windows.Forms.TextBox txtEmployeeId;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtPosition;

        private System.Windows.Forms.GroupBox grpActions;
        private System.Windows.Forms.Button btnCreateAccount;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnFindById;

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
            this.components = new System.ComponentModel.Container();

            this.grpEmployeeDetails = new System.Windows.Forms.GroupBox();
            this.lblEmployeeId = new System.Windows.Forms.Label();
            this.txtEmployeeId = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblPosition = new System.Windows.Forms.Label();
            this.txtPosition = new System.Windows.Forms.TextBox();

            this.grpActions = new System.Windows.Forms.GroupBox();
            this.btnCreateAccount = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnFindById = new System.Windows.Forms.Button();

            this.grpSearch = new System.Windows.Forms.GroupBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();

            this.dgvEmployees = new System.Windows.Forms.DataGridView();

            this.toolTip = new System.Windows.Forms.ToolTip(this.components);

            // 
            // grpEmployeeDetails
            // 
            this.grpEmployeeDetails.Text = "Employee Details";
            this.grpEmployeeDetails.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.grpEmployeeDetails.ForeColor = System.Drawing.Color.FromArgb(45, 45, 48);
            this.grpEmployeeDetails.Location = new System.Drawing.Point(15, 15);
            this.grpEmployeeDetails.Size = new System.Drawing.Size(510, 300);
            this.grpEmployeeDetails.Padding = new System.Windows.Forms.Padding(20);
            this.grpEmployeeDetails.BackColor = System.Drawing.Color.WhiteSmoke;
            this.grpEmployeeDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;

            int labelX = 25;
            int controlX = 170;
            int verticalSpacing = 45;

            // lblEmployeeId
            this.lblEmployeeId.Text = "Employee ID:";
            this.lblEmployeeId.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblEmployeeId.Location = new System.Drawing.Point(labelX, 40);
            this.lblEmployeeId.AutoSize = true;
            this.lblEmployeeId.ForeColor = System.Drawing.Color.FromArgb(80, 80, 80);

            // txtEmployeeId
            this.txtEmployeeId.Location = new System.Drawing.Point(controlX, 38);
            this.txtEmployeeId.Size = new System.Drawing.Size(310, 25);
            this.txtEmployeeId.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtEmployeeId.ReadOnly = true;
            this.txtEmployeeId.BackColor = System.Drawing.Color.White;
            this.txtEmployeeId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.toolTip.SetToolTip(this.txtEmployeeId, "Auto-generated Employee ID");

            // lblFirstName
            this.lblFirstName.Text = "First Name:";
            this.lblFirstName.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblFirstName.Location = new System.Drawing.Point(labelX, 40 + verticalSpacing);
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.ForeColor = System.Drawing.Color.FromArgb(80, 80, 80);

            // txtFirstName
            this.txtFirstName.Location = new System.Drawing.Point(controlX, 38 + verticalSpacing);
            this.txtFirstName.Size = new System.Drawing.Size(310, 25);
            this.txtFirstName.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtFirstName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            // lblLastName
            this.lblLastName.Text = "Last Name:";
            this.lblLastName.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblLastName.Location = new System.Drawing.Point(labelX, 40 + verticalSpacing * 2);
            this.lblLastName.AutoSize = true;
            this.lblLastName.ForeColor = System.Drawing.Color.FromArgb(80, 80, 80);

            // txtLastName
            this.txtLastName.Location = new System.Drawing.Point(controlX, 38 + verticalSpacing * 2);
            this.txtLastName.Size = new System.Drawing.Size(310, 25);
            this.txtLastName.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtLastName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            // lblEmail
            this.lblEmail.Text = "Email:";
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblEmail.Location = new System.Drawing.Point(labelX, 40 + verticalSpacing * 3);
            this.lblEmail.AutoSize = true;
            this.lblEmail.ForeColor = System.Drawing.Color.FromArgb(80, 80, 80);

            // txtEmail
            this.txtEmail.Location = new System.Drawing.Point(controlX, 38 + verticalSpacing * 3);
            this.txtEmail.Size = new System.Drawing.Size(310, 25);
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            // lblPhone
            this.lblPhone.Text = "Phone:";
            this.lblPhone.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblPhone.Location = new System.Drawing.Point(labelX, 40 + verticalSpacing * 4);
            this.lblPhone.AutoSize = true;
            this.lblPhone.ForeColor = System.Drawing.Color.FromArgb(80, 80, 80);

            // txtPhone
            this.txtPhone.Location = new System.Drawing.Point(controlX, 38 + verticalSpacing * 4);
            this.txtPhone.Size = new System.Drawing.Size(310, 25);
            this.txtPhone.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            // lblPosition
            this.lblPosition.Text = "Position:";
            this.lblPosition.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblPosition.Location = new System.Drawing.Point(labelX, 40 + verticalSpacing * 5);
            this.lblPosition.AutoSize = true;
            this.lblPosition.ForeColor = System.Drawing.Color.FromArgb(80, 80, 80);

            // txtPosition
            this.txtPosition.Location = new System.Drawing.Point(controlX, 38 + verticalSpacing * 5);
            this.txtPosition.Size = new System.Drawing.Size(310, 25);
            this.txtPosition.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtPosition.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            this.grpEmployeeDetails.Controls.Add(this.lblEmployeeId);
            this.grpEmployeeDetails.Controls.Add(this.txtEmployeeId);
            this.grpEmployeeDetails.Controls.Add(this.lblFirstName);
            this.grpEmployeeDetails.Controls.Add(this.txtFirstName);
            this.grpEmployeeDetails.Controls.Add(this.lblLastName);
            this.grpEmployeeDetails.Controls.Add(this.txtLastName);
            this.grpEmployeeDetails.Controls.Add(this.lblEmail);
            this.grpEmployeeDetails.Controls.Add(this.txtEmail);
            this.grpEmployeeDetails.Controls.Add(this.lblPhone);
            this.grpEmployeeDetails.Controls.Add(this.txtPhone);
            this.grpEmployeeDetails.Controls.Add(this.lblPosition);
            this.grpEmployeeDetails.Controls.Add(this.txtPosition);

            // 
            // grpActions
            // 
            this.grpActions.Text = "Actions";
            this.grpActions.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.grpActions.ForeColor = System.Drawing.Color.FromArgb(45, 45, 48);
            this.grpActions.Location = new System.Drawing.Point(545, 15);
            this.grpActions.Size = new System.Drawing.Size(290, 300);
            this.grpActions.Padding = new System.Windows.Forms.Padding(20);
            this.grpActions.BackColor = System.Drawing.Color.WhiteSmoke;
            this.grpActions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;

            System.Drawing.Size btnSize = new System.Drawing.Size(250, 45);
            System.Drawing.Font btnFont = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);

            // btnCreateAccount
            this.btnCreateAccount.Text = "Create Account";
            this.btnCreateAccount.Size = btnSize;
            this.btnCreateAccount.Location = new System.Drawing.Point(20, 40);
            this.btnCreateAccount.Font = btnFont;
            this.btnCreateAccount.BackColor = System.Drawing.Color.FromArgb(39, 174, 96); // Green
            this.btnCreateAccount.ForeColor = System.Drawing.Color.White;
            this.btnCreateAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateAccount.FlatAppearance.BorderSize = 0;
            this.btnCreateAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.toolTip.SetToolTip(this.btnCreateAccount, "Add new employee record");
            this.btnCreateAccount.Click += new System.EventHandler(this.btnCreateAccount_Click);

            // btnUpdate
            this.btnUpdate.Text = "Update";
            this.btnUpdate.Size = btnSize;
            this.btnUpdate.Location = new System.Drawing.Point(20, 100);
            this.btnUpdate.Font = btnFont;
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(52, 152, 219); // Blue
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.toolTip.SetToolTip(this.btnUpdate, "Modify selected employee");
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);

            // btnDelete
            this.btnDelete.Text = "Delete";
            this.btnDelete.Size = btnSize;
            this.btnDelete.Location = new System.Drawing.Point(20, 160);
            this.btnDelete.Font = btnFont;
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(231, 76, 60); // Red
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.toolTip.SetToolTip(this.btnDelete, "Delete selected employee");
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);

            // btnFindById
            this.btnFindById.Text = "Find by ID";
            this.btnFindById.Size = btnSize;
            this.btnFindById.Location = new System.Drawing.Point(20, 220);
            this.btnFindById.Font = btnFont;
            this.btnFindById.BackColor = System.Drawing.Color.FromArgb(241, 196, 15); // Yellow
            this.btnFindById.ForeColor = System.Drawing.Color.Black;
            this.btnFindById.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFindById.FlatAppearance.BorderSize = 0;
            this.btnFindById.Cursor = System.Windows.Forms.Cursors.Hand;
            this.toolTip.SetToolTip(this.btnFindById, "Find employee by their ID");
            this.btnFindById.Click += new System.EventHandler(this.btnFindById_Click);

            this.grpActions.Controls.Add(this.btnCreateAccount);
            this.grpActions.Controls.Add(this.btnUpdate);
            this.grpActions.Controls.Add(this.btnDelete);
            this.grpActions.Controls.Add(this.btnFindById);

            // 
            // grpSearch
            // 
            this.grpSearch.Text = "Search Employees";
            this.grpSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.grpSearch.ForeColor = System.Drawing.Color.FromArgb(45, 45, 48);
            this.grpSearch.Location = new System.Drawing.Point(15, 330);
            this.grpSearch.Size = new System.Drawing.Size(820, 70);
            this.grpSearch.Padding = new System.Windows.Forms.Padding(20);
            this.grpSearch.BackColor = System.Drawing.Color.WhiteSmoke;
            this.grpSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;

            this.txtSearch.Location = new System.Drawing.Point(25, 32);
            this.txtSearch.Size = new System.Drawing.Size(650, 28);
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.toolTip.SetToolTip(this.txtSearch, "Enter employee name, email, or phone to search");

            this.btnSearch.Text = "Search";
            this.btnSearch.Size = new System.Drawing.Size(120, 30);
            this.btnSearch.Location = new System.Drawing.Point(690, 30);
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(39, 174, 96); // Green
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);

            this.grpSearch.Controls.Add(this.txtSearch);
            this.grpSearch.Controls.Add(this.btnSearch);

            // 
            // dgvEmployees
            // 
            this.dgvEmployees.Location = new System.Drawing.Point(15, 410);
            this.dgvEmployees.Size = new System.Drawing.Size(820, 300);
            this.dgvEmployees.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dgvEmployees.BackgroundColor = System.Drawing.Color.White;
            this.dgvEmployees.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dgvEmployees.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmployees.MultiSelect = false;
            this.dgvEmployees.ReadOnly = true;
            this.dgvEmployees.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEmployees.AllowUserToAddRows = false;
            this.dgvEmployees.AllowUserToDeleteRows = false;
            this.dgvEmployees.RowHeadersVisible = false;

            // 
            // Employee (UserControl)
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.grpEmployeeDetails);
            this.Controls.Add(this.grpActions);
            this.Controls.Add(this.grpSearch);
            this.Controls.Add(this.dgvEmployees);

            this.Size = new System.Drawing.Size(860, 730);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
        }

        #endregion
    }
}

namespace SolmileGuestHouseUI.Forms.ManagerForms
{
    partial class Attendance
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblEmployeeId;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblStatus;

        private System.Windows.Forms.TextBox txtEmployeeId;
        private System.Windows.Forms.DateTimePicker dtpAttendanceDate;
        private System.Windows.Forms.TextBox txtStatus;

        private System.Windows.Forms.Button btnGetAll;
        private System.Windows.Forms.Button btnGetByEmployeeAndDate;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;

        private System.Windows.Forms.DataGridView dgvAttendance;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        private void InitializeComponent()
        {
            lblEmployeeId = new Label();
            lblDate = new Label();
            lblStatus = new Label();
            txtEmployeeId = new TextBox();
            dtpAttendanceDate = new DateTimePicker();
            txtStatus = new TextBox();
            btnGetAll = new Button();
            btnGetByEmployeeAndDate = new Button();
            btnCreate = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            dgvAttendance = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvAttendance).BeginInit();
            SuspendLayout();
            // 
            // lblEmployeeId
            // 
            lblEmployeeId.AutoSize = true;
            lblEmployeeId.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEmployeeId.ForeColor = Color.Goldenrod;
            lblEmployeeId.Location = new Point(20, 20);
            lblEmployeeId.Name = "lblEmployeeId";
            lblEmployeeId.Size = new Size(85, 14);
            lblEmployeeId.TabIndex = 0;
            lblEmployeeId.Text = "Employee ID:";
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDate.ForeColor = Color.Goldenrod;
            lblDate.Location = new Point(20, 60);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(108, 14);
            lblDate.TabIndex = 2;
            lblDate.Text = "Attendance Date:";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStatus.ForeColor = Color.Goldenrod;
            lblStatus.Location = new Point(20, 100);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(55, 14);
            lblStatus.TabIndex = 4;
            lblStatus.Text = "Reason:";
            // 
            // txtEmployeeId
            // 
            txtEmployeeId.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmployeeId.Location = new Point(120, 17);
            txtEmployeeId.Name = "txtEmployeeId";
            txtEmployeeId.Size = new Size(200, 23);
            txtEmployeeId.TabIndex = 1;
            // 
            // dtpAttendanceDate
            // 
            dtpAttendanceDate.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpAttendanceDate.Location = new Point(132, 53);
            dtpAttendanceDate.Name = "dtpAttendanceDate";
            dtpAttendanceDate.Size = new Size(249, 23);
            dtpAttendanceDate.TabIndex = 3;
            // 
            // txtStatus
            // 
            txtStatus.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtStatus.Location = new Point(120, 97);
            txtStatus.Name = "txtStatus";
            txtStatus.Size = new Size(200, 23);
            txtStatus.TabIndex = 5;
            // 
            // btnGetAll
            // 
            btnGetAll.BackColor = Color.Goldenrod;
            btnGetAll.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGetAll.Location = new Point(350, 15);
            btnGetAll.Name = "btnGetAll";
            btnGetAll.Size = new Size(100, 25);
            btnGetAll.TabIndex = 6;
            btnGetAll.Text = "Get All";
            btnGetAll.UseVisualStyleBackColor = false;
            btnGetAll.Click += btnGetAll_Click;
            // 
            // btnGetByEmployeeAndDate
            // 
            btnGetByEmployeeAndDate.BackColor = Color.Goldenrod;
            btnGetByEmployeeAndDate.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGetByEmployeeAndDate.Location = new Point(470, 53);
            btnGetByEmployeeAndDate.Name = "btnGetByEmployeeAndDate";
            btnGetByEmployeeAndDate.Size = new Size(100, 25);
            btnGetByEmployeeAndDate.TabIndex = 7;
            btnGetByEmployeeAndDate.Text = "Get by ID & Date";
            btnGetByEmployeeAndDate.UseVisualStyleBackColor = false;
            btnGetByEmployeeAndDate.Click += btnGetByEmployeeAndDate_Click;
            // 
            // btnCreate
            // 
            btnCreate.BackColor = Color.FromArgb(0, 192, 0);
            btnCreate.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCreate.Location = new Point(470, 15);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(100, 25);
            btnCreate.TabIndex = 8;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = false;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.Goldenrod;
            btnUpdate.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUpdate.Location = new Point(590, 53);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(100, 25);
            btnUpdate.TabIndex = 9;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Red;
            btnDelete.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(590, 15);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(100, 25);
            btnDelete.TabIndex = 10;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // dgvAttendance
            // 
            dgvAttendance.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAttendance.Location = new Point(20, 140);
            dgvAttendance.Name = "dgvAttendance";
            dgvAttendance.Size = new Size(821, 528);
            dgvAttendance.TabIndex = 11;
            // 
            // Attendance
            // 
            BackColor = Color.White;
            Controls.Add(lblEmployeeId);
            Controls.Add(txtEmployeeId);
            Controls.Add(lblDate);
            Controls.Add(dtpAttendanceDate);
            Controls.Add(lblStatus);
            Controls.Add(txtStatus);
            Controls.Add(btnGetAll);
            Controls.Add(btnGetByEmployeeAndDate);
            Controls.Add(btnCreate);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(dgvAttendance);
            Name = "Attendance";
            Size = new Size(855, 690);
            ((System.ComponentModel.ISupportInitialize)dgvAttendance).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}

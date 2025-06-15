namespace SolmileGuestHouseUI.Forms.ManagerForms
{
    partial class Attendance
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblEmployeeId;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblIsPresent;

        private System.Windows.Forms.ComboBox cmbIsPresent;
        //private System.Windows.Forms.TextBox.txtEmployeeId;


        private System.Windows.Forms.DateTimePicker dtpAttendanceDate;
        private System.Windows.Forms.TextBox txtReason;
        private System.Windows.Forms.Button btnGetByEmployeeAndDate;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;

        private System.Windows.Forms.TabControl tabControlAttendance;
        private System.Windows.Forms.TabPage tabSingleAttendance;
        private System.Windows.Forms.TabPage tabMultipleAttendance;

        private TabPage tabSummary;
        private Button btnGenerateSummary;
        private DataGridView dgvMonthlySummary;

        private System.Windows.Forms.DataGridView dgvAttendance;
        private System.Windows.Forms.DataGridView dgvMultipleAttendance;

        private System.Windows.Forms.Button btnMultipleSave;

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
            lblIsPresent = new Label();
            dtpAttendanceDate = new DateTimePicker();
            txtReason = new TextBox();
            cmbIsPresent = new ComboBox();
            btnGetByEmployeeAndDate = new Button();
            btnCreate = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            dgvAttendance = new DataGridView();
            dgvMultipleAttendance = new DataGridView();
            btnMultipleSave = new Button();
            tabControlAttendance = new TabControl();
            tabMultipleAttendance = new TabPage();
            dateTimePicker2 = new DateTimePicker();
            dateTimePicker1 = new DateTimePicker();
            dateTime2 = new DateTimePicker();
            tabSingleAttendance = new TabPage();
            txtEmployeeId = new TextBox();
            btnGetAll = new PictureBox();
            btnById = new Button();
            btnClear = new Button();
            tabSummary = new TabPage();
            txtEmpId = new TextBox();
            dtpSummaryMonth = new DateTimePicker();
            btnGetIdDate = new Button();
            btnGenerateSummary = new Button();
            dgvMonthlySummary = new DataGridView();
            clear = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvAttendance).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvMultipleAttendance).BeginInit();
            tabControlAttendance.SuspendLayout();
            tabMultipleAttendance.SuspendLayout();
            tabSingleAttendance.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnGetAll).BeginInit();
            tabSummary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMonthlySummary).BeginInit();
            SuspendLayout();
            // 
            // lblEmployeeId
            // 
            lblEmployeeId.AutoSize = true;
            lblEmployeeId.Font = new Font("Arial Rounded MT Bold", 9F);
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
            lblDate.Font = new Font("Arial Rounded MT Bold", 9F);
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
            lblStatus.Font = new Font("Arial Rounded MT Bold", 9F);
            lblStatus.ForeColor = Color.Goldenrod;
            lblStatus.Location = new Point(220, 100);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(55, 14);
            lblStatus.TabIndex = 6;
            lblStatus.Text = "Reason:";
            // 
            // lblIsPresent
            // 
            lblIsPresent.AutoSize = true;
            lblIsPresent.Font = new Font("Arial Rounded MT Bold", 9F);
            lblIsPresent.ForeColor = Color.Goldenrod;
            lblIsPresent.Location = new Point(20, 100);
            lblIsPresent.Name = "lblIsPresent";
            lblIsPresent.Size = new Size(48, 14);
            lblIsPresent.TabIndex = 4;
            lblIsPresent.Text = "Status:";
            // 
            // dtpAttendanceDate
            // 
            dtpAttendanceDate.Font = new Font("Arial Rounded MT Bold", 9.75F);
            dtpAttendanceDate.Location = new Point(132, 53);
            dtpAttendanceDate.Name = "dtpAttendanceDate";
            dtpAttendanceDate.Size = new Size(250, 23);
            dtpAttendanceDate.TabIndex = 3;
            // 
            // txtReason
            // 
            txtReason.Font = new Font("Arial Rounded MT Bold", 9.75F);
            txtReason.Location = new Point(280, 95);
            txtReason.Name = "txtReason";
            txtReason.Size = new Size(250, 23);
            txtReason.TabIndex = 7;
            // 
            // cmbIsPresent
            // 
            cmbIsPresent.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbIsPresent.Font = new Font("Arial Rounded MT Bold", 9.75F);
            cmbIsPresent.Items.AddRange(new object[] { "Present", "Absent" });
            cmbIsPresent.Location = new Point(80, 95);
            cmbIsPresent.Name = "cmbIsPresent";
            cmbIsPresent.Size = new Size(121, 23);
            cmbIsPresent.TabIndex = 5;
            // 
            // btnGetByEmployeeAndDate
            // 
            btnGetByEmployeeAndDate.BackColor = SystemColors.MenuHighlight;
            btnGetByEmployeeAndDate.Font = new Font("Arial Rounded MT Bold", 9.75F);
            btnGetByEmployeeAndDate.Location = new Point(627, 51);
            btnGetByEmployeeAndDate.Name = "btnGetByEmployeeAndDate";
            btnGetByEmployeeAndDate.Size = new Size(111, 30);
            btnGetByEmployeeAndDate.TabIndex = 9;
            btnGetByEmployeeAndDate.Text = "Get by ID & Date";
            btnGetByEmployeeAndDate.UseVisualStyleBackColor = false;
            btnGetByEmployeeAndDate.Click += btnGetByEmployeeAndDate_Click;
            // 
            // btnCreate
            // 
            btnCreate.BackColor = Color.FromArgb(0, 192, 0);
            btnCreate.Font = new Font("Arial Rounded MT Bold", 9.75F);
            btnCreate.Location = new Point(541, 15);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(80, 30);
            btnCreate.TabIndex = 10;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = false;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.Goldenrod;
            btnUpdate.Font = new Font("Arial Rounded MT Bold", 9.75F);
            btnUpdate.Location = new Point(541, 53);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(80, 30);
            btnUpdate.TabIndex = 11;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Red;
            btnDelete.Font = new Font("Arial Rounded MT Bold", 9.75F);
            btnDelete.Location = new Point(541, 91);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(80, 30);
            btnDelete.TabIndex = 12;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // dgvAttendance
            // 
            dgvAttendance.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAttendance.BackgroundColor = Color.White;
            dgvAttendance.Location = new Point(20, 127);
            dgvAttendance.Name = "dgvAttendance";
            dgvAttendance.ReadOnly = true;
            dgvAttendance.Size = new Size(770, 476);
            dgvAttendance.TabIndex = 13;
            dgvAttendance.CellClick += dgvAttendance_CellClick;
            // 
            // dgvMultipleAttendance
            // 
            dgvMultipleAttendance.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMultipleAttendance.BackgroundColor = Color.White;
            dgvMultipleAttendance.Location = new Point(20, 60);
            dgvMultipleAttendance.Name = "dgvMultipleAttendance";
            dgvMultipleAttendance.Size = new Size(760, 580);
            dgvMultipleAttendance.TabIndex = 0;
            // 
            // btnMultipleSave
            // 
            btnMultipleSave.BackColor = Color.FromArgb(0, 192, 0);
            btnMultipleSave.Font = new Font("Arial Rounded MT Bold", 9.75F);
            btnMultipleSave.Location = new Point(298, 15);
            btnMultipleSave.Name = "btnMultipleSave";
            btnMultipleSave.Size = new Size(140, 30);
            btnMultipleSave.TabIndex = 1;
            btnMultipleSave.Text = "Create Date";
            btnMultipleSave.UseVisualStyleBackColor = false;
            btnMultipleSave.Click += btnMultipleSave_Click;
            // 
            // tabControlAttendance
            // 
            tabControlAttendance.Controls.Add(tabMultipleAttendance);
            tabControlAttendance.Controls.Add(tabSingleAttendance);
            tabControlAttendance.Controls.Add(tabSummary);
            tabControlAttendance.Font = new Font("Arial Rounded MT Bold", 9F);
            tabControlAttendance.Location = new Point(5, 5);
            tabControlAttendance.Name = "tabControlAttendance";
            tabControlAttendance.SelectedIndex = 0;
            tabControlAttendance.Size = new Size(810, 670);
            tabControlAttendance.TabIndex = 0;
            // 
            // tabMultipleAttendance
            // 
            tabMultipleAttendance.BackColor = Color.White;
            tabMultipleAttendance.Controls.Add(dateTimePicker2);
            tabMultipleAttendance.Controls.Add(dateTimePicker1);
            tabMultipleAttendance.Controls.Add(dateTime2);
            tabMultipleAttendance.Controls.Add(btnMultipleSave);
            tabMultipleAttendance.Controls.Add(dgvMultipleAttendance);
            tabMultipleAttendance.Location = new Point(4, 23);
            tabMultipleAttendance.Name = "tabMultipleAttendance";
            tabMultipleAttendance.Size = new Size(802, 643);
            tabMultipleAttendance.TabIndex = 1;
            tabMultipleAttendance.Text = "Create Date";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(36, 19);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(244, 21);
            dateTimePicker2.TabIndex = 2;
            dateTimePicker2.Value = new DateTime(2025, 6, 15, 13, 4, 55, 0);
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(36, 19);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(244, 21);
            dateTimePicker1.TabIndex = 2;
            // 
            // dateTime2
            // 
            dateTime2.Location = new Point(36, 19);
            dateTime2.Name = "dateTime2";
            dateTime2.Size = new Size(244, 21);
            dateTime2.TabIndex = 2;
            // 
            // tabSingleAttendance
            // 
            tabSingleAttendance.BackColor = Color.White;
            tabSingleAttendance.Controls.Add(txtEmployeeId);
            tabSingleAttendance.Controls.Add(btnGetAll);
            tabSingleAttendance.Controls.Add(btnById);
            tabSingleAttendance.Controls.Add(lblEmployeeId);
            tabSingleAttendance.Controls.Add(lblDate);
            tabSingleAttendance.Controls.Add(dtpAttendanceDate);
            tabSingleAttendance.Controls.Add(lblIsPresent);
            tabSingleAttendance.Controls.Add(cmbIsPresent);
            tabSingleAttendance.Controls.Add(lblStatus);
            tabSingleAttendance.Controls.Add(txtReason);
            tabSingleAttendance.Controls.Add(btnClear);
            tabSingleAttendance.Controls.Add(btnGetByEmployeeAndDate);
            tabSingleAttendance.Controls.Add(btnCreate);
            tabSingleAttendance.Controls.Add(btnUpdate);
            tabSingleAttendance.Controls.Add(btnDelete);
            tabSingleAttendance.Controls.Add(dgvAttendance);
            tabSingleAttendance.Location = new Point(4, 23);
            tabSingleAttendance.Name = "tabSingleAttendance";
            tabSingleAttendance.Size = new Size(802, 643);
            tabSingleAttendance.TabIndex = 0;
            tabSingleAttendance.Text = "Single Attendance";
            // 
            // txtEmployeeId
            // 
            txtEmployeeId.Location = new Point(132, 17);
            txtEmployeeId.Name = "txtEmployeeId";
            txtEmployeeId.Size = new Size(250, 21);
            txtEmployeeId.TabIndex = 16;
            // 
            // btnGetAll
            // 
            btnGetAll.Image = Properties.Resources.icons8_refresh_48;
            btnGetAll.Location = new Point(20, 155);
            btnGetAll.Name = "btnGetAll";
            btnGetAll.Size = new Size(31, 22);
            btnGetAll.SizeMode = PictureBoxSizeMode.Zoom;
            btnGetAll.TabIndex = 15;
            btnGetAll.TabStop = false;
            btnGetAll.Click += btnGetAll_Click;
            // 
            // btnById
            // 
            btnById.BackColor = SystemColors.MenuHighlight;
            btnById.Font = new Font("Arial Rounded MT Bold", 9.75F);
            btnById.Location = new Point(627, 16);
            btnById.Name = "btnById";
            btnById.Size = new Size(80, 28);
            btnById.TabIndex = 14;
            btnById.Text = "Get By ID";
            btnById.UseVisualStyleBackColor = false;
            btnById.Click += btnById_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = SystemColors.MenuHighlight;
            btnClear.Font = new Font("Arial Rounded MT Bold", 9.75F);
            btnClear.Location = new Point(737, 609);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(53, 30);
            btnClear.TabIndex = 9;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click_1;
            // 
            // tabSummary
            // 
            tabSummary.BackColor = Color.White;
            tabSummary.Controls.Add(clear);
            tabSummary.Controls.Add(txtEmpId);
            tabSummary.Controls.Add(dtpSummaryMonth);
            tabSummary.Controls.Add(btnGetIdDate);
            tabSummary.Controls.Add(btnGenerateSummary);
            tabSummary.Controls.Add(dgvMonthlySummary);
            tabSummary.Location = new Point(4, 23);
            tabSummary.Name = "tabSummary";
            tabSummary.Size = new Size(802, 643);
            tabSummary.TabIndex = 2;
            tabSummary.Text = "Monthly Summary";
            // 
            // txtEmpId
            // 
            txtEmpId.Location = new Point(215, 26);
            txtEmpId.Name = "txtEmpId";
            txtEmpId.Size = new Size(231, 21);
            txtEmpId.TabIndex = 5;
            // 
            // dtpSummaryMonth
            // 
            dtpSummaryMonth.Location = new Point(215, 53);
            dtpSummaryMonth.Name = "dtpSummaryMonth";
            dtpSummaryMonth.Size = new Size(231, 21);
            dtpSummaryMonth.TabIndex = 4;
            // 
            // btnGetIdDate
            // 
            btnGetIdDate.BackColor = SystemColors.MenuHighlight;
            btnGetIdDate.Font = new Font("Arial Rounded MT Bold", 9.75F);
            btnGetIdDate.Location = new Point(467, 26);
            btnGetIdDate.Name = "btnGetIdDate";
            btnGetIdDate.Size = new Size(131, 25);
            btnGetIdDate.TabIndex = 1;
            btnGetIdDate.Text = "Get By ID&Date";
            btnGetIdDate.UseVisualStyleBackColor = false;
            btnGetIdDate.Click += btnGetIdDate_Click;
            // 
            // btnGenerateSummary
            // 
            btnGenerateSummary.BackColor = Color.MediumSeaGreen;
            btnGenerateSummary.Font = new Font("Arial Rounded MT Bold", 9.75F);
            btnGenerateSummary.Location = new Point(467, 58);
            btnGenerateSummary.Name = "btnGenerateSummary";
            btnGenerateSummary.Size = new Size(146, 25);
            btnGenerateSummary.TabIndex = 1;
            btnGenerateSummary.Text = "Generate Summary";
            btnGenerateSummary.UseVisualStyleBackColor = false;
            btnGenerateSummary.Click += btnGenerateSummary_Click;
            // 
            // dgvMonthlySummary
            // 
            dgvMonthlySummary.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMonthlySummary.BackgroundColor = Color.White;
            dgvMonthlySummary.Location = new Point(30, 97);
            dgvMonthlySummary.Name = "dgvMonthlySummary";
            dgvMonthlySummary.Size = new Size(760, 513);
            dgvMonthlySummary.TabIndex = 2;
            // 
            // clear
            // 
            clear.BackColor = SystemColors.MenuHighlight;
            clear.Font = new Font("Arial Rounded MT Bold", 9.75F);
            clear.Location = new Point(737, 613);
            clear.Name = "clear";
            clear.Size = new Size(53, 30);
            clear.TabIndex = 10;
            clear.Text = "Clear";
            clear.UseVisualStyleBackColor = false;
            clear.Click += clear_Click;
            // 
            // Attendance
            // 
            BackColor = Color.White;
            Controls.Add(tabControlAttendance);
            Name = "Attendance";
            Size = new Size(820, 680);
            Load += Attendance_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAttendance).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvMultipleAttendance).EndInit();
            tabControlAttendance.ResumeLayout(false);
            tabMultipleAttendance.ResumeLayout(false);
            tabSingleAttendance.ResumeLayout(false);
            tabSingleAttendance.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnGetAll).EndInit();
            tabSummary.ResumeLayout(false);
            tabSummary.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMonthlySummary).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DateTimePicker dateTime2;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private Button btnById;
        private PictureBox btnGetAll;
        private Button btnGetIdDate;
        private DateTimePicker dtpSummaryMonth;
        private TextBox txtEmployeeId;
        private TextBox txtEmpId;
        private Button btnClear;
        private Button clear;
    }
}

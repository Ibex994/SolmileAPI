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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
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
            groupBox1 = new GroupBox();
            btnById = new Button();
            txtUsername = new TextBox();
            txtEmployeeId = new TextBox();
            btnGetAll = new PictureBox();
            lblName = new Label();
            tabSummary = new TabPage();
            clear = new Button();
            txtEmpId = new TextBox();
            dtpSummaryMonth = new DateTimePicker();
            btnGetIdDate = new Button();
            btnGenerateSummary = new Button();
            dgvMonthlySummary = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvAttendance).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvMultipleAttendance).BeginInit();
            tabControlAttendance.SuspendLayout();
            tabMultipleAttendance.SuspendLayout();
            tabSingleAttendance.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnGetAll).BeginInit();
            tabSummary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMonthlySummary).BeginInit();
            SuspendLayout();
            // 
            // lblEmployeeId
            // 
            lblEmployeeId.AutoSize = true;
            lblEmployeeId.Font = new Font("Arial", 11.25F, FontStyle.Bold);
            lblEmployeeId.ForeColor = Color.Goldenrod;
            lblEmployeeId.Location = new Point(20, 24);
            lblEmployeeId.Name = "lblEmployeeId";
            lblEmployeeId.Size = new Size(100, 18);
            lblEmployeeId.TabIndex = 0;
            lblEmployeeId.Text = "Employee ID:";
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Font = new Font("Arial", 11.25F, FontStyle.Bold);
            lblDate.ForeColor = Color.Goldenrod;
            lblDate.Location = new Point(20, 78);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(129, 18);
            lblDate.TabIndex = 2;
            lblDate.Text = "Attendance Date:";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Arial", 11.25F, FontStyle.Bold);
            lblStatus.ForeColor = Color.Goldenrod;
            lblStatus.Location = new Point(20, 225);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(66, 18);
            lblStatus.TabIndex = 6;
            lblStatus.Text = "Reason:";
            // 
            // lblIsPresent
            // 
            lblIsPresent.AutoSize = true;
            lblIsPresent.Font = new Font("Arial", 11.25F, FontStyle.Bold);
            lblIsPresent.ForeColor = Color.Goldenrod;
            lblIsPresent.Location = new Point(20, 129);
            lblIsPresent.Name = "lblIsPresent";
            lblIsPresent.Size = new Size(57, 18);
            lblIsPresent.TabIndex = 4;
            lblIsPresent.Text = "Status:";
            // 
            // dtpAttendanceDate
            // 
            dtpAttendanceDate.Font = new Font("Arial Rounded MT Bold", 9.75F);
            dtpAttendanceDate.Location = new Point(157, 73);
            dtpAttendanceDate.Name = "dtpAttendanceDate";
            dtpAttendanceDate.Size = new Size(250, 23);
            dtpAttendanceDate.TabIndex = 3;
            // 
            // txtReason
            // 
            txtReason.Font = new Font("Arial Rounded MT Bold", 9.75F);
            txtReason.Location = new Point(157, 220);
            txtReason.Name = "txtReason";
            txtReason.Size = new Size(250, 23);
            txtReason.TabIndex = 7;
            // 
            // cmbIsPresent
            // 
            cmbIsPresent.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbIsPresent.Font = new Font("Arial Rounded MT Bold", 9.75F);
            cmbIsPresent.Items.AddRange(new object[] { "Present", "Absent" });
            cmbIsPresent.Location = new Point(157, 128);
            cmbIsPresent.Name = "cmbIsPresent";
            cmbIsPresent.Size = new Size(250, 23);
            cmbIsPresent.TabIndex = 5;
            cmbIsPresent.SelectedIndexChanged += cmbIsPresent_SelectedIndexChanged;
            // 
            // btnGetByEmployeeAndDate
            // 
            btnGetByEmployeeAndDate.BackColor = Color.FromArgb(52, 152, 219);
            btnGetByEmployeeAndDate.FlatStyle = FlatStyle.Flat;
            btnGetByEmployeeAndDate.Font = new Font("Arial Rounded MT Bold", 9.75F);
            btnGetByEmployeeAndDate.ForeColor = Color.White;
            btnGetByEmployeeAndDate.Location = new Point(39, 140);
            btnGetByEmployeeAndDate.Name = "btnGetByEmployeeAndDate";
            btnGetByEmployeeAndDate.Size = new Size(134, 31);
            btnGetByEmployeeAndDate.TabIndex = 9;
            btnGetByEmployeeAndDate.Text = "Get by ID & Date";
            btnGetByEmployeeAndDate.UseVisualStyleBackColor = false;
            btnGetByEmployeeAndDate.Click += btnGetByEmployeeAndDate_Click;
            // 
            // btnCreate
            // 
            btnCreate.BackColor = Color.FromArgb(39, 174, 96);
            btnCreate.FlatStyle = FlatStyle.Flat;
            btnCreate.Font = new Font("Arial Rounded MT Bold", 9.75F);
            btnCreate.ForeColor = Color.White;
            btnCreate.Location = new Point(39, 27);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(134, 31);
            btnCreate.TabIndex = 10;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = false;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(241, 196, 15);
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Arial Rounded MT Bold", 9.75F);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(39, 65);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(134, 31);
            btnUpdate.TabIndex = 11;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(231, 76, 60);
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Arial Rounded MT Bold", 9.75F);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(39, 103);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(134, 31);
            btnDelete.TabIndex = 12;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // dgvAttendance
            // 
            dgvAttendance.AllowUserToAddRows = false;
            dgvAttendance.AllowUserToDeleteRows = false;
            dgvAttendance.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAttendance.BackgroundColor = Color.White;
            dgvAttendance.BorderStyle = BorderStyle.None;
            dgvAttendance.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvAttendance.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(52, 152, 219);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvAttendance.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(52, 152, 219);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvAttendance.DefaultCellStyle = dataGridViewCellStyle2;
            dgvAttendance.EnableHeadersVisualStyles = false;
            dgvAttendance.GridColor = Color.LightGray;
            dgvAttendance.Location = new Point(20, 270);
            dgvAttendance.MultiSelect = false;
            dgvAttendance.Name = "dgvAttendance";
            dgvAttendance.ReadOnly = true;
            dgvAttendance.RowHeadersVisible = false;
            dgvAttendance.RowTemplate.Height = 30;
            dgvAttendance.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAttendance.Size = new Size(770, 356);
            dgvAttendance.TabIndex = 13;
            dgvAttendance.CellClick += dgvAttendance_CellClick;
            // 
            // dgvMultipleAttendance
            // 
            dgvMultipleAttendance.AllowUserToAddRows = false;
            dgvMultipleAttendance.AllowUserToDeleteRows = false;
            dgvMultipleAttendance.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvMultipleAttendance.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMultipleAttendance.BackgroundColor = Color.White;
            dgvMultipleAttendance.BorderStyle = BorderStyle.None;
            dgvMultipleAttendance.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvMultipleAttendance.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(52, 152, 219);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvMultipleAttendance.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(52, 152, 219);
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgvMultipleAttendance.DefaultCellStyle = dataGridViewCellStyle4;
            dgvMultipleAttendance.EnableHeadersVisualStyles = false;
            dgvMultipleAttendance.GridColor = Color.LightGray;
            dgvMultipleAttendance.Location = new Point(20, 60);
            dgvMultipleAttendance.MultiSelect = false;
            dgvMultipleAttendance.Name = "dgvMultipleAttendance";
            dgvMultipleAttendance.ReadOnly = true;
            dgvMultipleAttendance.RowHeadersVisible = false;
            dgvMultipleAttendance.RowTemplate.Height = 30;
            dgvMultipleAttendance.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMultipleAttendance.Size = new Size(760, 580);
            dgvMultipleAttendance.TabIndex = 0;
            // 
            // btnMultipleSave
            // 
            btnMultipleSave.BackColor = Color.FromArgb(39, 174, 96);
            btnMultipleSave.FlatStyle = FlatStyle.Flat;
            btnMultipleSave.Font = new Font("Arial Rounded MT Bold", 9.75F);
            btnMultipleSave.ForeColor = Color.White;
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
            dateTimePicker2.Value = new DateTime(2025, 6, 20, 18, 31, 27, 0);
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
            tabSingleAttendance.Controls.Add(groupBox1);
            tabSingleAttendance.Controls.Add(txtUsername);
            tabSingleAttendance.Controls.Add(txtEmployeeId);
            tabSingleAttendance.Controls.Add(btnGetAll);
            tabSingleAttendance.Controls.Add(lblName);
            tabSingleAttendance.Controls.Add(lblEmployeeId);
            tabSingleAttendance.Controls.Add(lblDate);
            tabSingleAttendance.Controls.Add(dtpAttendanceDate);
            tabSingleAttendance.Controls.Add(lblIsPresent);
            tabSingleAttendance.Controls.Add(cmbIsPresent);
            tabSingleAttendance.Controls.Add(lblStatus);
            tabSingleAttendance.Controls.Add(txtReason);
            tabSingleAttendance.Controls.Add(dgvAttendance);
            tabSingleAttendance.Location = new Point(4, 23);
            tabSingleAttendance.Name = "tabSingleAttendance";
            tabSingleAttendance.Size = new Size(802, 643);
            tabSingleAttendance.TabIndex = 0;
            tabSingleAttendance.Text = "Single Attendance";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnById);
            groupBox1.Controls.Add(btnCreate);
            groupBox1.Controls.Add(btnGetByEmployeeAndDate);
            groupBox1.Controls.Add(btnDelete);
            groupBox1.Controls.Add(btnUpdate);
            groupBox1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            groupBox1.Location = new Point(585, 24);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(205, 240);
            groupBox1.TabIndex = 17;
            groupBox1.TabStop = false;
            groupBox1.Text = "Action";
            // 
            // btnById
            // 
            btnById.BackColor = Color.FromArgb(52, 152, 219);
            btnById.FlatStyle = FlatStyle.Flat;
            btnById.Font = new Font("Arial Rounded MT Bold", 9.75F);
            btnById.ForeColor = Color.White;
            btnById.Location = new Point(39, 181);
            btnById.Name = "btnById";
            btnById.Size = new Size(134, 31);
            btnById.TabIndex = 14;
            btnById.Text = "Get By ID";
            btnById.UseVisualStyleBackColor = false;
            btnById.Click += btnById_Click;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(157, 175);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(250, 21);
            txtUsername.TabIndex = 16;
            // 
            // txtEmployeeId
            // 
            txtEmployeeId.Location = new Point(157, 24);
            txtEmployeeId.Name = "txtEmployeeId";
            txtEmployeeId.Size = new Size(250, 21);
            txtEmployeeId.TabIndex = 16;
            // 
            // btnGetAll
            // 
            btnGetAll.Image = Properties.Resources.icons8_refresh_48;
            btnGetAll.Location = new Point(20, 260);
            btnGetAll.Name = "btnGetAll";
            btnGetAll.Size = new Size(31, 22);
            btnGetAll.SizeMode = PictureBoxSizeMode.Zoom;
            btnGetAll.TabIndex = 15;
            btnGetAll.TabStop = false;
            btnGetAll.Click += btnGetAll_Click;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Arial", 11.25F, FontStyle.Bold);
            lblName.ForeColor = Color.Goldenrod;
            lblName.Location = new Point(20, 178);
            lblName.Name = "lblName";
            lblName.Size = new Size(125, 18);
            lblName.TabIndex = 0;
            lblName.Text = "Employee Name:";
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
            btnGetIdDate.BackColor = Color.FromArgb(52, 152, 219);
            btnGetIdDate.FlatStyle = FlatStyle.Flat;
            btnGetIdDate.Font = new Font("Arial Rounded MT Bold", 9.75F);
            btnGetIdDate.ForeColor = Color.White;
            btnGetIdDate.Location = new Point(467, 16);
            btnGetIdDate.Name = "btnGetIdDate";
            btnGetIdDate.Size = new Size(134, 31);
            btnGetIdDate.TabIndex = 1;
            btnGetIdDate.Text = "Get By ID&Date";
            btnGetIdDate.UseVisualStyleBackColor = false;
            btnGetIdDate.Click += btnGetIdDate_Click;
            // 
            // btnGenerateSummary
            // 
            btnGenerateSummary.BackColor = Color.FromArgb(39, 174, 96);
            btnGenerateSummary.FlatStyle = FlatStyle.Flat;
            btnGenerateSummary.Font = new Font("Arial Rounded MT Bold", 9.75F);
            btnGenerateSummary.ForeColor = Color.White;
            btnGenerateSummary.Location = new Point(467, 58);
            btnGenerateSummary.Name = "btnGenerateSummary";
            btnGenerateSummary.Size = new Size(134, 31);
            btnGenerateSummary.TabIndex = 1;
            btnGenerateSummary.Text = "Generate Summary";
            btnGenerateSummary.UseVisualStyleBackColor = false;
            btnGenerateSummary.Click += btnGenerateSummary_Click;
            // 
            // dgvMonthlySummary
            // 
            dgvMonthlySummary.AllowUserToAddRows = false;
            dgvMonthlySummary.AllowUserToDeleteRows = false;
            dgvMonthlySummary.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMonthlySummary.BackgroundColor = Color.White;
            dgvMonthlySummary.BorderStyle = BorderStyle.None;
            dgvMonthlySummary.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvMonthlySummary.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(52, 152, 219);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgvMonthlySummary.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Window;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle6.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(52, 152, 219);
            dataGridViewCellStyle6.SelectionForeColor = Color.White;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dgvMonthlySummary.DefaultCellStyle = dataGridViewCellStyle6;
            dgvMonthlySummary.EnableHeadersVisualStyles = false;
            dgvMonthlySummary.GridColor = Color.LightGray;
            dgvMonthlySummary.Location = new Point(30, 97);
            dgvMonthlySummary.MultiSelect = false;
            dgvMonthlySummary.Name = "dgvMonthlySummary";
            dgvMonthlySummary.ReadOnly = true;
            dgvMonthlySummary.RowHeadersVisible = false;
            dgvMonthlySummary.RowTemplate.Height = 30;
            dgvMonthlySummary.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMonthlySummary.Size = new Size(760, 513);
            dgvMonthlySummary.TabIndex = 2;
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
            groupBox1.ResumeLayout(false);
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
        private Button clear;
        private TextBox txtUsername;
        private Label lblName;
        private GroupBox groupBox1;
    }
}

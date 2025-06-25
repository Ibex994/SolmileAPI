using System;
using System.Drawing;
using System.Windows.Forms;

namespace SolmileGuestHouseUI.Forms.HRForms
{
    partial class Payroll
    {
        private System.ComponentModel.IContainer components = null;

        // Shared controls
        private DateTimePicker dtpPayPeriod, dtpPayPeriodInput;
        private DataGridView dgvPayrolls;
        private GroupBox groupBoxPayrollDetails, groupBoxDeduction;
        private Label lblEmpId, lblPayPeriodInput, lblBasicSalary, lblAllowances, lblDeductions, lblDeductReason;
        private TextBox txtEmpId, txtBasicSalary, txtAllowances, txtDeductions, txtDeductReason;
        private TextBox textEmpId;
        private TabControl tabControl;
        private TabPage tabPayrollDetails;
        private TabPage tabDeduction;
        private TabPage tabPayrollList;
        private TabPage tabAddDeduction;
        private GroupBox groupBoxAddDeduction;
        private Label lblDeductionEmpId, lblDeductionAmount, lblDeductionReason;
        private TextBox txtDeductionEmpId, txtDeductionAmount, txtDeductionReason;
        private Button btnSaveDeduction;

        // FIXED: Added missing button declarations
        private Button btnSavePayroll;
        private Button btnDeletePayroll;
        private Button btnSearch;
        private Button btnDownloadPayslip;
        private Button btnDownloadPDFByDate;
        private Label lblPayslipEmpId;
        private Label lblPayPeriod;
        private DateTimePicker dtpDeductionPeriod;
        private Label lblDuductionDate;
        private PictureBox pictureBox1;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            tabControl = new TabControl();
            tabPayrollList = new TabPage();
            pictureBox1 = new PictureBox();
            btnSearch = new Button();
            dgvPayrolls = new DataGridView();
            tabPayrollDetails = new TabPage();
            groupBoxPayrollDetails = new GroupBox();
            lblEmpId = new Label();
            txtEmpId = new TextBox();
            lblPayPeriodInput = new Label();
            dtpPayPeriodInput = new DateTimePicker();
            lblBasicSalary = new Label();
            txtBasicSalary = new TextBox();
            lblAllowances = new Label();
            txtAllowances = new TextBox();
            lblDeductions = new Label();
            txtDeductions = new TextBox();
            lblDeductReason = new Label();
            txtDeductReason = new TextBox();
            btnSavePayroll = new Button();
            btnDeletePayroll = new Button();
            tabAddDeduction = new TabPage();
            groupBoxAddDeduction = new GroupBox();
            dtpDeductionPeriod = new DateTimePicker();
            lblDeductionEmpId = new Label();
            txtDeductionEmpId = new TextBox();
            lblDeductionAmount = new Label();
            txtDeductionAmount = new TextBox();
            lblDuductionDate = new Label();
            lblDeductionReason = new Label();
            txtDeductionReason = new TextBox();
            btnSaveDeduction = new Button();
            tabDeduction = new TabPage();
            groupBoxDeduction = new GroupBox();
            textEmpId = new TextBox();
            lblPayslipEmpId = new Label();
            btnDownloadPayslip = new Button();
            lblPayPeriod = new Label();
            dtpPayPeriod = new DateTimePicker();
            btnDownloadPDFByDate = new Button();
            tabControl.SuspendLayout();
            tabPayrollList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvPayrolls).BeginInit();
            tabPayrollDetails.SuspendLayout();
            groupBoxPayrollDetails.SuspendLayout();
            tabAddDeduction.SuspendLayout();
            groupBoxAddDeduction.SuspendLayout();
            tabDeduction.SuspendLayout();
            groupBoxDeduction.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl
            // 
            tabControl.Controls.Add(tabPayrollList);
            tabControl.Controls.Add(tabPayrollDetails);
            tabControl.Controls.Add(tabAddDeduction);
            tabControl.Controls.Add(tabDeduction);
            tabControl.Dock = DockStyle.Fill;
            tabControl.Font = new Font("Segoe UI", 9F);
            tabControl.Location = new Point(0, 0);
            tabControl.Margin = new Padding(3, 2, 3, 2);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(805, 480);
            tabControl.TabIndex = 0;
            // 
            // tabPayrollList
            // 
            tabPayrollList.Controls.Add(pictureBox1);
            tabPayrollList.Controls.Add(btnSearch);
            tabPayrollList.Controls.Add(dgvPayrolls);
            tabPayrollList.Location = new Point(4, 24);
            tabPayrollList.Margin = new Padding(3, 2, 3, 2);
            tabPayrollList.Name = "tabPayrollList";
            tabPayrollList.Padding = new Padding(9, 8, 9, 8);
            tabPayrollList.Size = new Size(797, 452);
            tabPayrollList.TabIndex = 2;
            tabPayrollList.Text = "Payroll List";
            tabPayrollList.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.icons8_refresh_48;
            pictureBox1.Location = new Point(9, 36);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(25, 20);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(52, 152, 219);
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(715, 11);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(71, 32);
            btnSearch.TabIndex = 1;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // dgvPayrolls
            // 
            dgvPayrolls.AllowUserToAddRows = false;
            dgvPayrolls.AllowUserToDeleteRows = false;
            dgvPayrolls.BackgroundColor = Color.White;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = SystemColors.Control;
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle7.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dgvPayrolls.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dgvPayrolls.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = SystemColors.Window;
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle8.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            dgvPayrolls.DefaultCellStyle = dataGridViewCellStyle8;
            dgvPayrolls.Location = new Point(9, 48);
            dgvPayrolls.Margin = new Padding(3, 2, 3, 2);
            dgvPayrolls.Name = "dgvPayrolls";
            dgvPayrolls.ReadOnly = true;
            dgvPayrolls.RowHeadersWidth = 51;
            dgvPayrolls.Size = new Size(779, 396);
            dgvPayrolls.TabIndex = 0;
            // 
            // tabPayrollDetails
            // 
            tabPayrollDetails.Controls.Add(groupBoxPayrollDetails);
            tabPayrollDetails.Location = new Point(4, 24);
            tabPayrollDetails.Margin = new Padding(3, 2, 3, 2);
            tabPayrollDetails.Name = "tabPayrollDetails";
            tabPayrollDetails.Padding = new Padding(9, 8, 9, 8);
            tabPayrollDetails.Size = new Size(797, 452);
            tabPayrollDetails.TabIndex = 0;
            tabPayrollDetails.Text = "Payroll Details";
            tabPayrollDetails.UseVisualStyleBackColor = true;
            // 
            // groupBoxPayrollDetails
            // 
            groupBoxPayrollDetails.Controls.Add(lblEmpId);
            groupBoxPayrollDetails.Controls.Add(txtEmpId);
            groupBoxPayrollDetails.Controls.Add(lblPayPeriodInput);
            groupBoxPayrollDetails.Controls.Add(dtpPayPeriodInput);
            groupBoxPayrollDetails.Controls.Add(lblBasicSalary);
            groupBoxPayrollDetails.Controls.Add(txtBasicSalary);
            groupBoxPayrollDetails.Controls.Add(lblAllowances);
            groupBoxPayrollDetails.Controls.Add(txtAllowances);
            groupBoxPayrollDetails.Controls.Add(lblDeductions);
            groupBoxPayrollDetails.Controls.Add(txtDeductions);
            groupBoxPayrollDetails.Controls.Add(lblDeductReason);
            groupBoxPayrollDetails.Controls.Add(txtDeductReason);
            groupBoxPayrollDetails.Controls.Add(btnSavePayroll);
            groupBoxPayrollDetails.Controls.Add(btnDeletePayroll);
            groupBoxPayrollDetails.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            groupBoxPayrollDetails.Location = new Point(166, 54);
            groupBoxPayrollDetails.Margin = new Padding(3, 2, 3, 2);
            groupBoxPayrollDetails.Name = "groupBoxPayrollDetails";
            groupBoxPayrollDetails.Padding = new Padding(9, 8, 9, 8);
            groupBoxPayrollDetails.Size = new Size(474, 262);
            groupBoxPayrollDetails.TabIndex = 0;
            groupBoxPayrollDetails.TabStop = false;
            groupBoxPayrollDetails.Text = "Payroll Entry";
            // 
            // lblEmpId
            // 
            lblEmpId.AutoSize = true;
            lblEmpId.ForeColor = Color.Goldenrod;
            lblEmpId.Location = new Point(24, 35);
            lblEmpId.Name = "lblEmpId";
            lblEmpId.Size = new Size(106, 21);
            lblEmpId.TabIndex = 0;
            lblEmpId.Text = "Employee ID:";
            // 
            // txtEmpId
            // 
            txtEmpId.Location = new Point(176, 27);
            txtEmpId.Margin = new Padding(3, 2, 3, 2);
            txtEmpId.Name = "txtEmpId";
            txtEmpId.Size = new Size(219, 29);
            txtEmpId.TabIndex = 1;
            // 
            // lblPayPeriodInput
            // 
            lblPayPeriodInput.AutoSize = true;
            lblPayPeriodInput.ForeColor = Color.Goldenrod;
            lblPayPeriodInput.Location = new Point(24, 65);
            lblPayPeriodInput.Name = "lblPayPeriodInput";
            lblPayPeriodInput.Size = new Size(90, 21);
            lblPayPeriodInput.TabIndex = 2;
            lblPayPeriodInput.Text = "Pay Period:";
            // 
            // dtpPayPeriodInput
            // 
            dtpPayPeriodInput.Format = DateTimePickerFormat.Short;
            dtpPayPeriodInput.Location = new Point(176, 57);
            dtpPayPeriodInput.Margin = new Padding(3, 2, 3, 2);
            dtpPayPeriodInput.Name = "dtpPayPeriodInput";
            dtpPayPeriodInput.Size = new Size(219, 29);
            dtpPayPeriodInput.TabIndex = 3;
            // 
            // lblBasicSalary
            // 
            lblBasicSalary.AutoSize = true;
            lblBasicSalary.ForeColor = Color.Goldenrod;
            lblBasicSalary.Location = new Point(24, 95);
            lblBasicSalary.Name = "lblBasicSalary";
            lblBasicSalary.Size = new Size(99, 21);
            lblBasicSalary.TabIndex = 4;
            lblBasicSalary.Text = "Basic Salary:";
            // 
            // txtBasicSalary
            // 
            txtBasicSalary.Location = new Point(176, 87);
            txtBasicSalary.Margin = new Padding(3, 2, 3, 2);
            txtBasicSalary.Name = "txtBasicSalary";
            txtBasicSalary.Size = new Size(219, 29);
            txtBasicSalary.TabIndex = 5;
            // 
            // lblAllowances
            // 
            lblAllowances.AutoSize = true;
            lblAllowances.ForeColor = Color.Goldenrod;
            lblAllowances.Location = new Point(24, 125);
            lblAllowances.Name = "lblAllowances";
            lblAllowances.Size = new Size(96, 21);
            lblAllowances.TabIndex = 6;
            lblAllowances.Text = "Allowances:";
            // 
            // txtAllowances
            // 
            txtAllowances.Location = new Point(176, 117);
            txtAllowances.Margin = new Padding(3, 2, 3, 2);
            txtAllowances.Name = "txtAllowances";
            txtAllowances.Size = new Size(219, 29);
            txtAllowances.TabIndex = 7;
            // 
            // lblDeductions
            // 
            lblDeductions.AutoSize = true;
            lblDeductions.ForeColor = Color.Goldenrod;
            lblDeductions.Location = new Point(24, 155);
            lblDeductions.Name = "lblDeductions";
            lblDeductions.Size = new Size(97, 21);
            lblDeductions.TabIndex = 8;
            lblDeductions.Text = "Deductions:";
            // 
            // txtDeductions
            // 
            txtDeductions.Location = new Point(176, 147);
            txtDeductions.Margin = new Padding(3, 2, 3, 2);
            txtDeductions.Name = "txtDeductions";
            txtDeductions.Size = new Size(219, 29);
            txtDeductions.TabIndex = 9;
            // 
            // lblDeductReason
            // 
            lblDeductReason.AutoSize = true;
            lblDeductReason.ForeColor = Color.Goldenrod;
            lblDeductReason.Location = new Point(24, 185);
            lblDeductReason.Name = "lblDeductReason";
            lblDeductReason.Size = new Size(147, 21);
            lblDeductReason.TabIndex = 10;
            lblDeductReason.Text = "Deduction Reason:";
            // 
            // txtDeductReason
            // 
            txtDeductReason.Location = new Point(176, 177);
            txtDeductReason.Margin = new Padding(3, 2, 3, 2);
            txtDeductReason.Name = "txtDeductReason";
            txtDeductReason.Size = new Size(219, 29);
            txtDeductReason.TabIndex = 11;
            // 
            // btnSavePayroll
            // 
            btnSavePayroll.BackColor = Color.FromArgb(52, 152, 219);
            btnSavePayroll.FlatStyle = FlatStyle.Flat;
            btnSavePayroll.ForeColor = Color.White;
            btnSavePayroll.Location = new Point(158, 218);
            btnSavePayroll.Margin = new Padding(3, 2, 3, 2);
            btnSavePayroll.Name = "btnSavePayroll";
            btnSavePayroll.Size = new Size(131, 30);
            btnSavePayroll.TabIndex = 12;
            btnSavePayroll.Text = "Save / Update";
            btnSavePayroll.UseVisualStyleBackColor = false;
            // 
            // btnDeletePayroll
            // 
            btnDeletePayroll.BackColor = Color.FromArgb(231, 76, 60);
            btnDeletePayroll.FlatStyle = FlatStyle.Flat;
            btnDeletePayroll.ForeColor = Color.White;
            btnDeletePayroll.Location = new Point(300, 218);
            btnDeletePayroll.Margin = new Padding(3, 2, 3, 2);
            btnDeletePayroll.Name = "btnDeletePayroll";
            btnDeletePayroll.Size = new Size(131, 30);
            btnDeletePayroll.TabIndex = 13;
            btnDeletePayroll.Text = "Delete Payroll";
            btnDeletePayroll.UseVisualStyleBackColor = false;
            // 
            // tabAddDeduction
            // 
            tabAddDeduction.Controls.Add(groupBoxAddDeduction);
            tabAddDeduction.Location = new Point(4, 24);
            tabAddDeduction.Name = "tabAddDeduction";
            tabAddDeduction.Size = new Size(797, 452);
            tabAddDeduction.TabIndex = 0;
            tabAddDeduction.Text = "Add Deduction";
            tabAddDeduction.UseVisualStyleBackColor = true;
            // 
            // groupBoxAddDeduction
            // 
            groupBoxAddDeduction.Controls.Add(dtpDeductionPeriod);
            groupBoxAddDeduction.Controls.Add(lblDeductionEmpId);
            groupBoxAddDeduction.Controls.Add(txtDeductionEmpId);
            groupBoxAddDeduction.Controls.Add(lblDeductionAmount);
            groupBoxAddDeduction.Controls.Add(txtDeductionAmount);
            groupBoxAddDeduction.Controls.Add(lblDuductionDate);
            groupBoxAddDeduction.Controls.Add(lblDeductionReason);
            groupBoxAddDeduction.Controls.Add(txtDeductionReason);
            groupBoxAddDeduction.Controls.Add(btnSaveDeduction);
            groupBoxAddDeduction.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            groupBoxAddDeduction.Location = new Point(170, 70);
            groupBoxAddDeduction.Name = "groupBoxAddDeduction";
            groupBoxAddDeduction.Size = new Size(460, 250);
            groupBoxAddDeduction.TabIndex = 0;
            groupBoxAddDeduction.TabStop = false;
            groupBoxAddDeduction.Text = "Deduction Entry";
            // 
            // dtpDeductionPeriod
            // 
            dtpDeductionPeriod.Location = new Point(142, 113);
            dtpDeductionPeriod.Name = "dtpDeductionPeriod";
            dtpDeductionPeriod.Size = new Size(279, 29);
            dtpDeductionPeriod.TabIndex = 7;
            // 
            // lblDeductionEmpId
            // 
            lblDeductionEmpId.AutoSize = true;
            lblDeductionEmpId.ForeColor = Color.Goldenrod;
            lblDeductionEmpId.Location = new Point(24, 35);
            lblDeductionEmpId.Name = "lblDeductionEmpId";
            lblDeductionEmpId.Size = new Size(106, 21);
            lblDeductionEmpId.TabIndex = 0;
            lblDeductionEmpId.Text = "Employee ID:";
            // 
            // txtDeductionEmpId
            // 
            txtDeductionEmpId.Location = new Point(183, 32);
            txtDeductionEmpId.Name = "txtDeductionEmpId";
            txtDeductionEmpId.Size = new Size(238, 29);
            txtDeductionEmpId.TabIndex = 1;
            // 
            // lblDeductionAmount
            // 
            lblDeductionAmount.AutoSize = true;
            lblDeductionAmount.ForeColor = Color.Goldenrod;
            lblDeductionAmount.Location = new Point(24, 75);
            lblDeductionAmount.Name = "lblDeductionAmount";
            lblDeductionAmount.Size = new Size(153, 21);
            lblDeductionAmount.TabIndex = 2;
            lblDeductionAmount.Text = "Deduction Amount:";
            // 
            // txtDeductionAmount
            // 
            txtDeductionAmount.Location = new Point(183, 72);
            txtDeductionAmount.Name = "txtDeductionAmount";
            txtDeductionAmount.Size = new Size(238, 29);
            txtDeductionAmount.TabIndex = 3;
            // 
            // lblDuductionDate
            // 
            lblDuductionDate.AutoSize = true;
            lblDuductionDate.ForeColor = Color.Goldenrod;
            lblDuductionDate.Location = new Point(24, 113);
            lblDuductionDate.Name = "lblDuductionDate";
            lblDuductionDate.Size = new Size(48, 21);
            lblDuductionDate.TabIndex = 4;
            lblDuductionDate.Text = "Date:";
            // 
            // lblDeductionReason
            // 
            lblDeductionReason.AutoSize = true;
            lblDeductionReason.ForeColor = Color.Goldenrod;
            lblDeductionReason.Location = new Point(24, 151);
            lblDeductionReason.Name = "lblDeductionReason";
            lblDeductionReason.Size = new Size(67, 21);
            lblDeductionReason.TabIndex = 4;
            lblDeductionReason.Text = "Reason:";
            // 
            // txtDeductionReason
            // 
            txtDeductionReason.Location = new Point(142, 151);
            txtDeductionReason.Name = "txtDeductionReason";
            txtDeductionReason.Size = new Size(279, 29);
            txtDeductionReason.TabIndex = 5;
            // 
            // btnSaveDeduction
            // 
            btnSaveDeduction.BackColor = Color.FromArgb(52, 152, 219);
            btnSaveDeduction.FlatStyle = FlatStyle.Flat;
            btnSaveDeduction.ForeColor = Color.White;
            btnSaveDeduction.Location = new Point(183, 198);
            btnSaveDeduction.Name = "btnSaveDeduction";
            btnSaveDeduction.Size = new Size(150, 35);
            btnSaveDeduction.TabIndex = 6;
            btnSaveDeduction.Text = "Save Deduction";
            btnSaveDeduction.UseVisualStyleBackColor = false;
            btnSaveDeduction.Click += btnSaveDeduction_Click;
            // 
            // tabDeduction
            // 
            tabDeduction.Controls.Add(groupBoxDeduction);
            tabDeduction.Location = new Point(4, 24);
            tabDeduction.Margin = new Padding(3, 2, 3, 2);
            tabDeduction.Name = "tabDeduction";
            tabDeduction.Padding = new Padding(9, 8, 9, 8);
            tabDeduction.Size = new Size(797, 452);
            tabDeduction.TabIndex = 1;
            tabDeduction.Text = "Payslips & Exports";
            tabDeduction.UseVisualStyleBackColor = true;
            // 
            // groupBoxDeduction
            // 
            groupBoxDeduction.Controls.Add(textEmpId);
            groupBoxDeduction.Controls.Add(lblPayslipEmpId);
            groupBoxDeduction.Controls.Add(btnDownloadPayslip);
            groupBoxDeduction.Controls.Add(lblPayPeriod);
            groupBoxDeduction.Controls.Add(dtpPayPeriod);
            groupBoxDeduction.Controls.Add(btnDownloadPDFByDate);
            groupBoxDeduction.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            groupBoxDeduction.Location = new Point(117, 82);
            groupBoxDeduction.Margin = new Padding(3, 2, 3, 2);
            groupBoxDeduction.Name = "groupBoxDeduction";
            groupBoxDeduction.Padding = new Padding(9, 8, 9, 8);
            groupBoxDeduction.Size = new Size(580, 259);
            groupBoxDeduction.TabIndex = 0;
            groupBoxDeduction.TabStop = false;
            groupBoxDeduction.Text = "Payslip and PDF Exports";
            // 
            // textEmpId
            // 
            textEmpId.Location = new Point(223, 44);
            textEmpId.Margin = new Padding(3, 2, 3, 2);
            textEmpId.Name = "textEmpId";
            textEmpId.Size = new Size(219, 29);
            textEmpId.TabIndex = 8;
            // 
            // lblPayslipEmpId
            // 
            lblPayslipEmpId.AutoSize = true;
            lblPayslipEmpId.ForeColor = Color.Goldenrod;
            lblPayslipEmpId.Location = new Point(89, 53);
            lblPayslipEmpId.Name = "lblPayslipEmpId";
            lblPayslipEmpId.Size = new Size(106, 21);
            lblPayslipEmpId.TabIndex = 0;
            lblPayslipEmpId.Text = "Employee ID:";
            // 
            // btnDownloadPayslip
            // 
            btnDownloadPayslip.BackColor = Color.FromArgb(52, 152, 219);
            btnDownloadPayslip.FlatStyle = FlatStyle.Flat;
            btnDownloadPayslip.ForeColor = Color.White;
            btnDownloadPayslip.Location = new Point(248, 77);
            btnDownloadPayslip.Margin = new Padding(3, 2, 3, 2);
            btnDownloadPayslip.Name = "btnDownloadPayslip";
            btnDownloadPayslip.Size = new Size(156, 31);
            btnDownloadPayslip.TabIndex = 2;
            btnDownloadPayslip.Text = "Download Payslip";
            btnDownloadPayslip.UseVisualStyleBackColor = false;
            // 
            // lblPayPeriod
            // 
            lblPayPeriod.AutoSize = true;
            lblPayPeriod.ForeColor = Color.Goldenrod;
            lblPayPeriod.Location = new Point(89, 131);
            lblPayPeriod.Name = "lblPayPeriod";
            lblPayPeriod.Size = new Size(90, 21);
            lblPayPeriod.TabIndex = 3;
            lblPayPeriod.Text = "Pay Period:";
            // 
            // dtpPayPeriod
            // 
            dtpPayPeriod.Format = DateTimePickerFormat.Short;
            dtpPayPeriod.Location = new Point(223, 125);
            dtpPayPeriod.Margin = new Padding(3, 2, 3, 2);
            dtpPayPeriod.Name = "dtpPayPeriod";
            dtpPayPeriod.Size = new Size(219, 29);
            dtpPayPeriod.TabIndex = 4;
            // 
            // btnDownloadPDFByDate
            // 
            btnDownloadPDFByDate.BackColor = Color.FromArgb(52, 152, 219);
            btnDownloadPDFByDate.FlatStyle = FlatStyle.Flat;
            btnDownloadPDFByDate.ForeColor = Color.White;
            btnDownloadPDFByDate.Location = new Point(248, 169);
            btnDownloadPDFByDate.Margin = new Padding(3, 2, 3, 2);
            btnDownloadPDFByDate.Name = "btnDownloadPDFByDate";
            btnDownloadPDFByDate.Size = new Size(129, 31);
            btnDownloadPDFByDate.TabIndex = 5;
            btnDownloadPDFByDate.Text = "Download PDF";
            btnDownloadPDFByDate.UseVisualStyleBackColor = false;
            // 
            // Payroll
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tabControl);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Payroll";
            Size = new Size(805, 480);
            tabControl.ResumeLayout(false);
            tabPayrollList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvPayrolls).EndInit();
            tabPayrollDetails.ResumeLayout(false);
            groupBoxPayrollDetails.ResumeLayout(false);
            groupBoxPayrollDetails.PerformLayout();
            tabAddDeduction.ResumeLayout(false);
            groupBoxAddDeduction.ResumeLayout(false);
            groupBoxAddDeduction.PerformLayout();
            tabDeduction.ResumeLayout(false);
            groupBoxDeduction.ResumeLayout(false);
            groupBoxDeduction.PerformLayout();
            ResumeLayout(false);
        }
    }
}
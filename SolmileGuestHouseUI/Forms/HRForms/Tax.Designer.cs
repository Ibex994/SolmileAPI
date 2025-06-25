namespace SolmileGuestHouseUI.Forms.HRForms
{
    partial class Tax
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            tabControlTax = new TabControl();
            tabEmployeeTaxRecords = new TabPage();
            btnDeleteEmpTax = new Button();
            dgvEmployeeTaxes = new DataGridView();
            groupBoxEmployeeTaxEntry = new GroupBox();
            lblEmpTaxId = new Label();
            txtEmpTaxId = new TextBox();
            btnLoadEmpTaxForEdit = new Button();
            lblEmpId = new Label();
            txtEmpId = new TextBox();
            lblGrossSalary = new Label();
            txtGrossSalary = new TextBox();
            lblTaxAmount = new Label();
            txtTaxAmount = new TextBox();
            btnSaveEmpTax = new Button();
            btnClearEmpTaxFields = new Button();
            btnRefreshEmpTaxList = new Button();
            tabTaxBrackets = new TabPage();
            btnDeleteBracket = new Button();
            btnRefreshBracketsList = new Button();
            dgvTaxBrackets = new DataGridView();
            groupBoxTaxBracketEntry = new GroupBox();
            lblBracketId = new Label();
            txtBracketId = new TextBox();
            btnLoadBracketForEdit = new Button();
            lblFrom = new Label();
            txtFrom = new TextBox();
            lblTo = new Label();
            txtTo = new TextBox();
            lblRatePercent = new Label();
            txtRatePercent = new TextBox();
            lblDeductible = new Label();
            txtDeductible = new TextBox();
            btnSaveBracket = new Button();
            btnClearBracketFields = new Button();
            tabTaxCalculationAndSummary = new TabPage();
            groupBoxTaxOperations = new GroupBox();
            lblSalaryForCalculation = new Label();
            txtSalaryForCalculation = new TextBox();
            btnCalculateTax = new Button();
            lblCalculatedTaxResultLabel = new Label();
            lblCalculatedTaxResultValue = new Label();
            lblEmployeeSummaryId = new Label();
            txtEmployeeSummaryId = new TextBox();
            btnViewTaxSummary = new Button();
            rtbTaxSummaryOutput = new RichTextBox();
            tabControlTax.SuspendLayout();
            tabEmployeeTaxRecords.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEmployeeTaxes).BeginInit();
            groupBoxEmployeeTaxEntry.SuspendLayout();
            tabTaxBrackets.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTaxBrackets).BeginInit();
            groupBoxTaxBracketEntry.SuspendLayout();
            tabTaxCalculationAndSummary.SuspendLayout();
            groupBoxTaxOperations.SuspendLayout();
            SuspendLayout();
            // 
            // tabControlTax
            // 
            tabControlTax.Controls.Add(tabEmployeeTaxRecords);
            tabControlTax.Controls.Add(tabTaxBrackets);
            tabControlTax.Controls.Add(tabTaxCalculationAndSummary);
            tabControlTax.Dock = DockStyle.Fill;
            tabControlTax.Location = new Point(0, 0);
            tabControlTax.Margin = new Padding(3, 2, 3, 2);
            tabControlTax.Name = "tabControlTax";
            tabControlTax.SelectedIndex = 0;
            tabControlTax.Size = new Size(1050, 600);
            tabControlTax.TabIndex = 0;
            // 
            // tabEmployeeTaxRecords
            // 
            tabEmployeeTaxRecords.Controls.Add(btnDeleteEmpTax);
            tabEmployeeTaxRecords.Controls.Add(dgvEmployeeTaxes);
            tabEmployeeTaxRecords.Controls.Add(groupBoxEmployeeTaxEntry);
            tabEmployeeTaxRecords.Controls.Add(btnRefreshEmpTaxList);
            tabEmployeeTaxRecords.Location = new Point(4, 24);
            tabEmployeeTaxRecords.Margin = new Padding(3, 2, 3, 2);
            tabEmployeeTaxRecords.Name = "tabEmployeeTaxRecords";
            tabEmployeeTaxRecords.Padding = new Padding(3, 2, 3, 2);
            tabEmployeeTaxRecords.Size = new Size(1042, 572);
            tabEmployeeTaxRecords.TabIndex = 0;
            tabEmployeeTaxRecords.Text = "Employee Tax Records";
            tabEmployeeTaxRecords.UseVisualStyleBackColor = true;
            // 
            // btnDeleteEmpTax
            // 
            btnDeleteEmpTax.BackColor = Color.FromArgb(220, 53, 69);
            btnDeleteEmpTax.FlatStyle = FlatStyle.Flat;
            btnDeleteEmpTax.ForeColor = Color.White;
            btnDeleteEmpTax.Location = new Point(739, 198);
            btnDeleteEmpTax.Margin = new Padding(3, 2, 3, 2);
            btnDeleteEmpTax.Name = "btnDeleteEmpTax";
            btnDeleteEmpTax.Size = new Size(97, 26);
            btnDeleteEmpTax.TabIndex = 3;
            btnDeleteEmpTax.Text = "Delete Selected";
            btnDeleteEmpTax.UseVisualStyleBackColor = false;
            // 
            // dgvEmployeeTaxes
            // 
            dgvEmployeeTaxes.AllowUserToAddRows = false;
            dgvEmployeeTaxes.AllowUserToDeleteRows = false;
            dgvEmployeeTaxes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEmployeeTaxes.BackgroundColor = Color.White;
            dgvEmployeeTaxes.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(52, 58, 64);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvEmployeeTaxes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvEmployeeTaxes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmployeeTaxes.EnableHeadersVisualStyles = false;
            dgvEmployeeTaxes.Location = new Point(23, 228);
            dgvEmployeeTaxes.Margin = new Padding(3, 2, 3, 2);
            dgvEmployeeTaxes.MultiSelect = false;
            dgvEmployeeTaxes.Name = "dgvEmployeeTaxes";
            dgvEmployeeTaxes.ReadOnly = true;
            dgvEmployeeTaxes.RowHeadersWidth = 51;
            dgvEmployeeTaxes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEmployeeTaxes.Size = new Size(813, 326);
            dgvEmployeeTaxes.TabIndex = 1;
            // 
            // groupBoxEmployeeTaxEntry
            // 
            groupBoxEmployeeTaxEntry.Controls.Add(lblEmpTaxId);
            groupBoxEmployeeTaxEntry.Controls.Add(txtEmpTaxId);
            groupBoxEmployeeTaxEntry.Controls.Add(btnLoadEmpTaxForEdit);
            groupBoxEmployeeTaxEntry.Controls.Add(lblEmpId);
            groupBoxEmployeeTaxEntry.Controls.Add(txtEmpId);
            groupBoxEmployeeTaxEntry.Controls.Add(lblGrossSalary);
            groupBoxEmployeeTaxEntry.Controls.Add(txtGrossSalary);
            groupBoxEmployeeTaxEntry.Controls.Add(lblTaxAmount);
            groupBoxEmployeeTaxEntry.Controls.Add(txtTaxAmount);
            groupBoxEmployeeTaxEntry.Controls.Add(btnSaveEmpTax);
            groupBoxEmployeeTaxEntry.Controls.Add(btnClearEmpTaxFields);
            groupBoxEmployeeTaxEntry.Location = new Point(23, 12);
            groupBoxEmployeeTaxEntry.Margin = new Padding(3, 2, 3, 2);
            groupBoxEmployeeTaxEntry.Name = "groupBoxEmployeeTaxEntry";
            groupBoxEmployeeTaxEntry.Padding = new Padding(3, 2, 3, 2);
            groupBoxEmployeeTaxEntry.Size = new Size(601, 212);
            groupBoxEmployeeTaxEntry.TabIndex = 0;
            groupBoxEmployeeTaxEntry.TabStop = false;
            groupBoxEmployeeTaxEntry.Text = "Employee Tax Entry";
            // 
            // lblEmpTaxId
            // 
            lblEmpTaxId.AutoSize = true;
            lblEmpTaxId.Location = new Point(13, 22);
            lblEmpTaxId.Name = "lblEmpTaxId";
            lblEmpTaxId.Size = new Size(63, 15);
            lblEmpTaxId.TabIndex = 0;
            lblEmpTaxId.Text = "Tax Rec ID:";
            // 
            // txtEmpTaxId
            // 
            txtEmpTaxId.Enabled = false;
            txtEmpTaxId.Location = new Point(105, 20);
            txtEmpTaxId.Margin = new Padding(3, 2, 3, 2);
            txtEmpTaxId.Name = "txtEmpTaxId";
            txtEmpTaxId.Size = new Size(132, 23);
            txtEmpTaxId.TabIndex = 1;
            // 
            // btnLoadEmpTaxForEdit
            // 
            btnLoadEmpTaxForEdit.BackColor = Color.FromArgb(0, 123, 255);
            btnLoadEmpTaxForEdit.FlatStyle = FlatStyle.Flat;
            btnLoadEmpTaxForEdit.ForeColor = Color.White;
            btnLoadEmpTaxForEdit.Location = new Point(245, 19);
            btnLoadEmpTaxForEdit.Margin = new Padding(3, 2, 3, 2);
            btnLoadEmpTaxForEdit.Name = "btnLoadEmpTaxForEdit";
            btnLoadEmpTaxForEdit.Size = new Size(70, 22);
            btnLoadEmpTaxForEdit.TabIndex = 2;
            btnLoadEmpTaxForEdit.Text = "Load";
            btnLoadEmpTaxForEdit.UseVisualStyleBackColor = false;
            // 
            // lblEmpId
            // 
            lblEmpId.AutoSize = true;
            lblEmpId.Location = new Point(13, 60);
            lblEmpId.Name = "lblEmpId";
            lblEmpId.Size = new Size(76, 15);
            lblEmpId.TabIndex = 3;
            lblEmpId.Text = "Employee ID:";
            // 
            // txtEmpId
            // 
            txtEmpId.Location = new Point(105, 58);
            txtEmpId.Margin = new Padding(3, 2, 3, 2);
            txtEmpId.Name = "txtEmpId";
            txtEmpId.Size = new Size(210, 23);
            txtEmpId.TabIndex = 4;
            // 
            // lblGrossSalary
            // 
            lblGrossSalary.AutoSize = true;
            lblGrossSalary.Location = new Point(13, 98);
            lblGrossSalary.Name = "lblGrossSalary";
            lblGrossSalary.Size = new Size(73, 15);
            lblGrossSalary.TabIndex = 5;
            lblGrossSalary.Text = "Gross Salary:";
            // 
            // txtGrossSalary
            // 
            txtGrossSalary.Location = new Point(105, 95);
            txtGrossSalary.Margin = new Padding(3, 2, 3, 2);
            txtGrossSalary.Name = "txtGrossSalary";
            txtGrossSalary.Size = new Size(210, 23);
            txtGrossSalary.TabIndex = 6;
            // 
            // lblTaxAmount
            // 
            lblTaxAmount.AutoSize = true;
            lblTaxAmount.Location = new Point(13, 135);
            lblTaxAmount.Name = "lblTaxAmount";
            lblTaxAmount.Size = new Size(74, 15);
            lblTaxAmount.TabIndex = 7;
            lblTaxAmount.Text = "Tax Amount:";
            // 
            // txtTaxAmount
            // 
            txtTaxAmount.Location = new Point(105, 133);
            txtTaxAmount.Margin = new Padding(3, 2, 3, 2);
            txtTaxAmount.Name = "txtTaxAmount";
            txtTaxAmount.ReadOnly = true;
            txtTaxAmount.Size = new Size(210, 23);
            txtTaxAmount.TabIndex = 8;
            // 
            // btnSaveEmpTax
            // 
            btnSaveEmpTax.BackColor = Color.FromArgb(40, 167, 69);
            btnSaveEmpTax.FlatStyle = FlatStyle.Flat;
            btnSaveEmpTax.ForeColor = Color.White;
            btnSaveEmpTax.Location = new Point(105, 172);
            btnSaveEmpTax.Margin = new Padding(3, 2, 3, 2);
            btnSaveEmpTax.Name = "btnSaveEmpTax";
            btnSaveEmpTax.Size = new Size(88, 26);
            btnSaveEmpTax.TabIndex = 9;
            btnSaveEmpTax.Text = "Save";
            btnSaveEmpTax.UseVisualStyleBackColor = false;
            // 
            // btnClearEmpTaxFields
            // 
            btnClearEmpTaxFields.BackColor = Color.FromArgb(108, 117, 125);
            btnClearEmpTaxFields.FlatStyle = FlatStyle.Flat;
            btnClearEmpTaxFields.ForeColor = Color.White;
            btnClearEmpTaxFields.Location = new Point(210, 172);
            btnClearEmpTaxFields.Margin = new Padding(3, 2, 3, 2);
            btnClearEmpTaxFields.Name = "btnClearEmpTaxFields";
            btnClearEmpTaxFields.Size = new Size(88, 26);
            btnClearEmpTaxFields.TabIndex = 10;
            btnClearEmpTaxFields.Text = "Clear";
            btnClearEmpTaxFields.UseVisualStyleBackColor = false;
            // 
            // btnRefreshEmpTaxList
            // 
            btnRefreshEmpTaxList.BackColor = Color.FromArgb(40, 167, 69);
            btnRefreshEmpTaxList.FlatStyle = FlatStyle.Flat;
            btnRefreshEmpTaxList.ForeColor = Color.White;
            btnRefreshEmpTaxList.Location = new Point(630, 198);
            btnRefreshEmpTaxList.Margin = new Padding(3, 2, 3, 2);
            btnRefreshEmpTaxList.Name = "btnRefreshEmpTaxList";
            btnRefreshEmpTaxList.Size = new Size(105, 26);
            btnRefreshEmpTaxList.TabIndex = 2;
            btnRefreshEmpTaxList.Text = "Refresh List";
            btnRefreshEmpTaxList.UseVisualStyleBackColor = false;
            // 
            // tabTaxBrackets
            // 
            tabTaxBrackets.Controls.Add(btnDeleteBracket);
            tabTaxBrackets.Controls.Add(btnRefreshBracketsList);
            tabTaxBrackets.Controls.Add(dgvTaxBrackets);
            tabTaxBrackets.Controls.Add(groupBoxTaxBracketEntry);
            tabTaxBrackets.Location = new Point(4, 24);
            tabTaxBrackets.Margin = new Padding(3, 2, 3, 2);
            tabTaxBrackets.Name = "tabTaxBrackets";
            tabTaxBrackets.Padding = new Padding(3, 2, 3, 2);
            tabTaxBrackets.Size = new Size(1042, 572);
            tabTaxBrackets.TabIndex = 1;
            tabTaxBrackets.Text = "Tax Brackets";
            tabTaxBrackets.UseVisualStyleBackColor = true;
            // 
            // btnDeleteBracket
            // 
            btnDeleteBracket.BackColor = Color.FromArgb(220, 53, 69);
            btnDeleteBracket.FlatStyle = FlatStyle.Flat;
            btnDeleteBracket.ForeColor = Color.White;
            btnDeleteBracket.Location = new Point(741, 230);
            btnDeleteBracket.Margin = new Padding(3, 2, 3, 2);
            btnDeleteBracket.Name = "btnDeleteBracket";
            btnDeleteBracket.Size = new Size(105, 26);
            btnDeleteBracket.TabIndex = 3;
            btnDeleteBracket.Text = "Delete Selected";
            btnDeleteBracket.UseVisualStyleBackColor = false;
            // 
            // btnRefreshBracketsList
            // 
            btnRefreshBracketsList.BackColor = Color.FromArgb(40, 167, 69);
            btnRefreshBracketsList.FlatStyle = FlatStyle.Flat;
            btnRefreshBracketsList.ForeColor = Color.White;
            btnRefreshBracketsList.Location = new Point(644, 230);
            btnRefreshBracketsList.Margin = new Padding(3, 2, 3, 2);
            btnRefreshBracketsList.Name = "btnRefreshBracketsList";
            btnRefreshBracketsList.Size = new Size(91, 26);
            btnRefreshBracketsList.TabIndex = 2;
            btnRefreshBracketsList.Text = "Refresh List";
            btnRefreshBracketsList.UseVisualStyleBackColor = false;
            // 
            // dgvTaxBrackets
            // 
            dgvTaxBrackets.AllowUserToAddRows = false;
            dgvTaxBrackets.AllowUserToDeleteRows = false;
            dgvTaxBrackets.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTaxBrackets.BackgroundColor = Color.White;
            dgvTaxBrackets.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(52, 58, 64);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvTaxBrackets.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvTaxBrackets.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTaxBrackets.EnableHeadersVisualStyles = false;
            dgvTaxBrackets.Location = new Point(16, 260);
            dgvTaxBrackets.Margin = new Padding(3, 2, 3, 2);
            dgvTaxBrackets.MultiSelect = false;
            dgvTaxBrackets.Name = "dgvTaxBrackets";
            dgvTaxBrackets.ReadOnly = true;
            dgvTaxBrackets.RowHeadersWidth = 51;
            dgvTaxBrackets.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTaxBrackets.Size = new Size(830, 314);
            dgvTaxBrackets.TabIndex = 1;
            // 
            // groupBoxTaxBracketEntry
            // 
            groupBoxTaxBracketEntry.Controls.Add(lblBracketId);
            groupBoxTaxBracketEntry.Controls.Add(txtBracketId);
            groupBoxTaxBracketEntry.Controls.Add(btnLoadBracketForEdit);
            groupBoxTaxBracketEntry.Controls.Add(lblFrom);
            groupBoxTaxBracketEntry.Controls.Add(txtFrom);
            groupBoxTaxBracketEntry.Controls.Add(lblTo);
            groupBoxTaxBracketEntry.Controls.Add(txtTo);
            groupBoxTaxBracketEntry.Controls.Add(lblRatePercent);
            groupBoxTaxBracketEntry.Controls.Add(txtRatePercent);
            groupBoxTaxBracketEntry.Controls.Add(lblDeductible);
            groupBoxTaxBracketEntry.Controls.Add(txtDeductible);
            groupBoxTaxBracketEntry.Controls.Add(btnSaveBracket);
            groupBoxTaxBracketEntry.Controls.Add(btnClearBracketFields);
            groupBoxTaxBracketEntry.Location = new Point(16, 11);
            groupBoxTaxBracketEntry.Margin = new Padding(3, 2, 3, 2);
            groupBoxTaxBracketEntry.Name = "groupBoxTaxBracketEntry";
            groupBoxTaxBracketEntry.Padding = new Padding(3, 2, 3, 2);
            groupBoxTaxBracketEntry.Size = new Size(622, 245);
            groupBoxTaxBracketEntry.TabIndex = 0;
            groupBoxTaxBracketEntry.TabStop = false;
            groupBoxTaxBracketEntry.Text = "Tax Bracket Entry";
            // 
            // lblBracketId
            // 
            lblBracketId.AutoSize = true;
            lblBracketId.Location = new Point(13, 22);
            lblBracketId.Name = "lblBracketId";
            lblBracketId.Size = new Size(63, 15);
            lblBracketId.TabIndex = 0;
            lblBracketId.Text = "Bracket ID:";
            // 
            // txtBracketId
            // 
            txtBracketId.Location = new Point(105, 20);
            txtBracketId.Margin = new Padding(3, 2, 3, 2);
            txtBracketId.Name = "txtBracketId";
            txtBracketId.Size = new Size(132, 23);
            txtBracketId.TabIndex = 1;
            // 
            // btnLoadBracketForEdit
            // 
            btnLoadBracketForEdit.BackColor = Color.FromArgb(0, 123, 255);
            btnLoadBracketForEdit.FlatStyle = FlatStyle.Flat;
            btnLoadBracketForEdit.ForeColor = Color.White;
            btnLoadBracketForEdit.Location = new Point(245, 19);
            btnLoadBracketForEdit.Margin = new Padding(3, 2, 3, 2);
            btnLoadBracketForEdit.Name = "btnLoadBracketForEdit";
            btnLoadBracketForEdit.Size = new Size(70, 22);
            btnLoadBracketForEdit.TabIndex = 2;
            btnLoadBracketForEdit.Text = "Load";
            btnLoadBracketForEdit.UseVisualStyleBackColor = false;
            // 
            // lblFrom
            // 
            lblFrom.AutoSize = true;
            lblFrom.Location = new Point(13, 60);
            lblFrom.Name = "lblFrom";
            lblFrom.Size = new Size(38, 15);
            lblFrom.TabIndex = 3;
            lblFrom.Text = "From:";
            // 
            // txtFrom
            // 
            txtFrom.Location = new Point(105, 58);
            txtFrom.Margin = new Padding(3, 2, 3, 2);
            txtFrom.Name = "txtFrom";
            txtFrom.Size = new Size(210, 23);
            txtFrom.TabIndex = 4;
            // 
            // lblTo
            // 
            lblTo.AutoSize = true;
            lblTo.Location = new Point(13, 98);
            lblTo.Name = "lblTo";
            lblTo.Size = new Size(22, 15);
            lblTo.TabIndex = 5;
            lblTo.Text = "To:";
            // 
            // txtTo
            // 
            txtTo.Location = new Point(105, 95);
            txtTo.Margin = new Padding(3, 2, 3, 2);
            txtTo.Name = "txtTo";
            txtTo.Size = new Size(210, 23);
            txtTo.TabIndex = 6;
            // 
            // lblRatePercent
            // 
            lblRatePercent.AutoSize = true;
            lblRatePercent.Location = new Point(13, 135);
            lblRatePercent.Name = "lblRatePercent";
            lblRatePercent.Size = new Size(54, 15);
            lblRatePercent.TabIndex = 7;
            lblRatePercent.Text = "Rate (%):";
            // 
            // txtRatePercent
            // 
            txtRatePercent.Location = new Point(105, 133);
            txtRatePercent.Margin = new Padding(3, 2, 3, 2);
            txtRatePercent.Name = "txtRatePercent";
            txtRatePercent.Size = new Size(210, 23);
            txtRatePercent.TabIndex = 8;
            // 
            // lblDeductible
            // 
            lblDeductible.AutoSize = true;
            lblDeductible.Location = new Point(13, 172);
            lblDeductible.Name = "lblDeductible";
            lblDeductible.Size = new Size(67, 15);
            lblDeductible.TabIndex = 9;
            lblDeductible.Text = "Deductible:";
            // 
            // txtDeductible
            // 
            txtDeductible.Location = new Point(105, 170);
            txtDeductible.Margin = new Padding(3, 2, 3, 2);
            txtDeductible.Name = "txtDeductible";
            txtDeductible.Size = new Size(210, 23);
            txtDeductible.TabIndex = 10;
            // 
            // btnSaveBracket
            // 
            btnSaveBracket.BackColor = Color.FromArgb(40, 167, 69);
            btnSaveBracket.FlatStyle = FlatStyle.Flat;
            btnSaveBracket.ForeColor = Color.White;
            btnSaveBracket.Location = new Point(105, 210);
            btnSaveBracket.Margin = new Padding(3, 2, 3, 2);
            btnSaveBracket.Name = "btnSaveBracket";
            btnSaveBracket.Size = new Size(88, 26);
            btnSaveBracket.TabIndex = 11;
            btnSaveBracket.Text = "Save";
            btnSaveBracket.UseVisualStyleBackColor = false;
            // 
            // btnClearBracketFields
            // 
            btnClearBracketFields.BackColor = Color.FromArgb(108, 117, 125);
            btnClearBracketFields.FlatStyle = FlatStyle.Flat;
            btnClearBracketFields.ForeColor = Color.White;
            btnClearBracketFields.Location = new Point(210, 210);
            btnClearBracketFields.Margin = new Padding(3, 2, 3, 2);
            btnClearBracketFields.Name = "btnClearBracketFields";
            btnClearBracketFields.Size = new Size(88, 26);
            btnClearBracketFields.TabIndex = 12;
            btnClearBracketFields.Text = "Clear";
            btnClearBracketFields.UseVisualStyleBackColor = false;
            // 
            // tabTaxCalculationAndSummary
            // 
            tabTaxCalculationAndSummary.Controls.Add(groupBoxTaxOperations);
            tabTaxCalculationAndSummary.Location = new Point(4, 24);
            tabTaxCalculationAndSummary.Margin = new Padding(3, 2, 3, 2);
            tabTaxCalculationAndSummary.Name = "tabTaxCalculationAndSummary";
            tabTaxCalculationAndSummary.Size = new Size(1042, 572);
            tabTaxCalculationAndSummary.TabIndex = 2;
            tabTaxCalculationAndSummary.Text = "Tax Calculation & Summary";
            tabTaxCalculationAndSummary.UseVisualStyleBackColor = true;
            // 
            // groupBoxTaxOperations
            // 
            groupBoxTaxOperations.Controls.Add(lblSalaryForCalculation);
            groupBoxTaxOperations.Controls.Add(txtSalaryForCalculation);
            groupBoxTaxOperations.Controls.Add(btnCalculateTax);
            groupBoxTaxOperations.Controls.Add(lblCalculatedTaxResultLabel);
            groupBoxTaxOperations.Controls.Add(lblCalculatedTaxResultValue);
            groupBoxTaxOperations.Controls.Add(lblEmployeeSummaryId);
            groupBoxTaxOperations.Controls.Add(txtEmployeeSummaryId);
            groupBoxTaxOperations.Controls.Add(btnViewTaxSummary);
            groupBoxTaxOperations.Controls.Add(rtbTaxSummaryOutput);
            groupBoxTaxOperations.Dock = DockStyle.Fill;
            groupBoxTaxOperations.Location = new Point(0, 0);
            groupBoxTaxOperations.Margin = new Padding(3, 2, 3, 2);
            groupBoxTaxOperations.Name = "groupBoxTaxOperations";
            groupBoxTaxOperations.Padding = new Padding(9, 8, 9, 8);
            groupBoxTaxOperations.Size = new Size(1042, 572);
            groupBoxTaxOperations.TabIndex = 0;
            groupBoxTaxOperations.TabStop = false;
            groupBoxTaxOperations.Text = "Tax Operations";
            // 
            // lblSalaryForCalculation
            // 
            lblSalaryForCalculation.AutoSize = true;
            lblSalaryForCalculation.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblSalaryForCalculation.Location = new Point(18, 30);
            lblSalaryForCalculation.Name = "lblSalaryForCalculation";
            lblSalaryForCalculation.Size = new Size(97, 19);
            lblSalaryForCalculation.TabIndex = 0;
            lblSalaryForCalculation.Text = "Gross Salary:";
            // 
            // txtSalaryForCalculation
            // 
            txtSalaryForCalculation.Font = new Font("Segoe UI", 10F);
            txtSalaryForCalculation.Location = new Point(131, 28);
            txtSalaryForCalculation.Margin = new Padding(3, 2, 3, 2);
            txtSalaryForCalculation.Name = "txtSalaryForCalculation";
            txtSalaryForCalculation.Size = new Size(176, 25);
            txtSalaryForCalculation.TabIndex = 1;
            // 
            // btnCalculateTax
            // 
            btnCalculateTax.BackColor = Color.FromArgb(0, 123, 255);
            btnCalculateTax.FlatStyle = FlatStyle.Flat;
            btnCalculateTax.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnCalculateTax.ForeColor = Color.White;
            btnCalculateTax.Location = new Point(324, 26);
            btnCalculateTax.Margin = new Padding(3, 2, 3, 2);
            btnCalculateTax.Name = "btnCalculateTax";
            btnCalculateTax.Size = new Size(114, 26);
            btnCalculateTax.TabIndex = 2;
            btnCalculateTax.Text = "Calculate Tax";
            btnCalculateTax.UseVisualStyleBackColor = false;
            // 
            // lblCalculatedTaxResultLabel
            // 
            lblCalculatedTaxResultLabel.AutoSize = true;
            lblCalculatedTaxResultLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblCalculatedTaxResultLabel.Location = new Point(18, 68);
            lblCalculatedTaxResultLabel.Name = "lblCalculatedTaxResultLabel";
            lblCalculatedTaxResultLabel.Size = new Size(110, 19);
            lblCalculatedTaxResultLabel.TabIndex = 3;
            lblCalculatedTaxResultLabel.Text = "Calculated Tax:";
            // 
            // lblCalculatedTaxResultValue
            // 
            lblCalculatedTaxResultValue.AutoSize = true;
            lblCalculatedTaxResultValue.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblCalculatedTaxResultValue.ForeColor = Color.FromArgb(40, 167, 69);
            lblCalculatedTaxResultValue.Location = new Point(149, 66);
            lblCalculatedTaxResultValue.Name = "lblCalculatedTaxResultValue";
            lblCalculatedTaxResultValue.Size = new Size(41, 21);
            lblCalculatedTaxResultValue.TabIndex = 4;
            lblCalculatedTaxResultValue.Text = "N/A";
            // 
            // lblEmployeeSummaryId
            // 
            lblEmployeeSummaryId.AutoSize = true;
            lblEmployeeSummaryId.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblEmployeeSummaryId.Location = new Point(18, 112);
            lblEmployeeSummaryId.Name = "lblEmployeeSummaryId";
            lblEmployeeSummaryId.Size = new Size(97, 19);
            lblEmployeeSummaryId.TabIndex = 5;
            lblEmployeeSummaryId.Text = "Employee ID:";
            // 
            // txtEmployeeSummaryId
            // 
            txtEmployeeSummaryId.Font = new Font("Segoe UI", 10F);
            txtEmployeeSummaryId.Location = new Point(131, 110);
            txtEmployeeSummaryId.Margin = new Padding(3, 2, 3, 2);
            txtEmployeeSummaryId.Name = "txtEmployeeSummaryId";
            txtEmployeeSummaryId.Size = new Size(176, 25);
            txtEmployeeSummaryId.TabIndex = 6;
            // 
            // btnViewTaxSummary
            // 
            btnViewTaxSummary.BackColor = Color.FromArgb(40, 167, 69);
            btnViewTaxSummary.FlatStyle = FlatStyle.Flat;
            btnViewTaxSummary.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnViewTaxSummary.ForeColor = Color.White;
            btnViewTaxSummary.Location = new Point(324, 109);
            btnViewTaxSummary.Margin = new Padding(3, 2, 3, 2);
            btnViewTaxSummary.Name = "btnViewTaxSummary";
            btnViewTaxSummary.Size = new Size(131, 26);
            btnViewTaxSummary.TabIndex = 7;
            btnViewTaxSummary.Text = "View Tax Summary";
            btnViewTaxSummary.UseVisualStyleBackColor = false;
            // 
            // rtbTaxSummaryOutput
            // 
            rtbTaxSummaryOutput.BackColor = Color.White;
            rtbTaxSummaryOutput.BorderStyle = BorderStyle.FixedSingle;
            rtbTaxSummaryOutput.Font = new Font("Consolas", 9F);
            rtbTaxSummaryOutput.Location = new Point(18, 150);
            rtbTaxSummaryOutput.Margin = new Padding(3, 2, 3, 2);
            rtbTaxSummaryOutput.Name = "rtbTaxSummaryOutput";
            rtbTaxSummaryOutput.ReadOnly = true;
            rtbTaxSummaryOutput.Size = new Size(707, 406);
            rtbTaxSummaryOutput.TabIndex = 8;
            rtbTaxSummaryOutput.Text = "";
            // 
            // Tax
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(tabControlTax);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Tax";
            Size = new Size(1050, 600);
            tabControlTax.ResumeLayout(false);
            tabEmployeeTaxRecords.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvEmployeeTaxes).EndInit();
            groupBoxEmployeeTaxEntry.ResumeLayout(false);
            groupBoxEmployeeTaxEntry.PerformLayout();
            tabTaxBrackets.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvTaxBrackets).EndInit();
            groupBoxTaxBracketEntry.ResumeLayout(false);
            groupBoxTaxBracketEntry.PerformLayout();
            tabTaxCalculationAndSummary.ResumeLayout(false);
            groupBoxTaxOperations.ResumeLayout(false);
            groupBoxTaxOperations.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControlTax;
        private TabPage tabEmployeeTaxRecords;
        private Button btnDeleteEmpTax;
        private Button btnRefreshEmpTaxList;
        private DataGridView dgvEmployeeTaxes;
        private GroupBox groupBoxEmployeeTaxEntry;
        private Label lblEmpTaxId;
        private TextBox txtEmpTaxId;
        private Button btnLoadEmpTaxForEdit;
        private Label lblEmpId;
        private TextBox txtEmpId;
        private Label lblGrossSalary;
        private TextBox txtGrossSalary;
        private Label lblTaxAmount;
        private TextBox txtTaxAmount;
        private Button btnSaveEmpTax;
        private Button btnClearEmpTaxFields;
        private TabPage tabTaxBrackets;
        private Button btnDeleteBracket;
        private Button btnRefreshBracketsList;
        private DataGridView dgvTaxBrackets;
        private GroupBox groupBoxTaxBracketEntry;
        private Label lblBracketId;
        private TextBox txtBracketId;
        private Button btnLoadBracketForEdit;
        private Label lblFrom;
        private TextBox txtFrom;
        private Label lblTo;
        private TextBox txtTo;
        private Label lblRatePercent;
        private TextBox txtRatePercent;
        private Label lblDeductible;
        private TextBox txtDeductible;
        private Button btnSaveBracket;
        private Button btnClearBracketFields;
        private TabPage tabTaxCalculationAndSummary;
        private GroupBox groupBoxTaxOperations;
        private Label lblSalaryForCalculation;
        private TextBox txtSalaryForCalculation;
        private Button btnCalculateTax;
        private Label lblCalculatedTaxResultLabel;
        private Label lblCalculatedTaxResultValue;
        private Label lblEmployeeSummaryId;
        private TextBox txtEmployeeSummaryId;
        private Button btnViewTaxSummary;
        private RichTextBox rtbTaxSummaryOutput;
    }
}
namespace SolmileGuestHouseUI.Forms.ManagerForms
{
    partial class Payment
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

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            dgvPayments = new DataGridView();
            lblPaymentId = new Label();
            txtPaymentId = new TextBox();
            btnGetAll = new Button();
            btnGetById = new Button();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnProcess = new Button();
            lblBookingId = new Label();
            txtBookingId = new TextBox();
            lblAmount = new Label();
            txtAmount = new TextBox();
            lblPaymentDate = new Label();
            lblMethodId = new Label();
            payDate = new DateTimePicker();
            cmbPayMethod = new ComboBox();
            btnClear = new Button();
            groupBox1 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dgvPayments).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvPayments
            // 
            dgvPayments.AllowUserToAddRows = false;
            dgvPayments.AllowUserToDeleteRows = false;
            dgvPayments.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvPayments.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPayments.BackgroundColor = Color.White;
            dgvPayments.BorderStyle = BorderStyle.None;
            dgvPayments.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvPayments.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(52, 152, 219);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgvPayments.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Window;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(52, 152, 219);
            dataGridViewCellStyle6.SelectionForeColor = Color.White;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dgvPayments.DefaultCellStyle = dataGridViewCellStyle6;
            dgvPayments.EnableHeadersVisualStyles = false;
            dgvPayments.GridColor = Color.LightGray;
            dgvPayments.Location = new Point(33, 205);
            dgvPayments.MultiSelect = false;
            dgvPayments.Name = "dgvPayments";
            dgvPayments.ReadOnly = true;
            dgvPayments.RowHeadersVisible = false;
            dgvPayments.RowTemplate.Height = 30;
            dgvPayments.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPayments.Size = new Size(877, 352);
            dgvPayments.TabIndex = 0;
            dgvPayments.CellClick += dgvPayments_CellClick;
            // 
            // lblPaymentId
            // 
            lblPaymentId.Font = new Font("Arial", 11.25F, FontStyle.Bold);
            lblPaymentId.ForeColor = Color.Goldenrod;
            lblPaymentId.Location = new Point(199, 30);
            lblPaymentId.Name = "lblPaymentId";
            lblPaymentId.Size = new Size(80, 23);
            lblPaymentId.TabIndex = 1;
            lblPaymentId.Text = "Payment ID:";
            // 
            // txtPaymentId
            // 
            txtPaymentId.Enabled = false;
            txtPaymentId.Font = new Font("Arial Narrow", 8.25F, FontStyle.Bold);
            txtPaymentId.Location = new Point(304, 27);
            txtPaymentId.Name = "txtPaymentId";
            txtPaymentId.Size = new Size(153, 20);
            txtPaymentId.TabIndex = 2;
            // 
            // btnGetAll
            // 
            btnGetAll.BackColor = Color.FromArgb(52, 152, 219);
            btnGetAll.FlatStyle = FlatStyle.Flat;
            btnGetAll.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnGetAll.ForeColor = Color.White;
            btnGetAll.Location = new Point(183, 24);
            btnGetAll.Name = "btnGetAll";
            btnGetAll.Size = new Size(134, 31);
            btnGetAll.TabIndex = 3;
            btnGetAll.Text = "Get All";
            btnGetAll.UseVisualStyleBackColor = false;
            // 
            // btnGetById
            // 
            btnGetById.BackColor = Color.FromArgb(52, 152, 219);
            btnGetById.FlatStyle = FlatStyle.Flat;
            btnGetById.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnGetById.ForeColor = Color.White;
            btnGetById.Location = new Point(183, 98);
            btnGetById.Name = "btnGetById";
            btnGetById.Size = new Size(134, 31);
            btnGetById.TabIndex = 4;
            btnGetById.Text = "Get by ID";
            btnGetById.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(39, 174, 96);
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(17, 25);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(134, 31);
            btnAdd.TabIndex = 5;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(241, 196, 15);
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(17, 61);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(134, 31);
            btnUpdate.TabIndex = 6;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(231, 76, 60);
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(17, 98);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(134, 31);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnProcess
            // 
            btnProcess.BackColor = Color.FromArgb(52, 152, 219);
            btnProcess.FlatStyle = FlatStyle.Flat;
            btnProcess.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnProcess.ForeColor = Color.White;
            btnProcess.Location = new Point(183, 61);
            btnProcess.Name = "btnProcess";
            btnProcess.Size = new Size(134, 31);
            btnProcess.TabIndex = 8;
            btnProcess.Text = "Process";
            btnProcess.UseVisualStyleBackColor = false;
            // 
            // lblBookingId
            // 
            lblBookingId.Font = new Font("Arial", 11.25F, FontStyle.Bold);
            lblBookingId.ForeColor = Color.Goldenrod;
            lblBookingId.Location = new Point(199, 59);
            lblBookingId.Name = "lblBookingId";
            lblBookingId.Size = new Size(90, 23);
            lblBookingId.TabIndex = 5;
            lblBookingId.Text = "Reservation ID:";
            // 
            // txtBookingId
            // 
            txtBookingId.Font = new Font("Arial Narrow", 8.25F, FontStyle.Bold);
            txtBookingId.Location = new Point(304, 56);
            txtBookingId.Name = "txtBookingId";
            txtBookingId.Size = new Size(153, 20);
            txtBookingId.TabIndex = 6;
            // 
            // lblAmount
            // 
            lblAmount.Font = new Font("Arial", 11.25F, FontStyle.Bold);
            lblAmount.ForeColor = Color.Goldenrod;
            lblAmount.Location = new Point(199, 88);
            lblAmount.Name = "lblAmount";
            lblAmount.Size = new Size(80, 23);
            lblAmount.TabIndex = 7;
            lblAmount.Text = "Amount:";
            // 
            // txtAmount
            // 
            txtAmount.Font = new Font("Arial Narrow", 8.25F, FontStyle.Bold);
            txtAmount.Location = new Point(304, 88);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(153, 20);
            txtAmount.TabIndex = 8;
            // 
            // lblPaymentDate
            // 
            lblPaymentDate.Font = new Font("Arial", 11.25F, FontStyle.Bold);
            lblPaymentDate.ForeColor = Color.Goldenrod;
            lblPaymentDate.Location = new Point(199, 117);
            lblPaymentDate.Name = "lblPaymentDate";
            lblPaymentDate.Size = new Size(90, 23);
            lblPaymentDate.TabIndex = 9;
            lblPaymentDate.Text = "Payment Date:";
            // 
            // lblMethodId
            // 
            lblMethodId.Font = new Font("Arial", 11.25F, FontStyle.Bold);
            lblMethodId.ForeColor = Color.Goldenrod;
            lblMethodId.Location = new Point(199, 146);
            lblMethodId.Name = "lblMethodId";
            lblMethodId.Size = new Size(80, 23);
            lblMethodId.TabIndex = 11;
            lblMethodId.Text = "Method ID:";
            // 
            // payDate
            // 
            payDate.Font = new Font("Arial Narrow", 8.25F, FontStyle.Bold);
            payDate.Location = new Point(304, 117);
            payDate.Name = "payDate";
            payDate.Size = new Size(183, 20);
            payDate.TabIndex = 13;
            // 
            // cmbPayMethod
            // 
            cmbPayMethod.Font = new Font("Arial Narrow", 8.25F, FontStyle.Bold);
            cmbPayMethod.FormattingEnabled = true;
            cmbPayMethod.Location = new Point(304, 147);
            cmbPayMethod.Name = "cmbPayMethod";
            cmbPayMethod.Size = new Size(153, 23);
            cmbPayMethod.TabIndex = 14;
            // 
            // btnClear
            // 
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Arial", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClear.Location = new Point(277, 146);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(46, 26);
            btnClear.TabIndex = 4;
            btnClear.Text = "Clear";
            btnClear.Click += btnClear_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnAdd);
            groupBox1.Controls.Add(btnGetById);
            groupBox1.Controls.Add(btnUpdate);
            groupBox1.Controls.Add(btnGetAll);
            groupBox1.Controls.Add(btnDelete);
            groupBox1.Controls.Add(btnClear);
            groupBox1.Controls.Add(btnProcess);
            groupBox1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            groupBox1.Location = new Point(517, 27);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(323, 172);
            groupBox1.TabIndex = 15;
            groupBox1.TabStop = false;
            groupBox1.Text = "Action";
            // 
            // Payment
            // 
            BackColor = Color.White;
            Controls.Add(groupBox1);
            Controls.Add(cmbPayMethod);
            Controls.Add(payDate);
            Controls.Add(dgvPayments);
            Controls.Add(lblPaymentId);
            Controls.Add(txtPaymentId);
            Controls.Add(lblBookingId);
            Controls.Add(txtBookingId);
            Controls.Add(lblAmount);
            Controls.Add(txtAmount);
            Controls.Add(lblPaymentDate);
            Controls.Add(lblMethodId);
            Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            Name = "Payment";
            Size = new Size(940, 590);
            ((System.ComponentModel.ISupportInitialize)dgvPayments).EndInit();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.DataGridView dgvPayments;
        private System.Windows.Forms.Label lblPaymentId;
        private System.Windows.Forms.TextBox txtPaymentId;
        private System.Windows.Forms.Button btnGetAll;
        private System.Windows.Forms.Button btnGetById;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnProcess;
        private Label lblBookingId;
        private TextBox txtBookingId;
        private Label lblAmount;
        private TextBox txtAmount;
        private Label lblPaymentDate;
        private Label lblMethodId;
        private DateTimePicker payDate;
        private ComboBox cmbPayMethod;
        private Button btnClear;
        private GroupBox groupBox1;
    }
}

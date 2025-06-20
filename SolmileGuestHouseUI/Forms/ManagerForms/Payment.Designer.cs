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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            dgvPayments = new DataGridView();
            lblPaymentId = new Label();
            txtPaymentId = new TextBox();
            btnGetAll = new Button();
            btnGetById = new Button();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnProcess = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvPayments).BeginInit();
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
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(52, 152, 219);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvPayments.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(52, 152, 219);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvPayments.DefaultCellStyle = dataGridViewCellStyle2;
            dgvPayments.EnableHeadersVisualStyles = false;
            dgvPayments.GridColor = Color.LightGray;
            dgvPayments.Location = new Point(60, 205);
            dgvPayments.MultiSelect = false;
            dgvPayments.Name = "dgvPayments";
            dgvPayments.ReadOnly = true;
            dgvPayments.RowHeadersVisible = false;
            dgvPayments.RowTemplate.Height = 30;
            dgvPayments.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPayments.Size = new Size(850, 352);
            dgvPayments.TabIndex = 0;
            // 
            // lblPaymentId
            // 
            lblPaymentId.Location = new Point(199, 52);
            lblPaymentId.Name = "lblPaymentId";
            lblPaymentId.Size = new Size(80, 23);
            lblPaymentId.TabIndex = 1;
            lblPaymentId.Text = "Payment ID:";
            // 
            // txtPaymentId
            // 
            txtPaymentId.Location = new Point(289, 52);
            txtPaymentId.Name = "txtPaymentId";
            txtPaymentId.Size = new Size(153, 23);
            txtPaymentId.TabIndex = 2;
            // 
            // btnGetAll
            // 
            btnGetAll.Location = new Point(591, 18);
            btnGetAll.Name = "btnGetAll";
            btnGetAll.Size = new Size(90, 28);
            btnGetAll.TabIndex = 3;
            btnGetAll.Text = "Get All";
            // 
            // btnGetById
            // 
            btnGetById.Location = new Point(591, 86);
            btnGetById.Name = "btnGetById";
            btnGetById.Size = new Size(90, 28);
            btnGetById.TabIndex = 4;
            btnGetById.Text = "Get by ID";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(495, 18);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(90, 28);
            btnAdd.TabIndex = 5;
            btnAdd.Text = "Add";
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(495, 52);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(90, 28);
            btnUpdate.TabIndex = 6;
            btnUpdate.Text = "Update";
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDelete.Location = new Point(495, 86);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(90, 28);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "Delete";
            // 
            // btnProcess
            // 
            btnProcess.Location = new Point(591, 52);
            btnProcess.Name = "btnProcess";
            btnProcess.Size = new Size(90, 28);
            btnProcess.TabIndex = 8;
            btnProcess.Text = "Process";
            // 
            // Payment
            // 
            BackColor = Color.White;
            Controls.Add(dgvPayments);
            Controls.Add(lblPaymentId);
            Controls.Add(txtPaymentId);
            Controls.Add(btnGetAll);
            Controls.Add(btnGetById);
            Controls.Add(btnAdd);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(btnProcess);
            Name = "Payment";
            Size = new Size(940, 590);
            ((System.ComponentModel.ISupportInitialize)dgvPayments).EndInit();
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
}
}

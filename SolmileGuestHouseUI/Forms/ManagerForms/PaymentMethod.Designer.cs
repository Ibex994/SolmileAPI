namespace SolmileGuestHouseUI.Forms.ManagerForms
{
    partial class PaymentMethod
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            dgvPaymentMethods = new DataGridView();
            lblMethodId = new Label();
            txtMethodId = new TextBox();
            lblMethodName = new Label();
            txtMethodName = new TextBox();
            btnGetAll = new Button();
            btnGetById = new Button();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvPaymentMethods).BeginInit();
            SuspendLayout();
            // 
            // dgvPaymentMethods
            // 
            dgvPaymentMethods.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvPaymentMethods.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPaymentMethods.BackgroundColor = Color.White;
            dgvPaymentMethods.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(33, 150, 243);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvPaymentMethods.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvPaymentMethods.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPaymentMethods.EnableHeadersVisualStyles = false;
            dgvPaymentMethods.Font = new Font("Segoe UI", 10F);
            dgvPaymentMethods.GridColor = Color.LightGray;
            dgvPaymentMethods.Location = new Point(20, 130);
            dgvPaymentMethods.MultiSelect = false;
            dgvPaymentMethods.Name = "dgvPaymentMethods";
            dgvPaymentMethods.RowHeadersVisible = false;
            dgvPaymentMethods.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPaymentMethods.Size = new Size(760, 350);
            dgvPaymentMethods.TabIndex = 0;
            dgvPaymentMethods.CellClick += dgvPaymentMethods_CellClick;
            // 
            // lblMethodId
            // 
            lblMethodId.Font = new Font("Segoe UI", 10F);
            lblMethodId.Location = new Point(161, 31);
            lblMethodId.Name = "lblMethodId";
            lblMethodId.Size = new Size(90, 23);
            lblMethodId.TabIndex = 1;
            lblMethodId.Text = "Method ID:";
            // 
            // txtMethodId
            // 
            txtMethodId.BackColor = Color.WhiteSmoke;
            txtMethodId.BorderStyle = BorderStyle.FixedSingle;
            txtMethodId.Enabled = false;
            txtMethodId.Font = new Font("Segoe UI", 10F);
            txtMethodId.Location = new Point(261, 31);
            txtMethodId.Name = "txtMethodId";
            txtMethodId.ReadOnly = true;
            txtMethodId.Size = new Size(200, 25);
            txtMethodId.TabIndex = 2;
            // 
            // lblMethodName
            // 
            lblMethodName.Font = new Font("Segoe UI", 10F);
            lblMethodName.Location = new Point(161, 71);
            lblMethodName.Name = "lblMethodName";
            lblMethodName.Size = new Size(100, 23);
            lblMethodName.TabIndex = 3;
            lblMethodName.Text = "Method Name:";
            // 
            // txtMethodName
            // 
            txtMethodName.BorderStyle = BorderStyle.FixedSingle;
            txtMethodName.Font = new Font("Segoe UI", 10F);
            txtMethodName.Location = new Point(261, 71);
            txtMethodName.Name = "txtMethodName";
            txtMethodName.Size = new Size(200, 25);
            txtMethodName.TabIndex = 4;
            // 
            // btnGetAll
            // 
            btnGetAll.BackColor = Color.FromArgb(33, 150, 243);
            btnGetAll.Cursor = Cursors.Hand;
            btnGetAll.FlatAppearance.BorderSize = 0;
            btnGetAll.FlatStyle = FlatStyle.Flat;
            btnGetAll.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnGetAll.ForeColor = Color.White;
            btnGetAll.Location = new Point(486, 89);
            btnGetAll.Name = "btnGetAll";
            btnGetAll.Size = new Size(90, 30);
            btnGetAll.TabIndex = 5;
            btnGetAll.Text = "Get All";
            btnGetAll.UseVisualStyleBackColor = false;
            // 
            // btnGetById
            // 
            btnGetById.BackColor = Color.FromArgb(33, 150, 243);
            btnGetById.Cursor = Cursors.Hand;
            btnGetById.FlatAppearance.BorderSize = 0;
            btnGetById.FlatStyle = FlatStyle.Flat;
            btnGetById.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnGetById.ForeColor = Color.White;
            btnGetById.Location = new Point(486, 48);
            btnGetById.Name = "btnGetById";
            btnGetById.Size = new Size(90, 30);
            btnGetById.TabIndex = 6;
            btnGetById.Text = "Get by ID";
            btnGetById.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(33, 150, 243);
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(486, 13);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(90, 30);
            btnAdd.TabIndex = 7;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(241, 196, 15);
            btnUpdate.Cursor = Cursors.Hand;
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(582, 13);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(90, 30);
            btnUpdate.TabIndex = 8;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDelete.BackColor = Color.FromArgb(244, 67, 54);
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(582, 55);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(90, 30);
            btnDelete.TabIndex = 9;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // PaymentMethod
            // 
            BackColor = Color.WhiteSmoke;
            Controls.Add(dgvPaymentMethods);
            Controls.Add(lblMethodId);
            Controls.Add(txtMethodId);
            Controls.Add(lblMethodName);
            Controls.Add(txtMethodName);
            Controls.Add(btnGetAll);
            Controls.Add(btnGetById);
            Controls.Add(btnAdd);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Name = "PaymentMethod";
            Size = new Size(860, 510);
            ((System.ComponentModel.ISupportInitialize)dgvPaymentMethods).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }


        private System.Windows.Forms.DataGridView dgvPaymentMethods;
        private System.Windows.Forms.Label lblMethodId;
        private System.Windows.Forms.TextBox txtMethodId;
        private System.Windows.Forms.Label lblMethodName;
        private System.Windows.Forms.TextBox txtMethodName;
        private System.Windows.Forms.Button btnGetAll;
        private System.Windows.Forms.Button btnGetById;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
    }
}

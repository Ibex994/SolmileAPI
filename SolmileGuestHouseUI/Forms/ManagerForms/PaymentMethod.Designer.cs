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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
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
            groupBox1 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dgvPaymentMethods).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvPaymentMethods
            // 
            dgvPaymentMethods.AllowUserToAddRows = false;
            dgvPaymentMethods.AllowUserToDeleteRows = false;
            dgvPaymentMethods.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvPaymentMethods.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPaymentMethods.BackgroundColor = Color.White;
            dgvPaymentMethods.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(33, 150, 243);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvPaymentMethods.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvPaymentMethods.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPaymentMethods.EnableHeadersVisualStyles = false;
            dgvPaymentMethods.Font = new Font("Segoe UI", 10F);
            dgvPaymentMethods.GridColor = Color.LightGray;
            dgvPaymentMethods.Location = new Point(20, 151);
            dgvPaymentMethods.MultiSelect = false;
            dgvPaymentMethods.Name = "dgvPaymentMethods";
            dgvPaymentMethods.RowHeadersVisible = false;
            dgvPaymentMethods.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPaymentMethods.Size = new Size(818, 356);
            dgvPaymentMethods.TabIndex = 0;
            dgvPaymentMethods.CellClick += dgvPaymentMethods_CellClick;
            // 
            // lblMethodId
            // 
            lblMethodId.Font = new Font("Arial", 11.25F, FontStyle.Bold);
            lblMethodId.ForeColor = Color.Goldenrod;
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
            txtMethodId.Location = new Point(277, 31);
            txtMethodId.Name = "txtMethodId";
            txtMethodId.ReadOnly = true;
            txtMethodId.Size = new Size(184, 25);
            txtMethodId.TabIndex = 2;
            // 
            // lblMethodName
            // 
            lblMethodName.Font = new Font("Arial", 11.25F, FontStyle.Bold);
            lblMethodName.ForeColor = Color.Goldenrod;
            lblMethodName.Location = new Point(161, 71);
            lblMethodName.Name = "lblMethodName";
            lblMethodName.Size = new Size(110, 23);
            lblMethodName.TabIndex = 3;
            lblMethodName.Text = "Method Name:";
            // 
            // txtMethodName
            // 
            txtMethodName.BorderStyle = BorderStyle.FixedSingle;
            txtMethodName.Font = new Font("Segoe UI", 10F);
            txtMethodName.Location = new Point(277, 69);
            txtMethodName.Name = "txtMethodName";
            txtMethodName.Size = new Size(184, 25);
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
            btnGetAll.Location = new Point(159, 59);
            btnGetAll.Name = "btnGetAll";
            btnGetAll.Size = new Size(134, 31);
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
            btnGetById.Location = new Point(159, 22);
            btnGetById.Name = "btnGetById";
            btnGetById.Size = new Size(134, 31);
            btnGetById.TabIndex = 6;
            btnGetById.Text = "Get by ID";
            btnGetById.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(39, 174, 96);
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(19, 19);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(134, 31);
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
            btnUpdate.Location = new Point(19, 56);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(134, 31);
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
            btnDelete.Location = new Point(19, 95);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(134, 31);
            btnDelete.TabIndex = 9;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnGetById);
            groupBox1.Controls.Add(btnGetAll);
            groupBox1.Controls.Add(btnDelete);
            groupBox1.Controls.Add(btnUpdate);
            groupBox1.Controls.Add(btnAdd);
            groupBox1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            groupBox1.Location = new Point(467, 13);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(314, 132);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Action";
            // 
            // PaymentMethod
            // 
            BackColor = Color.White;
            Controls.Add(groupBox1);
            Controls.Add(dgvPaymentMethods);
            Controls.Add(lblMethodId);
            Controls.Add(txtMethodId);
            Controls.Add(lblMethodName);
            Controls.Add(txtMethodName);
            Name = "PaymentMethod";
            Size = new Size(860, 510);
            ((System.ComponentModel.ISupportInitialize)dgvPaymentMethods).EndInit();
            groupBox1.ResumeLayout(false);
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
        private GroupBox groupBox1;
    }
}

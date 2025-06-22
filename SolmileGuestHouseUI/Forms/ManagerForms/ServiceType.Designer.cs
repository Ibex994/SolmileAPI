namespace SolmileGuestHouseUI.Forms.ManagerForms
{
    partial class ServiceType
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
            dgvServiceTypes = new DataGridView();
            lblId = new Label();
            txtId = new TextBox();
            lblName = new Label();
            txtName = new TextBox();
            btnGetAll = new Button();
            btnFindByIdOrName = new Button();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnGetListForCustomer = new Button();
            btnClear = new Button();
            groupBox1 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dgvServiceTypes).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvServiceTypes
            // 
            dgvServiceTypes.AllowUserToAddRows = false;
            dgvServiceTypes.AllowUserToDeleteRows = false;
            dgvServiceTypes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvServiceTypes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvServiceTypes.BackgroundColor = Color.White;
            dgvServiceTypes.BorderStyle = BorderStyle.None;
            dgvServiceTypes.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvServiceTypes.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(52, 152, 219);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvServiceTypes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(52, 152, 219);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvServiceTypes.DefaultCellStyle = dataGridViewCellStyle2;
            dgvServiceTypes.EnableHeadersVisualStyles = false;
            dgvServiceTypes.GridColor = Color.LightGray;
            dgvServiceTypes.Location = new Point(20, 194);
            dgvServiceTypes.MultiSelect = false;
            dgvServiceTypes.Name = "dgvServiceTypes";
            dgvServiceTypes.ReadOnly = true;
            dgvServiceTypes.RowHeadersVisible = false;
            dgvServiceTypes.RowTemplate.Height = 30;
            dgvServiceTypes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvServiceTypes.Size = new Size(810, 506);
            dgvServiceTypes.TabIndex = 0;
            dgvServiceTypes.SelectionChanged += DgvServiceTypes_SelectionChanged;
            // 
            // lblId
            // 
            lblId.Font = new Font("Arial", 11.25F, FontStyle.Bold);
            lblId.ForeColor = Color.Goldenrod;
            lblId.Location = new Point(20, 20);
            lblId.Name = "lblId";
            lblId.Size = new Size(110, 23);
            lblId.TabIndex = 1;
            lblId.Text = "Service Type ID:";
            // 
            // txtId
            // 
            txtId.Location = new Point(136, 18);
            txtId.Name = "txtId";
            txtId.Size = new Size(200, 23);
            txtId.TabIndex = 2;
            // 
            // lblName
            // 
            lblName.Font = new Font("Arial", 11.25F, FontStyle.Bold);
            lblName.ForeColor = Color.Goldenrod;
            lblName.Location = new Point(20, 60);
            lblName.Name = "lblName";
            lblName.Size = new Size(110, 23);
            lblName.TabIndex = 3;
            lblName.Text = "Name:";
            // 
            // txtName
            // 
            txtName.Location = new Point(140, 60);
            txtName.Name = "txtName";
            txtName.Size = new Size(200, 23);
            txtName.TabIndex = 4;
            // 
            // btnGetAll
            // 
            btnGetAll.BackColor = Color.FromArgb(52, 152, 219);
            btnGetAll.FlatStyle = FlatStyle.Flat;
            btnGetAll.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnGetAll.ForeColor = Color.White;
            btnGetAll.Location = new Point(179, 38);
            btnGetAll.Name = "btnGetAll";
            btnGetAll.Size = new Size(147, 31);
            btnGetAll.TabIndex = 7;
            btnGetAll.Text = "Get All";
            btnGetAll.UseVisualStyleBackColor = false;
            // 
            // btnFindByIdOrName
            // 
            btnFindByIdOrName.BackColor = Color.FromArgb(52, 152, 219);
            btnFindByIdOrName.FlatStyle = FlatStyle.Flat;
            btnFindByIdOrName.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnFindByIdOrName.ForeColor = Color.White;
            btnFindByIdOrName.Location = new Point(179, 70);
            btnFindByIdOrName.Name = "btnFindByIdOrName";
            btnFindByIdOrName.Size = new Size(147, 31);
            btnFindByIdOrName.TabIndex = 8;
            btnFindByIdOrName.Text = "Get By ID / Name";
            btnFindByIdOrName.UseVisualStyleBackColor = false;
            btnFindByIdOrName.Click += btnFindByIdOrName_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(39, 174, 96);
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(20, 39);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(147, 31);
            btnAdd.TabIndex = 9;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(241, 196, 15);
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(20, 107);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(147, 31);
            btnUpdate.TabIndex = 10;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(231, 76, 60);
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(20, 73);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(147, 31);
            btnDelete.TabIndex = 11;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnGetListForCustomer
            // 
            btnGetListForCustomer.BackColor = Color.FromArgb(52, 152, 219);
            btnGetListForCustomer.FlatStyle = FlatStyle.Flat;
            btnGetListForCustomer.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnGetListForCustomer.ForeColor = Color.White;
            btnGetListForCustomer.Location = new Point(179, 107);
            btnGetListForCustomer.Name = "btnGetListForCustomer";
            btnGetListForCustomer.Size = new Size(147, 31);
            btnGetListForCustomer.TabIndex = 13;
            btnGetListForCustomer.Text = "Get Service List For Customer";
            btnGetListForCustomer.UseVisualStyleBackColor = false;
            // 
            // btnClear
            // 
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Segoe UI", 9F);
            btnClear.Location = new Point(316, 141);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(44, 23);
            btnClear.TabIndex = 14;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnGetAll);
            groupBox1.Controls.Add(btnClear);
            groupBox1.Controls.Add(btnFindByIdOrName);
            groupBox1.Controls.Add(btnGetListForCustomer);
            groupBox1.Controls.Add(btnAdd);
            groupBox1.Controls.Add(btnDelete);
            groupBox1.Controls.Add(btnUpdate);
            groupBox1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            groupBox1.Location = new Point(356, 18);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(360, 170);
            groupBox1.TabIndex = 15;
            groupBox1.TabStop = false;
            groupBox1.Text = "Action";
            // 
            // ServiceType
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(groupBox1);
            Controls.Add(dgvServiceTypes);
            Controls.Add(lblId);
            Controls.Add(txtId);
            Controls.Add(lblName);
            Controls.Add(txtName);
            Name = "ServiceType";
            Size = new Size(860, 720);
            ((System.ComponentModel.ISupportInitialize)dgvServiceTypes).EndInit();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }


        private System.Windows.Forms.DataGridView dgvServiceTypes;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnGetAll;
        private System.Windows.Forms.Button btnFindByIdOrName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnGetListForCustomer;
        private Button btnClear;
        private GroupBox groupBox1;
    }

        #endregion
    }


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
            ((System.ComponentModel.ISupportInitialize)dgvServiceTypes).BeginInit();
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
            dgvServiceTypes.Location = new Point(20, 130);
            dgvServiceTypes.MultiSelect = false;
            dgvServiceTypes.Name = "dgvServiceTypes";
            dgvServiceTypes.ReadOnly = true;
            dgvServiceTypes.RowHeadersVisible = false;
            dgvServiceTypes.RowTemplate.Height = 30;
            dgvServiceTypes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvServiceTypes.Size = new Size(810, 570);
            dgvServiceTypes.TabIndex = 0;
            dgvServiceTypes.SelectionChanged += DgvServiceTypes_SelectionChanged;
            // 
            // lblId
            // 
            lblId.Location = new Point(20, 20);
            lblId.Name = "lblId";
            lblId.Size = new Size(110, 23);
            lblId.TabIndex = 1;
            lblId.Text = "Service Type ID:";
            // 
            // txtId
            // 
            txtId.Location = new Point(140, 20);
            txtId.Name = "txtId";
            txtId.Size = new Size(200, 23);
            txtId.TabIndex = 2;
            // 
            // lblName
            // 
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
            btnGetAll.Location = new Point(494, 13);
            btnGetAll.Name = "btnGetAll";
            btnGetAll.Size = new Size(90, 28);
            btnGetAll.TabIndex = 7;
            btnGetAll.Text = "Get All";
            // 
            // btnFindByIdOrName
            // 
            btnFindByIdOrName.Location = new Point(494, 47);
            btnFindByIdOrName.Name = "btnFindByIdOrName";
            btnFindByIdOrName.Size = new Size(115, 28);
            btnFindByIdOrName.TabIndex = 8;
            btnFindByIdOrName.Text = "Get By ID / Name";
            btnFindByIdOrName.Click += btnFindByIdOrName_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(371, 13);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(90, 28);
            btnAdd.TabIndex = 9;
            btnAdd.Text = "Add";
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(371, 81);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(90, 28);
            btnUpdate.TabIndex = 10;
            btnUpdate.Text = "Update";
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(371, 47);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(90, 28);
            btnDelete.TabIndex = 11;
            btnDelete.Text = "Delete";
            btnDelete.Click += btnDelete_Click;
            // 
            // btnGetListForCustomer
            // 
            btnGetListForCustomer.Location = new Point(494, 87);
            btnGetListForCustomer.Name = "btnGetListForCustomer";
            btnGetListForCustomer.Size = new Size(180, 28);
            btnGetListForCustomer.TabIndex = 13;
            btnGetListForCustomer.Text = "Get Service List For Customer";
            // 
            // btnClear
            // 
            btnClear.Location = new Point(642, 18);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 23);
            btnClear.TabIndex = 14;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // ServiceType
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(btnClear);
            Controls.Add(dgvServiceTypes);
            Controls.Add(lblId);
            Controls.Add(txtId);
            Controls.Add(lblName);
            Controls.Add(txtName);
            Controls.Add(btnGetAll);
            Controls.Add(btnFindByIdOrName);
            Controls.Add(btnAdd);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(btnGetListForCustomer);
            Name = "ServiceType";
            Size = new Size(860, 720);
            ((System.ComponentModel.ISupportInitialize)dgvServiceTypes).EndInit();
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
    }

        #endregion
    }


namespace SolmileGuestHouseUI.Forms.ManagerForms
{
    partial class Role
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
            dgvRoles = new DataGridView();
            lblRoleId = new Label();
            txtRoleId = new TextBox();
            lblRoleName = new Label();
            txtRoleName = new TextBox();
            btnGetAll = new Button();
            btnAdd = new Button();
            btnDelete = new Button();
            btnClear = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvRoles).BeginInit();
            SuspendLayout();
            // 
            // dgvRoles
            // 
            dgvRoles.AllowUserToAddRows = false;
            dgvRoles.AllowUserToDeleteRows = false;
            dgvRoles.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvRoles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRoles.BackgroundColor = Color.White;
            dgvRoles.BorderStyle = BorderStyle.None;
            dgvRoles.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvRoles.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(52, 152, 219);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvRoles.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(52, 152, 219);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvRoles.DefaultCellStyle = dataGridViewCellStyle2;
            dgvRoles.EnableHeadersVisualStyles = false;
            dgvRoles.GridColor = Color.LightGray;
            dgvRoles.Location = new Point(20, 130);
            dgvRoles.MultiSelect = false;
            dgvRoles.Name = "dgvRoles";
            dgvRoles.ReadOnly = true;
            dgvRoles.RowHeadersVisible = false;
            dgvRoles.RowTemplate.Height = 30;
            dgvRoles.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRoles.Size = new Size(810, 570);
            dgvRoles.TabIndex = 0;
            // 
            // lblRoleId
            // 
            lblRoleId.Location = new Point(127, 47);
            lblRoleId.Name = "lblRoleId";
            lblRoleId.Size = new Size(80, 23);
            lblRoleId.TabIndex = 1;
            lblRoleId.Text = "Role ID:";
            // 
            // txtRoleId
            // 
            txtRoleId.Enabled = false;
            txtRoleId.Location = new Point(207, 47);
            txtRoleId.Name = "txtRoleId";
            txtRoleId.ReadOnly = true;
            txtRoleId.Size = new Size(200, 23);
            txtRoleId.TabIndex = 2;
            // 
            // lblRoleName
            // 
            lblRoleName.Location = new Point(127, 87);
            lblRoleName.Name = "lblRoleName";
            lblRoleName.Size = new Size(80, 23);
            lblRoleName.TabIndex = 3;
            lblRoleName.Text = "Role Name:";
            // 
            // txtRoleName
            // 
            txtRoleName.Location = new Point(207, 87);
            txtRoleName.Name = "txtRoleName";
            txtRoleName.Size = new Size(200, 23);
            txtRoleName.TabIndex = 4;
            // 
            // btnGetAll
            // 
            btnGetAll.Location = new Point(473, 47);
            btnGetAll.Name = "btnGetAll";
            btnGetAll.Size = new Size(90, 28);
            btnGetAll.TabIndex = 5;
            btnGetAll.Text = "Get All";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(573, 47);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(90, 28);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "Add Role";
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(673, 47);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(100, 28);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "Delete Role";
            // 
            // btnClear
            // 
            btnClear.Location = new Point(673, 81);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(100, 23);
            btnClear.TabIndex = 8;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // Role
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(btnClear);
            Controls.Add(dgvRoles);
            Controls.Add(lblRoleId);
            Controls.Add(txtRoleId);
            Controls.Add(lblRoleName);
            Controls.Add(txtRoleName);
            Controls.Add(btnGetAll);
            Controls.Add(btnAdd);
            Controls.Add(btnDelete);
            Name = "Role";
            Size = new Size(860, 730);
            Load += Role_Load;
            ((System.ComponentModel.ISupportInitialize)dgvRoles).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.DataGridView dgvRoles;
        private System.Windows.Forms.Label lblRoleId;
        private System.Windows.Forms.TextBox txtRoleId;
        private System.Windows.Forms.Label lblRoleName;
        private System.Windows.Forms.TextBox txtRoleName;
        private System.Windows.Forms.Button btnGetAll;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private Button btnClear;
    }

        #endregion
    }

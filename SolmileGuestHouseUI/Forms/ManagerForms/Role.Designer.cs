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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            dgvRoles = new DataGridView();
            lblRoleId = new Label();
            txtRoleId = new TextBox();
            lblRoleName = new Label();
            txtRoleName = new TextBox();
            btnGetAll = new Button();
            btnAdd = new Button();
            btnDelete = new Button();
            btnClear = new Button();
            groupBox1 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dgvRoles).BeginInit();
            groupBox1.SuspendLayout();
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
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(52, 152, 219);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvRoles.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(52, 152, 219);
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgvRoles.DefaultCellStyle = dataGridViewCellStyle4;
            dgvRoles.EnableHeadersVisualStyles = false;
            dgvRoles.GridColor = Color.LightGray;
            dgvRoles.Location = new Point(20, 167);
            dgvRoles.MultiSelect = false;
            dgvRoles.Name = "dgvRoles";
            dgvRoles.ReadOnly = true;
            dgvRoles.RowHeadersVisible = false;
            dgvRoles.RowTemplate.Height = 30;
            dgvRoles.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRoles.Size = new Size(810, 533);
            dgvRoles.TabIndex = 0;
            // 
            // lblRoleId
            // 
            lblRoleId.Font = new Font("Arial", 11.25F, FontStyle.Bold);
            lblRoleId.ForeColor = Color.Goldenrod;
            lblRoleId.Location = new Point(127, 47);
            lblRoleId.Name = "lblRoleId";
            lblRoleId.Size = new Size(80, 23);
            lblRoleId.TabIndex = 1;
            lblRoleId.Text = "Role ID:";
            // 
            // txtRoleId
            // 
            txtRoleId.Enabled = false;
            txtRoleId.Location = new Point(213, 42);
            txtRoleId.Name = "txtRoleId";
            txtRoleId.ReadOnly = true;
            txtRoleId.Size = new Size(200, 23);
            txtRoleId.TabIndex = 2;
            // 
            // lblRoleName
            // 
            lblRoleName.Font = new Font("Arial", 11.25F, FontStyle.Bold);
            lblRoleName.ForeColor = Color.Goldenrod;
            lblRoleName.Location = new Point(127, 87);
            lblRoleName.Name = "lblRoleName";
            lblRoleName.Size = new Size(80, 23);
            lblRoleName.TabIndex = 3;
            lblRoleName.Text = "Role Name:";
            // 
            // txtRoleName
            // 
            txtRoleName.Location = new Point(213, 82);
            txtRoleName.Name = "txtRoleName";
            txtRoleName.Size = new Size(200, 23);
            txtRoleName.TabIndex = 4;
            // 
            // btnGetAll
            // 
            btnGetAll.BackColor = Color.FromArgb(52, 152, 219);
            btnGetAll.FlatStyle = FlatStyle.Flat;
            btnGetAll.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnGetAll.ForeColor = Color.White;
            btnGetAll.Location = new Point(41, 27);
            btnGetAll.Name = "btnGetAll";
            btnGetAll.Size = new Size(134, 31);
            btnGetAll.TabIndex = 5;
            btnGetAll.Text = "Get All";
            btnGetAll.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(39, 174, 96);
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(41, 64);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(134, 31);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "Add Role";
            btnAdd.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(231, 76, 60);
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(41, 101);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(134, 31);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "Delete Role";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnClear
            // 
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Arial Narrow", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.Location = new Point(192, 110);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(47, 25);
            btnClear.TabIndex = 8;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnGetAll);
            groupBox1.Controls.Add(btnAdd);
            groupBox1.Controls.Add(btnClear);
            groupBox1.Controls.Add(btnDelete);
            groupBox1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            groupBox1.Location = new Point(440, 20);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(242, 141);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Action";
            // 
            // Role
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(groupBox1);
            Controls.Add(dgvRoles);
            Controls.Add(lblRoleId);
            Controls.Add(txtRoleId);
            Controls.Add(lblRoleName);
            Controls.Add(txtRoleName);
            ForeColor = Color.Black;
            Name = "Role";
            Size = new Size(860, 730);
            Load += Role_Load;
            ((System.ComponentModel.ISupportInitialize)dgvRoles).EndInit();
            groupBox1.ResumeLayout(false);
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
        private GroupBox groupBox1;
    }

        #endregion
    }

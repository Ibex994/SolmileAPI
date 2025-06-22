namespace SolmileGuestHouseUI.Forms.ManagerForms
{
    partial class UserRole
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private ComboBox cbUsers;
        private ComboBox cbRoles;
        private Button btnAssign;
        private Button btnRemove;
        private DataGridView dgvUserRoles;

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
            cbUsers = new ComboBox();
            cbRoles = new ComboBox();
            btnAssign = new Button();
            btnRemove = new Button();
            dgvUserRoles = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvUserRoles).BeginInit();
            SuspendLayout();
            // 
            // cbUsers
            // 
            cbUsers.DropDownStyle = ComboBoxStyle.DropDownList;
            cbUsers.Location = new Point(202, 31);
            cbUsers.Name = "cbUsers";
            cbUsers.Size = new Size(200, 23);
            cbUsers.TabIndex = 0;
            // 
            // cbRoles
            // 
            cbRoles.DropDownStyle = ComboBoxStyle.DropDownList;
            cbRoles.Location = new Point(442, 31);
            cbRoles.Name = "cbRoles";
            cbRoles.Size = new Size(200, 23);
            cbRoles.TabIndex = 1;
            // 
            // btnAssign
            // 
            btnAssign.BackColor = Color.FromArgb(241, 196, 15);
            btnAssign.FlatStyle = FlatStyle.Flat;
            btnAssign.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnAssign.ForeColor = Color.White;
            btnAssign.Location = new Point(268, 76);
            btnAssign.Name = "btnAssign";
            btnAssign.Size = new Size(134, 31);
            btnAssign.TabIndex = 2;
            btnAssign.Text = "Update Role";
            btnAssign.UseVisualStyleBackColor = false;
            btnAssign.Click += BtnAssign_Click;
            // 
            // btnRemove
            // 
            btnRemove.BackColor = Color.FromArgb(231, 76, 60);
            btnRemove.FlatStyle = FlatStyle.Flat;
            btnRemove.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnRemove.ForeColor = Color.White;
            btnRemove.Location = new Point(467, 76);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(134, 31);
            btnRemove.TabIndex = 3;
            btnRemove.Text = "Remove Selected Role";
            btnRemove.UseVisualStyleBackColor = false;
            btnRemove.Click += BtnRemove_Click;
            // 
            // dgvUserRoles
            // 
            dgvUserRoles.AllowUserToAddRows = false;
            dgvUserRoles.AllowUserToDeleteRows = false;
            dgvUserRoles.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvUserRoles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUserRoles.BackgroundColor = Color.White;
            dgvUserRoles.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(52, 152, 219);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvUserRoles.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvUserRoles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(52, 152, 219);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvUserRoles.DefaultCellStyle = dataGridViewCellStyle2;
            dgvUserRoles.EnableHeadersVisualStyles = false;
            dgvUserRoles.GridColor = Color.LightGray;
            dgvUserRoles.Location = new Point(30, 130);
            dgvUserRoles.MultiSelect = false;
            dgvUserRoles.Name = "dgvUserRoles";
            dgvUserRoles.ReadOnly = true;
            dgvUserRoles.RowHeadersVisible = false;
            dgvUserRoles.RowTemplate.Height = 30;
            dgvUserRoles.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUserRoles.Size = new Size(793, 415);
            dgvUserRoles.TabIndex = 4;
            // 
            // UserRole
            // 
            BackColor = Color.White;
            Controls.Add(cbUsers);
            Controls.Add(cbRoles);
            Controls.Add(btnAssign);
            Controls.Add(btnRemove);
            Controls.Add(dgvUserRoles);
            Name = "UserRole";
            Size = new Size(880, 588);
            ((System.ComponentModel.ISupportInitialize)dgvUserRoles).EndInit();
            ResumeLayout(false);
        }
    }
}

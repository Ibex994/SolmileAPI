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
            btnAssign.Location = new Point(231, 77);
            btnAssign.Name = "btnAssign";
            btnAssign.Size = new Size(120, 30);
            btnAssign.TabIndex = 2;
            btnAssign.Text = "Update Role";
            btnAssign.Click += BtnAssign_Click;
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(430, 77);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(200, 30);
            btnRemove.TabIndex = 3;
            btnRemove.Text = "Remove Selected Role";
            btnRemove.Click += BtnRemove_Click;
            // 
            // dgvUserRoles
            // 
            dgvUserRoles.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvUserRoles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUserRoles.BackgroundColor = Color.White;
            dgvUserRoles.Location = new Point(30, 130);
            dgvUserRoles.MultiSelect = false;
            dgvUserRoles.Name = "dgvUserRoles";
            dgvUserRoles.ReadOnly = true;
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

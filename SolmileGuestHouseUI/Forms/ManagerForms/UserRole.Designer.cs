namespace SolmileGuestHouseUI.Forms.ManagerForms
{
    partial class UserRole
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
            dgvUserRoles = new DataGridView();
            lblRoleId = new Label();
            txtRoleId = new TextBox();
            lblRoleName = new Label();
            txtRoleName = new TextBox();
            btnGetAllRoles = new Button();
            btnAddRole = new Button();
            btnDeleteRole = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvUserRoles).BeginInit();
            SuspendLayout();
            // 
            // dgvUserRoles
            // 
            dgvUserRoles.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvUserRoles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUserRoles.Location = new Point(20, 130);
            dgvUserRoles.Name = "dgvUserRoles";
            dgvUserRoles.Size = new Size(810, 570);
            dgvUserRoles.TabIndex = 0;
            // 
            // lblRoleId
            // 
            lblRoleId.Location = new Point(20, 20);
            lblRoleId.Name = "lblRoleId";
            lblRoleId.Size = new Size(100, 23);
            lblRoleId.TabIndex = 1;
            lblRoleId.Text = "Role ID:";
            // 
            // txtRoleId
            // 
            txtRoleId.Location = new Point(130, 20);
            txtRoleId.Name = "txtRoleId";
            txtRoleId.Size = new Size(150, 23);
            txtRoleId.TabIndex = 2;
            // 
            // lblRoleName
            // 
            lblRoleName.Location = new Point(20, 60);
            lblRoleName.Name = "lblRoleName";
            lblRoleName.Size = new Size(100, 23);
            lblRoleName.TabIndex = 3;
            lblRoleName.Text = "Role Name:";
            // 
            // txtRoleName
            // 
            txtRoleName.Location = new Point(130, 60);
            txtRoleName.Name = "txtRoleName";
            txtRoleName.Size = new Size(150, 23);
            txtRoleName.TabIndex = 4;
            // 
            // btnGetAllRoles
            // 
            btnGetAllRoles.Location = new Point(320, 20);
            btnGetAllRoles.Name = "btnGetAllRoles";
            btnGetAllRoles.Size = new Size(120, 28);
            btnGetAllRoles.TabIndex = 5;
            btnGetAllRoles.Text = "Get All Roles";
            // 
            // btnAddRole
            // 
            btnAddRole.Location = new Point(320, 60);
            btnAddRole.Name = "btnAddRole";
            btnAddRole.Size = new Size(120, 28);
            btnAddRole.TabIndex = 6;
            btnAddRole.Text = "Add Role";
            // 
            // btnDeleteRole
            // 
            btnDeleteRole.Location = new Point(320, 100);
            btnDeleteRole.Name = "btnDeleteRole";
            btnDeleteRole.Size = new Size(120, 28);
            btnDeleteRole.TabIndex = 7;
            btnDeleteRole.Text = "Delete Role";
            // 
            // UserRole
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dgvUserRoles);
            Controls.Add(lblRoleId);
            Controls.Add(txtRoleId);
            Controls.Add(lblRoleName);
            Controls.Add(txtRoleName);
            Controls.Add(btnGetAllRoles);
            Controls.Add(btnAddRole);
            Controls.Add(btnDeleteRole);
            Name = "UserRole";
            Size = new Size(860, 730);
            ((System.ComponentModel.ISupportInitialize)dgvUserRoles).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.DataGridView dgvUserRoles;
        private System.Windows.Forms.Label lblRoleId;
        private System.Windows.Forms.TextBox txtRoleId;
        private System.Windows.Forms.Label lblRoleName;
        private System.Windows.Forms.TextBox txtRoleName;

        private System.Windows.Forms.Button btnGetAllRoles;
        private System.Windows.Forms.Button btnAddRole;
        private System.Windows.Forms.Button btnDeleteRole;
        #endregion
    }
}

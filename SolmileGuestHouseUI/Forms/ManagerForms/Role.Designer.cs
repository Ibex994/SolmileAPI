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
            dgvRoles = new DataGridView();
            lblRoleId = new Label();
            txtRoleId = new TextBox();
            lblRoleName = new Label();
            txtRoleName = new TextBox();
            btnGetAll = new Button();
            btnAdd = new Button();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvRoles).BeginInit();
            SuspendLayout();
            // 
            // dgvRoles
            // 
            dgvRoles.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvRoles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRoles.Location = new Point(20, 130);
            dgvRoles.Name = "dgvRoles";
            dgvRoles.Size = new Size(810, 570);
            dgvRoles.TabIndex = 0;
            // 
            // lblRoleId
            // 
            lblRoleId.Location = new Point(20, 20);
            lblRoleId.Name = "lblRoleId";
            lblRoleId.Size = new Size(80, 23);
            lblRoleId.TabIndex = 1;
            lblRoleId.Text = "Role ID:";
            // 
            // txtRoleId
            // 
            txtRoleId.Location = new Point(100, 20);
            txtRoleId.Name = "txtRoleId";
            txtRoleId.Size = new Size(200, 23);
            txtRoleId.TabIndex = 2;
            // 
            // lblRoleName
            // 
            lblRoleName.Location = new Point(20, 60);
            lblRoleName.Name = "lblRoleName";
            lblRoleName.Size = new Size(80, 23);
            lblRoleName.TabIndex = 3;
            lblRoleName.Text = "Role Name:";
            // 
            // txtRoleName
            // 
            txtRoleName.Location = new Point(100, 60);
            txtRoleName.Name = "txtRoleName";
            txtRoleName.Size = new Size(200, 23);
            txtRoleName.TabIndex = 4;
            // 
            // btnGetAll
            // 
            btnGetAll.Location = new Point(320, 18);
            btnGetAll.Name = "btnGetAll";
            btnGetAll.Size = new Size(90, 28);
            btnGetAll.TabIndex = 5;
            btnGetAll.Text = "Get All";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(420, 18);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(90, 28);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "Add Role";
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(520, 18);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(100, 28);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "Delete Role";
            // 
            // Role
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
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
    }

        #endregion
    }

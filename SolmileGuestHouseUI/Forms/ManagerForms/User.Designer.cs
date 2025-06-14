namespace SolmileGuestHouseUI.Forms.ManagerForms
{
    partial class User
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.TextBox txtUserId;
        private System.Windows.Forms.Button btnLoadUsers;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnDeleteUser;
        private System.Windows.Forms.Button btnUpdateUser;
        private System.Windows.Forms.Button btnLock;
        private System.Windows.Forms.Button btnUnlock;
        private System.Windows.Forms.Button btnIsLocked;
        private System.Windows.Forms.Button btnGetLockedUsers;
        private System.Windows.Forms.Button btnCheckUsername;

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
            dgvUsers = new DataGridView();
            txtUserId = new TextBox();
            btnLoadUsers = new Button();
            btnSearch = new Button();
            btnDeleteUser = new Button();
            btnUpdateUser = new Button();
            btnLock = new Button();
            btnUnlock = new Button();
            btnIsLocked = new Button();
            btnGetLockedUsers = new Button();
            btnCheckUsername = new Button();
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            btnClear = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).BeginInit();
            SuspendLayout();
            // 
            // dgvUsers
            // 
            dgvUsers.BackgroundColor = Color.White;
            dgvUsers.Location = new Point(12, 119);
            dgvUsers.Name = "dgvUsers";
            dgvUsers.Size = new Size(711, 347);
            dgvUsers.TabIndex = 0;
            dgvUsers.CellClick += dgvUsers_CellClick;
            // 
            // txtUserId
            // 
            txtUserId.Enabled = false;
            txtUserId.Location = new Point(12, 12);
            txtUserId.Name = "txtUserId";
            txtUserId.PlaceholderText = "User ID";
            txtUserId.Size = new Size(247, 23);
            txtUserId.TabIndex = 1;
            // 
            // btnLoadUsers
            // 
            btnLoadUsers.Location = new Point(294, 12);
            btnLoadUsers.Name = "btnLoadUsers";
            btnLoadUsers.Size = new Size(104, 23);
            btnLoadUsers.TabIndex = 4;
            btnLoadUsers.Text = "Load All Users";
            btnLoadUsers.Click += btnLoadUsers_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(294, 42);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(104, 23);
            btnSearch.TabIndex = 5;
            btnSearch.Text = "Search";
            btnSearch.Click += btnSearch_Click;
            // 
            // btnDeleteUser
            // 
            btnDeleteUser.Location = new Point(294, 72);
            btnDeleteUser.Name = "btnDeleteUser";
            btnDeleteUser.Size = new Size(104, 23);
            btnDeleteUser.TabIndex = 6;
            btnDeleteUser.Text = "Delete User";
            btnDeleteUser.Click += btnDeleteUser_Click;
            // 
            // btnUpdateUser
            // 
            btnUpdateUser.Location = new Point(404, 12);
            btnUpdateUser.Name = "btnUpdateUser";
            btnUpdateUser.Size = new Size(104, 23);
            btnUpdateUser.TabIndex = 7;
            btnUpdateUser.Text = "Update User";
            btnUpdateUser.Click += btnUpdateUser_Click;
            // 
            // btnLock
            // 
            btnLock.Location = new Point(404, 42);
            btnLock.Name = "btnLock";
            btnLock.Size = new Size(104, 23);
            btnLock.TabIndex = 8;
            btnLock.Text = "Lock User";
            btnLock.Click += btnLock_Click;
            // 
            // btnUnlock
            // 
            btnUnlock.Location = new Point(404, 72);
            btnUnlock.Name = "btnUnlock";
            btnUnlock.Size = new Size(104, 23);
            btnUnlock.TabIndex = 9;
            btnUnlock.Text = "Unlock User";
            btnUnlock.Click += btnUnlock_Click;
            // 
            // btnIsLocked
            // 
            btnIsLocked.Location = new Point(514, 12);
            btnIsLocked.Name = "btnIsLocked";
            btnIsLocked.Size = new Size(110, 23);
            btnIsLocked.TabIndex = 10;
            btnIsLocked.Text = "Is Locked?";
            btnIsLocked.Click += btnIsLocked_Click;
            // 
            // btnGetLockedUsers
            // 
            btnGetLockedUsers.Location = new Point(514, 42);
            btnGetLockedUsers.Name = "btnGetLockedUsers";
            btnGetLockedUsers.Size = new Size(110, 23);
            btnGetLockedUsers.TabIndex = 11;
            btnGetLockedUsers.Text = "Get Locked Users";
            btnGetLockedUsers.Click += btnGetLockedUsers_Click;
            // 
            // btnCheckUsername
            // 
            btnCheckUsername.Location = new Point(514, 72);
            btnCheckUsername.Name = "btnCheckUsername";
            btnCheckUsername.Size = new Size(139, 23);
            btnCheckUsername.TabIndex = 12;
            btnCheckUsername.Text = "Check Username Exists";
            btnCheckUsername.Click += btnCheckUsername_Click;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(12, 72);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Password";
            txtPassword.Size = new Size(247, 23);
            txtPassword.TabIndex = 1;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(12, 43);
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = "UserName";
            txtUsername.Size = new Size(247, 23);
            txtUsername.TabIndex = 1;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(630, 31);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 23);
            btnClear.TabIndex = 12;
            btnClear.Text = "Clear";
            btnClear.Click += btnClear_Click;
            // 
            // User
            // 
            BackColor = Color.White;
            Controls.Add(dgvUsers);
            Controls.Add(txtUsername);
            Controls.Add(txtPassword);
            Controls.Add(txtUserId);
            Controls.Add(btnLoadUsers);
            Controls.Add(btnSearch);
            Controls.Add(btnDeleteUser);
            Controls.Add(btnUpdateUser);
            Controls.Add(btnLock);
            Controls.Add(btnUnlock);
            Controls.Add(btnIsLocked);
            Controls.Add(btnGetLockedUsers);
            Controls.Add(btnClear);
            Controls.Add(btnCheckUsername);
            Name = "User";
            Size = new Size(794, 501);
            ((System.ComponentModel.ISupportInitialize)dgvUsers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtPassword;
        private TextBox txtUsername;
        private Button btnClear;
    }
}

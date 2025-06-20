namespace SolmileGuestHouseUI.Forms.ManagerForms
{
    partial class User
    {
        private System.ComponentModel.IContainer components = null;

        private TabControl tabControl;
        private TabPage tabManageUsers;
        private TabPage tabLockUnlock;
        private TabPage tabUtility;

        private TextBox txtUserId;
        private TextBox txtUsername;
        private TextBox txtPassword;

        private Button btnLoadUsers;
        private Button btnSearch;
        private Button btnDeleteUser;
        private Button btnUpdateUser;
        private Button btnClearManage;

        private Button btnLock;
        private Button btnUnlock;
        private Button btnIsLocked;
        private Button btnGetLockedUsers;

        private Button btnCheckUsername;
        private Button btnClearUtility;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            tabControl = new TabControl();
            tabManageUsers = new TabPage();
            dgvUsers = new DataGridView();
            txtUserId = new TextBox();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            btnLoadUsers = new Button();
            btnSearch = new Button();
            btnUpdateUser = new Button();
            btnDeleteUser = new Button();
            btnClearManage = new Button();
            tabLockUnlock = new TabPage();
            btnGetLockedUsers = new Button();
            btnIsLocked = new Button();
            btnUnlock = new Button();
            btnLock = new Button();
            tabUtility = new TabPage();
            btnCheckUsername = new Button();
            btnClearUtility = new Button();
            tabControl.SuspendLayout();
            tabManageUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).BeginInit();
            tabLockUnlock.SuspendLayout();
            tabUtility.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl
            // 
            tabControl.Controls.Add(tabManageUsers);
            tabControl.Controls.Add(tabLockUnlock);
            tabControl.Controls.Add(tabUtility);
            tabControl.Location = new Point(10, 10);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(866, 571);
            tabControl.TabIndex = 0;
            tabControl.SelectedIndexChanged += tabControl_SelectedIndexChanged;
            // 
            // tabManageUsers
            // 
            tabManageUsers.BackColor = Color.White;
            tabManageUsers.Controls.Add(dgvUsers);
            tabManageUsers.Controls.Add(txtUserId);
            tabManageUsers.Controls.Add(txtUsername);
            tabManageUsers.Controls.Add(txtPassword);
            tabManageUsers.Controls.Add(btnLoadUsers);
            tabManageUsers.Controls.Add(btnSearch);
            tabManageUsers.Controls.Add(btnUpdateUser);
            tabManageUsers.Controls.Add(btnDeleteUser);
            tabManageUsers.Controls.Add(btnClearManage);
            tabManageUsers.Location = new Point(4, 24);
            tabManageUsers.Name = "tabManageUsers";
            tabManageUsers.Size = new Size(858, 543);
            tabManageUsers.TabIndex = 0;
            tabManageUsers.Text = "Manage Users";
            // 
            // dgvUsers
            // 
            dgvUsers.AllowUserToAddRows = false;
            dgvUsers.AllowUserToDeleteRows = false;
            dgvUsers.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUsers.BackgroundColor = Color.White;
            dgvUsers.BorderStyle = BorderStyle.None;
            dgvUsers.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvUsers.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvUsers.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(52, 152, 219);
            dgvUsers.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvUsers.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dgvUsers.DefaultCellStyle.Font = new Font("Segoe UI", 10F);
            dgvUsers.DefaultCellStyle.SelectionBackColor = Color.FromArgb(52, 152, 219);
            dgvUsers.DefaultCellStyle.SelectionForeColor = Color.White;
            dgvUsers.EnableHeadersVisualStyles = false;
            dgvUsers.GridColor = Color.LightGray;
            dgvUsers.Location = new Point(10, 110);
            dgvUsers.MultiSelect = false;
            dgvUsers.Name = "dgvUsers";
            dgvUsers.ReadOnly = true;
            dgvUsers.RowHeadersVisible = false;
            dgvUsers.RowTemplate.Height = 30;
            dgvUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsers.Size = new Size(800, 416);
            dgvUsers.TabIndex = 9;
            dgvUsers.CellClick += dgvUsers_CellClick;
            // 
            // txtUserId
            // 
            txtUserId.Enabled = false;
            txtUserId.Location = new Point(10, 10);
            txtUserId.Name = "txtUserId";
            txtUserId.PlaceholderText = "User ID";
            txtUserId.Size = new Size(250, 23);
            txtUserId.TabIndex = 0;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(10, 40);
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = "Username";
            txtUsername.Size = new Size(250, 23);
            txtUsername.TabIndex = 1;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(10, 70);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Password";
            txtPassword.Size = new Size(250, 23);
            txtPassword.TabIndex = 2;
            // 
            // btnLoadUsers
            // 
            btnLoadUsers.Location = new Point(280, 10);
            btnLoadUsers.Name = "btnLoadUsers";
            btnLoadUsers.Size = new Size(110, 23);
            btnLoadUsers.TabIndex = 3;
            btnLoadUsers.Text = "Load All Users";
            btnLoadUsers.Click += btnLoadUsers_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(280, 40);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(110, 23);
            btnSearch.TabIndex = 4;
            btnSearch.Text = "Search";
            btnSearch.Click += btnSearch_Click;
            // 
            // btnUpdateUser
            // 
            btnUpdateUser.Location = new Point(400, 10);
            btnUpdateUser.Name = "btnUpdateUser";
            btnUpdateUser.Size = new Size(110, 23);
            btnUpdateUser.TabIndex = 5;
            btnUpdateUser.Text = "Update User";
            btnUpdateUser.Click += btnUpdateUser_Click;
            // 
            // btnDeleteUser
            // 
            btnDeleteUser.Location = new Point(400, 40);
            btnDeleteUser.Name = "btnDeleteUser";
            btnDeleteUser.Size = new Size(110, 23);
            btnDeleteUser.TabIndex = 6;
            btnDeleteUser.Text = "Delete User";
            btnDeleteUser.Click += btnDeleteUser_Click;
            // 
            // btnClearManage
            // 
            btnClearManage.Location = new Point(280, 70);
            btnClearManage.Name = "btnClearManage";
            btnClearManage.Size = new Size(110, 23);
            btnClearManage.TabIndex = 7;
            btnClearManage.Text = "Clear";
            btnClearManage.Click += btnClear_Click;
            // 
            // tabLockUnlock
            // 
            tabLockUnlock.BackColor = Color.White;
            tabLockUnlock.Controls.Add(btnGetLockedUsers);
            tabLockUnlock.Controls.Add(btnIsLocked);
            tabLockUnlock.Controls.Add(btnUnlock);
            tabLockUnlock.Controls.Add(btnLock);
            tabLockUnlock.Location = new Point(4, 24);
            tabLockUnlock.Name = "tabLockUnlock";
            tabLockUnlock.Size = new Size(858, 543);
            tabLockUnlock.TabIndex = 1;
            tabLockUnlock.Text = "Lock/Unlock";
            // 
            // btnGetLockedUsers
            // 
            btnGetLockedUsers.Location = new Point(300, 20);
            btnGetLockedUsers.Name = "btnGetLockedUsers";
            btnGetLockedUsers.Size = new Size(130, 23);
            btnGetLockedUsers.TabIndex = 1;
            btnGetLockedUsers.Text = "Get Locked Users";
            btnGetLockedUsers.Click += btnGetLockedUsers_Click;
            // 
            // btnIsLocked
            // 
            btnIsLocked.Location = new Point(300, 50);
            btnIsLocked.Name = "btnIsLocked";
            btnIsLocked.Size = new Size(130, 23);
            btnIsLocked.TabIndex = 2;
            btnIsLocked.Text = "Is Locked?";
            btnIsLocked.Click += btnIsLocked_Click;
            // 
            // btnUnlock
            // 
            btnUnlock.Location = new Point(300, 80);
            btnUnlock.Name = "btnUnlock";
            btnUnlock.Size = new Size(130, 23);
            btnUnlock.TabIndex = 3;
            btnUnlock.Text = "Unlock User";
            btnUnlock.Click += btnUnlock_Click;
            // 
            // btnLock
            // 
            btnLock.Location = new Point(440, 20);
            btnLock.Name = "btnLock";
            btnLock.Size = new Size(130, 23);
            btnLock.TabIndex = 4;
            btnLock.Text = "Lock User";
            btnLock.Click += btnLock_Click;
            // 
            // tabUtility
            // 
            tabUtility.BackColor = Color.White;
            tabUtility.Controls.Add(btnCheckUsername);
            tabUtility.Controls.Add(btnClearUtility);
            tabUtility.Location = new Point(4, 24);
            tabUtility.Name = "tabUtility";
            tabUtility.Size = new Size(858, 543);
            tabUtility.TabIndex = 2;
            tabUtility.Text = "Utility";
            // 
            // btnCheckUsername
            // 
            btnCheckUsername.Location = new Point(324, 20);
            btnCheckUsername.Name = "btnCheckUsername";
            btnCheckUsername.Size = new Size(160, 23);
            btnCheckUsername.TabIndex = 1;
            btnCheckUsername.Text = "Check Username Exists";
            btnCheckUsername.Click += btnCheckUsername_Click;
            // 
            // btnClearUtility
            // 
            btnClearUtility.Location = new Point(494, 20);
            btnClearUtility.Name = "btnClearUtility";
            btnClearUtility.Size = new Size(80, 23);
            btnClearUtility.TabIndex = 2;
            btnClearUtility.Text = "Clear";
            btnClearUtility.Click += btnClear_Click;
            // 
            // User
            // 
            BackColor = Color.White;
            Controls.Add(tabControl);
            Name = "User";
            Size = new Size(922, 600);
            tabControl.ResumeLayout(false);
            tabManageUsers.ResumeLayout(false);
            tabManageUsers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).EndInit();
            tabLockUnlock.ResumeLayout(false);
            tabUtility.ResumeLayout(false);
            ResumeLayout(false);
        }
        private DataGridView dgvUsers;
    }
}

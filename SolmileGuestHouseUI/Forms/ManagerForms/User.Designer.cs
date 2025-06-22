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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            tabControl = new TabControl();
            tabManageUsers = new TabPage();
            dgvUsers = new DataGridView();
            txtUserId = new TextBox();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            groupBox1 = new GroupBox();
            btnLoadUsers = new Button();
            btnUpdateUser = new Button();
            btnSearch = new Button();
            btnDeleteUser = new Button();
            btnClearManage = new Button();
            tabLockUnlock = new TabPage();
            groupBox2 = new GroupBox();
            btnLock = new Button();
            btnGetLockedUsers = new Button();
            btnUnlock = new Button();
            btnIsLocked = new Button();
            tabUtility = new TabPage();
            btnCheckUsername = new Button();
            btnClearUtility = new Button();
            tabControl.SuspendLayout();
            tabManageUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).BeginInit();
            groupBox1.SuspendLayout();
            tabLockUnlock.SuspendLayout();
            groupBox2.SuspendLayout();
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
            tabManageUsers.Controls.Add(groupBox1);
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
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(52, 152, 219);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(52, 152, 219);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvUsers.DefaultCellStyle = dataGridViewCellStyle2;
            dgvUsers.EnableHeadersVisualStyles = false;
            dgvUsers.GridColor = Color.LightGray;
            dgvUsers.Location = new Point(10, 188);
            dgvUsers.MultiSelect = false;
            dgvUsers.Name = "dgvUsers";
            dgvUsers.ReadOnly = true;
            dgvUsers.RowHeadersVisible = false;
            dgvUsers.RowTemplate.Height = 30;
            dgvUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsers.Size = new Size(814, 338);
            dgvUsers.TabIndex = 9;
            dgvUsers.CellClick += dgvUsers_CellClick;
            // 
            // txtUserId
            // 
            txtUserId.Enabled = false;
            txtUserId.Font = new Font("Arial Narrow", 8.25F, FontStyle.Bold);
            txtUserId.Location = new Point(10, 15);
            txtUserId.Name = "txtUserId";
            txtUserId.PlaceholderText = "User ID";
            txtUserId.Size = new Size(250, 20);
            txtUserId.TabIndex = 0;
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Arial Narrow", 8.25F, FontStyle.Bold);
            txtUsername.Location = new Point(10, 45);
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = "Username";
            txtUsername.Size = new Size(250, 20);
            txtUsername.TabIndex = 1;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Arial Narrow", 8.25F, FontStyle.Bold);
            txtPassword.Location = new Point(10, 75);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Password";
            txtPassword.Size = new Size(250, 20);
            txtPassword.TabIndex = 2;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnLoadUsers);
            groupBox1.Controls.Add(btnUpdateUser);
            groupBox1.Controls.Add(btnSearch);
            groupBox1.Controls.Add(btnDeleteUser);
            groupBox1.Controls.Add(btnClearManage);
            groupBox1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            groupBox1.Location = new Point(390, 15);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(306, 132);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Action";
            // 
            // btnLoadUsers
            // 
            btnLoadUsers.BackColor = Color.FromArgb(52, 152, 219);
            btnLoadUsers.FlatStyle = FlatStyle.Flat;
            btnLoadUsers.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnLoadUsers.ForeColor = Color.White;
            btnLoadUsers.Location = new Point(29, 24);
            btnLoadUsers.Name = "btnLoadUsers";
            btnLoadUsers.Size = new Size(134, 31);
            btnLoadUsers.TabIndex = 3;
            btnLoadUsers.Text = "Load All Users";
            btnLoadUsers.UseVisualStyleBackColor = false;
            btnLoadUsers.Click += btnLoadUsers_Click;
            // 
            // btnUpdateUser
            // 
            btnUpdateUser.BackColor = Color.FromArgb(241, 196, 15);
            btnUpdateUser.FlatStyle = FlatStyle.Flat;
            btnUpdateUser.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnUpdateUser.ForeColor = Color.White;
            btnUpdateUser.Location = new Point(29, 61);
            btnUpdateUser.Name = "btnUpdateUser";
            btnUpdateUser.Size = new Size(134, 31);
            btnUpdateUser.TabIndex = 5;
            btnUpdateUser.Text = "Update User";
            btnUpdateUser.UseVisualStyleBackColor = false;
            btnUpdateUser.Click += btnUpdateUser_Click;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(52, 152, 219);
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(169, 24);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(134, 31);
            btnSearch.TabIndex = 4;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnDeleteUser
            // 
            btnDeleteUser.BackColor = Color.FromArgb(231, 76, 60);
            btnDeleteUser.FlatStyle = FlatStyle.Flat;
            btnDeleteUser.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnDeleteUser.ForeColor = Color.White;
            btnDeleteUser.Location = new Point(29, 98);
            btnDeleteUser.Name = "btnDeleteUser";
            btnDeleteUser.Size = new Size(134, 31);
            btnDeleteUser.TabIndex = 6;
            btnDeleteUser.Text = "Delete User";
            btnDeleteUser.UseVisualStyleBackColor = false;
            btnDeleteUser.Click += btnDeleteUser_Click;
            // 
            // btnClearManage
            // 
            btnClearManage.FlatStyle = FlatStyle.Flat;
            btnClearManage.Font = new Font("Segoe UI", 9F);
            btnClearManage.Location = new Point(260, 109);
            btnClearManage.Name = "btnClearManage";
            btnClearManage.Size = new Size(49, 24);
            btnClearManage.TabIndex = 7;
            btnClearManage.Text = "Clear";
            btnClearManage.Click += btnClear_Click;
            // 
            // tabLockUnlock
            // 
            tabLockUnlock.BackColor = Color.White;
            tabLockUnlock.Controls.Add(groupBox2);
            tabLockUnlock.Location = new Point(4, 24);
            tabLockUnlock.Name = "tabLockUnlock";
            tabLockUnlock.Size = new Size(858, 543);
            tabLockUnlock.TabIndex = 1;
            tabLockUnlock.Text = "Lock/Unlock";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnLock);
            groupBox2.Controls.Add(btnGetLockedUsers);
            groupBox2.Controls.Add(btnUnlock);
            groupBox2.Controls.Add(btnIsLocked);
            groupBox2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            groupBox2.Location = new Point(300, 17);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(453, 61);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Action";
            // 
            // btnLock
            // 
            btnLock.BackColor = Color.FromArgb(52, 152, 219);
            btnLock.FlatStyle = FlatStyle.Flat;
            btnLock.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnLock.ForeColor = Color.White;
            btnLock.Location = new Point(342, 28);
            btnLock.Name = "btnLock";
            btnLock.Size = new Size(104, 31);
            btnLock.TabIndex = 4;
            btnLock.Text = "Lock User";
            btnLock.UseVisualStyleBackColor = false;
            btnLock.Click += btnLock_Click;
            // 
            // btnGetLockedUsers
            // 
            btnGetLockedUsers.BackColor = Color.FromArgb(52, 152, 219);
            btnGetLockedUsers.FlatStyle = FlatStyle.Flat;
            btnGetLockedUsers.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnGetLockedUsers.ForeColor = Color.White;
            btnGetLockedUsers.Location = new Point(231, 28);
            btnGetLockedUsers.Name = "btnGetLockedUsers";
            btnGetLockedUsers.Size = new Size(105, 31);
            btnGetLockedUsers.TabIndex = 1;
            btnGetLockedUsers.Text = "Get Locked Users";
            btnGetLockedUsers.UseVisualStyleBackColor = false;
            btnGetLockedUsers.Click += btnGetLockedUsers_Click;
            // 
            // btnUnlock
            // 
            btnUnlock.BackColor = Color.FromArgb(52, 152, 219);
            btnUnlock.FlatStyle = FlatStyle.Flat;
            btnUnlock.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnUnlock.ForeColor = Color.White;
            btnUnlock.Location = new Point(19, 28);
            btnUnlock.Name = "btnUnlock";
            btnUnlock.Size = new Size(103, 31);
            btnUnlock.TabIndex = 3;
            btnUnlock.Text = "Unlock User";
            btnUnlock.UseVisualStyleBackColor = false;
            btnUnlock.Click += btnUnlock_Click;
            // 
            // btnIsLocked
            // 
            btnIsLocked.BackColor = Color.FromArgb(52, 152, 219);
            btnIsLocked.FlatStyle = FlatStyle.Flat;
            btnIsLocked.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnIsLocked.ForeColor = Color.White;
            btnIsLocked.Location = new Point(128, 28);
            btnIsLocked.Name = "btnIsLocked";
            btnIsLocked.Size = new Size(97, 31);
            btnIsLocked.TabIndex = 2;
            btnIsLocked.Text = "Is Locked?";
            btnIsLocked.UseVisualStyleBackColor = false;
            btnIsLocked.Click += btnIsLocked_Click;
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
            btnCheckUsername.BackColor = Color.FromArgb(52, 152, 219);
            btnCheckUsername.FlatStyle = FlatStyle.Flat;
            btnCheckUsername.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnCheckUsername.ForeColor = Color.White;
            btnCheckUsername.Location = new Point(292, 23);
            btnCheckUsername.Name = "btnCheckUsername";
            btnCheckUsername.Size = new Size(193, 31);
            btnCheckUsername.TabIndex = 1;
            btnCheckUsername.Text = "Check Username Exists";
            btnCheckUsername.UseVisualStyleBackColor = false;
            btnCheckUsername.Click += btnCheckUsername_Click;
            // 
            // btnClearUtility
            // 
            btnClearUtility.Location = new Point(501, 31);
            btnClearUtility.Name = "btnClearUtility";
            btnClearUtility.Size = new Size(43, 23);
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
            groupBox1.ResumeLayout(false);
            tabLockUnlock.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            tabUtility.ResumeLayout(false);
            ResumeLayout(false);
        }
        private DataGridView dgvUsers;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
    }
}

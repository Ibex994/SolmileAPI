namespace SolmileGuestHouseUI.Forms.ManagerForms
{
    partial class User
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
            components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.dgvUsers = new System.Windows.Forms.DataGridView();

            this.lblId = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();

            this.lblUsername = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();

            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();

            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();

            this.btnGetAll = new System.Windows.Forms.Button();
            this.btnGetById = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();

            this.btnLockUser = new System.Windows.Forms.Button();
            this.btnUnlockUser = new System.Windows.Forms.Button();

            this.btnIsLocked = new System.Windows.Forms.Button();
            this.btnGetLockedUsers = new System.Windows.Forms.Button();

            this.btnChangePassword = new System.Windows.Forms.Button();
            this.btnForgotPassword = new System.Windows.Forms.Button();
            this.btnResetPassword = new System.Windows.Forms.Button();

            this.btnCheckExists = new System.Windows.Forms.Button();
            this.btnVerifyOTP = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.SuspendLayout();

            // DataGridView: Users
            this.dgvUsers.Location = new System.Drawing.Point(20, 220);
            this.dgvUsers.Size = new System.Drawing.Size(760, 320);
            this.dgvUsers.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            this.dgvUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

            // Label: ID
            this.lblId.Text = "User ID:";
            this.lblId.Location = new System.Drawing.Point(20, 20);
            this.lblId.Size = new System.Drawing.Size(100, 23);

            // TextBox: ID
            this.txtId.Location = new System.Drawing.Point(130, 20);
            this.txtId.Size = new System.Drawing.Size(200, 22);
            this.txtId.Anchor = AnchorStyles.Top | AnchorStyles.Left;

            // Label: Username
            this.lblUsername.Text = "Username:";
            this.lblUsername.Location = new System.Drawing.Point(20, 60);
            this.lblUsername.Size = new System.Drawing.Size(100, 23);

            // TextBox: Username
            this.txtUsername.Location = new System.Drawing.Point(130, 60);
            this.txtUsername.Size = new System.Drawing.Size(200, 22);
            this.txtUsername.Anchor = AnchorStyles.Top | AnchorStyles.Left;

            // Label: Password
            this.lblPassword.Text = "Password:";
            this.lblPassword.Location = new System.Drawing.Point(20, 100);
            this.lblPassword.Size = new System.Drawing.Size(100, 23);

            // TextBox: Password
            this.txtPassword.Location = new System.Drawing.Point(130, 100);
            this.txtPassword.Size = new System.Drawing.Size(200, 22);
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.Anchor = AnchorStyles.Top | AnchorStyles.Left;

            // Label: Email
            this.lblEmail.Text = "Email:";
            this.lblEmail.Location = new System.Drawing.Point(20, 140);
            this.lblEmail.Size = new System.Drawing.Size(100, 23);

            // TextBox: Email
            this.txtEmail.Location = new System.Drawing.Point(130, 140);
            this.txtEmail.Size = new System.Drawing.Size(200, 22);
            this.txtEmail.Anchor = AnchorStyles.Top | AnchorStyles.Left;

            // Buttons for CRUD operations and others
            // Get All
            this.btnGetAll.Text = "Get All Users";
            this.btnGetAll.Location = new System.Drawing.Point(360, 18);
            this.btnGetAll.Size = new System.Drawing.Size(120, 28);
            this.btnGetAll.Anchor = AnchorStyles.Top | AnchorStyles.Left;

            // Get By ID
            this.btnGetById.Text = "Get By ID";
            this.btnGetById.Location = new System.Drawing.Point(490, 18);
            this.btnGetById.Size = new System.Drawing.Size(90, 28);
            this.btnGetById.Anchor = AnchorStyles.Top | AnchorStyles.Left;

            // Delete
            this.btnDelete.Text = "Delete User";
            this.btnDelete.Location = new System.Drawing.Point(590, 18);
            this.btnDelete.Size = new System.Drawing.Size(100, 28);
            this.btnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Left;

            // Update
            this.btnUpdate.Text = "Update User";
            this.btnUpdate.Location = new System.Drawing.Point(700, 18);
            this.btnUpdate.Size = new System.Drawing.Size(100, 28);
            this.btnUpdate.Anchor = AnchorStyles.Top | AnchorStyles.Left;

            // Lock User
            this.btnLockUser.Text = "Lock User";
            this.btnLockUser.Location = new System.Drawing.Point(360, 60);
            this.btnLockUser.Size = new System.Drawing.Size(100, 28);
            this.btnLockUser.Anchor = AnchorStyles.Top | AnchorStyles.Left;

            // Unlock User
            this.btnUnlockUser.Text = "Unlock User";
            this.btnUnlockUser.Location = new System.Drawing.Point(470, 60);
            this.btnUnlockUser.Size = new System.Drawing.Size(100, 28);
            this.btnUnlockUser.Anchor = AnchorStyles.Top | AnchorStyles.Left;

            // Is Locked
            this.btnIsLocked.Text = "Is Locked?";
            this.btnIsLocked.Location = new System.Drawing.Point(580, 60);
            this.btnIsLocked.Size = new System.Drawing.Size(90, 28);
            this.btnIsLocked.Anchor = AnchorStyles.Top | AnchorStyles.Left;

            // Get Locked Users
            this.btnGetLockedUsers.Text = "Get Locked Users";
            this.btnGetLockedUsers.Location = new System.Drawing.Point(680, 60);
            this.btnGetLockedUsers.Size = new System.Drawing.Size(130, 28);
            this.btnGetLockedUsers.Anchor = AnchorStyles.Top | AnchorStyles.Left;

            // Change Password
            this.btnChangePassword.Text = "Change Password";
            this.btnChangePassword.Location = new System.Drawing.Point(360, 100);
            this.btnChangePassword.Size = new System.Drawing.Size(130, 28);
            this.btnChangePassword.Anchor = AnchorStyles.Top | AnchorStyles.Left;

            // Forgot Password
            this.btnForgotPassword.Text = "Forgot Password";
            this.btnForgotPassword.Location = new System.Drawing.Point(500, 100);
            this.btnForgotPassword.Size = new System.Drawing.Size(130, 28);
            this.btnForgotPassword.Anchor = AnchorStyles.Top | AnchorStyles.Left;

            // Reset Password
            this.btnResetPassword.Text = "Reset Password";
            this.btnResetPassword.Location = new System.Drawing.Point(640, 100);
            this.btnResetPassword.Size = new System.Drawing.Size(120, 28);
            this.btnResetPassword.Anchor = AnchorStyles.Top | AnchorStyles.Left;

            // Check Exists
            this.btnCheckExists.Text = "Check Exists";
            this.btnCheckExists.Location = new System.Drawing.Point(360, 140);
            this.btnCheckExists.Size = new System.Drawing.Size(110, 28);
            this.btnCheckExists.Anchor = AnchorStyles.Top | AnchorStyles.Left;

            // Verify OTP
            this.btnVerifyOTP.Text = "Verify OTP";
            this.btnVerifyOTP.Location = new System.Drawing.Point(480, 140);
            this.btnVerifyOTP.Size = new System.Drawing.Size(110, 28);
            this.btnVerifyOTP.Anchor = AnchorStyles.Top | AnchorStyles.Left;

            // Adding controls to the form
            this.Controls.Add(this.dgvUsers);

            this.Controls.Add(this.lblId);
            this.Controls.Add(this.txtId);

            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.txtUsername);

            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtPassword);

            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtEmail);

            this.Controls.Add(this.btnGetAll);
            this.Controls.Add(this.btnGetById);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);

            this.Controls.Add(this.btnLockUser);
            this.Controls.Add(this.btnUnlockUser);
            this.Controls.Add(this.btnIsLocked);
            this.Controls.Add(this.btnGetLockedUsers);

            this.Controls.Add(this.btnChangePassword);
            this.Controls.Add(this.btnForgotPassword);
            this.Controls.Add(this.btnResetPassword);

            this.Controls.Add(this.btnCheckExists);
            this.Controls.Add(this.btnVerifyOTP);

            this.Text = "Users Management";
            this.ClientSize = new System.Drawing.Size(820, 560);
            this.ResumeLayout(false);
            this.PerformLayout();

            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
        }

        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;

        private System.Windows.Forms.Button btnGetAll;
        private System.Windows.Forms.Button btnGetById;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;

        private System.Windows.Forms.Button btnLockUser;
        private System.Windows.Forms.Button btnUnlockUser;
        private System.Windows.Forms.Button btnIsLocked;
        private System.Windows.Forms.Button btnGetLockedUsers;

        private System.Windows.Forms.Button btnChangePassword;
        private System.Windows.Forms.Button btnForgotPassword;
        private System.Windows.Forms.Button btnResetPassword;

        private System.Windows.Forms.Button btnCheckExists;
        private System.Windows.Forms.Button btnVerifyOTP;

        #endregion
    }
}

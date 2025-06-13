namespace SolmileGuestHouseUI.Forms.AdminForms
{
    partial class AdminForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            btnUserRole = new Button();
            btnUser = new Button();
            btnRoomType = new Button();
            btnRoomnumAssign = new Button();
            btnRoom = new Button();
            btnConDet = new Button();
            panelDesktopPane = new Panel();
            pictureBox1 = new PictureBox();
            panelTitleBar = new Panel();
            labelUsername = new Label();
            label1 = new Label();
            labelDateTime = new Label();
            pictureBoxMinimize = new PictureBox();
            pictureBoxClose = new PictureBox();
            btnLogout = new Button();
            panelMenu = new Panel();
            btnBranch = new Button();
            panelLogo = new Panel();
            lblTitle = new Label();
            panel1 = new Panel();
            btnCloseChildForm = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            panelDesktopPane.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMinimize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxClose).BeginInit();
            panelMenu.SuspendLayout();
            panelLogo.SuspendLayout();
            SuspendLayout();
            // 
            // btnUserRole
            // 
            resources.ApplyResources(btnUserRole, "btnUserRole");
            btnUserRole.Cursor = Cursors.Hand;
            btnUserRole.FlatAppearance.BorderSize = 0;
            btnUserRole.ForeColor = Color.Black;
            btnUserRole.Image = Properties.Resources.icons8_role_48;
            btnUserRole.Name = "btnUserRole";
            btnUserRole.UseVisualStyleBackColor = true;
            btnUserRole.Click += btnUserRole_Click;
            // 
            // btnUser
            // 
            resources.ApplyResources(btnUser, "btnUser");
            btnUser.Cursor = Cursors.Hand;
            btnUser.FlatAppearance.BorderSize = 0;
            btnUser.ForeColor = Color.Black;
            btnUser.Image = Properties.Resources.icons8_roles_48;
            btnUser.Name = "btnUser";
            btnUser.UseVisualStyleBackColor = true;
            btnUser.Click += btnUser_Click;
            // 
            // btnRoomType
            // 
            resources.ApplyResources(btnRoomType, "btnRoomType");
            btnRoomType.Cursor = Cursors.Hand;
            btnRoomType.FlatAppearance.BorderSize = 0;
            btnRoomType.ForeColor = Color.Black;
            btnRoomType.Image = Properties.Resources.icons8_room_48;
            btnRoomType.Name = "btnRoomType";
            btnRoomType.UseVisualStyleBackColor = true;
            btnRoomType.Click += btnRoomType_Click;
            // 
            // btnRoomnumAssign
            // 
            resources.ApplyResources(btnRoomnumAssign, "btnRoomnumAssign");
            btnRoomnumAssign.Cursor = Cursors.Hand;
            btnRoomnumAssign.FlatAppearance.BorderSize = 0;
            btnRoomnumAssign.ForeColor = Color.Black;
            btnRoomnumAssign.Image = Properties.Resources.icons8_number_48;
            btnRoomnumAssign.Name = "btnRoomnumAssign";
            btnRoomnumAssign.UseVisualStyleBackColor = true;
            btnRoomnumAssign.Click += btnRoomnumAssign_Click;
            // 
            // btnRoom
            // 
            resources.ApplyResources(btnRoom, "btnRoom");
            btnRoom.Cursor = Cursors.Hand;
            btnRoom.FlatAppearance.BorderSize = 0;
            btnRoom.ForeColor = Color.Black;
            btnRoom.Image = Properties.Resources.icons8_room_46;
            btnRoom.Name = "btnRoom";
            btnRoom.UseVisualStyleBackColor = true;
            btnRoom.Click += btnRoom_Click;
            // 
            // btnConDet
            // 
            resources.ApplyResources(btnConDet, "btnConDet");
            btnConDet.Cursor = Cursors.Hand;
            btnConDet.FlatAppearance.BorderSize = 0;
            btnConDet.ForeColor = Color.Black;
            btnConDet.Image = Properties.Resources.icons8_contact_details_48;
            btnConDet.Name = "btnConDet";
            btnConDet.UseVisualStyleBackColor = true;
            btnConDet.Click += btnConDet_Click;
            // 
            // panelDesktopPane
            // 
            panelDesktopPane.BackColor = Color.Transparent;
            panelDesktopPane.Controls.Add(pictureBox1);
            resources.ApplyResources(panelDesktopPane, "panelDesktopPane");
            panelDesktopPane.Name = "panelDesktopPane";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = Properties.Resources.Black_and_Gold_Vintage_Luxury_Hotel_Logo__1__removebg_preview;
            resources.ApplyResources(pictureBox1, "pictureBox1");
            pictureBox1.Name = "pictureBox1";
            pictureBox1.TabStop = false;
            // 
            // panelTitleBar
            // 
            panelTitleBar.BackColor = Color.Transparent;
            panelTitleBar.Controls.Add(labelUsername);
            panelTitleBar.Controls.Add(label1);
            panelTitleBar.Controls.Add(labelDateTime);
            panelTitleBar.Controls.Add(pictureBoxMinimize);
            panelTitleBar.Controls.Add(pictureBoxClose);
            resources.ApplyResources(panelTitleBar, "panelTitleBar");
            panelTitleBar.Name = "panelTitleBar";
            // 
            // labelUsername
            // 
            resources.ApplyResources(labelUsername, "labelUsername");
            labelUsername.BackColor = Color.Transparent;
            labelUsername.ForeColor = Color.Black;
            labelUsername.Name = "labelUsername";
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.BackColor = Color.Transparent;
            label1.ForeColor = Color.Black;
            label1.Name = "label1";
            // 
            // labelDateTime
            // 
            resources.ApplyResources(labelDateTime, "labelDateTime");
            labelDateTime.BackColor = Color.Transparent;
            labelDateTime.Name = "labelDateTime";
            // 
            // pictureBoxMinimize
            // 
            resources.ApplyResources(pictureBoxMinimize, "pictureBoxMinimize");
            pictureBoxMinimize.Cursor = Cursors.Hand;
            pictureBoxMinimize.Name = "pictureBoxMinimize";
            pictureBoxMinimize.TabStop = false;
            pictureBoxMinimize.Click += pictureBoxMinimize_Click;
            // 
            // pictureBoxClose
            // 
            resources.ApplyResources(pictureBoxClose, "pictureBoxClose");
            pictureBoxClose.Cursor = Cursors.Hand;
            pictureBoxClose.Name = "pictureBoxClose";
            pictureBoxClose.TabStop = false;
            pictureBoxClose.Click += pictureBoxClose_Click;
            // 
            // btnLogout
            // 
            resources.ApplyResources(btnLogout, "btnLogout");
            btnLogout.Cursor = Cursors.Hand;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.ForeColor = Color.Black;
            btnLogout.Name = "btnLogout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.Transparent;
            panelMenu.Controls.Add(btnLogout);
            panelMenu.Controls.Add(btnUserRole);
            panelMenu.Controls.Add(btnUser);
            panelMenu.Controls.Add(btnRoomType);
            panelMenu.Controls.Add(btnRoomnumAssign);
            panelMenu.Controls.Add(btnRoom);
            panelMenu.Controls.Add(btnConDet);
            panelMenu.Controls.Add(btnBranch);
            panelMenu.Controls.Add(panelLogo);
            resources.ApplyResources(panelMenu, "panelMenu");
            panelMenu.Name = "panelMenu";
            // 
            // btnBranch
            // 
            resources.ApplyResources(btnBranch, "btnBranch");
            btnBranch.Cursor = Cursors.Hand;
            btnBranch.FlatAppearance.BorderSize = 0;
            btnBranch.ForeColor = Color.Black;
            btnBranch.Image = Properties.Resources.icons8_branch_48;
            btnBranch.Name = "btnBranch";
            btnBranch.UseVisualStyleBackColor = true;
            btnBranch.Click += btnBranch_Click;
            // 
            // panelLogo
            // 
            panelLogo.BackColor = Color.Transparent;
            panelLogo.Controls.Add(lblTitle);
            panelLogo.Controls.Add(panel1);
            panelLogo.Controls.Add(btnCloseChildForm);
            resources.ApplyResources(panelLogo, "panelLogo");
            panelLogo.Name = "panelLogo";
            // 
            // lblTitle
            // 
            resources.ApplyResources(lblTitle, "lblTitle");
            lblTitle.ForeColor = Color.Black;
            lblTitle.Name = "lblTitle";
            // 
            // panel1
            // 
            resources.ApplyResources(panel1, "panel1");
            panel1.Name = "panel1";
            // 
            // btnCloseChildForm
            // 
            resources.ApplyResources(btnCloseChildForm, "btnCloseChildForm");
            btnCloseChildForm.BackColor = Color.Transparent;
            btnCloseChildForm.Cursor = Cursors.Hand;
            btnCloseChildForm.FlatAppearance.BorderSize = 0;
            btnCloseChildForm.ForeColor = Color.Transparent;
            btnCloseChildForm.Image = Properties.Resources.icons8_home_30;
            btnCloseChildForm.Name = "btnCloseChildForm";
            btnCloseChildForm.UseVisualStyleBackColor = false;
            btnCloseChildForm.Click += btnCloseChildForm_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // AdminForm
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(panelDesktopPane);
            Controls.Add(panelTitleBar);
            Controls.Add(panelMenu);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminForm";
            Load += AdminForm_Load;
            panelDesktopPane.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelTitleBar.ResumeLayout(false);
            panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMinimize).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxClose).EndInit();
            panelMenu.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            panelLogo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button btnUserRole;
        private Button btnUser;
        private Button btnRoomType;
        private Button btnRoomnumAssign;
        private Button btnRoom;
        private Button btnConDet;
        private Panel panelDesktopPane;
        private PictureBox pictureBox1;
        private Panel panelTitleBar;
        private Label labelUsername;
        private Label label1;
        private Label labelDateTime;
        private PictureBox pictureBoxMinimize;
        private PictureBox pictureBoxClose;
        private Button btnLogout;
        private Panel panelMenu;
        private Button btnBranch;
        private Panel panelLogo;
        private Panel panel1;
        private Button btnCloseChildForm;
        private Label lblTitle;
        private System.Windows.Forms.Timer timer1;
    }
}
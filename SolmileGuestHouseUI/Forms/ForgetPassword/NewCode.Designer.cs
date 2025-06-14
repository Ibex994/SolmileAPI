namespace SolmileGuestHouseUI.Forms.ForgetPassword
{
    partial class NewCode
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewCode));
            pictureBox1 = new PictureBox();
            resetPasswordBtn = new Button();
            label1 = new Label();
            Backbtn = new PictureBox();
            NewPasslbl = new Label();
            ConPasslbl = new Label();
            NewPassTxt = new TextBox();
            usernameDisplayTxt = new TextBox();
            ConPassTxt = new TextBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Backbtn).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Black_and_Gold_Vintage_Luxury_Hotel_Logo_removebg_preview;
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(656, 355);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // resetPasswordBtn
            // 
            resetPasswordBtn.BackColor = Color.White;
            resetPasswordBtn.FlatStyle = FlatStyle.Flat;
            resetPasswordBtn.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            resetPasswordBtn.ForeColor = Color.DarkGoldenrod;
            resetPasswordBtn.Location = new Point(252, 222);
            resetPasswordBtn.Name = "resetPasswordBtn";
            resetPasswordBtn.Size = new Size(150, 26);
            resetPasswordBtn.TabIndex = 6;
            resetPasswordBtn.Text = "Change Password";
            resetPasswordBtn.UseVisualStyleBackColor = false;
            resetPasswordBtn.Click += resetPasswordBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Goldenrod;
            label1.Location = new Point(156, 44);
            label1.Name = "label1";
            label1.Size = new Size(371, 40);
            label1.TabIndex = 4;
            label1.Text = "Enter New Password";
            // 
            // Backbtn
            // 
            Backbtn.Image = (Image)resources.GetObject("Backbtn.Image");
            Backbtn.Location = new Point(1, 0);
            Backbtn.Name = "Backbtn";
            Backbtn.Size = new Size(22, 18);
            Backbtn.SizeMode = PictureBoxSizeMode.CenterImage;
            Backbtn.TabIndex = 13;
            Backbtn.TabStop = false;
            // 
            // NewPasslbl
            // 
            NewPasslbl.AutoSize = true;
            NewPasslbl.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            NewPasslbl.Location = new Point(156, 152);
            NewPasslbl.Name = "NewPasslbl";
            NewPasslbl.Size = new Size(130, 18);
            NewPasslbl.TabIndex = 14;
            NewPasslbl.Text = "New Password ";
            // 
            // ConPasslbl
            // 
            ConPasslbl.AutoSize = true;
            ConPasslbl.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ConPasslbl.Location = new Point(156, 117);
            ConPasslbl.Name = "ConPasslbl";
            ConPasslbl.Size = new Size(100, 18);
            ConPasslbl.TabIndex = 14;
            ConPasslbl.Text = "User Name ";
            // 
            // NewPassTxt
            // 
            NewPassTxt.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            NewPassTxt.Location = new Point(319, 153);
            NewPassTxt.Name = "NewPassTxt";
            NewPassTxt.Size = new Size(199, 25);
            NewPassTxt.TabIndex = 5;
            NewPassTxt.TextAlign = HorizontalAlignment.Center;
            // 
            // usernameDisplayTxt
            // 
            usernameDisplayTxt.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            usernameDisplayTxt.Location = new Point(319, 114);
            usernameDisplayTxt.Name = "usernameDisplayTxt";
            usernameDisplayTxt.Size = new Size(199, 25);
            usernameDisplayTxt.TabIndex = 5;
            usernameDisplayTxt.TextAlign = HorizontalAlignment.Center;
            // 
            // ConPassTxt
            // 
            ConPassTxt.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ConPassTxt.Location = new Point(319, 186);
            ConPassTxt.Name = "ConPassTxt";
            ConPassTxt.Size = new Size(199, 25);
            ConPassTxt.TabIndex = 5;
            ConPassTxt.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(156, 189);
            label2.Name = "label2";
            label2.Size = new Size(157, 18);
            label2.TabIndex = 14;
            label2.Text = "Confirm Password ";
            // 
            // NewCode
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            BackgroundImageLayout = ImageLayout.None;
            BorderStyle = BorderStyle.Fixed3D;
            Controls.Add(label2);
            Controls.Add(ConPasslbl);
            Controls.Add(NewPasslbl);
            Controls.Add(ConPassTxt);
            Controls.Add(Backbtn);
            Controls.Add(usernameDisplayTxt);
            Controls.Add(NewPassTxt);
            Controls.Add(resetPasswordBtn);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            MaximumSize = new Size(654, 355);
            MinimumSize = new Size(654, 355);
            Name = "NewCode";
            Size = new Size(650, 351);
            Load += NewCode_Load_1;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)Backbtn).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button resetPasswordBtn;
        private Label label1;
        private PictureBox Backbtn;
        private Label NewPasslbl;
        private Label ConPasslbl;
        private TextBox NewPassTxt;
        private TextBox usernameDisplayTxt;
        private TextBox ConPassTxt;
        private Label label2;
    }
}

namespace SolmileGuestHouseUI.Forms.ForgetPassword
{
    partial class Verfication
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Verfication));
            pictureBox1 = new PictureBox();
            checkOTPbtn = new Button();
            otpTxt = new TextBox();
            label1 = new Label();
            Backbtn = new PictureBox();
            usernametxt = new TextBox();
            label3 = new Label();
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
            pictureBox1.Size = new Size(654, 355);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // checkOTPbtn
            // 
            checkOTPbtn.BackColor = Color.White;
            checkOTPbtn.BackgroundImageLayout = ImageLayout.None;
            checkOTPbtn.FlatStyle = FlatStyle.Flat;
            checkOTPbtn.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkOTPbtn.ForeColor = Color.Goldenrod;
            checkOTPbtn.Location = new Point(271, 223);
            checkOTPbtn.Name = "checkOTPbtn";
            checkOTPbtn.Size = new Size(112, 27);
            checkOTPbtn.TabIndex = 6;
            checkOTPbtn.Text = "Check OTP";
            checkOTPbtn.UseVisualStyleBackColor = false;
            checkOTPbtn.Click += checkOTPbtn_Click;
            // 
            // otpTxt
            // 
            otpTxt.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            otpTxt.Location = new Point(247, 182);
            otpTxt.Name = "otpTxt";
            otpTxt.Size = new Size(214, 25);
            otpTxt.TabIndex = 5;
            otpTxt.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Goldenrod;
            label1.Location = new Point(133, 58);
            label1.Name = "label1";
            label1.Size = new Size(403, 40);
            label1.TabIndex = 4;
            label1.Text = "Enter Verfication Code";
            // 
            // Backbtn
            // 
            Backbtn.Image = (Image)resources.GetObject("Backbtn.Image");
            Backbtn.Location = new Point(0, 3);
            Backbtn.Name = "Backbtn";
            Backbtn.Size = new Size(22, 18);
            Backbtn.SizeMode = PictureBoxSizeMode.CenterImage;
            Backbtn.TabIndex = 13;
            Backbtn.TabStop = false;
            Backbtn.Click += Backbtn_Click;
            // 
            // usernametxt
            // 
            usernametxt.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            usernametxt.Location = new Point(247, 133);
            usernametxt.Name = "usernametxt";
            usernametxt.Size = new Size(214, 25);
            usernametxt.TabIndex = 14;
            usernametxt.TextAlign = HorizontalAlignment.Center;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(149, 182);
            label3.Name = "label3";
            label3.Size = new Size(86, 18);
            label3.TabIndex = 16;
            label3.Text = "OTP code";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(149, 138);
            label2.Name = "label2";
            label2.Size = new Size(92, 18);
            label2.TabIndex = 17;
            label2.Text = "UserName";
            // 
            // Verfication
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.Disable;
            BackColor = SystemColors.Window;
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(usernametxt);
            Controls.Add(Backbtn);
            Controls.Add(checkOTPbtn);
            Controls.Add(otpTxt);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            MaximumSize = new Size(654, 355);
            MinimumSize = new Size(654, 355);
            Name = "Verfication";
            Size = new Size(654, 355);
            Load += Verfication_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)Backbtn).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox1;
        private Button checkOTPbtn;
        private TextBox otpTxt;
        private Label label1;
        private PictureBox Backbtn;
        private TextBox usernametxt;
        private Label label3;
        private Label label2;
    }
}

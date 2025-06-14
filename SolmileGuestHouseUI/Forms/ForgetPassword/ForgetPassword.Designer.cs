namespace SolmileGuestHouseUI.Forms.ForgetPassword
{
    partial class ForgetPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForgetPassword));
            pictureBoxClose = new PictureBox();
            pictureBoxMinimize = new PictureBox();
            Backbtn = new PictureBox();
            pictureBox1 = new PictureBox();
            Otpbtn = new Button();
            usertxtbox = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxClose).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMinimize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Backbtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxClose
            // 
            pictureBoxClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBoxClose.Cursor = Cursors.Hand;
            pictureBoxClose.Image = (Image)resources.GetObject("pictureBoxClose.Image");
            pictureBoxClose.Location = new Point(625, 1);
            pictureBoxClose.Name = "pictureBoxClose";
            pictureBoxClose.Size = new Size(29, 18);
            pictureBoxClose.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxClose.TabIndex = 8;
            pictureBoxClose.TabStop = false;
            pictureBoxClose.Click += pictureBoxClose_Click;
            // 
            // pictureBoxMinimize
            // 
            pictureBoxMinimize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBoxMinimize.Cursor = Cursors.Hand;
            pictureBoxMinimize.Image = (Image)resources.GetObject("pictureBoxMinimize.Image");
            pictureBoxMinimize.Location = new Point(601, 1);
            pictureBoxMinimize.Name = "pictureBoxMinimize";
            pictureBoxMinimize.Size = new Size(27, 18);
            pictureBoxMinimize.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxMinimize.TabIndex = 9;
            pictureBoxMinimize.TabStop = false;
            pictureBoxMinimize.Click += pictureBoxMinimize_Click;
            // 
            // Backbtn
            // 
            Backbtn.Image = (Image)resources.GetObject("Backbtn.Image");
            Backbtn.Location = new Point(0, 1);
            Backbtn.Name = "Backbtn";
            Backbtn.Size = new Size(22, 18);
            Backbtn.SizeMode = PictureBoxSizeMode.CenterImage;
            Backbtn.TabIndex = 10;
            Backbtn.TabStop = false;
            Backbtn.Click += Backbtn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.Window;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(-2, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(654, 355);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // Otpbtn
            // 
            Otpbtn.BackColor = Color.White;
            Otpbtn.FlatStyle = FlatStyle.Flat;
            Otpbtn.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Otpbtn.ForeColor = Color.DarkGoldenrod;
            Otpbtn.Location = new Point(276, 217);
            Otpbtn.Name = "Otpbtn";
            Otpbtn.Size = new Size(96, 29);
            Otpbtn.TabIndex = 14;
            Otpbtn.Text = "Get OTP";
            Otpbtn.UseVisualStyleBackColor = false;
            Otpbtn.Click += Otpbtn_Click;
            // 
            // usertxtbox
            // 
            usertxtbox.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            usertxtbox.Location = new Point(224, 185);
            usertxtbox.Name = "usertxtbox";
            usertxtbox.Size = new Size(199, 26);
            usertxtbox.TabIndex = 13;
            usertxtbox.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial Rounded MT Bold", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Goldenrod;
            label1.Location = new Point(177, 127);
            label1.Name = "label1";
            label1.Size = new Size(300, 40);
            label1.TabIndex = 12;
            label1.Text = "Enter UserName";
            // 
            // ForgetPassword
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(654, 355);
            Controls.Add(Otpbtn);
            Controls.Add(usertxtbox);
            Controls.Add(label1);
            Controls.Add(Backbtn);
            Controls.Add(pictureBoxMinimize);
            Controls.Add(pictureBoxClose);
            Controls.Add(pictureBox1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ForgetPassword";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "password";
            ((System.ComponentModel.ISupportInitialize)pictureBoxClose).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMinimize).EndInit();
            ((System.ComponentModel.ISupportInitialize)Backbtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxClose;
        private PictureBox pictureBoxMinimize;
        private PictureBox Backbtn;
        private PictureBox pictureBox1;
        private Button Otpbtn;
        private TextBox usertxtbox;
        private Label label1;
    }
}
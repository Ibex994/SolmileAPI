namespace SolmileGuestHouseUI.Forms.AdminForms
{
    partial class SearchByInputForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtSearchInput;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.PictureBox pictureBoxClose;

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
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchByInputForm));
            txtSearchInput = new TextBox();
            btnFind = new Button();
            pictureBoxClose = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxClose).BeginInit();
            SuspendLayout();
            // 
            // txtSearchInput
            // 
            txtSearchInput.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearchInput.Location = new Point(86, 30);
            txtSearchInput.Name = "txtSearchInput";
            txtSearchInput.Size = new Size(200, 26);
            txtSearchInput.TabIndex = 2;
            txtSearchInput.TextAlign = HorizontalAlignment.Center;
            // 
            // btnFind
            // 
            btnFind.Location = new Point(140, 59);
            btnFind.Name = "btnFind";
            btnFind.Size = new Size(75, 23);
            btnFind.TabIndex = 1;
            btnFind.Text = "Find";
            btnFind.Click += BtnFind_Click;
            // 
            // pictureBoxClose
            // 
            pictureBoxClose.Cursor = Cursors.Hand;
            pictureBoxClose.Image = Properties.Resources.icons8_close_96;
            pictureBoxClose.Location = new Point(360, 0);
            pictureBoxClose.Name = "pictureBoxClose";
            pictureBoxClose.Size = new Size(20, 16);
            pictureBoxClose.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxClose.TabIndex = 0;
            pictureBoxClose.TabStop = false;
            pictureBoxClose.Click += pictureBoxClose_Click;
            // 
            // SearchByInputForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(380, 100);
            Controls.Add(pictureBoxClose);
            Controls.Add(btnFind);
            Controls.Add(txtSearchInput);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "SearchByInputForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Search by Username";
            ((System.ComponentModel.ISupportInitialize)pictureBoxClose).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
#endregion

}
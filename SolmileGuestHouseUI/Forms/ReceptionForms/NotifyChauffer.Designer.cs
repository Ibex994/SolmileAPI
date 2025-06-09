namespace Solmile.Forms.ReceptionForms
{
    partial class NotifyChauffer
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
            checkIn1 = new CheckIn();
            label1 = new Label();
            SuspendLayout();
            // 
            // checkIn1
            // 
            checkIn1.ClientSize = new Size(800, 450);
            checkIn1.Location = new Point(130, 130);
            checkIn1.Name = "checkIn1";
            checkIn1.Text = "checkIn1";
            checkIn1.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Constantia", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(195, 195);
            label1.Name = "label1";
            label1.Size = new Size(378, 59);
            label1.TabIndex = 0;
            label1.Text = "Notify Chauffer";
            // 
            // NotifyCauffer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label1);
            Name = "NotifyCauffer";
            Size = new Size(859, 583);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckIn checkIn1;
        private Label label1;
    }
}

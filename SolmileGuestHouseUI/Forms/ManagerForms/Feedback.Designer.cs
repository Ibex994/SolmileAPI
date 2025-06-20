namespace SolmileGuestHouseUI.Forms.ManagerForms
{
    partial class Feedback
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
            lblFeedbackId = new Label();
            txtFeedbackId = new TextBox();
            lblCustomerId = new Label();
            txtCustomerId = new TextBox();
            lblFeedbackText = new Label();
            lblDate = new Label();
            dtpDate = new DateTimePicker();
            lblRating = new Label();
            btnGetByCustomer = new Button();
            btnGetById = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            dgvFeedbacks = new DataGridView();
            richTextBox1 = new RichTextBox();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvFeedbacks).BeginInit();
            SuspendLayout();
            // 
            // lblFeedbackId
            // 
            lblFeedbackId.Location = new Point(20, 20);
            lblFeedbackId.Name = "lblFeedbackId";
            lblFeedbackId.Size = new Size(100, 23);
            lblFeedbackId.TabIndex = 0;
            lblFeedbackId.Text = "Feedback ID:";
            // 
            // txtFeedbackId
            // 
            txtFeedbackId.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtFeedbackId.Location = new Point(140, 17);
            txtFeedbackId.Name = "txtFeedbackId";
            txtFeedbackId.ReadOnly = true;
            txtFeedbackId.Size = new Size(122, 23);
            txtFeedbackId.TabIndex = 1;
            // 
            // lblCustomerId
            // 
            lblCustomerId.Location = new Point(20, 60);
            lblCustomerId.Name = "lblCustomerId";
            lblCustomerId.Size = new Size(100, 23);
            lblCustomerId.TabIndex = 2;
            lblCustomerId.Text = "Customer ID:";
            // 
            // txtCustomerId
            // 
            txtCustomerId.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtCustomerId.Location = new Point(140, 57);
            txtCustomerId.Name = "txtCustomerId";
            txtCustomerId.ReadOnly = true;
            txtCustomerId.Size = new Size(122, 23);
            txtCustomerId.TabIndex = 3;
            // 
            // lblFeedbackText
            // 
            lblFeedbackText.Location = new Point(20, 100);
            lblFeedbackText.Name = "lblFeedbackText";
            lblFeedbackText.Size = new Size(100, 23);
            lblFeedbackText.TabIndex = 4;
            lblFeedbackText.Text = "Feedback:";
            // 
            // lblDate
            // 
            lblDate.Location = new Point(20, 234);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(100, 23);
            lblDate.TabIndex = 6;
            lblDate.Text = "Date:";
            // 
            // dtpDate
            // 
            dtpDate.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dtpDate.Enabled = false;
            dtpDate.Location = new Point(140, 231);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(400, 23);
            dtpDate.TabIndex = 7;
            // 
            // lblRating
            // 
            lblRating.Location = new Point(333, 17);
            lblRating.Name = "lblRating";
            lblRating.Size = new Size(79, 23);
            lblRating.TabIndex = 8;
            lblRating.Text = "Rating (1-5):";
            // 
            // btnGetByCustomer
            // 
            btnGetByCustomer.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnGetByCustomer.FlatStyle = FlatStyle.Flat;
            btnGetByCustomer.Location = new Point(597, 90);
            btnGetByCustomer.Name = "btnGetByCustomer";
            btnGetByCustomer.Size = new Size(133, 33);
            btnGetByCustomer.TabIndex = 11;
            btnGetByCustomer.Text = "Get by Customer ID";
            btnGetByCustomer.Click += btnGetByCustomer_Click;
            // 
            // btnGetById
            // 
            btnGetById.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnGetById.FlatStyle = FlatStyle.Flat;
            btnGetById.Location = new Point(597, 130);
            btnGetById.Name = "btnGetById";
            btnGetById.Size = new Size(133, 33);
            btnGetById.TabIndex = 12;
            btnGetById.Text = "Get by Feedback ID";
            btnGetById.Click += btnGetById_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Location = new Point(597, 170);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(133, 33);
            btnUpdate.TabIndex = 13;
            btnUpdate.Text = "Update (PUT)";
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Location = new Point(597, 210);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(133, 33);
            btnDelete.TabIndex = 14;
            btnDelete.Text = "Delete (DELETE)";
            btnDelete.Click += btnDelete_Click;
            // 
            // dgvFeedbacks
            // 
            dgvFeedbacks.AllowUserToAddRows = false;
            dgvFeedbacks.AllowUserToDeleteRows = false;
            dgvFeedbacks.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvFeedbacks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvFeedbacks.BackgroundColor = Color.White;
            dgvFeedbacks.BorderStyle = BorderStyle.None;
            dgvFeedbacks.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvFeedbacks.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvFeedbacks.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(52, 152, 219);
            dgvFeedbacks.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvFeedbacks.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dgvFeedbacks.DefaultCellStyle.Font = new Font("Segoe UI", 10F);
            dgvFeedbacks.DefaultCellStyle.SelectionBackColor = Color.FromArgb(52, 152, 219);
            dgvFeedbacks.DefaultCellStyle.SelectionForeColor = Color.White;
            dgvFeedbacks.EnableHeadersVisualStyles = false;
            dgvFeedbacks.GridColor = Color.LightGray;
            dgvFeedbacks.Location = new Point(20, 270);
            dgvFeedbacks.MultiSelect = false;
            dgvFeedbacks.Name = "dgvFeedbacks";
            dgvFeedbacks.ReadOnly = true;
            dgvFeedbacks.RowHeadersVisible = false;
            dgvFeedbacks.RowTemplate.Height = 30;
            dgvFeedbacks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvFeedbacks.Size = new Size(760, 200);
            dgvFeedbacks.TabIndex = 15;

            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(140, 97);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.Size = new Size(400, 119);
            richTextBox1.TabIndex = 16;
            richTextBox1.Text = "";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(418, 14);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(50, 23);
            textBox1.TabIndex = 17;
            // 
            // Feedback
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(textBox1);
            Controls.Add(richTextBox1);
            Controls.Add(lblFeedbackId);
            Controls.Add(txtFeedbackId);
            Controls.Add(lblCustomerId);
            Controls.Add(txtCustomerId);
            Controls.Add(lblFeedbackText);
            Controls.Add(lblDate);
            Controls.Add(dtpDate);
            Controls.Add(lblRating);
            Controls.Add(btnGetByCustomer);
            Controls.Add(btnGetById);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(dgvFeedbacks);
            Name = "Feedback";
            Size = new Size(800, 500);
            ((System.ComponentModel.ISupportInitialize)dgvFeedbacks).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Label lblFeedbackId;
        private System.Windows.Forms.TextBox txtFeedbackId;
        private System.Windows.Forms.Label lblCustomerId;
        private System.Windows.Forms.TextBox txtCustomerId;
        private System.Windows.Forms.Label lblFeedbackText;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label lblRating;
        private System.Windows.Forms.Button btnGetByCustomer;
        private System.Windows.Forms.Button btnGetById;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dgvFeedbacks;
        private RichTextBox richTextBox1;
        private TextBox textBox1;
    }

        #endregion
    }


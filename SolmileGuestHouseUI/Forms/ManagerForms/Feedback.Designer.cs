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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
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
            btnDelete = new Button();
            dgvFeedbacks = new DataGridView();
            richTextBox1 = new RichTextBox();
            textBox1 = new TextBox();
            groupBox1 = new GroupBox();
            btnClear = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvFeedbacks).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // lblFeedbackId
            // 
            lblFeedbackId.Font = new Font("Arial", 11.25F, FontStyle.Bold);
            lblFeedbackId.ForeColor = Color.Goldenrod;
            lblFeedbackId.Location = new Point(20, 20);
            lblFeedbackId.Name = "lblFeedbackId";
            lblFeedbackId.Size = new Size(100, 23);
            lblFeedbackId.TabIndex = 0;
            lblFeedbackId.Text = "Feedback ID:";
            // 
            // txtFeedbackId
            // 
            txtFeedbackId.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtFeedbackId.Font = new Font("Arial Narrow", 8.25F, FontStyle.Bold);
            txtFeedbackId.Location = new Point(140, 17);
            txtFeedbackId.Name = "txtFeedbackId";
            txtFeedbackId.ReadOnly = true;
            txtFeedbackId.Size = new Size(117, 20);
            txtFeedbackId.TabIndex = 1;
            // 
            // lblCustomerId
            // 
            lblCustomerId.Font = new Font("Arial", 11.25F, FontStyle.Bold);
            lblCustomerId.ForeColor = Color.Goldenrod;
            lblCustomerId.Location = new Point(20, 60);
            lblCustomerId.Name = "lblCustomerId";
            lblCustomerId.Size = new Size(100, 23);
            lblCustomerId.TabIndex = 2;
            lblCustomerId.Text = "Customer ID:";
            // 
            // txtCustomerId
            // 
            txtCustomerId.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtCustomerId.Font = new Font("Arial Narrow", 8.25F, FontStyle.Bold);
            txtCustomerId.Location = new Point(140, 57);
            txtCustomerId.Name = "txtCustomerId";
            txtCustomerId.ReadOnly = true;
            txtCustomerId.Size = new Size(117, 20);
            txtCustomerId.TabIndex = 3;
            // 
            // lblFeedbackText
            // 
            lblFeedbackText.Font = new Font("Arial", 11.25F, FontStyle.Bold);
            lblFeedbackText.ForeColor = Color.Goldenrod;
            lblFeedbackText.Location = new Point(20, 140);
            lblFeedbackText.Name = "lblFeedbackText";
            lblFeedbackText.Size = new Size(100, 23);
            lblFeedbackText.TabIndex = 4;
            lblFeedbackText.Text = "Feedback:";
            // 
            // lblDate
            // 
            lblDate.Font = new Font("Arial", 11.25F, FontStyle.Bold);
            lblDate.ForeColor = Color.Goldenrod;
            lblDate.Location = new Point(20, 100);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(100, 23);
            lblDate.TabIndex = 6;
            lblDate.Text = "Date:";
            // 
            // dtpDate
            // 
            dtpDate.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dtpDate.Enabled = false;
            dtpDate.Font = new Font("Arial Narrow", 8.25F, FontStyle.Bold);
            dtpDate.Location = new Point(140, 97);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(179, 20);
            dtpDate.TabIndex = 7;
            // 
            // lblRating
            // 
            lblRating.Font = new Font("Arial", 11.25F, FontStyle.Bold);
            lblRating.ForeColor = Color.Goldenrod;
            lblRating.Location = new Point(333, 17);
            lblRating.Name = "lblRating";
            lblRating.Size = new Size(79, 23);
            lblRating.TabIndex = 8;
            lblRating.Text = "Rating (1-5):";
            // 
            // btnGetByCustomer
            // 
            btnGetByCustomer.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnGetByCustomer.BackColor = Color.FromArgb(39, 174, 96);
            btnGetByCustomer.FlatStyle = FlatStyle.Flat;
            btnGetByCustomer.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnGetByCustomer.ForeColor = Color.White;
            btnGetByCustomer.Location = new Point(20, 49);
            btnGetByCustomer.Name = "btnGetByCustomer";
            btnGetByCustomer.Size = new Size(171, 31);
            btnGetByCustomer.TabIndex = 11;
            btnGetByCustomer.Text = "Get by Customer ID";
            btnGetByCustomer.UseVisualStyleBackColor = false;
            btnGetByCustomer.Click += btnGetByCustomer_Click;
            // 
            // btnGetById
            // 
            btnGetById.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnGetById.BackColor = Color.FromArgb(52, 152, 219);
            btnGetById.FlatStyle = FlatStyle.Flat;
            btnGetById.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnGetById.ForeColor = Color.White;
            btnGetById.Location = new Point(20, 89);
            btnGetById.Name = "btnGetById";
            btnGetById.Size = new Size(171, 31);
            btnGetById.TabIndex = 12;
            btnGetById.Text = "Get by Feedback ID";
            btnGetById.UseVisualStyleBackColor = false;
            btnGetById.Click += btnGetById_Click;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDelete.BackColor = Color.FromArgb(231, 76, 60);
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(20, 135);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(171, 31);
            btnDelete.TabIndex = 14;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
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
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(52, 152, 219);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvFeedbacks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(52, 152, 219);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvFeedbacks.DefaultCellStyle = dataGridViewCellStyle2;
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
            richTextBox1.BackColor = Color.White;
            richTextBox1.Font = new Font("Arial Narrow", 8.25F, FontStyle.Bold);
            richTextBox1.Location = new Point(140, 145);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.Size = new Size(395, 119);
            richTextBox1.TabIndex = 16;
            richTextBox1.Text = "";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Arial Narrow", 8.25F, FontStyle.Bold);
            textBox1.Location = new Point(400, 19);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(45, 20);
            textBox1.TabIndex = 17;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnClear);
            groupBox1.Controls.Add(btnGetByCustomer);
            groupBox1.Controls.Add(btnGetById);
            groupBox1.Controls.Add(btnDelete);
            groupBox1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            groupBox1.Location = new Point(570, 20);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(210, 204);
            groupBox1.TabIndex = 18;
            groupBox1.TabStop = false;
            groupBox1.Text = "Action";
            // 
            // btnClear
            // 
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClear.Location = new Point(163, 181);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(47, 23);
            btnClear.TabIndex = 15;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // Feedback
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(groupBox1);
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
            Controls.Add(dgvFeedbacks);
            Name = "Feedback";
            Size = new Size(800, 500);
            Load += Feedback_Load;
            ((System.ComponentModel.ISupportInitialize)dgvFeedbacks).EndInit();
            groupBox1.ResumeLayout(false);
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
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dgvFeedbacks;
        private RichTextBox richTextBox1;
        private TextBox textBox1;
        private GroupBox groupBox1;
        private Button btnClear;
    }

        #endregion
    }


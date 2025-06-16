namespace SolmileGuestHouseUI.Forms.ManagerForms
{
    partial class Complaint
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblComplaintId;
        private System.Windows.Forms.Label lblCustomerId;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblHandler;

        private System.Windows.Forms.TextBox txtComplaintId;
        private System.Windows.Forms.TextBox txtCustomerId;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.ComboBox cmbHandler;
        private System.Windows.Forms.Button btnUpdateStatus;
        private System.Windows.Forms.Button btnAssignHandler;
        private System.Windows.Forms.Button btnResolve;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnHistory;

        private System.Windows.Forms.DataGridView dgvComplaints;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
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
            lblComplaintId = new Label();
            lblCustomerId = new Label();
            lblDescription = new Label();
            lblStatus = new Label();
            lblHandler = new Label();
            txtComplaintId = new TextBox();
            txtCustomerId = new TextBox();
            cmbStatus = new ComboBox();
            cmbHandler = new ComboBox();
            btnUpdateStatus = new Button();
            btnAssignHandler = new Button();
            btnResolve = new Button();
            btnDelete = new Button();
            btnHistory = new Button();
            dgvComplaints = new DataGridView();
            btnClear = new Button();
            txtDescription = new RichTextBox();
            ((System.ComponentModel.ISupportInitialize)dgvComplaints).BeginInit();
            SuspendLayout();
            // 
            // lblComplaintId
            // 
            lblComplaintId.AutoSize = true;
            lblComplaintId.Font = new Font("Arial", 11.25F, FontStyle.Bold);
            lblComplaintId.ForeColor = Color.Goldenrod;
            lblComplaintId.Location = new Point(20, 20);
            lblComplaintId.Name = "lblComplaintId";
            lblComplaintId.Size = new Size(102, 18);
            lblComplaintId.TabIndex = 0;
            lblComplaintId.Text = "Complaint ID:";
            // 
            // lblCustomerId
            // 
            lblCustomerId.AutoSize = true;
            lblCustomerId.Font = new Font("Arial", 11.25F, FontStyle.Bold);
            lblCustomerId.ForeColor = Color.Goldenrod;
            lblCustomerId.Location = new Point(20, 60);
            lblCustomerId.Name = "lblCustomerId";
            lblCustomerId.Size = new Size(100, 18);
            lblCustomerId.TabIndex = 2;
            lblCustomerId.Text = "Customer ID:";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Font = new Font("Arial", 11.25F, FontStyle.Bold);
            lblDescription.ForeColor = Color.Goldenrod;
            lblDescription.Location = new Point(20, 113);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(94, 18);
            lblDescription.TabIndex = 6;
            lblDescription.Text = "Description:";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Arial", 11.25F, FontStyle.Bold);
            lblStatus.ForeColor = Color.Goldenrod;
            lblStatus.Location = new Point(407, 20);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(57, 18);
            lblStatus.TabIndex = 8;
            lblStatus.Text = "Status:";
            // 
            // lblHandler
            // 
            lblHandler.AutoSize = true;
            lblHandler.Font = new Font("Arial", 11.25F, FontStyle.Bold);
            lblHandler.ForeColor = Color.Goldenrod;
            lblHandler.Location = new Point(399, 60);
            lblHandler.Name = "lblHandler";
            lblHandler.Size = new Size(68, 18);
            lblHandler.TabIndex = 10;
            lblHandler.Text = "Handler:";
            // 
            // txtComplaintId
            // 
            txtComplaintId.Enabled = false;
            txtComplaintId.Location = new Point(128, 19);
            txtComplaintId.Name = "txtComplaintId";
            txtComplaintId.Size = new Size(200, 23);
            txtComplaintId.TabIndex = 1;
            // 
            // txtCustomerId
            // 
            txtCustomerId.Enabled = false;
            txtCustomerId.Location = new Point(128, 59);
            txtCustomerId.Name = "txtCustomerId";
            txtCustomerId.Size = new Size(200, 23);
            txtCustomerId.TabIndex = 3;
            // 
            // cmbStatus
            // 
            cmbStatus.BackColor = Color.White;
            cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatus.Location = new Point(481, 20);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(200, 23);
            cmbStatus.TabIndex = 9;
            // 
            // cmbHandler
            // 
            cmbHandler.BackColor = Color.White;
            cmbHandler.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbHandler.Location = new Point(481, 52);
            cmbHandler.Name = "cmbHandler";
            cmbHandler.Size = new Size(200, 23);
            cmbHandler.TabIndex = 11;
            // 
            // btnUpdateStatus
            // 
            btnUpdateStatus.BackColor = Color.FromArgb(241, 196, 15);
            btnUpdateStatus.FlatStyle = FlatStyle.Flat;
            btnUpdateStatus.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnUpdateStatus.ForeColor = Color.White;
            btnUpdateStatus.Location = new Point(707, 78);
            btnUpdateStatus.Name = "btnUpdateStatus";
            btnUpdateStatus.Size = new Size(134, 31);
            btnUpdateStatus.TabIndex = 13;
            btnUpdateStatus.Text = "Update Status";
            btnUpdateStatus.UseVisualStyleBackColor = false;
            btnUpdateStatus.Click += btnUpdateStatus_Click;
            // 
            // btnAssignHandler
            // 
            btnAssignHandler.BackColor = Color.FromArgb(39, 174, 96);
            btnAssignHandler.FlatStyle = FlatStyle.Flat;
            btnAssignHandler.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnAssignHandler.ForeColor = Color.White;
            btnAssignHandler.Location = new Point(707, 112);
            btnAssignHandler.Name = "btnAssignHandler";
            btnAssignHandler.Size = new Size(134, 31);
            btnAssignHandler.TabIndex = 14;
            btnAssignHandler.Text = "Assign Handler";
            btnAssignHandler.UseVisualStyleBackColor = false;
            btnAssignHandler.Click += btnAssignHandler_Click;
            // 
            // btnResolve
            // 
            btnResolve.BackColor = Color.FromArgb(52, 152, 219);
            btnResolve.FlatStyle = FlatStyle.Flat;
            btnResolve.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnResolve.ForeColor = Color.White;
            btnResolve.Location = new Point(707, 149);
            btnResolve.Name = "btnResolve";
            btnResolve.Size = new Size(134, 31);
            btnResolve.TabIndex = 15;
            btnResolve.Text = "Resolve";
            btnResolve.UseVisualStyleBackColor = false;
            btnResolve.Click += btnResolve_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(231, 76, 60);
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(707, 186);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(134, 31);
            btnDelete.TabIndex = 16;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnHistory
            // 
            btnHistory.BackColor = Color.DimGray;
            btnHistory.FlatStyle = FlatStyle.Flat;
            btnHistory.Font = new Font("Arial", 11.25F, FontStyle.Bold);
            btnHistory.ForeColor = Color.White;
            btnHistory.Location = new Point(707, 223);
            btnHistory.Name = "btnHistory";
            btnHistory.Size = new Size(134, 31);
            btnHistory.TabIndex = 17;
            btnHistory.Text = "History";
            btnHistory.UseVisualStyleBackColor = false;
            btnHistory.Click += btnHistory_Click;
            // 
            // dgvComplaints
            // 
            dgvComplaints.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvComplaints.BackgroundColor = Color.White;
            dgvComplaints.Location = new Point(20, 345);
            dgvComplaints.Name = "dgvComplaints";
            dgvComplaints.ReadOnly = true;
            dgvComplaints.Size = new Size(805, 301);
            dgvComplaints.TabIndex = 18;
            dgvComplaints.CellClick += dgvComplaints_CellClick;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(774, 652);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(51, 24);
            btnClear.TabIndex = 17;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // txtDescription
            // 
            txtDescription.BackColor = Color.White;
            txtDescription.Location = new Point(120, 110);
            txtDescription.Name = "txtDescription";
            txtDescription.ReadOnly = true;
            txtDescription.Size = new Size(570, 186);
            txtDescription.TabIndex = 19;
            txtDescription.Text = "";
            // 
            // Complaint
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(txtDescription);
            Controls.Add(lblComplaintId);
            Controls.Add(txtComplaintId);
            Controls.Add(lblCustomerId);
            Controls.Add(txtCustomerId);
            Controls.Add(lblDescription);
            Controls.Add(lblStatus);
            Controls.Add(cmbStatus);
            Controls.Add(lblHandler);
            Controls.Add(cmbHandler);
            Controls.Add(btnUpdateStatus);
            Controls.Add(btnAssignHandler);
            Controls.Add(btnResolve);
            Controls.Add(btnDelete);
            Controls.Add(btnClear);
            Controls.Add(btnHistory);
            Controls.Add(dgvComplaints);
            ForeColor = Color.Black;
            Name = "Complaint";
            Size = new Size(855, 690);
            Load += Complaint_Load;
            ((System.ComponentModel.ISupportInitialize)dgvComplaints).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnClear;
        private RichTextBox txtDescription;
    }
}

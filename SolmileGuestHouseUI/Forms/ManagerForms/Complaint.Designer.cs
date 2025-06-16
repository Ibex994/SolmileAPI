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
            lblComplaintId.Location = new Point(20, 20);
            lblComplaintId.Name = "lblComplaintId";
            lblComplaintId.Size = new Size(80, 15);
            lblComplaintId.TabIndex = 0;
            lblComplaintId.Text = "Complaint ID:";
            // 
            // lblCustomerId
            // 
            lblCustomerId.AutoSize = true;
            lblCustomerId.Location = new Point(20, 60);
            lblCustomerId.Name = "lblCustomerId";
            lblCustomerId.Size = new Size(76, 15);
            lblCustomerId.TabIndex = 2;
            lblCustomerId.Text = "Customer ID:";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(20, 113);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(70, 15);
            lblDescription.TabIndex = 6;
            lblDescription.Text = "Description:";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(407, 20);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(42, 15);
            lblStatus.TabIndex = 8;
            lblStatus.Text = "Status:";
            // 
            // lblHandler
            // 
            lblHandler.AutoSize = true;
            lblHandler.Location = new Point(399, 60);
            lblHandler.Name = "lblHandler";
            lblHandler.Size = new Size(52, 15);
            lblHandler.TabIndex = 10;
            lblHandler.Text = "Handler:";
            // 
            // txtComplaintId
            // 
            txtComplaintId.Enabled = false;
            txtComplaintId.Location = new Point(120, 17);
            txtComplaintId.Name = "txtComplaintId";
            txtComplaintId.Size = new Size(200, 23);
            txtComplaintId.TabIndex = 1;
            // 
            // txtCustomerId
            // 
            txtCustomerId.Enabled = false;
            txtCustomerId.Location = new Point(120, 57);
            txtCustomerId.Name = "txtCustomerId";
            txtCustomerId.Size = new Size(200, 23);
            txtCustomerId.TabIndex = 3;
            // 
            // cmbStatus
            // 
            cmbStatus.BackColor = Color.White;
            cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatus.Location = new Point(466, 20);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(200, 23);
            cmbStatus.TabIndex = 9;
            // 
            // cmbHandler
            // 
            cmbHandler.BackColor = Color.White;
            cmbHandler.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbHandler.Location = new Point(466, 52);
            cmbHandler.Name = "cmbHandler";
            cmbHandler.Size = new Size(200, 23);
            cmbHandler.TabIndex = 11;
            // 
            // btnUpdateStatus
            // 
            btnUpdateStatus.Location = new Point(725, 73);
            btnUpdateStatus.Name = "btnUpdateStatus";
            btnUpdateStatus.Size = new Size(100, 30);
            btnUpdateStatus.TabIndex = 13;
            btnUpdateStatus.Text = "Update Status";
            btnUpdateStatus.UseVisualStyleBackColor = true;
            btnUpdateStatus.Click += btnUpdateStatus_Click;
            // 
            // btnAssignHandler
            // 
            btnAssignHandler.Location = new Point(725, 113);
            btnAssignHandler.Name = "btnAssignHandler";
            btnAssignHandler.Size = new Size(100, 30);
            btnAssignHandler.TabIndex = 14;
            btnAssignHandler.Text = "Assign Handler";
            btnAssignHandler.UseVisualStyleBackColor = true;
            btnAssignHandler.Click += btnAssignHandler_Click;
            // 
            // btnResolve
            // 
            btnResolve.Location = new Point(725, 153);
            btnResolve.Name = "btnResolve";
            btnResolve.Size = new Size(100, 30);
            btnResolve.TabIndex = 15;
            btnResolve.Text = "Resolve";
            btnResolve.UseVisualStyleBackColor = true;
            btnResolve.Click += btnResolve_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(725, 196);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(100, 30);
            btnDelete.TabIndex = 16;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnHistory
            // 
            btnHistory.Location = new Point(725, 232);
            btnHistory.Name = "btnHistory";
            btnHistory.Size = new Size(100, 30);
            btnHistory.TabIndex = 17;
            btnHistory.Text = "History";
            btnHistory.UseVisualStyleBackColor = true;
            btnHistory.Click += btnHistory_Click;
            // 
            // dgvComplaints
            // 
            dgvComplaints.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvComplaints.BackgroundColor = Color.White;
            dgvComplaints.Location = new Point(20, 345);
            dgvComplaints.Name = "dgvComplaints";
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
            txtDescription.Location = new Point(96, 110);
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
            Name = "Complaint";
            Size = new Size(855, 690);
            ((System.ComponentModel.ISupportInitialize)dgvComplaints).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnClear;
        private RichTextBox txtDescription;
    }
}

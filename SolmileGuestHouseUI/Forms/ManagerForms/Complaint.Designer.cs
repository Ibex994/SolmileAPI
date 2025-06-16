namespace SolmileGuestHouseUI.Forms.ManagerForms
{
    partial class Complaint
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblComplaintId;
        private System.Windows.Forms.Label lblCustomerId;
        private System.Windows.Forms.Label lblComplaintDate;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblHandler;

        private System.Windows.Forms.TextBox txtComplaintId;
        private System.Windows.Forms.TextBox txtCustomerId;
        private System.Windows.Forms.DateTimePicker dtpComplaintDate;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.ComboBox cmbHandler;
        private System.Windows.Forms.Button btnUpdateStatus;
        private System.Windows.Forms.Button btnAssignHandler;
        private System.Windows.Forms.Button btnResolve;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnGetDetails;

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
            lblComplaintDate = new Label();
            lblDescription = new Label();
            lblStatus = new Label();
            lblHandler = new Label();
            txtComplaintId = new TextBox();
            txtCustomerId = new TextBox();
            dtpComplaintDate = new DateTimePicker();
            txtDescription = new TextBox();
            cmbStatus = new ComboBox();
            cmbHandler = new ComboBox();
            btnUpdateStatus = new Button();
            btnAssignHandler = new Button();
            btnResolve = new Button();
            btnDelete = new Button();
            btnGetDetails = new Button();
            dgvComplaints = new DataGridView();
            btnClear = new Button();
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
            // lblComplaintDate
            // 
            lblComplaintDate.AutoSize = true;
            lblComplaintDate.Location = new Point(20, 100);
            lblComplaintDate.Name = "lblComplaintDate";
            lblComplaintDate.Size = new Size(93, 15);
            lblComplaintDate.TabIndex = 4;
            lblComplaintDate.Text = "Complaint Date:";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(20, 140);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(70, 15);
            lblDescription.TabIndex = 6;
            lblDescription.Text = "Description:";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(344, 20);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(42, 15);
            lblStatus.TabIndex = 8;
            lblStatus.Text = "Status:";
            // 
            // lblHandler
            // 
            lblHandler.AutoSize = true;
            lblHandler.Location = new Point(336, 60);
            lblHandler.Name = "lblHandler";
            lblHandler.Size = new Size(52, 15);
            lblHandler.TabIndex = 10;
            lblHandler.Text = "Handler:";
            // 
            // txtComplaintId
            // 
            txtComplaintId.Location = new Point(120, 17);
            txtComplaintId.Name = "txtComplaintId";
            txtComplaintId.Size = new Size(200, 23);
            txtComplaintId.TabIndex = 1;
            // 
            // txtCustomerId
            // 
            txtCustomerId.Location = new Point(120, 57);
            txtCustomerId.Name = "txtCustomerId";
            txtCustomerId.Size = new Size(200, 23);
            txtCustomerId.TabIndex = 3;
            // 
            // dtpComplaintDate
            // 
            dtpComplaintDate.Location = new Point(120, 97);
            dtpComplaintDate.Name = "dtpComplaintDate";
            dtpComplaintDate.Size = new Size(200, 23);
            dtpComplaintDate.TabIndex = 5;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(120, 137);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(450, 140);
            txtDescription.TabIndex = 7;
            // 
            // cmbStatus
            // 
            cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatus.Location = new Point(403, 20);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(200, 23);
            cmbStatus.TabIndex = 9;
            // 
            // cmbHandler
            // 
            cmbHandler.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbHandler.Location = new Point(403, 52);
            cmbHandler.Name = "cmbHandler";
            cmbHandler.Size = new Size(200, 23);
            cmbHandler.TabIndex = 11;
            // 
            // btnUpdateStatus
            // 
            btnUpdateStatus.Location = new Point(676, 60);
            btnUpdateStatus.Name = "btnUpdateStatus";
            btnUpdateStatus.Size = new Size(100, 30);
            btnUpdateStatus.TabIndex = 13;
            btnUpdateStatus.Text = "Update Status";
            btnUpdateStatus.UseVisualStyleBackColor = true;
            btnUpdateStatus.Click += btnUpdateStatus_Click;
            // 
            // btnAssignHandler
            // 
            btnAssignHandler.Location = new Point(676, 100);
            btnAssignHandler.Name = "btnAssignHandler";
            btnAssignHandler.Size = new Size(100, 30);
            btnAssignHandler.TabIndex = 14;
            btnAssignHandler.Text = "Assign Handler";
            btnAssignHandler.UseVisualStyleBackColor = true;
            btnAssignHandler.Click += btnAssignHandler_Click;
            // 
            // btnResolve
            // 
            btnResolve.Location = new Point(676, 140);
            btnResolve.Name = "btnResolve";
            btnResolve.Size = new Size(100, 30);
            btnResolve.TabIndex = 15;
            btnResolve.Text = "Resolve";
            btnResolve.UseVisualStyleBackColor = true;
            btnResolve.Click += btnResolve_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(676, 180);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(100, 30);
            btnDelete.TabIndex = 16;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnGetDetails
            // 
            btnGetDetails.Location = new Point(676, 216);
            btnGetDetails.Name = "btnGetDetails";
            btnGetDetails.Size = new Size(100, 30);
            btnGetDetails.TabIndex = 17;
            btnGetDetails.Text = "Get Details";
            btnGetDetails.UseVisualStyleBackColor = true;
            // 
            // dgvComplaints
            // 
            dgvComplaints.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvComplaints.BackgroundColor = Color.White;
            dgvComplaints.Location = new Point(20, 296);
            dgvComplaints.Name = "dgvComplaints";
            dgvComplaints.Size = new Size(805, 350);
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
            // Complaint
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblComplaintId);
            Controls.Add(txtComplaintId);
            Controls.Add(lblCustomerId);
            Controls.Add(txtCustomerId);
            Controls.Add(lblComplaintDate);
            Controls.Add(dtpComplaintDate);
            Controls.Add(lblDescription);
            Controls.Add(txtDescription);
            Controls.Add(lblStatus);
            Controls.Add(cmbStatus);
            Controls.Add(lblHandler);
            Controls.Add(cmbHandler);
            Controls.Add(btnUpdateStatus);
            Controls.Add(btnAssignHandler);
            Controls.Add(btnResolve);
            Controls.Add(btnDelete);
            Controls.Add(btnClear);
            Controls.Add(btnGetDetails);
            Controls.Add(dgvComplaints);
            Name = "Complaint";
            Size = new Size(855, 690);
            ((System.ComponentModel.ISupportInitialize)dgvComplaints).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnClear;
    }
}

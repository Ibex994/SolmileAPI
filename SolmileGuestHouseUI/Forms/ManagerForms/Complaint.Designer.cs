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

        private System.Windows.Forms.Button btnCreate;
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
            this.components = new System.ComponentModel.Container();

            // Labels
            this.lblComplaintId = new System.Windows.Forms.Label();
            this.lblCustomerId = new System.Windows.Forms.Label();
            this.lblComplaintDate = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblHandler = new System.Windows.Forms.Label();

            // TextBoxes and DateTimePicker
            this.txtComplaintId = new System.Windows.Forms.TextBox();
            this.txtCustomerId = new System.Windows.Forms.TextBox();
            this.dtpComplaintDate = new System.Windows.Forms.DateTimePicker();
            this.txtDescription = new System.Windows.Forms.TextBox();

            // ComboBoxes
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.cmbHandler = new System.Windows.Forms.ComboBox();

            // Buttons
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnUpdateStatus = new System.Windows.Forms.Button();
            this.btnAssignHandler = new System.Windows.Forms.Button();
            this.btnResolve = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnGetDetails = new System.Windows.Forms.Button();

            // DataGridView
            this.dgvComplaints = new System.Windows.Forms.DataGridView();

            ((System.ComponentModel.ISupportInitialize)(this.dgvComplaints)).BeginInit();
            this.SuspendLayout();

            // lblComplaintId
            this.lblComplaintId.AutoSize = true;
            this.lblComplaintId.Location = new System.Drawing.Point(20, 20);
            this.lblComplaintId.Name = "lblComplaintId";
            this.lblComplaintId.Text = "Complaint ID:";

            // txtComplaintId
            this.txtComplaintId.Location = new System.Drawing.Point(120, 17);
            this.txtComplaintId.Name = "txtComplaintId";
            this.txtComplaintId.Size = new System.Drawing.Size(200, 23);

            // lblCustomerId
            this.lblCustomerId.AutoSize = true;
            this.lblCustomerId.Location = new System.Drawing.Point(20, 60);
            this.lblCustomerId.Name = "lblCustomerId";
            this.lblCustomerId.Text = "Customer ID:";

            // txtCustomerId
            this.txtCustomerId.Location = new System.Drawing.Point(120, 57);
            this.txtCustomerId.Name = "txtCustomerId";
            this.txtCustomerId.Size = new System.Drawing.Size(200, 23);

            // lblComplaintDate
            this.lblComplaintDate.AutoSize = true;
            this.lblComplaintDate.Location = new System.Drawing.Point(20, 100);
            this.lblComplaintDate.Name = "lblComplaintDate";
            this.lblComplaintDate.Text = "Complaint Date:";

            // dtpComplaintDate
            this.dtpComplaintDate.Location = new System.Drawing.Point(120, 97);
            this.dtpComplaintDate.Name = "dtpComplaintDate";
            this.dtpComplaintDate.Size = new System.Drawing.Size(200, 23);

            // lblDescription
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(20, 140);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Text = "Description:";

            // txtDescription
            this.txtDescription.Location = new System.Drawing.Point(120, 137);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(450, 80);

            // lblStatus
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(20, 230);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Text = "Status:";

            // cmbStatus
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.Location = new System.Drawing.Point(120, 227);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(200, 23);

            // lblHandler
            this.lblHandler.AutoSize = true;
            this.lblHandler.Location = new System.Drawing.Point(20, 270);
            this.lblHandler.Name = "lblHandler";
            this.lblHandler.Text = "Handler:";

            // cmbHandler
            this.cmbHandler.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHandler.Location = new System.Drawing.Point(120, 267);
            this.cmbHandler.Name = "cmbHandler";
            this.cmbHandler.Size = new System.Drawing.Size(200, 23);

            // Buttons
            this.btnCreate.Location = new System.Drawing.Point(600, 20);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(100, 30);
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;

            this.btnUpdateStatus.Location = new System.Drawing.Point(600, 60);
            this.btnUpdateStatus.Name = "btnUpdateStatus";
            this.btnUpdateStatus.Size = new System.Drawing.Size(100, 30);
            this.btnUpdateStatus.Text = "Update Status";
            this.btnUpdateStatus.UseVisualStyleBackColor = true;

            this.btnAssignHandler.Location = new System.Drawing.Point(600, 100);
            this.btnAssignHandler.Name = "btnAssignHandler";
            this.btnAssignHandler.Size = new System.Drawing.Size(100, 30);
            this.btnAssignHandler.Text = "Assign Handler";
            this.btnAssignHandler.UseVisualStyleBackColor = true;

            this.btnResolve.Location = new System.Drawing.Point(600, 140);
            this.btnResolve.Name = "btnResolve";
            this.btnResolve.Size = new System.Drawing.Size(100, 30);
            this.btnResolve.Text = "Resolve";
            this.btnResolve.UseVisualStyleBackColor = true;

            this.btnDelete.Location = new System.Drawing.Point(600, 180);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 30);
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;

            this.btnGetDetails.Location = new System.Drawing.Point(600, 220);
            this.btnGetDetails.Name = "btnGetDetails";
            this.btnGetDetails.Size = new System.Drawing.Size(100, 30);
            this.btnGetDetails.Text = "Get Details";
            this.btnGetDetails.UseVisualStyleBackColor = true;

            // dgvComplaints
            this.dgvComplaints.Location = new System.Drawing.Point(20, 320);
            this.dgvComplaints.Name = "dgvComplaints";
            this.dgvComplaints.Size = new System.Drawing.Size(780, 350);
            this.dgvComplaints.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

            // Complaint
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblComplaintId);
            this.Controls.Add(this.txtComplaintId);
            this.Controls.Add(this.lblCustomerId);
            this.Controls.Add(this.txtCustomerId);
            this.Controls.Add(this.lblComplaintDate);
            this.Controls.Add(this.dtpComplaintDate);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.lblHandler);
            this.Controls.Add(this.cmbHandler);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.btnUpdateStatus);
            this.Controls.Add(this.btnAssignHandler);
            this.Controls.Add(this.btnResolve);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnGetDetails);
            this.Controls.Add(this.dgvComplaints);
            this.Name = "Complaint";
            this.Size = new System.Drawing.Size(855, 690);

            ((System.ComponentModel.ISupportInitialize)(this.dgvComplaints)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}

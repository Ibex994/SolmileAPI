namespace SolmileGuestHouseUI.Forms.SupervisorForms
{
    partial class TaskManagement
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
        private System.Windows.Forms.DataGridView dgvTasks;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtAssignedTo;
        private System.Windows.Forms.DateTimePicker dtpDueDate;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.TextBox txtServiceRequestId;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnFindByServiceRequest;
        private System.Windows.Forms.Button btnFindEmployeeId;

        private void InitializeComponent()
        {
            this.dgvTasks = new System.Windows.Forms.DataGridView();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtAssignedTo = new System.Windows.Forms.TextBox();
            this.dtpDueDate = new System.Windows.Forms.DateTimePicker();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.txtServiceRequestId = new System.Windows.Forms.TextBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnFindByServiceRequest = new System.Windows.Forms.Button();
            this.btnFindEmployeeId = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)(this.dgvTasks)).BeginInit();
            this.SuspendLayout();

            // 
            // dgvTasks
            // 
            dgvTasks.AllowUserToAddRows = false;
            dgvTasks.AllowUserToDeleteRows = false;
            dgvTasks.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvTasks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTasks.BackgroundColor = Color.White;
            dgvTasks.BorderStyle = BorderStyle.None;
            dgvTasks.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvTasks.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvTasks.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(52, 152, 219);
            dgvTasks.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvTasks.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dgvTasks.DefaultCellStyle.Font = new Font("Segoe UI", 10F);
            dgvTasks.DefaultCellStyle.SelectionBackColor = Color.FromArgb(52, 152, 219);
            dgvTasks.DefaultCellStyle.SelectionForeColor = Color.White;
            dgvTasks.EnableHeadersVisualStyles = false;
            dgvTasks.GridColor = Color.LightGray;
            dgvTasks.Location = new Point(20, 180);
            dgvTasks.MultiSelect = false;
            dgvTasks.Name = "dgvTasks";
            dgvTasks.ReadOnly = true;
            dgvTasks.RowHeadersVisible = false;
            dgvTasks.RowTemplate.Height = 30;
            dgvTasks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTasks.Size = new Size(760, 300);
            dgvTasks.TabIndex = 0;
            // txtName
            this.txtName.Location = new System.Drawing.Point(20, 20);
            this.txtName.Size = new System.Drawing.Size(180, 23);
            this.txtName.PlaceholderText = "Task Name";

            // txtDescription
            this.txtDescription.Location = new System.Drawing.Point(210, 20);
            this.txtDescription.Size = new System.Drawing.Size(180, 23);
            this.txtDescription.PlaceholderText = "Description";

            // txtAssignedTo
            this.txtAssignedTo.Location = new System.Drawing.Point(400, 20);
            this.txtAssignedTo.Size = new System.Drawing.Size(100, 23);
            this.txtAssignedTo.PlaceholderText = "Assigned To";

            // dtpDueDate
            this.dtpDueDate.Location = new System.Drawing.Point(510, 20);
            this.dtpDueDate.Size = new System.Drawing.Size(150, 23);

            // cmbStatus
            this.cmbStatus.Location = new System.Drawing.Point(670, 20);
            this.cmbStatus.Size = new System.Drawing.Size(110, 23);
            this.cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbStatus.Items.AddRange(new object[] { "Pending", "InProgress", "Completed" });

            // txtServiceRequestId
            this.txtServiceRequestId.Location = new System.Drawing.Point(20, 60);
            this.txtServiceRequestId.Size = new System.Drawing.Size(180, 23);
            this.txtServiceRequestId.PlaceholderText = "Service Request ID";

            // Buttons
            this.btnCreate.Text = "Create";
            this.btnCreate.Location = new System.Drawing.Point(210, 60);
            this.btnCreate.Size = new System.Drawing.Size(75, 30);

            this.btnUpdate.Text = "Update";
            this.btnUpdate.Location = new System.Drawing.Point(295, 60);
            this.btnUpdate.Size = new System.Drawing.Size(75, 30);

            this.btnDelete.Text = "Delete";
            this.btnDelete.Location = new System.Drawing.Point(380, 60);
            this.btnDelete.Size = new System.Drawing.Size(75, 30);

            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.Location = new System.Drawing.Point(465, 60);
            this.btnRefresh.Size = new System.Drawing.Size(75, 30);

            this.btnFindByServiceRequest.Text = "Find By Service ID";
            this.btnFindByServiceRequest.Location = new System.Drawing.Point(550, 60);
            this.btnFindByServiceRequest.Size = new System.Drawing.Size(120, 30);

            this.btnFindEmployeeId.Text = "Find Employee ID";
            this.btnFindEmployeeId.Location = new System.Drawing.Point(680, 60);
            this.btnFindEmployeeId.Size = new System.Drawing.Size(120, 30);

            // TaskManagement (UserControl)
            this.Controls.Add(this.dgvTasks);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtAssignedTo);
            this.Controls.Add(this.dtpDueDate);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.txtServiceRequestId);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnFindByServiceRequest);
            this.Controls.Add(this.btnFindEmployeeId);
            this.Name = "TaskManagement";
            this.Size = new System.Drawing.Size(820, 500);

            ((System.ComponentModel.ISupportInitialize)(this.dgvTasks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }


    #endregion
}
}

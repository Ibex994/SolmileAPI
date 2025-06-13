namespace SolmileGuestHouseUI.Forms.ManagerForms
{
    partial class Log
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

        private void InitializeComponent()
        {
            this.lblEmployeeId = new System.Windows.Forms.Label();
            this.txtEmployeeId = new System.Windows.Forms.TextBox();
            this.btnGetAllLogs = new System.Windows.Forms.Button();
            this.btnGetByEmployee = new System.Windows.Forms.Button();
            this.dgvLogs = new System.Windows.Forms.DataGridView();

            ((System.ComponentModel.ISupportInitialize)(this.dgvLogs)).BeginInit();
            this.SuspendLayout();

            // Label: Employee ID
            this.lblEmployeeId.Text = "Employee ID:";
            this.lblEmployeeId.Location = new System.Drawing.Point(20, 20);
            this.lblEmployeeId.Size = new System.Drawing.Size(100, 23);

            // TextBox: Employee ID
            this.txtEmployeeId.Location = new System.Drawing.Point(130, 20);
            this.txtEmployeeId.Size = new System.Drawing.Size(300, 22);
            this.txtEmployeeId.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;

            // Button: Get All Logs
            this.btnGetAllLogs.Text = "Get All Logs";
            this.btnGetAllLogs.Location = new System.Drawing.Point(450, 18);
            this.btnGetAllLogs.Size = new System.Drawing.Size(120, 28);
            this.btnGetAllLogs.Anchor = AnchorStyles.Top | AnchorStyles.Right;

            // Button: Get Logs by Employee
            this.btnGetByEmployee.Text = "Get Logs by Employee";
            this.btnGetByEmployee.Location = new System.Drawing.Point(580, 18);
            this.btnGetByEmployee.Size = new System.Drawing.Size(180, 28);
            this.btnGetByEmployee.Anchor = AnchorStyles.Top | AnchorStyles.Right;

            // DataGridView: Logs
            this.dgvLogs.Location = new System.Drawing.Point(20, 60);
            this.dgvLogs.Size = new System.Drawing.Size(740, 380);
            this.dgvLogs.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            this.dgvLogs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

            // Form Layout
            this.Controls.Add(this.lblEmployeeId);
            this.Controls.Add(this.txtEmployeeId);
            this.Controls.Add(this.btnGetAllLogs);
            this.Controls.Add(this.btnGetByEmployee);
            this.Controls.Add(this.dgvLogs);

            this.Text = "System Log Viewer";
            this.ClientSize = new System.Drawing.Size(800, 460);
            this.ResumeLayout(false);
            this.PerformLayout();

            ((System.ComponentModel.ISupportInitialize)(this.dgvLogs)).EndInit();
        }

        private System.Windows.Forms.Label lblEmployeeId;
        private System.Windows.Forms.TextBox txtEmployeeId;
        private System.Windows.Forms.Button btnGetAllLogs;
        private System.Windows.Forms.Button btnGetByEmployee;
        private System.Windows.Forms.DataGridView dgvLogs;
    }
}


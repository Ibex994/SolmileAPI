namespace SolmileGuestHouseUI.Forms.ManagerForms
{
    partial class Payment
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
            this.dgvPayments = new System.Windows.Forms.DataGridView();
            this.lblPaymentId = new System.Windows.Forms.Label();
            this.txtPaymentId = new System.Windows.Forms.TextBox();

            this.btnGetAll = new System.Windows.Forms.Button();
            this.btnGetById = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnProcess = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)(this.dgvPayments)).BeginInit();
            this.SuspendLayout();

            // DataGridView: Payments
            this.dgvPayments.Location = new System.Drawing.Point(20, 100);
            this.dgvPayments.Size = new System.Drawing.Size(760, 350);
            this.dgvPayments.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            this.dgvPayments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

            // Label: Payment ID
            this.lblPaymentId.Text = "Payment ID:";
            this.lblPaymentId.Location = new System.Drawing.Point(20, 20);
            this.lblPaymentId.Size = new System.Drawing.Size(80, 23);

            // TextBox: Payment ID
            this.txtPaymentId.Location = new System.Drawing.Point(110, 20);
            this.txtPaymentId.Size = new System.Drawing.Size(200, 22);
            this.txtPaymentId.Anchor = AnchorStyles.Top | AnchorStyles.Left;

            // Button: Get All Payments
            this.btnGetAll.Text = "Get All";
            this.btnGetAll.Location = new System.Drawing.Point(330, 18);
            this.btnGetAll.Size = new System.Drawing.Size(90, 28);
            this.btnGetAll.Anchor = AnchorStyles.Top | AnchorStyles.Left;

            // Button: Get by ID
            this.btnGetById.Text = "Get by ID";
            this.btnGetById.Location = new System.Drawing.Point(430, 18);
            this.btnGetById.Size = new System.Drawing.Size(90, 28);
            this.btnGetById.Anchor = AnchorStyles.Top | AnchorStyles.Left;

            // Button: Add Payment
            this.btnAdd.Text = "Add";
            this.btnAdd.Location = new System.Drawing.Point(530, 18);
            this.btnAdd.Size = new System.Drawing.Size(90, 28);
            this.btnAdd.Anchor = AnchorStyles.Top | AnchorStyles.Left;

            // Button: Update Payment
            this.btnUpdate.Text = "Update";
            this.btnUpdate.Location = new System.Drawing.Point(630, 18);
            this.btnUpdate.Size = new System.Drawing.Size(90, 28);
            this.btnUpdate.Anchor = AnchorStyles.Top | AnchorStyles.Left;

            // Button: Delete Payment
            this.btnDelete.Text = "Delete";
            this.btnDelete.Location = new System.Drawing.Point(730, 18);
            this.btnDelete.Size = new System.Drawing.Size(90, 28);
            this.btnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;

            // Button: Process Payment
            this.btnProcess.Text = "Process";
            this.btnProcess.Location = new System.Drawing.Point(20, 60);
            this.btnProcess.Size = new System.Drawing.Size(120, 28);
            this.btnProcess.Anchor = AnchorStyles.Top | AnchorStyles.Left;

            // Form Layout
            this.Controls.Add(this.dgvPayments);
            this.Controls.Add(this.lblPaymentId);
            this.Controls.Add(this.txtPaymentId);
            this.Controls.Add(this.btnGetAll);
            this.Controls.Add(this.btnGetById);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnProcess);

            this.Text = "Payment Management";
            this.ClientSize = new System.Drawing.Size(850, 480);
            this.ResumeLayout(false);
            this.PerformLayout();

            ((System.ComponentModel.ISupportInitialize)(this.dgvPayments)).EndInit();
        }

        private System.Windows.Forms.DataGridView dgvPayments;
        private System.Windows.Forms.Label lblPaymentId;
        private System.Windows.Forms.TextBox txtPaymentId;
        private System.Windows.Forms.Button btnGetAll;
        private System.Windows.Forms.Button btnGetById;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnProcess;
}
}

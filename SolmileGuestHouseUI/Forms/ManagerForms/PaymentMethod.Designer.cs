namespace SolmileGuestHouseUI.Forms.ManagerForms
{
    partial class PaymentMethod
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
            this.dgvPaymentMethods = new System.Windows.Forms.DataGridView();

            this.lblMethodId = new System.Windows.Forms.Label();
            this.txtMethodId = new System.Windows.Forms.TextBox();

            this.lblMethodName = new System.Windows.Forms.Label();
            this.txtMethodName = new System.Windows.Forms.TextBox();

            this.btnGetAll = new System.Windows.Forms.Button();
            this.btnGetById = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)(this.dgvPaymentMethods)).BeginInit();
            this.SuspendLayout();

            // DataGridView: Payment Methods
            this.dgvPaymentMethods.Location = new System.Drawing.Point(20, 130);
            this.dgvPaymentMethods.Size = new System.Drawing.Size(760, 350);
            this.dgvPaymentMethods.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            this.dgvPaymentMethods.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

            // Label: Method ID
            this.lblMethodId.Text = "Method ID:";
            this.lblMethodId.Location = new System.Drawing.Point(20, 20);
            this.lblMethodId.Size = new System.Drawing.Size(90, 23);

            // TextBox: Method ID
            this.txtMethodId.Location = new System.Drawing.Point(120, 20);
            this.txtMethodId.Size = new System.Drawing.Size(200, 22);
            this.txtMethodId.Anchor = AnchorStyles.Top | AnchorStyles.Left;

            // Label: Method Name
            this.lblMethodName.Text = "Method Name:";
            this.lblMethodName.Location = new System.Drawing.Point(20, 60);
            this.lblMethodName.Size = new System.Drawing.Size(100, 23);

            // TextBox: Method Name
            this.txtMethodName.Location = new System.Drawing.Point(120, 60);
            this.txtMethodName.Size = new System.Drawing.Size(200, 22);
            this.txtMethodName.Anchor = AnchorStyles.Top | AnchorStyles.Left;

            // Button: Get All Payment Methods
            this.btnGetAll.Text = "Get All";
            this.btnGetAll.Location = new System.Drawing.Point(350, 18);
            this.btnGetAll.Size = new System.Drawing.Size(90, 28);
            this.btnGetAll.Anchor = AnchorStyles.Top | AnchorStyles.Left;

            // Button: Get by ID
            this.btnGetById.Text = "Get by ID";
            this.btnGetById.Location = new System.Drawing.Point(450, 18);
            this.btnGetById.Size = new System.Drawing.Size(90, 28);
            this.btnGetById.Anchor = AnchorStyles.Top | AnchorStyles.Left;

            // Button: Add Payment Method
            this.btnAdd.Text = "Add";
            this.btnAdd.Location = new System.Drawing.Point(550, 18);
            this.btnAdd.Size = new System.Drawing.Size(90, 28);
            this.btnAdd.Anchor = AnchorStyles.Top | AnchorStyles.Left;

            // Button: Update Payment Method
            this.btnUpdate.Text = "Update";
            this.btnUpdate.Location = new System.Drawing.Point(650, 18);
            this.btnUpdate.Size = new System.Drawing.Size(90, 28);
            this.btnUpdate.Anchor = AnchorStyles.Top | AnchorStyles.Left;

            // Button: Delete Payment Method
            this.btnDelete.Text = "Delete";
            this.btnDelete.Location = new System.Drawing.Point(750, 18);
            this.btnDelete.Size = new System.Drawing.Size(90, 28);
            this.btnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;

            // Add controls to form
            this.Controls.Add(this.dgvPaymentMethods);

            this.Controls.Add(this.lblMethodId);
            this.Controls.Add(this.txtMethodId);

            this.Controls.Add(this.lblMethodName);
            this.Controls.Add(this.txtMethodName);

            this.Controls.Add(this.btnGetAll);
            this.Controls.Add(this.btnGetById);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);

            this.Text = "Payment Method Management";
            this.ClientSize = new System.Drawing.Size(860, 510);
            this.ResumeLayout(false);
            this.PerformLayout();

            ((System.ComponentModel.ISupportInitialize)(this.dgvPaymentMethods)).EndInit();
        }

        private System.Windows.Forms.DataGridView dgvPaymentMethods;
        private System.Windows.Forms.Label lblMethodId;
        private System.Windows.Forms.TextBox txtMethodId;
        private System.Windows.Forms.Label lblMethodName;
        private System.Windows.Forms.TextBox txtMethodName;
        private System.Windows.Forms.Button btnGetAll;
        private System.Windows.Forms.Button btnGetById;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
    }
}

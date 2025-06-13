namespace SolmileGuestHouseUI.Forms.ManagerForms
{
    partial class ServiceType
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
            components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
 
            this.dgvServiceTypes = new System.Windows.Forms.DataGridView();

            this.lblId = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();

            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();

            this.lblDescription = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();

            this.btnGetAll = new System.Windows.Forms.Button();
            this.btnGetById = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();

            this.btnGetIdByName = new System.Windows.Forms.Button();
            this.btnGetListForCustomer = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)(this.dgvServiceTypes)).BeginInit();
            this.SuspendLayout();

            // DataGridView: Service Types
            this.dgvServiceTypes.Location = new System.Drawing.Point(20, 180);
            this.dgvServiceTypes.Size = new System.Drawing.Size(700, 300);
            this.dgvServiceTypes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            this.dgvServiceTypes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

            // Label: ID
            this.lblId.Text = "Service Type ID:";
            this.lblId.Location = new System.Drawing.Point(20, 20);
            this.lblId.Size = new System.Drawing.Size(110, 23);

            // TextBox: ID
            this.txtId.Location = new System.Drawing.Point(140, 20);
            this.txtId.Size = new System.Drawing.Size(200, 22);
            this.txtId.Anchor = AnchorStyles.Top | AnchorStyles.Left;

            // Label: Name
            this.lblName.Text = "Name:";
            this.lblName.Location = new System.Drawing.Point(20, 60);
            this.lblName.Size = new System.Drawing.Size(110, 23);

            // TextBox: Name
            this.txtName.Location = new System.Drawing.Point(140, 60);
            this.txtName.Size = new System.Drawing.Size(200, 22);
            this.txtName.Anchor = AnchorStyles.Top | AnchorStyles.Left;

            // Label: Description
            this.lblDescription.Text = "Description:";
            this.lblDescription.Location = new System.Drawing.Point(20, 100);
            this.lblDescription.Size = new System.Drawing.Size(110, 23);

            // TextBox: Description
            this.txtDescription.Location = new System.Drawing.Point(140, 100);
            this.txtDescription.Size = new System.Drawing.Size(200, 60);
            this.txtDescription.Multiline = true;
            this.txtDescription.Anchor = AnchorStyles.Top | AnchorStyles.Left;

            // Button: Get All Service Types
            this.btnGetAll.Text = "Get All";
            this.btnGetAll.Location = new System.Drawing.Point(360, 18);
            this.btnGetAll.Size = new System.Drawing.Size(90, 28);
            this.btnGetAll.Anchor = AnchorStyles.Top | AnchorStyles.Left;

            // Button: Get By ID
            this.btnGetById.Text = "Get By ID";
            this.btnGetById.Location = new System.Drawing.Point(460, 18);
            this.btnGetById.Size = new System.Drawing.Size(90, 28);
            this.btnGetById.Anchor = AnchorStyles.Top | AnchorStyles.Left;

            // Button: Add
            this.btnAdd.Text = "Add";
            this.btnAdd.Location = new System.Drawing.Point(560, 18);
            this.btnAdd.Size = new System.Drawing.Size(90, 28);
            this.btnAdd.Anchor = AnchorStyles.Top | AnchorStyles.Left;

            // Button: Update
            this.btnUpdate.Text = "Update";
            this.btnUpdate.Location = new System.Drawing.Point(660, 18);
            this.btnUpdate.Size = new System.Drawing.Size(90, 28);
            this.btnUpdate.Anchor = AnchorStyles.Top | AnchorStyles.Left;

            // Button: Delete
            this.btnDelete.Text = "Delete";
            this.btnDelete.Location = new System.Drawing.Point(360, 60);
            this.btnDelete.Size = new System.Drawing.Size(90, 28);
            this.btnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Left;

            // Button: Get ServiceType ID By Name
            this.btnGetIdByName.Text = "Get ID By Name";
            this.btnGetIdByName.Location = new System.Drawing.Point(460, 60);
            this.btnGetIdByName.Size = new System.Drawing.Size(130, 28);
            this.btnGetIdByName.Anchor = AnchorStyles.Top | AnchorStyles.Left;

            // Button: Get Service List For Customer
            this.btnGetListForCustomer.Text = "Get Service List For Customer";
            this.btnGetListForCustomer.Location = new System.Drawing.Point(600, 60);
            this.btnGetListForCustomer.Size = new System.Drawing.Size(180, 28);
            this.btnGetListForCustomer.Anchor = AnchorStyles.Top | AnchorStyles.Left;

            // Add controls to form
            this.Controls.Add(this.dgvServiceTypes);

            this.Controls.Add(this.lblId);
            this.Controls.Add(this.txtId);

            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtName);

            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.txtDescription);

            this.Controls.Add(this.btnGetAll);
            this.Controls.Add(this.btnGetById);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);

            this.Controls.Add(this.btnGetIdByName);
            this.Controls.Add(this.btnGetListForCustomer);

            this.Text = "Service Types Management";
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.ResumeLayout(false);
            this.PerformLayout();

            ((System.ComponentModel.ISupportInitialize)(this.dgvServiceTypes)).EndInit();
        }

        private System.Windows.Forms.DataGridView dgvServiceTypes;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Button btnGetAll;
        private System.Windows.Forms.Button btnGetById;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnGetIdByName;
        private System.Windows.Forms.Button btnGetListForCustomer;
    }

        #endregion
    }


namespace SolmileGuestHouseUI.Forms.ManagerForms
{
    partial class Rating
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
            this.dgvRatings = new System.Windows.Forms.DataGridView();

            this.lblRatingId = new System.Windows.Forms.Label();
            this.txtRatingId = new System.Windows.Forms.TextBox();

            this.lblServiceRequestId = new System.Windows.Forms.Label();
            this.txtServiceRequestId = new System.Windows.Forms.TextBox();

            this.lblRatingValue = new System.Windows.Forms.Label();
            this.txtRatingValue = new System.Windows.Forms.TextBox();

            this.btnGetAll = new System.Windows.Forms.Button();
            this.btnGetById = new System.Windows.Forms.Button();
            this.btnAddOrUpdate = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnGetRatingValueOrNA = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)(this.dgvRatings)).BeginInit();
            this.SuspendLayout();

            // DataGridView: Ratings
            this.dgvRatings.Location = new System.Drawing.Point(20, 170);
            this.dgvRatings.Size = new System.Drawing.Size(760, 320);
            this.dgvRatings.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            this.dgvRatings.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

            // Label: Rating ID
            this.lblRatingId.Text = "Rating ID:";
            this.lblRatingId.Location = new System.Drawing.Point(20, 20);
            this.lblRatingId.Size = new System.Drawing.Size(80, 23);

            // TextBox: Rating ID
            this.txtRatingId.Location = new System.Drawing.Point(130, 20);
            this.txtRatingId.Size = new System.Drawing.Size(200, 22);
            this.txtRatingId.Anchor = AnchorStyles.Top | AnchorStyles.Left;

            // Label: Service Request ID
            this.lblServiceRequestId.Text = "Service Request ID:";
            this.lblServiceRequestId.Location = new System.Drawing.Point(20, 60);
            this.lblServiceRequestId.Size = new System.Drawing.Size(120, 23);

            // TextBox: Service Request ID
            this.txtServiceRequestId.Location = new System.Drawing.Point(150, 60);
            this.txtServiceRequestId.Size = new System.Drawing.Size(180, 22);
            this.txtServiceRequestId.Anchor = AnchorStyles.Top | AnchorStyles.Left;

            // Label: Rating Value
            this.lblRatingValue.Text = "Rating Value:";
            this.lblRatingValue.Location = new System.Drawing.Point(20, 100);
            this.lblRatingValue.Size = new System.Drawing.Size(100, 23);

            // TextBox: Rating Value
            this.txtRatingValue.Location = new System.Drawing.Point(130, 100);
            this.txtRatingValue.Size = new System.Drawing.Size(200, 22);
            this.txtRatingValue.Anchor = AnchorStyles.Top | AnchorStyles.Left;

            // Button: Get All Ratings
            this.btnGetAll.Text = "Get All";
            this.btnGetAll.Location = new System.Drawing.Point(360, 18);
            this.btnGetAll.Size = new System.Drawing.Size(90, 28);
            this.btnGetAll.Anchor = AnchorStyles.Top | AnchorStyles.Left;

            // Button: Get by ID
            this.btnGetById.Text = "Get by ID";
            this.btnGetById.Location = new System.Drawing.Point(460, 18);
            this.btnGetById.Size = new System.Drawing.Size(90, 28);
            this.btnGetById.Anchor = AnchorStyles.Top | AnchorStyles.Left;

            // Button: Add or Update (POST /AddOrUpdate)
            this.btnAddOrUpdate.Text = "Add/Update";
            this.btnAddOrUpdate.Location = new System.Drawing.Point(560, 18);
            this.btnAddOrUpdate.Size = new System.Drawing.Size(100, 28);
            this.btnAddOrUpdate.Anchor = AnchorStyles.Top | AnchorStyles.Left;

            // Button: Update (PUT)
            this.btnUpdate.Text = "Update";
            this.btnUpdate.Location = new System.Drawing.Point(670, 18);
            this.btnUpdate.Size = new System.Drawing.Size(90, 28);
            this.btnUpdate.Anchor = AnchorStyles.Top | AnchorStyles.Left;

            // Button: Delete
            this.btnDelete.Text = "Delete";
            this.btnDelete.Location = new System.Drawing.Point(770, 18);
            this.btnDelete.Size = new System.Drawing.Size(90, 28);
            this.btnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;

            // Button: Get Rating Value or NA (GET /GetRatingValueOrNA/{serviceRequestId})
            this.btnGetRatingValueOrNA.Text = "Get Rating Value or NA";
            this.btnGetRatingValueOrNA.Location = new System.Drawing.Point(360, 60);
            this.btnGetRatingValueOrNA.Size = new System.Drawing.Size(200, 28);
            this.btnGetRatingValueOrNA.Anchor = AnchorStyles.Top | AnchorStyles.Left;

            // Add controls to form
            this.Controls.Add(this.dgvRatings);

            this.Controls.Add(this.lblRatingId);
            this.Controls.Add(this.txtRatingId);

            this.Controls.Add(this.lblServiceRequestId);
            this.Controls.Add(this.txtServiceRequestId);

            this.Controls.Add(this.lblRatingValue);
            this.Controls.Add(this.txtRatingValue);

            this.Controls.Add(this.btnGetAll);
            this.Controls.Add(this.btnGetById);
            this.Controls.Add(this.btnAddOrUpdate);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnGetRatingValueOrNA);

            this.Text = "Ratings Management";
            this.ClientSize = new System.Drawing.Size(880, 510);
            this.ResumeLayout(false);
            this.PerformLayout();

            ((System.ComponentModel.ISupportInitialize)(this.dgvRatings)).EndInit();
        }

        private System.Windows.Forms.DataGridView dgvRatings;
        private System.Windows.Forms.Label lblRatingId;
        private System.Windows.Forms.TextBox txtRatingId;
        private System.Windows.Forms.Label lblServiceRequestId;
        private System.Windows.Forms.TextBox txtServiceRequestId;
        private System.Windows.Forms.Label lblRatingValue;
        private System.Windows.Forms.TextBox txtRatingValue;
        private System.Windows.Forms.Button btnGetAll;
        private System.Windows.Forms.Button btnGetById;
        private System.Windows.Forms.Button btnAddOrUpdate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnGetRatingValueOrNA;
    }
    #endregion
}
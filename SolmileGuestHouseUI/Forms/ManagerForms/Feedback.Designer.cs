namespace SolmileGuestHouseUI.Forms.ManagerForms
{
    partial class Feedback
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
            this.lblFeedbackId = new System.Windows.Forms.Label();
            this.txtFeedbackId = new System.Windows.Forms.TextBox();
            this.lblCustomerId = new System.Windows.Forms.Label();
            this.txtCustomerId = new System.Windows.Forms.TextBox();
            this.lblFeedbackText = new System.Windows.Forms.Label();
            this.txtFeedbackText = new System.Windows.Forms.TextBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.lblRating = new System.Windows.Forms.Label();
            this.nudRating = new System.Windows.Forms.NumericUpDown();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnGetByCustomer = new System.Windows.Forms.Button();
            this.btnGetById = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dgvFeedbacks = new System.Windows.Forms.DataGridView();

            ((System.ComponentModel.ISupportInitialize)(this.nudRating)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFeedbacks)).BeginInit();
            this.SuspendLayout();

            // Feedback ID
            this.lblFeedbackId.Text = "Feedback ID:";
            this.lblFeedbackId.Location = new System.Drawing.Point(20, 20);
            this.txtFeedbackId.Location = new System.Drawing.Point(140, 17);
            this.txtFeedbackId.Size = new System.Drawing.Size(400, 22);
            this.txtFeedbackId.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;

            // Customer ID
            this.lblCustomerId.Text = "Customer ID:";
            this.lblCustomerId.Location = new System.Drawing.Point(20, 60);
            this.txtCustomerId.Location = new System.Drawing.Point(140, 57);
            this.txtCustomerId.Size = new System.Drawing.Size(400, 22);
            this.txtCustomerId.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;

            // Feedback Text
            this.lblFeedbackText.Text = "Feedback:";
            this.lblFeedbackText.Location = new System.Drawing.Point(20, 100);
            this.txtFeedbackText.Location = new System.Drawing.Point(140, 97);
            this.txtFeedbackText.Size = new System.Drawing.Size(400, 60);
            this.txtFeedbackText.Multiline = true;
            this.txtFeedbackText.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;

            // Date
            this.lblDate.Text = "Date:";
            this.lblDate.Location = new System.Drawing.Point(20, 180);
            this.dtpDate.Location = new System.Drawing.Point(140, 177);
            this.dtpDate.Size = new System.Drawing.Size(400, 22);
            this.dtpDate.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;

            // Rating
            this.lblRating.Text = "Rating (1-5):";
            this.lblRating.Location = new System.Drawing.Point(20, 220);
            this.nudRating.Location = new System.Drawing.Point(140, 217);
            this.nudRating.Minimum = 1;
            this.nudRating.Maximum = 5;
            this.nudRating.Value = 5;
            this.nudRating.Size = new System.Drawing.Size(60, 22);
            this.nudRating.Anchor = AnchorStyles.Top | AnchorStyles.Left;

            // Buttons
            this.btnCreate.Text = "Create (POST)";
            this.btnCreate.Location = new System.Drawing.Point(600, 17);
            this.btnCreate.Anchor = AnchorStyles.Top | AnchorStyles.Right;

            this.btnGetByCustomer.Text = "Get by Customer ID";
            this.btnGetByCustomer.Location = new System.Drawing.Point(600, 57);
            this.btnGetByCustomer.Anchor = AnchorStyles.Top | AnchorStyles.Right;

            this.btnGetById.Text = "Get by Feedback ID";
            this.btnGetById.Location = new System.Drawing.Point(600, 97);
            this.btnGetById.Anchor = AnchorStyles.Top | AnchorStyles.Right;

            this.btnUpdate.Text = "Update (PUT)";
            this.btnUpdate.Location = new System.Drawing.Point(600, 137);
            this.btnUpdate.Anchor = AnchorStyles.Top | AnchorStyles.Right;

            this.btnDelete.Text = "Delete (DELETE)";
            this.btnDelete.Location = new System.Drawing.Point(600, 177);
            this.btnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;

            // DataGridView
            this.dgvFeedbacks.Location = new System.Drawing.Point(20, 270);
            this.dgvFeedbacks.Size = new System.Drawing.Size(760, 200);
            this.dgvFeedbacks.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            // Add controls to form
            this.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.lblFeedbackId, this.txtFeedbackId,
                this.lblCustomerId, this.txtCustomerId,
                this.lblFeedbackText, this.txtFeedbackText,
                this.lblDate, this.dtpDate,
                this.lblRating, this.nudRating,
                this.btnCreate, this.btnGetByCustomer,
                this.btnGetById, this.btnUpdate,
                this.btnDelete, this.dgvFeedbacks
            });

            // Form settings
            this.Text = "Feedback Management";
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblFeedbackId;
        private System.Windows.Forms.TextBox txtFeedbackId;
        private System.Windows.Forms.Label lblCustomerId;
        private System.Windows.Forms.TextBox txtCustomerId;
        private System.Windows.Forms.Label lblFeedbackText;
        private System.Windows.Forms.TextBox txtFeedbackText;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label lblRating;
        private System.Windows.Forms.NumericUpDown nudRating;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnGetByCustomer;
        private System.Windows.Forms.Button btnGetById;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dgvFeedbacks;
    }

        #endregion
    }


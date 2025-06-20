namespace SolmileGuestHouseUI.Forms.ManagerForms
{
    partial class Rating
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.DataGridView dgvRatings;
        private System.Windows.Forms.TextBox txtEmployeeId;
        private System.Windows.Forms.TextBox txtServiceRequestId;
        private System.Windows.Forms.TextBox txtRatingValue;
        private System.Windows.Forms.TextBox txtGivenBy;
        private System.Windows.Forms.TextBox txtRatingIdSearch;
        private System.Windows.Forms.TextBox txtServiceRequestSearch;
        private System.Windows.Forms.Button btnGetAll;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnLoadById;
        private System.Windows.Forms.Button btnGetValueNA;
        private System.Windows.Forms.Label labelEmployeeId;
        private System.Windows.Forms.Label labelServiceRequestId;
        private System.Windows.Forms.Label labelRatingValue;
        private System.Windows.Forms.Label labelGivenBy;
        private System.Windows.Forms.Label labelRatingIdSearch;
        private System.Windows.Forms.Label labelServiceRequestSearch;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            dgvRatings = new DataGridView();
            txtEmployeeId = new TextBox();
            txtServiceRequestId = new TextBox();
            txtRatingValue = new TextBox();
            txtGivenBy = new TextBox();
            txtRatingIdSearch = new TextBox();
            txtServiceRequestSearch = new TextBox();
            btnGetAll = new Button();
            btnDelete = new Button();
            btnLoadById = new Button();
            btnGetValueNA = new Button();
            labelEmployeeId = new Label();
            labelServiceRequestId = new Label();
            labelRatingValue = new Label();
            labelGivenBy = new Label();
            labelRatingIdSearch = new Label();
            labelServiceRequestSearch = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvRatings).BeginInit();
            SuspendLayout();
            // 
            // dgvRatings
            // 
            dgvRatings.AllowUserToAddRows = false;
            dgvRatings.AllowUserToDeleteRows = false;
            dgvRatings.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvRatings.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRatings.BackgroundColor = Color.White;
            dgvRatings.BorderStyle = BorderStyle.None;
            dgvRatings.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvRatings.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(52, 152, 219);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvRatings.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(52, 152, 219);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvRatings.DefaultCellStyle = dataGridViewCellStyle2;
            dgvRatings.EnableHeadersVisualStyles = false;
            dgvRatings.GridColor = Color.LightGray;
            dgvRatings.Location = new Point(20, 125);
            dgvRatings.MultiSelect = false;
            dgvRatings.Name = "dgvRatings";
            dgvRatings.ReadOnly = true;
            dgvRatings.RowHeadersVisible = false;
            dgvRatings.RowTemplate.Height = 30;
            dgvRatings.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRatings.Size = new Size(842, 416);
            dgvRatings.TabIndex = 0;
            dgvRatings.SelectionChanged += dgvRatings_SelectionChanged;
            // 
            // txtEmployeeId
            // 
            txtEmployeeId.Location = new Point(124, 54);
            txtEmployeeId.Name = "txtEmployeeId";
            txtEmployeeId.ReadOnly = true;
            txtEmployeeId.Size = new Size(107, 23);
            txtEmployeeId.TabIndex = 2;
            // 
            // txtServiceRequestId
            // 
            txtServiceRequestId.Location = new Point(137, 91);
            txtServiceRequestId.Name = "txtServiceRequestId";
            txtServiceRequestId.ReadOnly = true;
            txtServiceRequestId.Size = new Size(94, 23);
            txtServiceRequestId.TabIndex = 4;
            // 
            // txtRatingValue
            // 
            txtRatingValue.Location = new Point(396, 19);
            txtRatingValue.Name = "txtRatingValue";
            txtRatingValue.ReadOnly = true;
            txtRatingValue.Size = new Size(84, 23);
            txtRatingValue.TabIndex = 6;
            // 
            // txtGivenBy
            // 
            txtGivenBy.Location = new Point(396, 53);
            txtGivenBy.Name = "txtGivenBy";
            txtGivenBy.ReadOnly = true;
            txtGivenBy.Size = new Size(150, 23);
            txtGivenBy.TabIndex = 8;
            // 
            // txtRatingIdSearch
            // 
            txtRatingIdSearch.Enabled = false;
            txtRatingIdSearch.Location = new Point(124, 20);
            txtRatingIdSearch.Name = "txtRatingIdSearch";
            txtRatingIdSearch.Size = new Size(107, 23);
            txtRatingIdSearch.TabIndex = 10;
            // 
            // txtServiceRequestSearch
            // 
            txtServiceRequestSearch.Enabled = false;
            txtServiceRequestSearch.Location = new Point(464, 91);
            txtServiceRequestSearch.Name = "txtServiceRequestSearch";
            txtServiceRequestSearch.ReadOnly = true;
            txtServiceRequestSearch.Size = new Size(82, 23);
            txtServiceRequestSearch.TabIndex = 13;
            // 
            // btnGetAll
            // 
            btnGetAll.Location = new Point(742, 12);
            btnGetAll.Name = "btnGetAll";
            btnGetAll.Size = new Size(120, 30);
            btnGetAll.TabIndex = 15;
            btnGetAll.Text = "Refresh All";
            btnGetAll.Click += btnGetAll_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(742, 53);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(120, 30);
            btnDelete.TabIndex = 16;
            btnDelete.Text = "Delete Selected";
            btnDelete.Click += btnDelete_Click;
            // 
            // btnLoadById
            // 
            btnLoadById.Location = new Point(602, 13);
            btnLoadById.Name = "btnLoadById";
            btnLoadById.Size = new Size(120, 30);
            btnLoadById.TabIndex = 11;
            btnLoadById.Text = "Load By ID";
            btnLoadById.Click += btnLoadById_Click;
            // 
            // btnGetValueNA
            // 
            btnGetValueNA.Location = new Point(602, 49);
            btnGetValueNA.Name = "btnGetValueNA";
            btnGetValueNA.Size = new Size(130, 30);
            btnGetValueNA.TabIndex = 14;
            btnGetValueNA.Text = "Get Rating Value / NA";
            btnGetValueNA.Click += btnGetValueNA_Click;
            // 
            // labelEmployeeId
            // 
            labelEmployeeId.Location = new Point(20, 49);
            labelEmployeeId.Name = "labelEmployeeId";
            labelEmployeeId.Size = new Size(78, 25);
            labelEmployeeId.TabIndex = 1;
            labelEmployeeId.Text = "Employee ID:";
            // 
            // labelServiceRequestId
            // 
            labelServiceRequestId.Location = new Point(20, 91);
            labelServiceRequestId.Name = "labelServiceRequestId";
            labelServiceRequestId.Size = new Size(111, 25);
            labelServiceRequestId.TabIndex = 3;
            labelServiceRequestId.Text = "Service Request ID:";
            // 
            // labelRatingValue
            // 
            labelRatingValue.Location = new Point(306, 23);
            labelRatingValue.Name = "labelRatingValue";
            labelRatingValue.Size = new Size(75, 25);
            labelRatingValue.TabIndex = 5;
            labelRatingValue.Text = "Rating Value:";
            // 
            // labelGivenBy
            // 
            labelGivenBy.Location = new Point(306, 58);
            labelGivenBy.Name = "labelGivenBy";
            labelGivenBy.Size = new Size(78, 25);
            labelGivenBy.TabIndex = 7;
            labelGivenBy.Text = "Given By:";
            // 
            // labelRatingIdSearch
            // 
            labelRatingIdSearch.Location = new Point(20, 17);
            labelRatingIdSearch.Name = "labelRatingIdSearch";
            labelRatingIdSearch.Size = new Size(78, 25);
            labelRatingIdSearch.TabIndex = 9;
            labelRatingIdSearch.Text = "Rating ID:";
            // 
            // labelServiceRequestSearch
            // 
            labelServiceRequestSearch.Location = new Point(306, 97);
            labelServiceRequestSearch.Name = "labelServiceRequestSearch";
            labelServiceRequestSearch.Size = new Size(152, 25);
            labelServiceRequestSearch.TabIndex = 12;
            labelServiceRequestSearch.Text = "Get Rating Value by SR ID:";
            // 
            // label1
            // 
            label1.Location = new Point(306, 23);
            label1.Name = "label1";
            label1.Size = new Size(75, 25);
            label1.TabIndex = 5;
            label1.Text = "Rating Value:";
            // 
            // Rating
            // 
            BackColor = Color.White;
            Controls.Add(dgvRatings);
            Controls.Add(labelEmployeeId);
            Controls.Add(txtEmployeeId);
            Controls.Add(labelServiceRequestId);
            Controls.Add(txtServiceRequestId);
            Controls.Add(label1);
            Controls.Add(labelRatingValue);
            Controls.Add(txtRatingValue);
            Controls.Add(labelGivenBy);
            Controls.Add(txtGivenBy);
            Controls.Add(labelRatingIdSearch);
            Controls.Add(txtRatingIdSearch);
            Controls.Add(btnLoadById);
            Controls.Add(labelServiceRequestSearch);
            Controls.Add(txtServiceRequestSearch);
            Controls.Add(btnGetValueNA);
            Controls.Add(btnGetAll);
            Controls.Add(btnDelete);
            Name = "Rating";
            Size = new Size(884, 566);
            ((System.ComponentModel.ISupportInitialize)dgvRatings).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
    }
}

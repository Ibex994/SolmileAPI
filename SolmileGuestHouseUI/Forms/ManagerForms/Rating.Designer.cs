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
            groupBox1 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dgvRatings).BeginInit();
            groupBox1.SuspendLayout();
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
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvRatings.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.Goldenrod;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(52, 152, 219);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvRatings.DefaultCellStyle = dataGridViewCellStyle2;
            dgvRatings.EnableHeadersVisualStyles = false;
            dgvRatings.GridColor = Color.LightGray;
            dgvRatings.Location = new Point(20, 162);
            dgvRatings.MultiSelect = false;
            dgvRatings.Name = "dgvRatings";
            dgvRatings.ReadOnly = true;
            dgvRatings.RowHeadersVisible = false;
            dgvRatings.RowTemplate.Height = 30;
            dgvRatings.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRatings.Size = new Size(842, 379);
            dgvRatings.TabIndex = 0;
            dgvRatings.SelectionChanged += dgvRatings_SelectionChanged;
            // 
            // txtEmployeeId
            // 
            txtEmployeeId.Font = new Font("Arial Narrow", 8.25F, FontStyle.Bold);
            txtEmployeeId.Location = new Point(124, 54);
            txtEmployeeId.Name = "txtEmployeeId";
            txtEmployeeId.ReadOnly = true;
            txtEmployeeId.Size = new Size(107, 20);
            txtEmployeeId.TabIndex = 2;
            // 
            // txtServiceRequestId
            // 
            txtServiceRequestId.Font = new Font("Arial Narrow", 8.25F, FontStyle.Bold);
            txtServiceRequestId.Location = new Point(168, 91);
            txtServiceRequestId.Name = "txtServiceRequestId";
            txtServiceRequestId.ReadOnly = true;
            txtServiceRequestId.Size = new Size(94, 20);
            txtServiceRequestId.TabIndex = 4;
            // 
            // txtRatingValue
            // 
            txtRatingValue.Font = new Font("Arial Narrow", 8.25F, FontStyle.Bold);
            txtRatingValue.Location = new Point(364, 13);
            txtRatingValue.Name = "txtRatingValue";
            txtRatingValue.ReadOnly = true;
            txtRatingValue.Size = new Size(84, 20);
            txtRatingValue.TabIndex = 6;
            // 
            // txtGivenBy
            // 
            txtGivenBy.Font = new Font("Arial Narrow", 8.25F, FontStyle.Bold);
            txtGivenBy.Location = new Point(364, 47);
            txtGivenBy.Name = "txtGivenBy";
            txtGivenBy.ReadOnly = true;
            txtGivenBy.Size = new Size(150, 20);
            txtGivenBy.TabIndex = 8;
            // 
            // txtRatingIdSearch
            // 
            txtRatingIdSearch.Enabled = false;
            txtRatingIdSearch.Font = new Font("Arial Narrow", 8.25F, FontStyle.Bold);
            txtRatingIdSearch.Location = new Point(124, 20);
            txtRatingIdSearch.Name = "txtRatingIdSearch";
            txtRatingIdSearch.Size = new Size(107, 20);
            txtRatingIdSearch.TabIndex = 10;
            // 
            // txtServiceRequestSearch
            // 
            txtServiceRequestSearch.Enabled = false;
            txtServiceRequestSearch.Font = new Font("Arial Narrow", 8.25F, FontStyle.Bold);
            txtServiceRequestSearch.Location = new Point(432, 85);
            txtServiceRequestSearch.Name = "txtServiceRequestSearch";
            txtServiceRequestSearch.ReadOnly = true;
            txtServiceRequestSearch.Size = new Size(82, 20);
            txtServiceRequestSearch.TabIndex = 13;
            // 
            // btnGetAll
            // 
            btnGetAll.BackColor = Color.FromArgb(52, 152, 219);
            btnGetAll.FlatStyle = FlatStyle.Flat;
            btnGetAll.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnGetAll.ForeColor = Color.White;
            btnGetAll.Location = new Point(156, 56);
            btnGetAll.Name = "btnGetAll";
            btnGetAll.Size = new Size(134, 31);
            btnGetAll.TabIndex = 15;
            btnGetAll.Text = "Refresh All";
            btnGetAll.UseVisualStyleBackColor = false;
            btnGetAll.Click += btnGetAll_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(231, 76, 60);
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(156, 97);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(134, 31);
            btnDelete.TabIndex = 16;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnLoadById
            // 
            btnLoadById.BackColor = Color.FromArgb(52, 152, 219);
            btnLoadById.FlatStyle = FlatStyle.Flat;
            btnLoadById.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnLoadById.ForeColor = Color.White;
            btnLoadById.Location = new Point(16, 56);
            btnLoadById.Name = "btnLoadById";
            btnLoadById.Size = new Size(134, 31);
            btnLoadById.TabIndex = 11;
            btnLoadById.Text = "Load By ID";
            btnLoadById.UseVisualStyleBackColor = false;
            btnLoadById.Click += btnLoadById_Click;
            // 
            // btnGetValueNA
            // 
            btnGetValueNA.BackColor = Color.FromArgb(52, 152, 219);
            btnGetValueNA.FlatStyle = FlatStyle.Flat;
            btnGetValueNA.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnGetValueNA.ForeColor = Color.White;
            btnGetValueNA.Location = new Point(16, 95);
            btnGetValueNA.Name = "btnGetValueNA";
            btnGetValueNA.Size = new Size(134, 31);
            btnGetValueNA.TabIndex = 14;
            btnGetValueNA.Text = "Get Rating Value / NA";
            btnGetValueNA.UseVisualStyleBackColor = false;
            btnGetValueNA.Click += btnGetValueNA_Click;
            // 
            // labelEmployeeId
            // 
            labelEmployeeId.Font = new Font("Arial", 11.25F, FontStyle.Bold);
            labelEmployeeId.ForeColor = Color.Goldenrod;
            labelEmployeeId.Location = new Point(20, 49);
            labelEmployeeId.Name = "labelEmployeeId";
            labelEmployeeId.Size = new Size(78, 25);
            labelEmployeeId.TabIndex = 1;
            labelEmployeeId.Text = "Employee ID:";
            // 
            // labelServiceRequestId
            // 
            labelServiceRequestId.Font = new Font("Arial", 11.25F, FontStyle.Bold);
            labelServiceRequestId.ForeColor = Color.Goldenrod;
            labelServiceRequestId.Location = new Point(20, 91);
            labelServiceRequestId.Name = "labelServiceRequestId";
            labelServiceRequestId.Size = new Size(132, 25);
            labelServiceRequestId.TabIndex = 3;
            labelServiceRequestId.Text = "Service Request ID:";
            // 
            // labelRatingValue
            // 
            labelRatingValue.Location = new Point(274, 17);
            labelRatingValue.Name = "labelRatingValue";
            labelRatingValue.Size = new Size(75, 25);
            labelRatingValue.TabIndex = 5;
            labelRatingValue.Text = "Rating Value:";
            // 
            // labelGivenBy
            // 
            labelGivenBy.Font = new Font("Arial", 11.25F, FontStyle.Bold);
            labelGivenBy.ForeColor = Color.Goldenrod;
            labelGivenBy.Location = new Point(274, 52);
            labelGivenBy.Name = "labelGivenBy";
            labelGivenBy.Size = new Size(78, 25);
            labelGivenBy.TabIndex = 7;
            labelGivenBy.Text = "Given By:";
            // 
            // labelRatingIdSearch
            // 
            labelRatingIdSearch.Font = new Font("Arial", 11.25F, FontStyle.Bold);
            labelRatingIdSearch.ForeColor = Color.Goldenrod;
            labelRatingIdSearch.Location = new Point(20, 17);
            labelRatingIdSearch.Name = "labelRatingIdSearch";
            labelRatingIdSearch.Size = new Size(78, 25);
            labelRatingIdSearch.TabIndex = 9;
            labelRatingIdSearch.Text = "Rating ID:";
            // 
            // labelServiceRequestSearch
            // 
            labelServiceRequestSearch.Font = new Font("Arial", 11.25F, FontStyle.Bold);
            labelServiceRequestSearch.ForeColor = Color.Goldenrod;
            labelServiceRequestSearch.Location = new Point(274, 91);
            labelServiceRequestSearch.Name = "labelServiceRequestSearch";
            labelServiceRequestSearch.Size = new Size(152, 25);
            labelServiceRequestSearch.TabIndex = 12;
            labelServiceRequestSearch.Text = "Get Rating Value by SR ID:";
            // 
            // label1
            // 
            label1.Font = new Font("Arial", 11.25F, FontStyle.Bold);
            label1.ForeColor = Color.Goldenrod;
            label1.Location = new Point(274, 17);
            label1.Name = "label1";
            label1.Size = new Size(75, 25);
            label1.TabIndex = 5;
            label1.Text = "Rating Value:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnGetValueNA);
            groupBox1.Controls.Add(btnGetAll);
            groupBox1.Controls.Add(btnLoadById);
            groupBox1.Controls.Add(btnDelete);
            groupBox1.Location = new Point(552, 17);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(297, 139);
            groupBox1.TabIndex = 17;
            groupBox1.TabStop = false;
            groupBox1.Text = "Action";
            // 
            // Rating
            // 
            BackColor = Color.White;
            Controls.Add(groupBox1);
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
            Controls.Add(labelServiceRequestSearch);
            Controls.Add(txtServiceRequestSearch);
            Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            ForeColor = Color.Goldenrod;
            Name = "Rating";
            Size = new Size(884, 566);
            ((System.ComponentModel.ISupportInitialize)dgvRatings).EndInit();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private GroupBox groupBox1;
    }
}

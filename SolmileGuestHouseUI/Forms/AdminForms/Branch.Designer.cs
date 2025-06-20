    namespace SolmileGuestHouseUI.Forms.AdminForms
    {
        partial class Branch
        {
            private System.ComponentModel.IContainer components = null;
            private DataGridView dgvBranches;
            private TextBox txtBranchName;
            private TextBox txtLocation;
            private Button btnAdd;
            private Button btnUpdate;
            private Button btnDelete;
            private Button btnClear;
            private Button btnLoad;
            private TextBox txtContactId;


        protected override void Dispose(bool disposing)
            {
                if (disposing && (components != null)) components.Dispose();
                base.Dispose(disposing);
            }

        private void InitializeComponent()
        {
            dgvBranches = new DataGridView();
            txtBranchName = new TextBox();
            txtLocation = new TextBox();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnClear = new Button();
            btnLoad = new Button();
            txtContactId = new TextBox();
            btnSearch = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvBranches).BeginInit();
            SuspendLayout();
            // 
            // dgvBranches
            // 
            dgvBranches.AllowUserToAddRows = false;
            dgvBranches.AllowUserToDeleteRows = false;
            dgvBranches.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvBranches.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBranches.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllHeaders;
            dgvBranches.BackgroundColor = Color.White;
            dgvBranches.BorderStyle = BorderStyle.None;
            dgvBranches.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvBranches.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvBranches.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(52, 152, 219);
            dgvBranches.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvBranches.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dgvBranches.DefaultCellStyle.Font = new Font("Segoe UI", 10F);
            dgvBranches.DefaultCellStyle.SelectionBackColor = Color.FromArgb(52, 152, 219);
            dgvBranches.DefaultCellStyle.SelectionForeColor = Color.White;
            dgvBranches.EnableHeadersVisualStyles = false;
            dgvBranches.GridColor = Color.LightGray;
            dgvBranches.Location = new Point(23, 118);
            dgvBranches.MultiSelect = false;
            dgvBranches.Name = "dgvBranches";
            dgvBranches.ReadOnly = true;
            dgvBranches.RowHeadersVisible = false;
            dgvBranches.RowTemplate.Height = 30;
            dgvBranches.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBranches.Size = new Size(823, 438);
            dgvBranches.TabIndex = 0;
            dgvBranches.Click += dgvBranches_CellClick;

            // 
            // txtBranchName
            // 
            txtBranchName.Location = new Point(103, 20);
            txtBranchName.Name = "txtBranchName";
            txtBranchName.PlaceholderText = "Branch Name";
            txtBranchName.Size = new Size(200, 23);
            txtBranchName.TabIndex = 1;
            // 
            // txtLocation
            // 
            txtLocation.Location = new Point(103, 89);
            txtLocation.Name = "txtLocation";
            txtLocation.PlaceholderText = "Location";
            txtLocation.Size = new Size(200, 23);
            txtLocation.TabIndex = 2;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(331, 19);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Add";
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(331, 48);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 4;
            btnUpdate.Text = "Update";
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(331, 88);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "Delete";
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(446, 20);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 23);
            btnClear.TabIndex = 6;
            btnClear.Text = "Clear";
            btnClear.Click += btnClear_Click;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(446, 88);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(75, 23);
            btnLoad.TabIndex = 7;
            btnLoad.Text = "Load";
            btnLoad.Click += btnLoad_Click;
            // 
            // txtContactId
            // 
            txtContactId.Location = new Point(103, 51);
            txtContactId.Name = "txtContactId";
            txtContactId.PlaceholderText = "Contact ID";
            txtContactId.Size = new Size(200, 23);
            txtContactId.TabIndex = 8;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(446, 51);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 7;
            btnSearch.Text = "Search";
            btnSearch.Click += btnSearch_Click;
            // 
            // Branch
            // 
            BackColor = Color.White;
            Controls.Add(txtBranchName);
            Controls.Add(txtLocation);
            Controls.Add(btnAdd);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(btnClear);
            Controls.Add(btnSearch);
            Controls.Add(btnLoad);
            Controls.Add(txtContactId);
            Controls.Add(dgvBranches);
            Name = "Branch";
            Size = new Size(859, 583);
            ((System.ComponentModel.ISupportInitialize)dgvBranches).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        private Button btnSearch;
    }
    }

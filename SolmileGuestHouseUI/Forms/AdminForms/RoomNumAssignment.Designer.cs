namespace SolmileGuestHouseUI.Forms.AdminForms
{
    partial class RoomNumAssignment
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.DataGridView dgvRoomNumAssign;
        private System.Windows.Forms.TextBox txtRoomNumber;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblBranchId;
        private System.Windows.Forms.Label lblRoomNumber;
        private ComboBox cmbBranch = new ComboBox();

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            dgvRoomNumAssign = new DataGridView();
            txtRoomNumber = new TextBox();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnRefresh = new Button();
            btnSearch = new Button();
            lblBranchId = new Label();
            lblRoomNumber = new Label();
            btnClear = new Button();
            cmbBranchList = new ComboBox();
            label1 = new Label();
            assignId = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvRoomNumAssign).BeginInit();
            SuspendLayout();
            // 
            // dgvRoomNumAssign
            // 
            dgvRoomNumAssign.AllowUserToAddRows = false;
            dgvRoomNumAssign.AllowUserToDeleteRows = false;
            dgvRoomNumAssign.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvRoomNumAssign.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRoomNumAssign.BackgroundColor = Color.White;
            dgvRoomNumAssign.BorderStyle = BorderStyle.None;
            dgvRoomNumAssign.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvRoomNumAssign.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(52, 152, 219);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvRoomNumAssign.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(52, 152, 219);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvRoomNumAssign.DefaultCellStyle = dataGridViewCellStyle2;
            dgvRoomNumAssign.EnableHeadersVisualStyles = false;
            dgvRoomNumAssign.GridColor = Color.LightGray;
            dgvRoomNumAssign.Location = new Point(18, 154);
            dgvRoomNumAssign.MultiSelect = false;
            dgvRoomNumAssign.Name = "dgvRoomNumAssign";
            dgvRoomNumAssign.ReadOnly = true;
            dgvRoomNumAssign.RowHeadersVisible = false;
            dgvRoomNumAssign.RowTemplate.Height = 30;
            dgvRoomNumAssign.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRoomNumAssign.Size = new Size(821, 411);
            dgvRoomNumAssign.TabIndex = 0;
            dgvRoomNumAssign.CellClick += dgvRoomNumAssign_CellClick;
            // 
            // txtRoomNumber
            // 
            txtRoomNumber.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtRoomNumber.Location = new Point(236, 107);
            txtRoomNumber.Name = "txtRoomNumber";
            txtRoomNumber.Size = new Size(150, 23);
            txtRoomNumber.TabIndex = 4;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(451, 17);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(90, 27);
            btnAdd.TabIndex = 5;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(451, 66);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(90, 27);
            btnUpdate.TabIndex = 6;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(592, 17);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(90, 27);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(592, 66);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(90, 27);
            btnRefresh.TabIndex = 8;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(592, 109);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(90, 27);
            btnSearch.TabIndex = 9;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // lblBranchId
            // 
            lblBranchId.AutoSize = true;
            lblBranchId.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBranchId.Location = new Point(52, 67);
            lblBranchId.Name = "lblBranchId";
            lblBranchId.Size = new Size(93, 18);
            lblBranchId.TabIndex = 1;
            lblBranchId.Text = "Branch ID:";
            // 
            // lblRoomNumber
            // 
            lblRoomNumber.AutoSize = true;
            lblRoomNumber.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRoomNumber.Location = new Point(52, 107);
            lblRoomNumber.Name = "lblRoomNumber";
            lblRoomNumber.Size = new Size(126, 18);
            lblRoomNumber.TabIndex = 3;
            lblRoomNumber.Text = "Room Number:";
            // 
            // btnClear
            // 
            btnClear.Location = new Point(451, 109);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(90, 27);
            btnClear.TabIndex = 9;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // cmbBranchList
            // 
            cmbBranchList.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBranchList.FormattingEnabled = true;
            cmbBranchList.Location = new Point(236, 62);
            cmbBranchList.Name = "cmbBranchList";
            cmbBranchList.Size = new Size(150, 23);
            cmbBranchList.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(52, 21);
            label1.Name = "label1";
            label1.Size = new Size(178, 18);
            label1.TabIndex = 3;
            label1.Text = "Room Num Assign ID:";
            // 
            // assignId
            // 
            assignId.Enabled = false;
            assignId.Location = new Point(236, 17);
            assignId.Name = "assignId";
            assignId.Size = new Size(150, 23);
            assignId.TabIndex = 11;
            // 
            // RoomNumAssignment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(assignId);
            Controls.Add(cmbBranchList);
            Controls.Add(dgvRoomNumAssign);
            Controls.Add(lblBranchId);
            Controls.Add(label1);
            Controls.Add(lblRoomNumber);
            Controls.Add(txtRoomNumber);
            Controls.Add(btnAdd);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(btnRefresh);
            Controls.Add(btnClear);
            Controls.Add(btnSearch);
            Name = "RoomNumAssignment";
            Size = new Size(860, 730);
            ((System.ComponentModel.ISupportInitialize)dgvRoomNumAssign).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        private Button btnClear;
        private ComboBox cmbBranchList;
        private Label label1;
        private TextBox assignId;
    }
}

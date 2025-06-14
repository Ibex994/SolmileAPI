namespace SolmileGuestHouseUI.Forms.AdminForms
{
    partial class RoomNumAssignment
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.DataGridView dgvRoomNumAssign;
        private System.Windows.Forms.TextBox txtBranchId;
        private System.Windows.Forms.TextBox txtRoomNumber;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblBranchId;
        private System.Windows.Forms.Label lblRoomNumber;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            dgvRoomNumAssign = new DataGridView();
            txtBranchId = new TextBox();
            txtRoomNumber = new TextBox();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnRefresh = new Button();
            btnSearch = new Button();
            lblBranchId = new Label();
            lblRoomNumber = new Label();
            btnClear = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvRoomNumAssign).BeginInit();
            SuspendLayout();
            // 
            // dgvRoomNumAssign
            // 
            dgvRoomNumAssign.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRoomNumAssign.BackgroundColor = Color.White;
            dgvRoomNumAssign.Location = new Point(18, 154);
            dgvRoomNumAssign.Name = "dgvRoomNumAssign";
            dgvRoomNumAssign.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRoomNumAssign.Size = new Size(821, 411);
            dgvRoomNumAssign.TabIndex = 0;
            dgvRoomNumAssign.CellClick += dgvRoomNumAssign_CellClick;
            // 
            // txtBranchId
            // 
            txtBranchId.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBranchId.Location = new Point(140, 27);
            txtBranchId.Name = "txtBranchId";
            txtBranchId.Size = new Size(150, 23);
            txtBranchId.TabIndex = 2;
            // 
            // txtRoomNumber
            // 
            txtRoomNumber.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtRoomNumber.Location = new Point(172, 70);
            txtRoomNumber.Name = "txtRoomNumber";
            txtRoomNumber.Size = new Size(150, 23);
            txtRoomNumber.TabIndex = 4;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(362, 18);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(90, 27);
            btnAdd.TabIndex = 5;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(362, 67);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(90, 27);
            btnUpdate.TabIndex = 6;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(503, 18);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(90, 27);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(503, 67);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(90, 27);
            btnRefresh.TabIndex = 8;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(503, 110);
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
            lblBranchId.Location = new Point(40, 30);
            lblBranchId.Name = "lblBranchId";
            lblBranchId.Size = new Size(93, 18);
            lblBranchId.TabIndex = 1;
            lblBranchId.Text = "Branch ID:";
            // 
            // lblRoomNumber
            // 
            lblRoomNumber.AutoSize = true;
            lblRoomNumber.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRoomNumber.Location = new Point(40, 70);
            lblRoomNumber.Name = "lblRoomNumber";
            lblRoomNumber.Size = new Size(126, 18);
            lblRoomNumber.TabIndex = 3;
            lblRoomNumber.Text = "Room Number:";
            // 
            // btnClear
            // 
            btnClear.Location = new Point(362, 110);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(90, 27);
            btnClear.TabIndex = 9;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // RoomNumAssignment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(dgvRoomNumAssign);
            Controls.Add(lblBranchId);
            Controls.Add(txtBranchId);
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
    }
}

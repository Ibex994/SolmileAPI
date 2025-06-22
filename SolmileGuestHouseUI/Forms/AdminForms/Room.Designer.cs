namespace SolmileGuestHouseUI.Forms.AdminForms
{
    partial class Room
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private TextBox txtRoomId;
        private ComboBox cmbStatus;
        private ComboBox cmbTypeId;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnClear;
        private DataGridView dgvRooms;


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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            txtRoomId = new TextBox();
            cmbStatus = new ComboBox();
            cmbTypeId = new ComboBox();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnClear = new Button();
            dgvRooms = new DataGridView();
            txtRoomNumberAssignmentId = new TextBox();
            cmbBranchList = new ComboBox();
            txtRoomNum = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvRooms).BeginInit();
            SuspendLayout();
            // 
            // txtRoomId
            // 
            txtRoomId.Location = new Point(30, 20);
            txtRoomId.Name = "txtRoomId";
            txtRoomId.PlaceholderText = "Room ID";
            txtRoomId.Size = new Size(200, 23);
            txtRoomId.TabIndex = 0;
            // 
            // cmbStatus
            // 
            cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatus.Items.AddRange(new object[] { "Available", "Maintenance" });
            cmbStatus.Location = new Point(30, 100);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(200, 23);
            cmbStatus.TabIndex = 2;
            // 
            // cmbTypeId
            // 
            cmbTypeId.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTypeId.Location = new Point(30, 140);
            cmbTypeId.Name = "cmbTypeId";
            cmbTypeId.Size = new Size(200, 23);
            cmbTypeId.TabIndex = 3;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(507, 20);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(100, 30);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Add";
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(507, 60);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(100, 30);
            btnUpdate.TabIndex = 5;
            btnUpdate.Text = "Update";
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(507, 100);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(100, 30);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "Delete";
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(507, 140);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(100, 30);
            btnClear.TabIndex = 7;
            btnClear.Text = "Clear";
            btnClear.Click += btnClear_Click;
            // 
            // dgvRooms
            // 
            dgvRooms.AllowUserToAddRows = false;
            dgvRooms.AllowUserToDeleteRows = false;
            dgvRooms.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvRooms.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRooms.BackgroundColor = Color.White;
            dgvRooms.BorderStyle = BorderStyle.None;
            dgvRooms.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvRooms.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(52, 152, 219);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvRooms.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(52, 152, 219);
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgvRooms.DefaultCellStyle = dataGridViewCellStyle4;
            dgvRooms.EnableHeadersVisualStyles = false;
            dgvRooms.GridColor = Color.LightGray;
            dgvRooms.Location = new Point(30, 176);
            dgvRooms.MultiSelect = false;
            dgvRooms.Name = "dgvRooms";
            dgvRooms.ReadOnly = true;
            dgvRooms.RowHeadersVisible = false;
            dgvRooms.RowTemplate.Height = 30;
            dgvRooms.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRooms.Size = new Size(818, 383);
            dgvRooms.TabIndex = 14;
            // 
            // txtRoomNumberAssignmentId
            // 
            txtRoomNumberAssignmentId.Enabled = false;
            txtRoomNumberAssignmentId.Location = new Point(30, 60);
            txtRoomNumberAssignmentId.Name = "txtRoomNumberAssignmentId";
            txtRoomNumberAssignmentId.PlaceholderText = "Room Number Assignment ID";
            txtRoomNumberAssignmentId.Size = new Size(200, 23);
            txtRoomNumberAssignmentId.TabIndex = 1;
            // 
            // cmbBranchList
            // 
            cmbBranchList.FormattingEnabled = true;
            cmbBranchList.Location = new Point(266, 60);
            cmbBranchList.Name = "cmbBranchList";
            cmbBranchList.Size = new Size(171, 23);
            cmbBranchList.TabIndex = 15;
            // 
            // txtRoomNum
            // 
            txtRoomNum.Location = new Point(266, 25);
            txtRoomNum.Name = "txtRoomNum";
            txtRoomNum.Size = new Size(171, 23);
            txtRoomNum.TabIndex = 16;
            // 
            // Room
            // 
            BackColor = Color.White;
            Controls.Add(txtRoomNum);
            Controls.Add(cmbBranchList);
            Controls.Add(txtRoomId);
            Controls.Add(txtRoomNumberAssignmentId);
            Controls.Add(cmbStatus);
            Controls.Add(cmbTypeId);
            Controls.Add(btnAdd);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(btnClear);
            Controls.Add(dgvRooms);
            Name = "Room";
            Size = new Size(866, 594);
            ((System.ComponentModel.ISupportInitialize)dgvRooms).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        private TextBox txtRoomNumberAssignmentId;
        private ComboBox cmbBranchList;
        private TextBox txtRoomNum;
    }
}

namespace SolmileGuestHouseUI.Forms.AdminForms
{
    partial class Room
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private TextBox txtRoomId;
        private TextBox txtRoomNumberAssignmentId;
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
            txtRoomId = new TextBox();
            txtRoomNumberAssignmentId = new TextBox();
            cmbStatus = new ComboBox();
            cmbTypeId = new ComboBox();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnClear = new Button();
            dgvRooms = new DataGridView();
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
            // txtRoomNumberAssignmentId
            // 
            txtRoomNumberAssignmentId.Location = new Point(30, 60);
            txtRoomNumberAssignmentId.Name = "txtRoomNumberAssignmentId";
            txtRoomNumberAssignmentId.PlaceholderText = "Room Number Assignment ID";
            txtRoomNumberAssignmentId.Size = new Size(200, 23);
            txtRoomNumberAssignmentId.TabIndex = 1;
            // 
            // cmbStatus
            // 
            cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatus.Items.AddRange(new object[] { "Available", "Occupied", "Maintenance" });
            cmbStatus.Location = new Point(30, 100);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(200, 23);
            cmbStatus.TabIndex = 2;
            // 
            // cmbTypeId
            // 
            cmbTypeId.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTypeId.Items.AddRange(new object[] { "1", "2", "3", "4" });
            cmbTypeId.Location = new Point(30, 140);
            cmbTypeId.Name = "cmbTypeId";
            cmbTypeId.Size = new Size(200, 23);
            cmbTypeId.TabIndex = 3;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(260, 20);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(100, 30);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Add";
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(260, 60);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(100, 30);
            btnUpdate.TabIndex = 5;
            btnUpdate.Text = "Update";
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(260, 100);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(100, 30);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "Delete";
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(260, 140);
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
            dgvRooms.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(52, 152, 219);
            dgvRooms.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvRooms.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dgvRooms.DefaultCellStyle.Font = new Font("Segoe UI", 10F);
            dgvRooms.DefaultCellStyle.SelectionBackColor = Color.FromArgb(52, 152, 219);
            dgvRooms.DefaultCellStyle.SelectionForeColor = Color.White;
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
            dgvRooms.TabIndex = 8;

            // 
            // Room
            // 
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

    }
}

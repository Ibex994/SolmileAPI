namespace SolmileGuestHouseUI.Forms.AdminForms
{
    partial class ContactDetails
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblEmergencyContact;
        private System.Windows.Forms.TextBox txtEmergencyContact;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dgvContacts;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
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
            lblPhone = new Label();
            txtPhone = new TextBox();
            lblEmail = new Label();
            txtEmail = new TextBox();
            lblAddress = new Label();
            txtAddress = new TextBox();
            lblEmergencyContact = new Label();
            txtEmergencyContact = new TextBox();
            btnSave = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            dgvContacts = new DataGridView();
            BtnClear = new Button();
            btnSearch = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvContacts).BeginInit();
            SuspendLayout();
            // 
            // lblPhone
            // 
            lblPhone.Location = new Point(40, 30);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(100, 23);
            lblPhone.TabIndex = 0;
            lblPhone.Text = "Phone:";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(150, 30);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(250, 23);
            txtPhone.TabIndex = 1;
            // 
            // lblEmail
            // 
            lblEmail.Location = new Point(40, 70);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(100, 23);
            lblEmail.TabIndex = 2;
            lblEmail.Text = "Email:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(150, 70);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(250, 23);
            txtEmail.TabIndex = 3;
            // 
            // lblAddress
            // 
            lblAddress.Location = new Point(40, 110);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(100, 23);
            lblAddress.TabIndex = 4;
            lblAddress.Text = "Address:";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(150, 110);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(250, 23);
            txtAddress.TabIndex = 5;
            // 
            // lblEmergencyContact
            // 
            lblEmergencyContact.Location = new Point(40, 150);
            lblEmergencyContact.Name = "lblEmergencyContact";
            lblEmergencyContact.Size = new Size(120, 23);
            lblEmergencyContact.TabIndex = 6;
            lblEmergencyContact.Text = "Emergency Contact:";
            // 
            // txtEmergencyContact
            // 
            txtEmergencyContact.Location = new Point(170, 150);
            txtEmergencyContact.Name = "txtEmergencyContact";
            txtEmergencyContact.Size = new Size(230, 23);
            txtEmergencyContact.TabIndex = 7;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(450, 30);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(100, 30);
            btnSave.TabIndex = 8;
            btnSave.Text = "Save";
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(450, 70);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(100, 30);
            btnUpdate.TabIndex = 9;
            btnUpdate.Text = "Update";
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(450, 110);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(100, 30);
            btnDelete.TabIndex = 10;
            btnDelete.Text = "Delete";
            // 
            // dgvContacts
            // 
            dgvContacts.AllowUserToAddRows = false;
            dgvContacts.AllowUserToDeleteRows = false;
            dgvContacts.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvContacts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvContacts.BackgroundColor = Color.White;
            dgvContacts.BorderStyle = BorderStyle.None;
            dgvContacts.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvContacts.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(52, 152, 219);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvContacts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(52, 152, 219);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvContacts.DefaultCellStyle = dataGridViewCellStyle2;
            dgvContacts.EnableHeadersVisualStyles = false;
            dgvContacts.GridColor = Color.LightGray;
            dgvContacts.Location = new Point(17, 185);
            dgvContacts.MultiSelect = false;
            dgvContacts.Name = "dgvContacts";
            dgvContacts.ReadOnly = true;
            dgvContacts.RowHeadersVisible = false;
            dgvContacts.RowTemplate.Height = 30;
            dgvContacts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvContacts.Size = new Size(782, 398);
            dgvContacts.TabIndex = 14;
            dgvContacts.SelectionChanged += dgvContacts_SelectionChanged_1;
            // 
            // BtnClear
            // 
            BtnClear.Location = new Point(450, 150);
            BtnClear.Name = "BtnClear";
            BtnClear.Size = new Size(100, 30);
            BtnClear.TabIndex = 11;
            BtnClear.Text = "Clear";
            BtnClear.Click += BtnClear_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(556, 86);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(100, 30);
            btnSearch.TabIndex = 11;
            btnSearch.Text = "Search";
            btnSearch.Click += btnSearch_Click;
            // 
            // ContactDetails
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnSearch);
            Controls.Add(BtnClear);
            Controls.Add(lblPhone);
            Controls.Add(txtPhone);
            Controls.Add(lblEmail);
            Controls.Add(txtEmail);
            Controls.Add(lblAddress);
            Controls.Add(txtAddress);
            Controls.Add(lblEmergencyContact);
            Controls.Add(txtEmergencyContact);
            Controls.Add(btnSave);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(dgvContacts);
            Name = "ContactDetails";
            Size = new Size(859, 583);
            ((System.ComponentModel.ISupportInitialize)dgvContacts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnClear;
        private Button btnSearch;
    }
}

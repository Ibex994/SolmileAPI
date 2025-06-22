namespace SolmileGuestHouseUI.Forms.AdminForms
{
    partial class RoomType
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtTypeId;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtCapacity;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button btnBrowseImage;
        private System.Windows.Forms.DataGridView dgvRoomTypes;

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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            txtTypeId = new TextBox();
            txtName = new TextBox();
            txtTitle = new TextBox();
            txtPrice = new TextBox();
            txtCapacity = new TextBox();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnClear = new Button();
            dgvRoomTypes = new DataGridView();
            pictureBox = new PictureBox();
            btnBrowseImage = new Button();
            btnSearch = new Button();
            txtDescription = new RichTextBox();
            txtAmenities = new RichTextBox();
            ((System.ComponentModel.ISupportInitialize)dgvRoomTypes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // txtTypeId
            // 
            txtTypeId.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTypeId.Location = new Point(30, 30);
            txtTypeId.Name = "txtTypeId";
            txtTypeId.PlaceholderText = "Type ID";
            txtTypeId.Size = new Size(200, 23);
            txtTypeId.TabIndex = 0;
            // 
            // txtName
            // 
            txtName.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtName.Location = new Point(30, 70);
            txtName.Name = "txtName";
            txtName.PlaceholderText = "Name";
            txtName.Size = new Size(200, 23);
            txtName.TabIndex = 1;
            // 
            // txtTitle
            // 
            txtTitle.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTitle.Location = new Point(30, 110);
            txtTitle.Name = "txtTitle";
            txtTitle.PlaceholderText = "Title";
            txtTitle.Size = new Size(200, 23);
            txtTitle.TabIndex = 2;
            // 
            // txtPrice
            // 
            txtPrice.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPrice.Location = new Point(30, 251);
            txtPrice.Name = "txtPrice";
            txtPrice.PlaceholderText = "Price Per Night";
            txtPrice.Size = new Size(200, 23);
            txtPrice.TabIndex = 5;
            // 
            // txtCapacity
            // 
            txtCapacity.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCapacity.Location = new Point(30, 280);
            txtCapacity.Name = "txtCapacity";
            txtCapacity.PlaceholderText = "Capacity";
            txtCapacity.Size = new Size(200, 23);
            txtCapacity.TabIndex = 6;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(507, 30);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(69, 30);
            btnAdd.TabIndex = 7;
            btnAdd.Text = "Add";
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(507, 70);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(69, 30);
            btnUpdate.TabIndex = 8;
            btnUpdate.Text = "Update";
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(507, 110);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(69, 30);
            btnDelete.TabIndex = 9;
            btnDelete.Text = "Delete";
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(507, 150);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(69, 30);
            btnClear.TabIndex = 10;
            btnClear.Text = "Clear";
            btnClear.Click += btnClear_Click;
            // 
            // dgvRoomTypes
            // 
            dgvRoomTypes.AllowUserToAddRows = false;
            dgvRoomTypes.AllowUserToDeleteRows = false;
            dgvRoomTypes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvRoomTypes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRoomTypes.BackgroundColor = Color.White;
            dgvRoomTypes.BorderStyle = BorderStyle.None;
            dgvRoomTypes.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvRoomTypes.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(52, 152, 219);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvRoomTypes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(52, 152, 219);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvRoomTypes.DefaultCellStyle = dataGridViewCellStyle2;
            dgvRoomTypes.EnableHeadersVisualStyles = false;
            dgvRoomTypes.GridColor = Color.LightGray;
            dgvRoomTypes.Location = new Point(30, 309);
            dgvRoomTypes.MultiSelect = false;
            dgvRoomTypes.Name = "dgvRoomTypes";
            dgvRoomTypes.ReadOnly = true;
            dgvRoomTypes.RowHeadersVisible = false;
            dgvRoomTypes.RowTemplate.Height = 30;
            dgvRoomTypes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRoomTypes.Size = new Size(752, 358);
            dgvRoomTypes.TabIndex = 11;
            // 
            // pictureBox
            // 
            pictureBox.BorderStyle = BorderStyle.FixedSingle;
            pictureBox.Location = new Point(582, 30);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(200, 150);
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.TabIndex = 12;
            pictureBox.TabStop = false;
            // 
            // btnBrowseImage
            // 
            btnBrowseImage.Location = new Point(582, 190);
            btnBrowseImage.Name = "btnBrowseImage";
            btnBrowseImage.Size = new Size(200, 30);
            btnBrowseImage.TabIndex = 13;
            btnBrowseImage.Text = "Browse Image";
            btnBrowseImage.Click += btnBrowseImage_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(507, 190);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(69, 30);
            btnSearch.TabIndex = 10;
            btnSearch.Text = "Search";
            btnSearch.Click += btnSearch_Click;
            // 
            // txtDescription
            // 
            txtDescription.BackColor = Color.White;
            txtDescription.Location = new Point(236, 30);
            txtDescription.Name = "txtDescription";
            txtDescription.ReadOnly = true;
            txtDescription.Size = new Size(265, 110);
            txtDescription.TabIndex = 14;
            txtDescription.Text = "";
            // 
            // txtAmenities
            // 
            txtAmenities.Location = new Point(30, 150);
            txtAmenities.Name = "txtAmenities";
            txtAmenities.Size = new Size(396, 95);
            txtAmenities.TabIndex = 14;
            txtAmenities.Text = "";
            // 
            // RoomType
            // 
            Controls.Add(txtAmenities);
            Controls.Add(txtDescription);
            Controls.Add(txtTypeId);
            Controls.Add(txtName);
            Controls.Add(txtTitle);
            Controls.Add(txtPrice);
            Controls.Add(txtCapacity);
            Controls.Add(btnAdd);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(btnSearch);
            Controls.Add(btnClear);
            Controls.Add(dgvRoomTypes);
            Controls.Add(pictureBox);
            Controls.Add(btnBrowseImage);
            Name = "RoomType";
            Size = new Size(800, 700);
            ((System.ComponentModel.ISupportInitialize)dgvRoomTypes).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        private Button btnSearch;
        private RichTextBox txtDescription;
        private RichTextBox txtAmenities;
    }
}

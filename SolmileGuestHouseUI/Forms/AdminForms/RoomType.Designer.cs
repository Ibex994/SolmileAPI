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
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtAmenities;
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
            txtTypeId = new TextBox();
            txtName = new TextBox();
            txtTitle = new TextBox();
            txtDescription = new TextBox();
            txtAmenities = new TextBox();
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
            ((System.ComponentModel.ISupportInitialize)dgvRoomTypes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // txtTypeId
            // 
            txtTypeId.Location = new Point(30, 30);
            txtTypeId.Name = "txtTypeId";
            txtTypeId.PlaceholderText = "Type ID";
            txtTypeId.Size = new Size(200, 23);
            txtTypeId.TabIndex = 0;
            // 
            // txtName
            // 
            txtName.Location = new Point(30, 70);
            txtName.Name = "txtName";
            txtName.PlaceholderText = "Name";
            txtName.Size = new Size(200, 23);
            txtName.TabIndex = 1;
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(30, 110);
            txtTitle.Name = "txtTitle";
            txtTitle.PlaceholderText = "Title";
            txtTitle.Size = new Size(200, 23);
            txtTitle.TabIndex = 2;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(236, 120);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.PlaceholderText = "Description";
            txtDescription.Size = new Size(200, 60);
            txtDescription.TabIndex = 3;
            // 
            // txtAmenities
            // 
            txtAmenities.Location = new Point(30, 139);
            txtAmenities.Multiline = true;
            txtAmenities.Name = "txtAmenities";
            txtAmenities.PlaceholderText = "Amenities";
            txtAmenities.Size = new Size(200, 60);
            txtAmenities.TabIndex = 4;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(30, 205);
            txtPrice.Name = "txtPrice";
            txtPrice.PlaceholderText = "Price Per Night";
            txtPrice.Size = new Size(200, 23);
            txtPrice.TabIndex = 5;
            // 
            // txtCapacity
            // 
            txtCapacity.Location = new Point(30, 234);
            txtCapacity.Name = "txtCapacity";
            txtCapacity.PlaceholderText = "Capacity";
            txtCapacity.Size = new Size(200, 23);
            txtCapacity.TabIndex = 6;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(442, 30);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(100, 30);
            btnAdd.TabIndex = 7;
            btnAdd.Text = "Add";
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(442, 70);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(100, 30);
            btnUpdate.TabIndex = 8;
            btnUpdate.Text = "Update";
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(442, 110);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(100, 30);
            btnDelete.TabIndex = 9;
            btnDelete.Text = "Delete";
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(442, 150);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(100, 30);
            btnClear.TabIndex = 10;
            btnClear.Text = "Clear";
            btnClear.Click += btnClear_Click;
            // 
            // dgvRoomTypes
            // 
            dgvRoomTypes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRoomTypes.BackgroundColor = Color.White;
            dgvRoomTypes.Location = new Point(30, 263);
            dgvRoomTypes.Name = "dgvRoomTypes";
            dgvRoomTypes.Size = new Size(752, 404);
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
            btnSearch.Location = new Point(442, 190);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(100, 30);
            btnSearch.TabIndex = 10;
            btnSearch.Text = "Search";
            btnSearch.Click += btnSearch_Click;
            // 
            // RoomType
            // 
            Controls.Add(txtTypeId);
            Controls.Add(txtName);
            Controls.Add(txtTitle);
            Controls.Add(txtDescription);
            Controls.Add(txtAmenities);
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
    }
}

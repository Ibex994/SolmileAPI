namespace Solmile.Forms.ReceptionForms
{
    partial class ManageReservation
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            tabPageUpdateReser = new TabPage();
            textBoxStat = new ComboBox();
            label3 = new Label();
            dateTimeChIn = new DateTimePicker();
            btnUpdate = new Button();
            dateTimeChOut = new DateTimePicker();
            textBoxRoomId = new TextBox();
            textBoxCustId = new TextBox();
            textBoxResId = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            tabPageSearchReser = new TabPage();
            dataGridView1 = new DataGridView();
            reservationBindingSource = new BindingSource(components);
            textBoxSearch = new TextBox();
            label2 = new Label();
            label1 = new Label();
            tabConReservation = new TabControl();
            tabPageUpdateReser.SuspendLayout();
            tabPageSearchReser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)reservationBindingSource).BeginInit();
            tabConReservation.SuspendLayout();
            SuspendLayout();
            // 
            // tabPageUpdateReser
            // 
            tabPageUpdateReser.BackColor = Color.White;
            tabPageUpdateReser.Controls.Add(textBoxStat);
            tabPageUpdateReser.Controls.Add(label3);
            tabPageUpdateReser.Controls.Add(dateTimeChIn);
            tabPageUpdateReser.Controls.Add(btnUpdate);
            tabPageUpdateReser.Controls.Add(dateTimeChOut);
            tabPageUpdateReser.Controls.Add(textBoxRoomId);
            tabPageUpdateReser.Controls.Add(textBoxCustId);
            tabPageUpdateReser.Controls.Add(textBoxResId);
            tabPageUpdateReser.Controls.Add(label4);
            tabPageUpdateReser.Controls.Add(label5);
            tabPageUpdateReser.Controls.Add(label6);
            tabPageUpdateReser.Controls.Add(label7);
            tabPageUpdateReser.Controls.Add(label8);
            tabPageUpdateReser.Controls.Add(label9);
            tabPageUpdateReser.Font = new Font("Arial Black", 12F, FontStyle.Bold);
            tabPageUpdateReser.Location = new Point(4, 4);
            tabPageUpdateReser.Name = "tabPageUpdateReser";
            tabPageUpdateReser.Padding = new Padding(3);
            tabPageUpdateReser.Size = new Size(1232, 562);
            tabPageUpdateReser.TabIndex = 1;
            tabPageUpdateReser.Text = "Update Reservation";
            tabPageUpdateReser.Enter += tabPageUpdateReser_Enter;
            tabPageUpdateReser.Leave += tabPageUpdateReser_Leave;
            // 
            // textBoxStat
            // 
            textBoxStat.BackColor = Color.Gray;
            textBoxStat.Cursor = Cursors.Hand;
            textBoxStat.FlatStyle = FlatStyle.Popup;
            textBoxStat.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            textBoxStat.ForeColor = Color.Black;
            textBoxStat.FormattingEnabled = true;
            textBoxStat.Items.AddRange(new object[] { "Pending", "Confirmed" });
            textBoxStat.Location = new Point(430, 308);
            textBoxStat.Name = "textBoxStat";
            textBoxStat.Size = new Size(249, 24);
            textBoxStat.TabIndex = 75;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Arial Black", 12F, FontStyle.Bold);
            label3.Location = new Point(310, 51);
            label3.Name = "label3";
            label3.Size = new Size(186, 23);
            label3.TabIndex = 61;
            label3.Text = "Update Reservation";
            // 
            // dateTimeChIn
            // 
            dateTimeChIn.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            dateTimeChIn.Location = new Point(430, 169);
            dateTimeChIn.Name = "dateTimeChIn";
            dateTimeChIn.Size = new Size(249, 22);
            dateTimeChIn.TabIndex = 73;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.LightSkyBlue;
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            btnUpdate.Location = new Point(326, 399);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(134, 34);
            btnUpdate.TabIndex = 62;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // dateTimeChOut
            // 
            dateTimeChOut.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            dateTimeChOut.Location = new Point(430, 239);
            dateTimeChOut.Name = "dateTimeChOut";
            dateTimeChOut.Size = new Size(249, 22);
            dateTimeChOut.TabIndex = 74;
            // 
            // textBoxRoomId
            // 
            textBoxRoomId.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            textBoxRoomId.Location = new Point(117, 309);
            textBoxRoomId.Name = "textBoxRoomId";
            textBoxRoomId.Size = new Size(194, 22);
            textBoxRoomId.TabIndex = 63;
            // 
            // textBoxCustId
            // 
            textBoxCustId.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            textBoxCustId.Location = new Point(117, 239);
            textBoxCustId.Name = "textBoxCustId";
            textBoxCustId.Size = new Size(194, 22);
            textBoxCustId.TabIndex = 67;
            // 
            // textBoxResId
            // 
            textBoxResId.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            textBoxResId.Location = new Point(117, 169);
            textBoxResId.Name = "textBoxResId";
            textBoxResId.Size = new Size(194, 22);
            textBoxResId.TabIndex = 70;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            label4.Location = new Point(443, 143);
            label4.Name = "label4";
            label4.Size = new Size(101, 16);
            label4.TabIndex = 64;
            label4.Text = "CheckOut Date";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            label5.Location = new Point(117, 143);
            label5.Name = "label5";
            label5.Size = new Size(98, 16);
            label5.TabIndex = 72;
            label5.Text = "Reservation Id";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            label6.Location = new Point(117, 213);
            label6.Name = "label6";
            label6.Size = new Size(83, 16);
            label6.TabIndex = 69;
            label6.Text = "Customer Id";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            label7.Location = new Point(443, 213);
            label7.Name = "label7";
            label7.Size = new Size(91, 16);
            label7.TabIndex = 66;
            label7.Text = "CheckIn Date";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            label8.Location = new Point(430, 283);
            label8.Name = "label8";
            label8.Size = new Size(46, 16);
            label8.TabIndex = 68;
            label8.Text = "Status";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            label9.Location = new Point(117, 283);
            label9.Name = "label9";
            label9.Size = new Size(60, 16);
            label9.TabIndex = 65;
            label9.Text = "Room Id";
            // 
            // tabPageSearchReser
            // 
            tabPageSearchReser.BackColor = Color.White;
            tabPageSearchReser.Controls.Add(dataGridView1);
            tabPageSearchReser.Controls.Add(textBoxSearch);
            tabPageSearchReser.Controls.Add(label2);
            tabPageSearchReser.Controls.Add(label1);
            tabPageSearchReser.Location = new Point(4, 4);
            tabPageSearchReser.Name = "tabPageSearchReser";
            tabPageSearchReser.Padding = new Padding(3);
            tabPageSearchReser.Size = new Size(1232, 562);
            tabPageSearchReser.TabIndex = 0;
            tabPageSearchReser.Text = "Search Reservation";
            tabPageSearchReser.Enter += tabPageSearchReser_Enter;
            tabPageSearchReser.Leave += tabPageSearchReser_Leave;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.DataSource = reservationBindingSource;
            dataGridView1.Location = new Point(6, 89);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridView1.Size = new Size(1218, 467);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.DoubleClick += dataGridView1_DoubleClick;
            // 
            // textBoxSearch
            // 
            textBoxSearch.Location = new Point(274, 57);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(131, 21);
            textBoxSearch.TabIndex = 0;
            textBoxSearch.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(235, 36);
            label2.Name = "label2";
            label2.Size = new Size(193, 18);
            label2.TabIndex = 1;
            label2.Text = "Reservation/Customer ID:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Arial Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 3);
            label1.Name = "label1";
            label1.Size = new Size(219, 27);
            label1.TabIndex = 0;
            label1.Text = "Search Reservation";
            // 
            // tabConReservation
            // 
            tabConReservation.Alignment = TabAlignment.Bottom;
            tabConReservation.Controls.Add(tabPageSearchReser);
            tabConReservation.Controls.Add(tabPageUpdateReser);
            tabConReservation.Dock = DockStyle.Fill;
            tabConReservation.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tabConReservation.Location = new Point(0, 0);
            tabConReservation.Name = "tabConReservation";
            tabConReservation.SelectedIndex = 0;
            tabConReservation.Size = new Size(1240, 590);
            tabConReservation.TabIndex = 0;
            // 
            // ManageReservation
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            AutoSize = true;
            BackColor = Color.White;
            ClientSize = new Size(1240, 590);
            Controls.Add(tabConReservation);
            Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ManageReservation";
            Text = "ManageReservation";
            Load += ManageReservation_Load;
            tabPageUpdateReser.ResumeLayout(false);
            tabPageUpdateReser.PerformLayout();
            tabPageSearchReser.ResumeLayout(false);
            tabPageSearchReser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)reservationBindingSource).EndInit();
            tabConReservation.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private TabPage tabPageUpdateReser;
        private Label label3;
        private DateTimePicker dateTimeChIn;
        private Button btnUpdate;
        private DateTimePicker dateTimeChOut;
        private TextBox textBoxRoomId;
        private TextBox textBoxCustId;
        private TextBox textBoxResId;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private TabPage tabPageSearchReser;
        private DataGridView dataGridView1;
        private TextBox textBoxSearch;
        private Label label2;
        private Label label1;
        private TabControl tabConReservation;
        private ComboBox textBoxStat;
        private BindingSource reservationBindingSource;
        private DataGridViewTextBoxColumn reservationIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn customerIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn roomIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn checkOutDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn checkInDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
    }
}
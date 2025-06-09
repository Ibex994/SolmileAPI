using System.Data;
using System.Diagnostics;
namespace Solmile.Forms.ReceptionForms
{
    public partial class ManageReservation : Form
    {

        public ManageReservation()
        {
            InitializeComponent();
        }
        private void ManageReservation_Load(object sender, EventArgs e)
        {
            AddActionButtons();
            Clear();
            PopulateDataGrid();
        }
        private void tabPageSearchReser_Enter(object sender, EventArgs e)
        {
            textBoxSearch.Clear();
            textBoxSearch.Focus();
        }

        public void Clear()
        {
            textBoxResId.Clear();
            textBoxCustId.Clear();
            textBoxRoomId.Clear();
            textBoxStat.SelectedValue = 0;
            dateTimeChIn.Value = DateTime.Now;
            dateTimeChOut.Value = DateTime.Now;
        }

        private void tabPageUpdateReser_Leave(object sender, EventArgs e)
        {
            Clear();
        }

        private void tabPageSearchReser_Leave(object sender, EventArgs e)
        {
            textBoxSearch.Clear();
        }

        private void tabPageUpdateReser_Enter(object sender, EventArgs e)
        {
            //Clear();
            //dateTimeChOut.Focus();
            //Reservation? reservation = reservationBindingSource.Current as Reservation;
        }

        private void tabPageCancelRes_Enter(object sender, EventArgs e)
        {
            Clear();
        }

        private void tabPageCancelRes_Leave(object sender, EventArgs e)
        {
            Clear();
        }
        private void AddActionButtons()
        {
            //DataGridViewButtonColumn actionColumn = new DataGridViewButtonColumn
            //{
            //    Name = "Actions",
            //    HeaderText = "Actions",
            //    Text = "Cancel",
            //    UseColumnTextForButtonValue = true,
            //    Width = 120,
            //    DefaultCellStyle = new DataGridViewCellStyle
            //    {
            //        BackColor = Color.Red,
            //        Font = new Font("Arial", 12, FontStyle.Bold),
            //        Alignment = DataGridViewContentAlignment.MiddleCenter
            //    }
            //};
            //dataGridView1.Columns.Add(actionColumn);
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            //if (string.IsNullOrWhiteSpace(textBoxResId.Text) || string.IsNullOrWhiteSpace(textBoxCustId.Text) ||
            //    string.IsNullOrWhiteSpace(textBoxRoomId.Text))
            //{
            //    MessageBox.Show("Please fill in all required fields",
            //                   "Validation Error",
            //                   MessageBoxButtons.OK,
            //                   MessageBoxIcon.Warning);
            //    return;
            //}

            //try
            //{
            //    using (DataContext context = new DataContext())
            //    {
            //        int reservationId = int.Parse(textBoxResId.Text);

            //        var existingReservation = await context.Reservations.FirstOrDefaultAsync(r => r.ReservationId == reservationId);

            //        if (existingReservation == null)
            //        {
            //            MessageBox.Show("Reservation not found!",
            //                          "Error",
            //                          MessageBoxButtons.OK,
            //                          MessageBoxIcon.Error);
            //            return;
            //        }

            //        existingReservation.CustomerId = int.Parse(textBoxCustId.Text);
            //        existingReservation.RoomId = textBoxRoomId.Text;
            //        existingReservation.Status = textBoxStat.Text;
            //        existingReservation.CheckInDate = dateTimeChIn.Value;
            //        existingReservation.CheckOutDate = dateTimeChOut.Value;

            //        int recordsAffected = await context.SaveChangesAsync();

            //        if (recordsAffected > 0)
            //        {
            //            MessageBox.Show("Reservation updated successfully!",
            //                          "Success",
            //                          MessageBoxButtons.OK,
            //                          MessageBoxIcon.Information);

            //            await RefreshReservationsGridAsync();

            //            // Ensure UI update happens on the main thread
            //            if (this.IsDisposed) return; // Check if form is still open

            //            this.Invoke((MethodInvoker)delegate
            //            {
            //                if (tabConReservation != null && tabPageSearchReser != null)
            //                {
            //                    tabConReservation.SelectedTab = tabPageSearchReser;
            //                }
            //                else
            //                {
            //                    MessageBox.Show("TabControl or TabPage is missing!");
            //                }
            //            });
            //        }
            //    }
            //}
            //catch (FormatException)
            //{
            //    MessageBox.Show("Invalid number format in ID fields",
            //                  "Input Error",
            //                  MessageBoxButtons.OK,
            //                  MessageBoxIcon.Error);
            //}
            //catch (DbUpdateException dbEx)
            //{
            //    MessageBox.Show($"Database error: {dbEx.InnerException?.Message}",
            //                  "Database Error",
            //                  MessageBoxButtons.OK,
            //                  MessageBoxIcon.Error);
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show($"Unexpected error: {ex.Message}",
            //                  "Error",
            //                  MessageBoxButtons.OK,
            //                  MessageBoxIcon.Error);
            //}
        }

        private async Task RefreshReservationsGridAsync()
        {
            //using (DataContext context = new DataContext())
            //{
            //    // Async database query
            //    var reservations = await context.Reservations.ToListAsync();

            //    // Bind to DataGridView
            //    dataGridView1.DataSource = reservations;

            //    // Format columns
            //    dataGridView1.Columns["ReservationId"].HeaderText = "Reservation ID";
            //    dataGridView1.Columns["CustomerId"].HeaderText = "Customer ID";
            //    dataGridView1.Columns["RoomId"].HeaderText = "Room ID";
            //    dataGridView1.Columns["CheckOutDate"].HeaderText = "Check Out";
            //    dataGridView1.Columns["CheckInDate"].HeaderText = "Check In";
            //    dataGridView1.Columns["Status"].HeaderText = "Status";

            //    // Format datetime columns
            //    dataGridView1.Columns["CheckInDate"].DefaultCellStyle.Format = "MM/dd/yyyy hh:mm tt";
            //}
        }

        void PopulateDataGrid()
        {
            //using (DataContext context = new DataContext())
            //{
            //    reservationBindingSource.DataSource = context.Reservations.ToList<Reservation>();
            //}
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            //// 1. Validate current row
            //if (dataGridView1.CurrentRow == null || dataGridView1.CurrentRow.Index == -1)
            //    return;

            //// 2. Debug: Show all available column names
            //Debug.WriteLine("Available Columns:");
            //foreach (DataGridViewColumn col in dataGridView1.Columns)
            //{
            //    Debug.WriteLine($"- {col.Name} (Header: {col.HeaderText})");
            //}

            //// 3. Check for column using either Name or HeaderText
            //string[] possibleColumnNames = { "ReservationId", "Reservation ID", "ID", "reservation_id" };
            //DataGridViewColumn targetColumn = null;

            //foreach (var colName in possibleColumnNames)
            //{
            //    targetColumn = dataGridView1.Columns[colName] ??
            //                  dataGridView1.Columns.Cast<DataGridViewColumn>()
            //                       .FirstOrDefault(c => c.HeaderText.Equals(colName, StringComparison.OrdinalIgnoreCase));

            //    if (targetColumn != null) break;
            //}

            //if (targetColumn == null)
            //{
            //    MessageBox.Show("Could not find reservation ID column. Available columns:\n" +
            //                    string.Join("\n", dataGridView1.Columns.Cast<DataGridViewColumn>()
            //                        .Select(c => $"{c.Name} ({c.HeaderText})")));
            //    return;
            //}

            //// 4. Safely get the value
            //try
            //{
            //    var cellValue = dataGridView1.CurrentRow.Cells[targetColumn.Index].Value;
            //    if (cellValue == null || cellValue == DBNull.Value)
            //    {
            //        MessageBox.Show("Reservation ID value is empty");
            //        return;
            //    }

            //    int reservationId = Convert.ToInt32(cellValue);

            //    // 5. Load reservation data
            //    using (DataContext context = new DataContext())
            //    {
            //        var rese = context.Reservations.FirstOrDefault(x => x.ReservationId == reservationId);
            //        if (rese != null)
            //        {
            //            tabConReservation.SelectedTab = tabPageUpdateReser;
            //            textBoxResId.Text = rese.ReservationId.ToString();
            //            textBoxCustId.Text = rese.CustomerId.ToString();
            //            textBoxRoomId.Text = rese.RoomId;
            //            textBoxStat.Text = rese.Status;
            //            dateTimeChIn.Value = rese.CheckInDate;
            //            dateTimeChOut.Value = rese.CheckOutDate;
            //            textBoxResId.Enabled = false;
            //            textBoxCustId.Enabled = false;
            //            textBoxRoomId.Enabled = false;
            //        }
            //        else
            //        {
            //            MessageBox.Show("Reservation not found in database");
            //        }
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show($"Error: {ex.Message}");
            //}
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //// 1. Validate click location
            //if (e.RowIndex < 0 || e.ColumnIndex < 0 ||
            //    dataGridView1.Columns[e.ColumnIndex].Name != "Actions")
            //    return;

            //// 2. Debug: Show all available column names
            //Debug.WriteLine("Available Columns:");
            //foreach (DataGridViewColumn col in dataGridView1.Columns)
            //{
            //    Debug.WriteLine($"- {col.Name} (Header: {col.HeaderText})");
            //}

            //// 3. Find reservation ID column
            //string[] possibleColumnNames = { "ReservationId", "Reservation ID", "ID", "reservation_id" };
            //DataGridViewColumn targetColumn = null;

            //foreach (var colName in possibleColumnNames)
            //{
            //    targetColumn = dataGridView1.Columns[colName] ??
            //                  dataGridView1.Columns.Cast<DataGridViewColumn>()
            //                       .FirstOrDefault(c => c.HeaderText.Equals(colName, StringComparison.OrdinalIgnoreCase));

            //    if (targetColumn != null) break;
            //}

            //if (targetColumn == null)
            //{
            //    MessageBox.Show("Could not find reservation ID column. Available columns:\n" +
            //                   string.Join("\n", dataGridView1.Columns.Cast<DataGridViewColumn>()
            //                       .Select(c => $"{c.Name} ({c.HeaderText})")));
            //    return;
            //}

            //// 4. Safely get the reservation ID
            //try
            //{
            //    var cellValue = dataGridView1.Rows[e.RowIndex].Cells[targetColumn.Index].Value;
            //    if (cellValue == null || cellValue == DBNull.Value)
            //    {
            //        MessageBox.Show("Reservation ID value is empty");
            //        return;
            //    }

            //    int reservationId = Convert.ToInt32(cellValue);

            //    // 5. Direct cancellation without context menu
            //    try
            //    {
            //        using (DataContext context = new DataContext())
            //        {
            //            var reservation = context.Reservations.FirstOrDefault(r => r.ReservationId == reservationId);
            //            if (reservation != null)
            //            {
            //                // NEW: Check if already cancelled
            //                if (reservation.Status == "Cancelled")
            //                {
            //                    MessageBox.Show($"Reservation #{reservationId} is already cancelled.",
            //                                  "Information",
            //                                  MessageBoxButtons.OK,
            //                                  MessageBoxIcon.Information);
            //                    return;
            //                }

            //                var confirm = MessageBox.Show(
            //                    $"Cancel reservation #{reservationId}?",
            //                    "Confirm Cancellation",
            //                    MessageBoxButtons.YesNo,
            //                    MessageBoxIcon.Question);

            //                if (confirm == DialogResult.Yes)
            //                {
            //                    reservation.Status = "Cancelled";
            //                    context.SaveChangesAsync();
            //                    MessageBox.Show("Reservation cancelled successfully!");
            //                    _ = RefreshReservationsGridAsync();
            //                }
            //            }
            //            else
            //            {
            //                MessageBox.Show("Reservation not found in database");
            //            }
            //        }
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show($"Error cancelling reservation: {ex.Message}");
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show($"Error: {ex.Message}");
            //}
        }

        private async void txtSearch_TextChanged(object sender, EventArgs e)
        {
        //    try
        //    {
        //        string searchText = textBoxSearch.Text.Trim();

        //        using (var db = new DataContext())
        //        {
        //            // Start with base query
        //            IQueryable<Reservation> query = db.Reservations;

        //            // Apply filter only if search text exists
        //            if (!string.IsNullOrEmpty(searchText))
        //            {
        //                query = query.Where(r =>
        //                    r.ReservationId.ToString().Contains(searchText) ||
        //                    r.CustomerId.ToString().Contains(searchText));
        //            }

        //            // Execute query and bind results
        //            List<Reservation> results = await query
        //                .AsNoTracking()
        //                .OrderBy(r => r.ReservationId)
        //                .ToListAsync();

        //            dataGridView1.DataSource = results;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show($"Search error: {ex.Message}", "Error",
        //                      MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
 }


    }
}

using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using static SolmileGuesthouseAPI.DTO.NavigatorModel.DTOs;

namespace SolmileGuestHouseUI.Forms.AdminForms
{
    public partial class SearchByIdForm : Form
    {
        private readonly Func<int, Task<object>> _searchFunction;
        public object SelectedItem { get; private set; }

        public SearchByIdForm(string title, Func<int, Task<object>> searchFunction)
        {
            InitializeComponent();
            _searchFunction = searchFunction ?? throw new ArgumentNullException(nameof(searchFunction));
            this.Text = title;

            btnFind.Click += BtnFind_Click;
            pictureBoxClose.Click += pictureBoxClose_Click;
            txtSearchId.KeyDown += TxtSearchId_KeyDown;
            this.KeyPreview = true; // Enable form to capture key events
            this.KeyDown += SearchByIdForm_KeyDown;
        }

        private async void BtnFind_Click(object sender, EventArgs e)
        {
            await PerformSearchAsync();
        }

        private async Task PerformSearchAsync()
        {
            txtSearchId.Text = txtSearchId.Text.Trim();

            if (string.IsNullOrEmpty(txtSearchId.Text))
            {
                MessageBox.Show("Please enter an ID to search.", "Missing Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSearchId.Focus();
                return;
            }

            if (!int.TryParse(txtSearchId.Text, out int id))
            {
                MessageBox.Show("Invalid input. Please enter a valid numeric ID.", "Invalid ID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSearchId.Focus();
                return;
            }

            try
            {
                btnFind.Enabled = false;
                btnFind.Text = "Searching...";

                var item = await _searchFunction(id);

                if (item != null)
                {
                    SelectedItem = item;
                    DialogResult = DialogResult.OK;
                    Close();
                }
                else
                {
                    MessageBox.Show($"No record found with ID {id}.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtSearchId.Focus();
                    txtSearchId.SelectAll();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred during search:\n\n{ex.Message}", "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnFind.Enabled = true;
                btnFind.Text = "Find";
            }
        }

        private void TxtSearchId_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                e.SuppressKeyPress = true; // prevent ding sound
                _ = PerformSearchAsync();
            }
        }

        private void SearchByIdForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                e.Handled = true;
                this.Close();
            }
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

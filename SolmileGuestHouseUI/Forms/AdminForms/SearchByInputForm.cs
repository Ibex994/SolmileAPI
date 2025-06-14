using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SolmileGuestHouseUI.Forms.AdminForms
{
    public partial class SearchByInputForm : Form
    {
        private readonly Func<string, Task<object>> _searchFunction;
        public object SelectedItem { get; private set; }
        public SearchByInputForm(string title, Func<string, Task<object>> searchFunction)
        {
            InitializeComponent();

            _searchFunction = searchFunction ?? throw new ArgumentNullException(nameof(searchFunction));
            this.Text = title;

            btnFind.Click += BtnFind_Click;
            txtSearchInput.KeyDown += TxtSearchInput_KeyDown;
            this.KeyPreview = true;
            this.KeyDown += SearchByInputForm_KeyDown;
        }

        private async void BtnFind_Click(object sender, EventArgs e)
        {
            await PerformSearchAsync();
        }

        private async Task PerformSearchAsync()
        {
            string input = txtSearchInput.Text.Trim();

            if (string.IsNullOrEmpty(input))
            {
                MessageBox.Show("Please enter an ID or username.", "Missing Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSearchInput.Focus();
                return;
            }

            try
            {
                btnFind.Enabled = false;
                btnFind.Text = "Searching...";

                var item = await _searchFunction(input);

                if (item != null)
                {
                    SelectedItem = item;
                    DialogResult = DialogResult.OK;
                    Close();
                }
                else
                {
                    MessageBox.Show("No matching user found.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtSearchInput.Focus();
                    txtSearchInput.SelectAll();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred:\n\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnFind.Enabled = true;
                btnFind.Text = "Find";
            }
        }
        private void TxtSearchInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                _ = PerformSearchAsync();
            }
        }
        private void SearchByInputForm_KeyDown(object sender, KeyEventArgs e)
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

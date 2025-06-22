using Newtonsoft.Json;
using SolmileGuesthouseAPI.DTO.NavigatorModel;
using SolmileGuestHouseUI.Forms.AdminForms;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SolmileGuestHouseUI.Forms.ManagerForms
{
    public partial class Feedback : UserControl
    {
        private readonly HttpClient _httpClient = new HttpClient();

        public Feedback()
        {
            InitializeComponent();
            _httpClient.BaseAddress = new Uri("https://localhost:7107/api/");
            dgvFeedbacks.CellClick += dgvFeedbacks_CellClick;
        }

        private async void btnGetById_Click(object sender, EventArgs e)
        {
            using var searchForm = new SearchByIdForm("Search Feedback by ID", SearchFeedbackByIdAsync);
            var result = searchForm.ShowDialog();

            if (result == DialogResult.OK && searchForm.SelectedItem is FeedbackDto feedback)
            {
                txtCustomerId.Text = feedback.CustomerId.ToString();
                textBox1.Text = feedback.Rating.ToString();
                richTextBox1.Text = feedback.Comments;
                dtpDate.Value = feedback.CreatedAt;
            }
        }

        private async void btnGetByCustomer_Click(object sender, EventArgs e)
        {
            using var searchForm = new SearchByIdForm("Search Feedbacks by Customer ID", SearchFeedbacksByCustomerIdAsync);
            var result = searchForm.ShowDialog();

            if (result == DialogResult.OK && searchForm.SelectedItem is List<FeedbackDto> feedbacks)
            {
                dgvFeedbacks.DataSource = feedbacks;
            }
        }

        private async Task LoadAllFeedbacksAsync()
        {
            try
            {
                var response = await _httpClient.GetAsync("FeedBack");
                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    var feedbacks = JsonConvert.DeserializeObject<List<FeedbackDto>>(json);

                    if (feedbacks != null && feedbacks.Count > 0)
                    {
                        dgvFeedbacks.DataSource = feedbacks;
                    }
                    else
                    {
                        dgvFeedbacks.DataSource = null;
                        MessageBox.Show("No feedback records found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Failed to retrieve feedback records from the server.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading feedbacks: {ex.Message}", "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private async void btnDelete_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtFeedbackId.Text, out int feedbackId))
            {
                MessageBox.Show("Invalid Feedback ID");
                return;
            }

            try
            {
                var response = await _httpClient.DeleteAsync($"FeedBack/{feedbackId}");
                var message = await response.Content.ReadAsStringAsync();
                MessageBox.Show(message);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
        private async void dgvFeedbacks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    var row = dgvFeedbacks.Rows[e.RowIndex];
                    if (row.Cells["FeedbackId"].Value != null && int.TryParse(row.Cells["FeedbackId"].Value.ToString(), out int feedbackId))
                    {
                        var response = await _httpClient.GetAsync($"FeedBack/{feedbackId}");
                        if (response.IsSuccessStatusCode)
                        {
                            var json = await response.Content.ReadAsStringAsync();
                            var feedback = JsonConvert.DeserializeObject<FeedbackDto>(json);

                            txtFeedbackId.Text = feedback.FeedbackId.ToString();
                            txtCustomerId.Text = feedback.CustomerId.ToString();
                            textBox1.Text = feedback.Rating.ToString();
                            richTextBox1.Text = feedback.Comments;
                            dtpDate.Value = feedback.CreatedAt;
                        }
                        else
                        {
                            MessageBox.Show("Failed to load selected feedback.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading feedback: " + ex.Message);
                }
            }
        }


        private void btnClear_Click(object sender, EventArgs e)
        {
            txtFeedbackId.Clear();
            txtCustomerId.Clear();
            textBox1.Clear();
            richTextBox1.Clear();
            dtpDate.Value = DateTime.Today;
        }


        // Search feedback by feedback ID (single FeedbackDto)
        private async Task<object> SearchFeedbackByIdAsync(int id)
        {
            try
            {
                var response = await _httpClient.GetAsync($"FeedBack/{id}");
                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    var feedback = JsonConvert.DeserializeObject<FeedbackDto>(json);
                    return feedback;
                }
                return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error retrieving feedback: {ex.Message}");
                return null;
            }
        }

        // Search feedback list by customer ID (returns List<FeedbackDto>)
        private async Task<object> SearchFeedbacksByCustomerIdAsync(int customerId)
        {
            try
            {
                var response = await _httpClient.GetAsync($"FeedBack/customer/{customerId}");
                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    var feedbacks = JsonConvert.DeserializeObject<List<FeedbackDto>>(json);
                    return feedbacks;
                }
                return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error retrieving feedbacks: {ex.Message}");
                return null;
            }
        }

        private async void Feedback_Load(object sender, EventArgs e)
        {
            await LoadAllFeedbacksAsync();
        }
    }
}

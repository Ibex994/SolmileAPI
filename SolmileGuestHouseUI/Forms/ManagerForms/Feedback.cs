using Newtonsoft.Json;
using SolmileGuesthouseAPI.DTO.NavigatorModel;
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
            LoadAllFeedbacksAsync();
        }

        private async void btnGetById_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtFeedbackId.Text, out int id))
            {
                MessageBox.Show("Invalid Feedback ID");
                return;
            }

            try
            {
                var response = await _httpClient.GetAsync($"FeedBack/{id}");
                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    var feedback = JsonConvert.DeserializeObject<FeedbackDto>(json);

                    txtCustomerId.Text = feedback.CustomerId.ToString();
                    textBox1.Text = feedback.Rating.ToString();
                    richTextBox1.Text = feedback.Comments;
                    dtpDate.Value = feedback.CreatedAt;
                }
                else
                {
                    MessageBox.Show("Feedback not found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private async void btnGetByCustomer_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtCustomerId.Text, out int customerId))
            {
                MessageBox.Show("Invalid Customer ID");
                return;
            }

            try
            {
                var response = await _httpClient.GetAsync($"FeedBack/customer/{customerId}");
                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    var feedbacks = JsonConvert.DeserializeObject<List<FeedbackDto>>(json);
                    dgvFeedbacks.DataSource = feedbacks;
                }
                else
                {
                    MessageBox.Show("No feedbacks found for this customer.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
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
                    dgvFeedbacks.DataSource = feedbacks;
                }
                else
                {
                    MessageBox.Show("No feedback records found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }


        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtFeedbackId.Text, out int feedbackId))
            {
                MessageBox.Show("Invalid Feedback ID");
                return;
            }

            var dto = new CreateFeedbackDto
            {
                ReservationId = 0, // Optional: add another textbox if needed
                CustomerId = int.Parse(txtCustomerId.Text),
                Rating = decimal.Parse(textBox1.Text),
                Comments = richTextBox1.Text
            };

            try
            {
                var content = new StringContent(JsonConvert.SerializeObject(dto), Encoding.UTF8, "application/json");
                var response = await _httpClient.PutAsync($"FeedBack/{feedbackId}", content);
                var message = await response.Content.ReadAsStringAsync();
                MessageBox.Show(message);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
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
    }
}

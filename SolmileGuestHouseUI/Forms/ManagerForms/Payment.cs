using System;
using System.Collections.Generic;
using System.Drawing;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using SolmileGuesthouseAPI.DTO.NavigatorModel;

namespace SolmileGuestHouseUI.Forms.ManagerForms
{
    public partial class Payment : UserControl
    {
        private readonly HttpClient _httpClient = new HttpClient
        {
            BaseAddress = new Uri("https://localhost:7107/api/") // Update with your API base URL
        };

        public Payment()
        {
            InitializeComponent();
            WireUpEvents();
        }

        private void WireUpEvents()
        {
            btnGetAll.Click += btnGetAll_Click;
            btnGetById.Click += btnGetById_Click;
            btnAdd.Click += btnAdd_Click;
            btnUpdate.Click += btnUpdate_Click;
            btnDelete.Click += btnDelete_Click;
            btnProcess.Click += btnProcess_Click;
        }

        private async void btnGetAll_Click(object sender, EventArgs e)
        {
            var response = await _httpClient.GetAsync("Payment");
            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                var payments = JsonConvert.DeserializeObject<List<PaymentDto>>(json);
                dgvPayments.DataSource = payments;
            }
        }

        private async void btnGetById_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtPaymentId.Text, out var id)) return;

            var response = await _httpClient.GetAsync($"Payment/{id}");
            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                var payment = JsonConvert.DeserializeObject<PaymentDto>(json);
                dgvPayments.DataSource = new List<PaymentDto> { payment };
            }
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            var dto = new CreatePaymentDto
            {
                BookingID = 1, // Replace with real value
                Amount = 1000f,
                MethodId = 1
            };

            var content = new StringContent(JsonConvert.SerializeObject(dto), Encoding.UTF8, "application/json");
            var response = await _httpClient.PostAsync("Payment", content);
            MessageBox.Show(response.IsSuccessStatusCode ? "Payment created." : "Failed to create.");
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtPaymentId.Text, out var id)) return;

            var dto = new UpdatePaymentDto
            {
                Amount = 1200f, // Replace with real value
                MethodId = 2
            };

            var content = new StringContent(JsonConvert.SerializeObject(dto), Encoding.UTF8, "application/json");
            var response = await _httpClient.PutAsync($"Payment/{id}", content);
            MessageBox.Show(response.IsSuccessStatusCode ? "Payment updated." : "Failed to update.");
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtPaymentId.Text, out var id)) return;

            var response = await _httpClient.DeleteAsync($"Payment/{id}");
            MessageBox.Show(response.IsSuccessStatusCode ? "Deleted successfully." : "Delete failed.");
        }

        private async void btnProcess_Click(object sender, EventArgs e)
        {
            var dto = new ProcessPaymentDto
            {
                ReservationId = "RES123", // Replace with actual ID
                Amount = 1500f,
                MethodId = 1
            };

            var content = new StringContent(JsonConvert.SerializeObject(dto), Encoding.UTF8, "application/json");
            var response = await _httpClient.PostAsync("Payment/process", content);

            var json = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<PaymentResultDto>(json);
            MessageBox.Show(result.Success ? $"Processed: {result.AmountPaid} on {result.PaymentDate}" : result.Message);
        }


    }
}

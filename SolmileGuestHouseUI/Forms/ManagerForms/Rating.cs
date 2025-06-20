using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using SolmileGuesthouseAPI.DTO.NavigatorModel;
using SolmileGuestHouseUI.Forms.AdminForms;
using static SolmileGuesthouseAPI.DTO.NavigatorModel.DTOs;

namespace SolmileGuestHouseUI.Forms.ManagerForms
{
    public partial class Rating : UserControl
    {
        private readonly HttpClient _httpClient = new HttpClient();
        private const string BaseApiUrl = "https://localhost:7107/api/Ratings";

        public Rating()
        {
            InitializeComponent();
            _httpClient.DefaultRequestHeaders.Clear();
        }

        private async void Rating_Load(object sender, EventArgs e)
        {
            await LoadRatingsAsync();
        }

        private async Task LoadRatingsAsync()
        {
            try
            {
                var ratings = await _httpClient.GetFromJsonAsync<List<RatingDto>>($"{BaseApiUrl}");
                dgvRatings.DataSource = ratings;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to load ratings: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task SearchAndShowRatingByIdAsync()
        {
            // Define the async search function expected by SearchByInputForm
            async Task<object> SearchFunc(string input)
            {
                if (int.TryParse(input, out int ratingId))
                {
                    var rating = await _httpClient.GetFromJsonAsync<RatingDto>($"{BaseApiUrl}/{ratingId}");
                    return rating;
                }
                return null;
            }

            using (var searchForm = new SearchByInputForm("Enter Rating ID", SearchFunc))
            {
                if (searchForm.ShowDialog() == DialogResult.OK)
                {
                    if (searchForm.SelectedItem is RatingDto rating)
                    {
                        // Show details in MessageBox
                        MessageBox.Show(
                            $"Rating ID: {rating.RatingId}\nEmployee ID: {rating.EmployeeId}\nValue: {rating.RatingValue}",
                            "Rating Detail");

                        // Optionally, update your form fields with the result
                        txtEmployeeId.Text = rating.EmployeeId.ToString();
                        txtServiceRequestId.Text = rating.ServiceRequestId.ToString();
                        txtRatingValue.Text = rating.RatingValue.ToString();
                        txtGivenBy.Text = rating.GivenBy;

                        // Optionally select this rating in the DataGridView
                        foreach (DataGridViewRow row in dgvRatings.Rows)
                        {
                            if (row.DataBoundItem is RatingDto r && r.RatingId == rating.RatingId)
                            {
                                dgvRatings.ClearSelection();
                                row.Selected = true;
                                dgvRatings.FirstDisplayedScrollingRowIndex = row.Index;
                                break;
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("No rating found for the given ID.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }


        private async Task GetRatingValueOrNA(int serviceRequestId)
        {
            try
            {
                var value = await _httpClient.GetStringAsync($"{BaseApiUrl}/GetRatingValueOrNA/{serviceRequestId}");
                MessageBox.Show($"Rating Value: {value}", "Rating Info");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to fetch rating value: {ex.Message}", "Error");
            }
        }

        private async void btnGetAll_Click(object sender, EventArgs e)
        {
            await LoadRatingsAsync();
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvRatings.CurrentRow?.DataBoundItem is RatingDto selected)
            {
                var confirm = MessageBox.Show("Delete this rating?", "Confirm", MessageBoxButtons.YesNo);
                if (confirm == DialogResult.Yes)
                {
                    try
                    {
                        var response = await _httpClient.DeleteAsync($"{BaseApiUrl}/{selected.RatingId}");
                        if (response.IsSuccessStatusCode)
                        {
                            MessageBox.Show("Deleted successfully.");
                            await LoadRatingsAsync();
                        }
                        else
                        {
                            MessageBox.Show("Delete failed.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error: {ex.Message}");
                    }
                }
            }
        }

        private void dgvRatings_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvRatings.CurrentRow?.DataBoundItem is RatingDto selected)
            {
                txtEmployeeId.Text = selected.EmployeeId.ToString();
                txtServiceRequestId.Text = selected.ServiceRequestId.ToString();
                txtRatingValue.Text = selected.RatingValue.ToString();
                txtGivenBy.Text = selected.GivenBy;
            }
        }

        private async void btnLoadById_Click(object sender, EventArgs e)
        {
            await SearchAndShowRatingByIdAsync();
        }

        private async void btnGetValueNA_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtServiceRequestSearch.Text, out int serviceRequestId))
                await GetRatingValueOrNA(serviceRequestId);
        }
    }
}

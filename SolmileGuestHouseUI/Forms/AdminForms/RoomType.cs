using Newtonsoft.Json;
using System.Net.Http.Headers;
using static SolmileGuesthouseAPI.DTO.NavigatorModel.DTOs;
using System;
using System.Drawing;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Generic;

namespace SolmileGuestHouseUI.Forms.AdminForms
{
    public partial class RoomType : UserControl
    {
        private string selectedImagePath;
        private readonly HttpClient httpClient = new HttpClient();
        private const string BaseUrl = "https://localhost:7107/api/RoomTypes";

        public RoomType()
        {
            InitializeComponent();
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            LoadRoomTypes();
            dgvRoomTypes.CellClick += DgvRoomTypes_CellClick;
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtName.Text)) return;

                var form = CreateFormContent(includeTypeId: true);

                var response = await httpClient.PostAsync(BaseUrl, form);
                response.EnsureSuccessStatusCode();

                MessageBox.Show("Room type added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadRoomTypes();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to add room type: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(txtTypeId.Text, out int id)) return;

                var form = CreateFormContent(includeTypeId: false);

                var response = await httpClient.PutAsync($"{BaseUrl}/{id}", form);
                response.EnsureSuccessStatusCode();

                MessageBox.Show("Room type updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadRoomTypes();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to update room type: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(txtTypeId.Text, out int id)) return;

                var result = MessageBox.Show("Are you sure you want to delete this room type?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    var response = await httpClient.DeleteAsync($"{BaseUrl}/{id}");
                    response.EnsureSuccessStatusCode();

                    MessageBox.Show("Room type deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadRoomTypes();
                    ClearFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to delete room type: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
            LoadRoomTypes();
        }

        private async void LoadRoomTypes()
        {
            try
            {
                var response = await httpClient.GetStringAsync(BaseUrl);
                var data = JsonConvert.DeserializeObject<List<RoomTypeDto>>(response);
                dgvRoomTypes.DataSource = data;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load room types: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearFields()
        {
            txtTypeId.Text = "";
            txtName.Text = "";
            txtTitle.Text = "";
            txtDescription.Text = "";
            txtAmenities.Text = "";
            txtPrice.Text = "";
            txtCapacity.Text = "";
            pictureBox.Image = null;
            selectedImagePath = null;
        }

        private void btnBrowseImage_Click(object sender, EventArgs e)
        {
            using OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                selectedImagePath = ofd.FileName;
                pictureBox.Image = Image.FromFile(selectedImagePath);
            }
        }

        private void DgvRoomTypes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgvRoomTypes.Rows[e.RowIndex];
                txtTypeId.Text = row.Cells["typeId"].Value?.ToString();
                txtName.Text = row.Cells["name"].Value?.ToString();
                txtTitle.Text = row.Cells["title"].Value?.ToString();
                txtDescription.Text = row.Cells["description"].Value?.ToString();
                txtAmenities.Text = row.Cells["amenities"].Value?.ToString();
                txtPrice.Text = row.Cells["pricePerNight"].Value?.ToString();
                txtCapacity.Text = row.Cells["capacity"].Value?.ToString();

                if (row.Cells["imageUrl"].Value is byte[] imageBytes && imageBytes.Length > 0)
                {
                    using var ms = new MemoryStream(imageBytes);
                    pictureBox.Image = Image.FromStream(ms);
                    selectedImagePath = null;
                }
                else
                {
                    pictureBox.Image = null;
                }
            }
        }

        private MultipartFormDataContent CreateFormContent(bool includeTypeId)
        {
            var form = new MultipartFormDataContent();

            if (includeTypeId)
                form.Add(new StringContent(txtTypeId.Text), "TypeId");

            form.Add(new StringContent(txtName.Text), "Name");
            form.Add(new StringContent(txtTitle.Text), "Title");
            form.Add(new StringContent(txtDescription.Text), "Description");
            form.Add(new StringContent(txtAmenities.Text), "Amenities");
            form.Add(new StringContent(txtPrice.Text), "PricePerNight");
            form.Add(new StringContent(txtCapacity.Text), "Capacity");

            if (!string.IsNullOrEmpty(selectedImagePath))
            {
                var imageBytes = File.ReadAllBytes(selectedImagePath);
                var byteContent = new ByteArrayContent(imageBytes);
                byteContent.Headers.ContentType = MediaTypeHeaderValue.Parse("image/jpeg");
                form.Add(byteContent, "ImageUrl", Path.GetFileName(selectedImagePath));
            }

            return form;
        }

        private async Task<object> GetRoomTypeAsync(int id)
        {
            try
            {
                var response = await httpClient.GetAsync($"{BaseUrl}/findRoomTypeById/{id}");
                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<RoomTypeDto>(json);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving room type: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return null;
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            var searchForm = new SearchByIdForm("Search Room Type", GetRoomTypeAsync);
            if (searchForm.ShowDialog() == DialogResult.OK)
            {
                if (searchForm.SelectedItem is RoomTypeDto roomType)
                {
                    dgvRoomTypes.DataSource = new List<RoomTypeDto> { roomType };
                }
            }
        }
    }
}

    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Net.Http.Headers;
    using System.Text;
    using System.Text.Json;
    using System.Threading.Tasks;
    using System.Windows.Forms;
using Newtonsoft.Json;
using SolmileGuesthouseAPI.Data.Models;
    using static SolmileGuesthouseAPI.DTO.NavigatorModel.DTOs;
using JsonSerializer = System.Text.Json.JsonSerializer;
using Task = System.Threading.Tasks.Task;

namespace SolmileGuestHouseUI.Forms.AdminForms
    {
        public partial class Room : UserControl
        {
            private readonly HttpClient httpClient;
            private const string baseUrl = "https://localhost:7107/api/Rooms";
        private const string roomTypeUrl = "https://localhost:7107/api/RoomTypes";
        private const string BranchUrl = "https://localhost:7107/api/Branches";

        public Room()
            {
                InitializeComponent();
                httpClient = new HttpClient();
                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            dgvRooms.CellClick += dgvRooms_CellClick;
            _ = LoadRoomTypesAsync(); // Load combo
            LoadRoomData();
            LoadBranchesAsync();    
        }
            private async void LoadRoomData()
            {
                try
                {
                    var response = await httpClient.GetAsync(baseUrl);
                    response.EnsureSuccessStatusCode();
                    var json = await response.Content.ReadAsStringAsync();
                    var rooms = JsonSerializer.Deserialize<List<RoomDto>>(json);
                    dgvRooms.DataSource = rooms;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to load data: " + ex.Message);
                }
            }

        private async Task LoadRoomTypesAsync()
        {
            try
            {
                var response = await httpClient.GetAsync(roomTypeUrl);
                response.EnsureSuccessStatusCode();

                var json = await response.Content.ReadAsStringAsync();
                var roomTypes = JsonSerializer.Deserialize<List<RoomTypeDto>>(json, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

                cmbTypeId.DataSource = roomTypes;
                cmbTypeId.DisplayMember = "TypeName";
                cmbTypeId.ValueMember = "TypeId";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to load room types:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private async void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate required fields first
                if (string.IsNullOrWhiteSpace(txtRoomId.Text) ||
                    string.IsNullOrWhiteSpace(txtRoomNum.Text) ||
                    cmbBranchList.SelectedValue == null ||
                    cmbTypeId.SelectedValue == null ||
                    cmbStatus.SelectedItem == null)
                {
                    MessageBox.Show("Please fill in all required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var room = new RoomWithRNARequestDto
                {
                    RoomId = txtRoomId.Text.Trim(),
                    BranchId = (int)cmbBranchList.SelectedValue,
                    RoomNumber = Convert.ToInt32(txtRoomNum.Text),
                    Status = cmbStatus.SelectedItem.ToString(),
                    TypeId = (int)cmbTypeId.SelectedValue
                };

                // Send POST request
                var content = new StringContent(JsonSerializer.Serialize(room), Encoding.UTF8, "application/json");
                var response = await httpClient.PostAsync($"{baseUrl}/AddRoomWithRNA", content);

                response.EnsureSuccessStatusCode();
                MessageBox.Show("Room added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadRoomData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to add room:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private async Task LoadBranchesAsync()
        {
            try
            {
                var response = await httpClient.GetAsync(BranchUrl);
                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    var branches = JsonConvert.DeserializeObject<List<BranchDto>>(json);

                    cmbBranchList.DataSource = branches;
                    cmbBranchList.DisplayMember = "DisplayName";
                    cmbBranchList.ValueMember = "BranchId";
                }
                else
                {
                    MessageBox.Show("Failed to load branches.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading branches:\n{ex.Message}", "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                var room = new RoomDto
                {
                    RoomId = txtRoomId.Text,
                    RoomNumberAssignmentId = int.Parse(txtRoomNumberAssignmentId.Text),
                    Status = cmbStatus.SelectedItem?.ToString(),
                    TypeId = Convert.ToInt32(cmbTypeId.SelectedValue)
                };

                var content = new StringContent(JsonSerializer.Serialize(room), Encoding.UTF8, "application/json");
                var response = await httpClient.PutAsync($"{baseUrl}/{room.RoomId}", content);
                response.EnsureSuccessStatusCode();

                MessageBox.Show("Room updated successfully!");
                LoadRoomData();
                txtRoomNum.Enabled = true;
                cmbBranchList.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to update room: " + ex.Message);
            }
        }



        private async void btnDelete_Click(object sender, EventArgs e)
            {
                try
                {
                    var roomId = txtRoomId.Text;
                    var response = await httpClient.DeleteAsync($"{baseUrl}/{roomId}");
                    response.EnsureSuccessStatusCode();
                    MessageBox.Show("Room deleted successfully!");
                    LoadRoomData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to delete room: " + ex.Message);
                }
            }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtRoomId.Clear();
            txtRoomNumberAssignmentId.Clear();
            txtRoomNum.Clear();

            cmbStatus.SelectedIndex = -1;
            cmbTypeId.SelectedIndex = -1;
            cmbBranchList.SelectedIndex = -1;

            // ✅ Re-enable
            txtRoomNum.Enabled = true;
            cmbBranchList.Enabled = true;
        }


        private void dgvRooms_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgvRooms.Rows[e.RowIndex];

                txtRoomId.Text = row.Cells["RoomId"].Value?.ToString();
                txtRoomNumberAssignmentId.Text = row.Cells["RoomNumberAssignmentId"].Value?.ToString();
                cmbStatus.SelectedItem = row.Cells["Status"].Value?.ToString();

                if (cmbTypeId.DataSource != null)
                {
                    cmbTypeId.SelectedValue = Convert.ToInt32(row.Cells["TypeId"].Value);
                }
                txtRoomNum.Enabled = false;
                cmbBranchList.Enabled = false;
            }
        }

    }
}

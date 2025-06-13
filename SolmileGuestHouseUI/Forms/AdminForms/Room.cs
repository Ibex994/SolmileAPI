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
    using SolmileGuesthouseAPI.Data.Models;
    using static SolmileGuesthouseAPI.DTO.NavigatorModel.DTOs;

    namespace SolmileGuestHouseUI.Forms.AdminForms
    {
        public partial class Room : UserControl
        {
            private readonly HttpClient httpClient;
            private const string baseUrl = "https://localhost:7107/api/Rooms";
            public Room()
            {
                InitializeComponent();
                httpClient = new HttpClient();
                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                LoadRoomData();
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
            


            private async void btnAdd_Click(object sender, EventArgs e)
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
                    var response = await httpClient.PostAsync(baseUrl, content);
                    response.EnsureSuccessStatusCode();
                    MessageBox.Show("Room added successfully!");
                    LoadRoomData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to add room: " + ex.Message);
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
                cmbStatus.SelectedIndex = -1;
                cmbTypeId.SelectedIndex = -1;
            }


        }
    }

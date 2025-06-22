using Newtonsoft.Json;
using SolmileGuesthouseAPI.Data.Models;
using SolmileGuesthouseAPI.DTO.NavigatorModel;
using SolmileGuestHouseUI.Forms.AdminForms;
using System.Text;
using static SolmileGuesthouseAPI.DTO.NavigatorModel.DTOs;
using Task = System.Threading.Tasks.Task;

namespace SolmileGuestHouseUI.Forms.ManagerForms
{
    public partial class Employee : UserControl
    {
        private readonly HttpClient _httpClient = new HttpClient
        {
            BaseAddress = new Uri("https://localhost:7107/api/Employees/")
        };
        private readonly HttpClient _branchClient = new HttpClient
        {
            BaseAddress = new Uri("https://localhost:7107/api/Branches")
        };
        private readonly HttpClient _roleClient = new HttpClient
        {
            BaseAddress = new Uri("https://localhost:7107/api/Role")
        };
        public Employee()
        {
            InitializeComponent();
            _ = LoadBranchesAsync();
            _ = LoadAllEmployeesAsync();
            _ = LoadRolesAsync();
        }

        private async Task LoadBranchesAsync()
        {
            try
            {
                var response = await _branchClient.GetAsync("");
                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    var branches = JsonConvert.DeserializeObject<List<SolmileGuesthouseAPI.Data.Models.Branch>>(json);
                    cmbBranch.DataSource = branches;
                    cmbBranch.DisplayMember = "Name";
                    cmbBranch.ValueMember = "BranchId";
                }
                else
                {
                    MessageBox.Show("Failed to load branches.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading branches: " + ex.Message);
            }
        }

        private async Task LoadAllEmployeesAsync()
        {
            try
            {
                var response = await _httpClient.GetAsync("");
                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    var employees = JsonConvert.DeserializeObject<List<EmployeeDto>>(json);
                    dgvEmployees.DataSource = employees;
                }
                else
                {
                    MessageBox.Show("Failed to load employees.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading employees: " + ex.Message);
            }
        }

        private EmployeeDto GetEmployeeFromForm()
        {
            return new EmployeeDto
            {
                Id = int.TryParse(txtEmployeeId.Text, out var id) ? id : 0,
                FirstName = txtFirstName.Text?.Trim(),
                LastName = txtLastName.Text?.Trim(),
                Email = txtEmail.Text?.Trim(),
                Phone = txtPhone.Text?.Trim(),
                Position = cmbPosition?.SelectedValue?.ToString() ?? "",
                DateOfBirth = dtpDateOfBirth.Value,
                HireDate = dtpHireDate.Value,
                Status = rbtnActive.Checked,
                Gender = cmbGender?.SelectedItem?.ToString() ?? "",
                BranchId = int.TryParse(cmbBranch?.SelectedValue?.ToString(), out var bId) ? bId : 0,
                EmployeePhotoUrl = pictureBox1.Image != null
                    ? Convert.ToBase64String(ImageToByteArray(pictureBox1.Image))
                    : null
            };
        }


        private void SetFormFromEmployee(EmployeeDto emp)
        {
            if (emp == null) return;

            txtEmployeeId.Text = emp.Id.ToString();
            txtFirstName.Text = emp.FirstName;
            txtLastName.Text = emp.LastName;
            txtEmail.Text = emp.Email;
            txtPhone.Text = emp.Phone;
            cmbPosition.SelectedValue = emp.Position;
            dtpDateOfBirth.Value = emp.DateOfBirth;
            dtpHireDate.Value = emp.HireDate;
            rbtnActive.Checked = emp.Status;
            rbtnInactive.Checked = !emp.Status;
            cmbGender.SelectedItem = emp.Gender;
            cmbBranch.SelectedValue = emp.BranchId;

            if (!string.IsNullOrEmpty(emp.EmployeePhotoUrl))
            {
                pictureBox1.Image = ByteArrayToImage(Convert.FromBase64String(emp.EmployeePhotoUrl));
            }
            else
            {
                pictureBox1.Image = Properties.Resources.icons8_user_48;
            }
        }


        private byte[] ImageToByteArray(Image image)
        {
            using var ms = new MemoryStream();
            image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
            return ms.ToArray();
        }

        private Image ByteArrayToImage(byte[] bytes)
        {
            using var ms = new MemoryStream(bytes);
            return Image.FromStream(ms);
        }

        private void ClearForm()
        {
            try
            {
                txtEmployeeId.Text = string.Empty;
                txtFirstName.Text = string.Empty;
                txtLastName.Text = string.Empty;
                txtEmail.Text = string.Empty;
                txtPhone.Text = string.Empty;
                if (cmbGender != null)
                {
                    cmbGender.SelectedIndex = -1;
                }
                if (cmbPosition != null)
                {
                    cmbPosition.SelectedIndex = -1;
                }
                if (cmbBranch != null)
                {
                    cmbBranch.SelectedIndex = -1;
                }
                if (grpStatus != null)
                {
                    rbtnActive.Checked = true;
                }
                if (dtpDateOfBirth != null)
                {
                    dtpDateOfBirth.Value = DateTime.Today;
                }

                if (dtpHireDate != null)
                {
                    dtpHireDate.Value = DateTime.Today;
                }
                if (pictureBox1 != null)
                {
                    pictureBox1.Image = Properties.Resources.icons8_user_48;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error clearing form: {ex.Message}", "Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnCreateAccount_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtFirstName.Text) ||
                    string.IsNullOrWhiteSpace(txtLastName.Text) ||
                    string.IsNullOrWhiteSpace(txtEmail.Text) ||
                    string.IsNullOrWhiteSpace(txtPhone.Text))
                {
                    MessageBox.Show("Please fill in all required fields (First Name, Last Name, Email, Phone).", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (cmbGender.SelectedIndex < 0 || cmbBranch.SelectedIndex < 0)
                {
                    MessageBox.Show("Please select Gender and Branch.", "Missing Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var employee = GetEmployeeFromForm();

                var content = new MultipartFormDataContent();

                content.Add(new StringContent(employee.FirstName), "FirstName");
                content.Add(new StringContent(employee.LastName), "LastName");
                content.Add(new StringContent(employee.Position ?? ""), "Position");
                content.Add(new StringContent(employee.Phone), "Phone");
                content.Add(new StringContent(employee.Email), "Email");
                content.Add(new StringContent(employee.DateOfBirth.ToString("yyyy-MM-dd")), "DateOfBirth");
                content.Add(new StringContent(employee.HireDate.ToString("yyyy-MM-dd")), "HireDate");
                content.Add(new StringContent(employee.Status.ToString()), "Status");
                content.Add(new StringContent(employee.Gender), "Gender");
                content.Add(new StringContent(employee.BranchId.ToString()), "BranchId");

                if (pictureBox1.Image != null)
                {
                    byte[] imageBytes = ImageToByteArray(pictureBox1.Image);
                    var imageContent = new ByteArrayContent(imageBytes);
                    imageContent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("image/jpeg");
                    content.Add(imageContent, "EmployeePhotoUrl", "photo.jpg");
                }

                var response = await _httpClient.PostAsync("CreateAccount", content);
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Employee created successfully.");
                    await LoadAllEmployeesAsync();
                    ClearForm();
                }
                else
                {
                    var errorContent = await response.Content.ReadAsStringAsync();

                    var validationErrors = new StringBuilder("Failed to create employee.\n\n");

                    dynamic errorObj = JsonConvert.DeserializeObject(errorContent);
                    if (errorObj != null && errorObj.errors != null)
                    {
                        foreach (var field in errorObj.errors)
                        {
                            string fieldName = field.Name;
                            foreach (var message in field.Value)
                            {
                                validationErrors.AppendLine($"{fieldName}: {message}");
                            }
                        }
                    }
                    else
                    {
                        validationErrors.AppendLine(errorContent);
                    }

                    MessageBox.Show(validationErrors.ToString(), "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error creating employee: " + ex.Message);
            }
        }

        private async Task LoadRolesAsync()
        {
            try
            {
                var response = await _roleClient.GetAsync("");
                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    var roles = JsonConvert.DeserializeObject<List<RoleReadDto>>(json);

                    cmbPosition.DataSource = roles;
                    cmbPosition.DisplayMember = "Name";
                    cmbPosition.ValueMember = "Name";
                }
                else
                {
                    MessageBox.Show("Failed to load roles.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading roles: " + ex.Message);
            }
        }
        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtFirstName.Text) ||
                    string.IsNullOrWhiteSpace(txtLastName.Text) ||
                    string.IsNullOrWhiteSpace(txtEmail.Text) ||
                    string.IsNullOrWhiteSpace(txtPhone.Text))
                {
                    MessageBox.Show("Please fill in all required fields (First Name, Last Name, Email, Phone).", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (cmbGender.SelectedIndex < 0 || cmbBranch.SelectedIndex < 0)
                {
                    MessageBox.Show("Please select Gender and Branch.", "Missing Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var employee = GetEmployeeFromForm();
                if (employee.Id == 0)
                {
                    MessageBox.Show("Please enter a valid Employee ID to update.");
                    return;
                }

                var content = new MultipartFormDataContent();

                content.Add(new StringContent(employee.FirstName ?? ""), "FirstName");
                content.Add(new StringContent(employee.LastName ?? ""), "LastName");
                content.Add(new StringContent(employee.Position ?? ""), "Position");
                content.Add(new StringContent(employee.Phone ?? ""), "Phone");
                content.Add(new StringContent(employee.Email ?? ""), "Email");
                content.Add(new StringContent(employee.DateOfBirth.ToString("yyyy-MM-dd")), "DateOfBirth");
                content.Add(new StringContent(employee.HireDate.ToString("yyyy-MM-dd")), "HireDate");
                content.Add(new StringContent(employee.Status.ToString()), "Status");
                content.Add(new StringContent(employee.Gender ?? ""), "Gender");
                content.Add(new StringContent(employee.BranchId.ToString()), "BranchId");

                if (pictureBox1.Image != null)
                {
                    byte[] imageBytes = ImageToByteArray(pictureBox1.Image);
                    var imageContent = new ByteArrayContent(imageBytes);
                    imageContent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("image/jpeg");
                    content.Add(imageContent, "EmployeePhotoUrl", "photo.jpg");
                }

                var response = await _httpClient.PutAsync($"{employee.Id}", content);

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Employee updated successfully.");
                    ClearForm();
                    await LoadAllEmployeesAsync();

                }
                else
                {
                    var errorContent = await response.Content.ReadAsStringAsync();
                    var validationErrors = new StringBuilder("Failed to update employee.\n\n");

                    dynamic errorObj = JsonConvert.DeserializeObject(errorContent);
                    if (errorObj != null && errorObj.errors != null)
                    {
                        foreach (var field in errorObj.errors)
                        {
                            string fieldName = field.Name;
                            foreach (var message in field.Value)
                            {
                                validationErrors.AppendLine($"{fieldName}: {message}");
                            }
                        }
                    }
                    else
                    {
                        validationErrors.AppendLine(errorContent);
                    }

                    MessageBox.Show(validationErrors.ToString(), "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating employee: " + ex.Message);
            }
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(txtEmployeeId.Text, out int employeeId) || employeeId == 0)
                {
                    MessageBox.Show("Please enter a valid Employee ID to delete.");
                    return;
                }

                var confirmResult = MessageBox.Show("Are you sure to delete this employee?", "Confirm Delete", MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    var response = await _httpClient.DeleteAsync(employeeId.ToString());
                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Employee deleted successfully.");
                        await LoadAllEmployeesAsync();
                        ClearForm();
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete employee.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting employee: " + ex.Message);
            }
        }

        private async void btnFindById_Click(object sender, EventArgs e)
        {
            async Task<object> SearchEmployeeByQuery(string input)
            {
                if (string.IsNullOrWhiteSpace(input))
                {
                    MessageBox.Show("Please enter a valid Employee ID or Username.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return null;
                }

                try
                {
                    HttpResponseMessage response;

                    if (int.TryParse(input, out int employeeId))
                    {
                        response = await _httpClient.GetAsync($"FindById/{employeeId}");

                        if (response.IsSuccessStatusCode)
                        {
                            var json = await response.Content.ReadAsStringAsync();
                            var employee = JsonConvert.DeserializeObject<EmployeeDto>(json);
                            return employee;
                        }
                    }

                    // Search by username returns single employee now
                    response = await _httpClient.GetAsync($"Search?query={Uri.EscapeDataString(input)}");

                    if (response.IsSuccessStatusCode)
                    {
                        var json = await response.Content.ReadAsStringAsync();
                        var employee = JsonConvert.DeserializeObject<EmployeeDto>(json);

                        if (employee != null)
                        {
                            return employee;
                        }
                    }

                    MessageBox.Show("No matching employee found.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return null;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error retrieving employee: " + ex.Message);
                    return null;
                }
            }

            using var searchForm = new SearchByInputForm("Enter Employee ID or Username", SearchEmployeeByQuery);
            var result = searchForm.ShowDialog();

            if (result == DialogResult.OK && searchForm.SelectedItem is EmployeeDto emp)
            {
                SetFormFromEmployee(emp);
            }
        }

        private void pictureBoxEmployee_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Title = "Select Employee Photo";
                ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        pictureBox1.Image = Image.FromFile(ofd.FileName);
                        pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Failed to load image: " + ex.Message);
                    }
                }
            }
        }


        private async void dgvEmployees_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    DataGridViewRow row = dgvEmployees.Rows[e.RowIndex];
                    if (row.Cells["Id"].Value != null && int.TryParse(row.Cells["Id"].Value.ToString(), out int employeeId))
                    {
                        var response = await _httpClient.GetAsync($"FindById/{employeeId}");
                        if (response.IsSuccessStatusCode)
                        {
                            var json = await response.Content.ReadAsStringAsync();
                            var employee = JsonConvert.DeserializeObject<EmployeeDto>(json);
                            SetFormFromEmployee(employee);
                        }
                        else
                        {
                            MessageBox.Show("Failed to retrieve employee details.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid Employee ID selected.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading employee data: " + ex.Message);
                }
            }
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }
    }
}

using System.Text;
using Newtonsoft.Json;
using System.Net.Http;
using SolmileGuesthouseAPI.DTO.NavigatorModel;
using SolmileGuestHouseUI.Forms.AdminForms;

namespace SolmileGuestHouseUI.Forms.HRForms
{
    public partial class Tax : UserControl
    {
        private readonly HttpClient _httpClient;
        private const string BaseApiUrl = "https://localhost:7107/api/";
        private const string TaxUrl = "https://localhost:7107/api/";

        public Tax()
        {
            InitializeComponent();
            _httpClient = new HttpClient { BaseAddress = new Uri(BaseApiUrl) };
            _httpClient.DefaultRequestHeaders.Accept.Clear();
            //_httpClient.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

            this.Load += Tax_Load;

            btnRefreshEmpTaxList.Click += BtnRefreshEmpTaxList_Click;
            btnSaveEmpTax.Click += BtnSaveEmpTax_Click;
            btnClearEmpTaxFields.Click += BtnClearEmpTaxFields_Click;
            btnLoadEmpTaxForEdit.Click += BtnLoadEmpTaxForEdit_Click;
            btnDeleteEmpTax.Click += BtnDeleteEmpTax_Click;
            dgvEmployeeTaxes.CellDoubleClick += DgvEmployeeTaxes_CellDoubleClick;
            btnRefreshBracketsList.Click += BtnRefreshBracketsList_Click;
            btnSaveBracket.Click += BtnSaveBracket_Click;
            btnClearBracketFields.Click += BtnClearBracketFields_Click;
            btnLoadBracketForEdit.Click += BtnLoadBracketForEdit_Click;
            btnDeleteBracket.Click += BtnDeleteBracket_Click;
            dgvTaxBrackets.CellDoubleClick += DgvTaxBrackets_CellDoubleClick;
            btnCalculateTax.Click += BtnCalculateTax_Click;
            btnViewTaxSummary.Click += BtnViewTaxSummary_Click;
        }

        private async void Tax_Load(object sender, EventArgs e)
        {
            await LoadEmployeeTaxesAsync();
            await LoadTaxBracketsAsync();
        }

        private void ShowMessage(string message, string title, MessageBoxIcon icon)
        {
            MessageBox.Show(this, message, title, MessageBoxButtons.OK, icon);
        }

        private async Task LoadEmployeeTaxesAsync()
        {
            try
            {
                HttpResponseMessage response = await _httpClient.GetAsync("Tax");
                response.EnsureSuccessStatusCode();

                var jsonResponse = await response.Content.ReadAsStringAsync();
                var taxes = JsonConvert.DeserializeObject<List<TaxDto>>(jsonResponse);

                dgvEmployeeTaxes.DataSource = taxes;
                if (dgvEmployeeTaxes.Columns.Contains("TaxId")) dgvEmployeeTaxes.Columns["TaxId"].HeaderText = "Tax ID";
                if (dgvEmployeeTaxes.Columns.Contains("EmployeeId")) dgvEmployeeTaxes.Columns["EmployeeId"].HeaderText = "Employee ID";
                if (dgvEmployeeTaxes.Columns.Contains("TaxRate")) dgvEmployeeTaxes.Columns["TaxRate"].HeaderText = "Tax Rate";
                if (dgvEmployeeTaxes.Columns.Contains("TaxAmount")) dgvEmployeeTaxes.Columns["TaxAmount"].HeaderText = "Tax Amount";
            }
            catch (HttpRequestException ex)
            {
                ShowMessage($"Error loading employee tax records: {ex.Message}", "API Error", MessageBoxIcon.Error);
                dgvEmployeeTaxes.DataSource = null;
            }
            catch (JsonException ex)
            {
                ShowMessage($"Error parsing employee tax records data: {ex.Message}", "Data Error", MessageBoxIcon.Error);
                dgvEmployeeTaxes.DataSource = null;
            }
            catch (Exception ex)
            {
                ShowMessage($"An unexpected error occurred while loading employee taxes: {ex.Message}", "Error", MessageBoxIcon.Error);
                dgvEmployeeTaxes.DataSource = null;
            }
        }

        private async void BtnRefreshEmpTaxList_Click(object sender, EventArgs e)
        {
            await LoadEmployeeTaxesAsync();
        }

        private async void BtnSaveEmpTax_Click(object sender, EventArgs e)
        {
            if (!decimal.TryParse(txtGrossSalary.Text, out decimal grossSalary)) 
            {
                ShowMessage("Please enter a valid numeric value for Gross Salary.", "Input Error", MessageBoxIcon.Warning);
                return;
            }
            if (!int.TryParse(txtEmpId.Text, out int employeeId))
            {
                ShowMessage("Please enter a valid numeric value for Employee ID.", "Input Error", MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (string.IsNullOrWhiteSpace(txtEmpTaxId.Text) || txtEmpTaxId.ReadOnly == false)
                {
                    var createDto = new CreateTaxDto
                    {
                        EmployeeId = employeeId,
                        GrossSalary = grossSalary
                    };

                    var jsonContent = new StringContent(JsonConvert.SerializeObject(createDto), Encoding.UTF8, "application/json");
                    HttpResponseMessage response = await _httpClient.PostAsync("Tax", jsonContent);

                    if (response.IsSuccessStatusCode)
                    {
                        ShowMessage("Employee Tax Record created successfully!", "Success", MessageBoxIcon.Information);
                        ClearEmpTaxFields();
                        await LoadEmployeeTaxesAsync();
                    }
                    else
                    {
                        var errorContent = await response.Content.ReadAsStringAsync();
                        ShowMessage($"Error creating tax record: {response.ReasonPhrase}\nDetails: {errorContent}", "API Error", MessageBoxIcon.Error);
                    }
                }
                else
                {
                    if (!int.TryParse(txtEmpTaxId.Text, out int taxId))
                    {
                        ShowMessage("Invalid Tax Record ID for update. Please load a record first.", "Input Error", MessageBoxIcon.Warning);
                        return;
                    }

                    decimal taxAmount = 0;
                    decimal.TryParse(txtTaxAmount.Text, out taxAmount);

                    var updateDto = new UpdateTaxDto
                    {
                        EmployeeId = employeeId,
                        TaxRate = 0,
                        TaxAmount = taxAmount
                    };

                    var jsonContent = new StringContent(JsonConvert.SerializeObject(updateDto), Encoding.UTF8, "application/json");
                    HttpResponseMessage response = await _httpClient.PutAsync($"Tax/{taxId}", jsonContent);

                    if (response.IsSuccessStatusCode)
                    {
                        ShowMessage("Employee Tax Record updated successfully!", "Success", MessageBoxIcon.Information);
                        ClearEmpTaxFields();
                        await LoadEmployeeTaxesAsync();
                    }
                    else if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
                    {
                        ShowMessage("Tax record not found for update.", "Not Found", MessageBoxIcon.Warning);
                    }
                    else
                    {
                        var errorContent = await response.Content.ReadAsStringAsync();
                        ShowMessage($"Error updating tax record: {response.ReasonPhrase}\nDetails: {errorContent}", "API Error", MessageBoxIcon.Error);
                    }
                }
            }
            catch (HttpRequestException ex)
            {
                ShowMessage($"API communication error during save: {ex.Message}", "Connection Error", MessageBoxIcon.Error);
            }
            catch (JsonException ex)
            {
                ShowMessage($"Error serializing/deserializing data during save: {ex.Message}", "Data Error", MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                ShowMessage($"An unexpected error occurred during save: {ex.Message}", "Error", MessageBoxIcon.Error);
            }
        }


        private void BtnClearEmpTaxFields_Click(object sender, EventArgs e)
        {
            ClearEmpTaxFields();
        }

        private void ClearEmpTaxFields()
        {
            txtEmpTaxId.Clear();
            txtEmpId.Clear();
            txtGrossSalary.Clear();
            txtTaxAmount.Clear();
            txtEmpTaxId.ReadOnly = false;
            lblGrossSalary.Text = "Gross Salary";
        }

        private async void BtnLoadEmpTaxForEdit_Click(object sender, EventArgs e)
        {
            var form = new SearchByInputForm("Enter Tax ID", async (input) =>
            {
                if (int.TryParse(input, out int taxId))
                {
                    var response = await _httpClient.GetAsync($"Tax/{taxId}");
                    if (response.IsSuccessStatusCode)
                    {
                        var json = await response.Content.ReadAsStringAsync();
                        var tax = JsonConvert.DeserializeObject<TaxDto>(json);
                        return tax;
                    }
                }
                return null;
            });

            if (form.ShowDialog() == DialogResult.OK && form.SelectedItem is TaxDto selectedTax)
            {
                txtEmpTaxId.Text = selectedTax.TaxId.ToString();
                lblGrossSalary.Text = "Tax Rate";
                await LoadEmployeeTaxByIdForEdit(selectedTax.TaxId);
            }
        }

        private async void DgvEmployeeTaxes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvEmployeeTaxes.Rows.Count)
            {
                var selectedTax = dgvEmployeeTaxes.Rows[e.RowIndex].DataBoundItem as TaxDto;
                lblGrossSalary.Text = "Tax Rate";
                if (selectedTax != null)
                {
                    await LoadEmployeeTaxByIdForEdit(selectedTax.TaxId);
                }
            }
        }

        private async Task LoadEmployeeTaxByIdForEdit(int taxId)
        {
            try
            {
                HttpResponseMessage response = await _httpClient.GetAsync($"Tax/{taxId}");
                if (response.IsSuccessStatusCode)
                {
                    var jsonResponse = await response.Content.ReadAsStringAsync();
                    var tax = JsonConvert.DeserializeObject<TaxDto>(jsonResponse);

                    txtEmpTaxId.Text = tax.TaxId.ToString();
                    txtEmpId.Text = tax.EmployeeId.ToString();
                    txtGrossSalary.Text = tax.TaxRate.ToString();
                    txtTaxAmount.Text = tax.TaxAmount.ToString();
                    txtEmpTaxId.ReadOnly = true;
                }
                else if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
                {
                    ShowMessage($"Tax record with ID {taxId} not found.", "Not Found", MessageBoxIcon.Warning);
                    ClearEmpTaxFields();
                }
                else
                {
                    var errorContent = await response.Content.ReadAsStringAsync();
                    ShowMessage($"Error loading tax record for edit: {response.ReasonPhrase}\nDetails: {errorContent}", "API Error", MessageBoxIcon.Error);
                }
            }
            catch (HttpRequestException ex)
            {
                ShowMessage($"API communication error while loading tax record: {ex.Message}", "Connection Error", MessageBoxIcon.Error);
            }
            catch (JsonException ex)
            {
                ShowMessage($"Error parsing tax record data for edit: {ex.Message}", "Data Error", MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                ShowMessage($"An unexpected error occurred while loading tax record: {ex.Message}", "Error", MessageBoxIcon.Error);
            }
        }

        private async void BtnDeleteEmpTax_Click(object sender, EventArgs e)
        {
            if (dgvEmployeeTaxes.SelectedRows.Count == 0)
            {
                ShowMessage("Please select a tax record to delete.", "No Selection", MessageBoxIcon.Warning);
                return;
            }

            var result = MessageBox.Show("Are you sure you want to delete the selected tax record?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                return;
            }

            var selectedTax = dgvEmployeeTaxes.SelectedRows[0].DataBoundItem as TaxDto;
            if (selectedTax == null)
            {
                ShowMessage("Could not retrieve selected tax record data for deletion.", "Error", MessageBoxIcon.Error);
                return;
            }

            try
            {
                HttpResponseMessage response = await _httpClient.DeleteAsync($"Tax/{selectedTax.TaxId}");

                if (response.IsSuccessStatusCode)
                {
                    ShowMessage("Employee Tax Record deleted successfully!", "Success", MessageBoxIcon.Information);
                    await LoadEmployeeTaxesAsync();
                    ClearEmpTaxFields();
                }
                else if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
                {
                    ShowMessage("Tax record not found for deletion.", "Not Found", MessageBoxIcon.Warning);
                }
                else
                {
                    var errorContent = await response.Content.ReadAsStringAsync();
                    ShowMessage($"Error deleting tax record: {response.ReasonPhrase}\nDetails: {errorContent}", "API Error", MessageBoxIcon.Error);
                }
            }
            catch (HttpRequestException ex)
            {
                ShowMessage($"API communication error during delete: {ex.Message}", "Connection Error", MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                ShowMessage($"An unexpected error occurred during delete: {ex.Message}", "Error", MessageBoxIcon.Error);
            }
        }

        private async Task LoadTaxBracketsAsync()
        {
            try
            {
                HttpResponseMessage response = await _httpClient.GetAsync("TaxBracket/all");
                response.EnsureSuccessStatusCode();

                var jsonResponse = await response.Content.ReadAsStringAsync();
                var brackets = JsonConvert.DeserializeObject<List<TaxBracketDto>>(jsonResponse);

                dgvTaxBrackets.DataSource = brackets;
                if (dgvTaxBrackets.Columns.Contains("Id")) dgvTaxBrackets.Columns["Id"].HeaderText = "Bracket ID";
                if (dgvTaxBrackets.Columns.Contains("From")) dgvTaxBrackets.Columns["From"].HeaderText = "From Income";
                if (dgvTaxBrackets.Columns.Contains("To")) dgvTaxBrackets.Columns["To"].HeaderText = "To Income";
                if (dgvTaxBrackets.Columns.Contains("RatePercent")) dgvTaxBrackets.Columns["RatePercent"].HeaderText = "Rate (%)";
                if (dgvTaxBrackets.Columns.Contains("Deductible")) dgvTaxBrackets.Columns["Deductible"].HeaderText = "Deductible";
            }
            catch (HttpRequestException ex)
            {
                ShowMessage($"Error loading tax brackets: {ex.Message}", "API Error", MessageBoxIcon.Error);
                dgvTaxBrackets.DataSource = null;
            }
            catch (JsonException ex)
            {
                ShowMessage($"Error parsing tax bracket data: {ex.Message}", "Data Error", MessageBoxIcon.Error);
                dgvTaxBrackets.DataSource = null;
            }
            catch (Exception ex)
            {
                ShowMessage($"An unexpected error occurred while loading tax brackets: {ex.Message}", "Error", MessageBoxIcon.Error);
                dgvTaxBrackets.DataSource = null;
            }
        }

        private async void BtnRefreshBracketsList_Click(object sender, EventArgs e)
        {
            await LoadTaxBracketsAsync();
        }

        private async void BtnSaveBracket_Click(object sender, EventArgs e)
        {
            if (!decimal.TryParse(txtFrom.Text, out decimal fromAmount) ||
                !decimal.TryParse(txtTo.Text, out decimal toAmount) ||
                !decimal.TryParse(txtRatePercent.Text, out decimal ratePercent) ||
                !decimal.TryParse(txtDeductible.Text, out decimal deductible))
            {
                ShowMessage("Please enter valid numeric values for all bracket fields (From, To, Rate, Deductible).", "Input Error", MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (string.IsNullOrWhiteSpace(txtBracketId.Text) || txtBracketId.ReadOnly == false)
                {
                    var createDto = new CreateTaxBracketDto
                    {
                        From = fromAmount,
                        To = toAmount,
                        RatePercent = ratePercent,
                        Deductible = deductible
                    };

                    var jsonContent = new StringContent(JsonConvert.SerializeObject(createDto), Encoding.UTF8, "application/json");
                    HttpResponseMessage response = await _httpClient.PostAsync("TaxBracket/create", jsonContent);

                    if (response.IsSuccessStatusCode)
                    {
                        ShowMessage("Tax Bracket created successfully!", "Success", MessageBoxIcon.Information);
                        ClearBracketFields();
                        await LoadTaxBracketsAsync();
                    }
                    else
                    {
                        var errorContent = await response.Content.ReadAsStringAsync();
                        ShowMessage($"Error creating tax bracket: {response.ReasonPhrase}\nDetails: {errorContent}", "API Error", MessageBoxIcon.Error);
                    }
                }
                else
                {
                    ShowMessage("Update functionality not available. TaxBracketController needs PUT endpoint.", "Feature Not Available", MessageBoxIcon.Warning);
                }
            }
            catch (HttpRequestException ex)
            {
                ShowMessage($"API communication error during save: {ex.Message}", "Connection Error", MessageBoxIcon.Error);
            }
            catch (JsonException ex)
            {
                ShowMessage($"Error serializing/deserializing data during save: {ex.Message}", "Data Error", MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                ShowMessage($"An unexpected error occurred during save: {ex.Message}", "Error", MessageBoxIcon.Error);
            }
        }

        private void BtnClearBracketFields_Click(object sender, EventArgs e)
        {
            ClearBracketFields();
        }

        private void ClearBracketFields()
        {
            txtBracketId.Clear();
            txtFrom.Clear();
            txtTo.Clear();
            txtRatePercent.Clear();
            txtDeductible.Clear();
            txtBracketId.ReadOnly = false;
        }

        private async void BtnLoadBracketForEdit_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtBracketId.Text, out int bracketId))
            {
                ShowMessage("Please enter a valid Bracket ID to load.", "Input Error", MessageBoxIcon.Warning);
                return;
            }
            await LoadTaxBracketByIdForEdit(bracketId);
        }

        private async void DgvTaxBrackets_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvTaxBrackets.Rows.Count)
            {
                var selectedBracket = dgvTaxBrackets.Rows[e.RowIndex].DataBoundItem as TaxBracketDto;

                if (selectedBracket != null)
                {
                    await LoadTaxBracketByIdForEdit(selectedBracket.Id);
                }
            }
        }


        private async Task LoadTaxBracketByIdForEdit(int bracketId)
        {
            try
            {
                HttpResponseMessage response = await _httpClient.GetAsync($"TaxBracket/{bracketId}");
                if (response.IsSuccessStatusCode)
                {
                    var jsonResponse = await response.Content.ReadAsStringAsync();
                    var bracket = JsonConvert.DeserializeObject<TaxBracketDto>(jsonResponse);

                    txtBracketId.Text = bracket.Id.ToString();
                    txtFrom.Text = bracket.From.ToString();
                    txtTo.Text = bracket.To.ToString();
                    txtRatePercent.Text = bracket.RatePercent.ToString();
                    txtDeductible.Text = bracket.Deductible.ToString();
                    txtBracketId.ReadOnly = true;
                }
                else if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
                {
                    ShowMessage($"Tax bracket with ID {bracketId} not found.", "Not Found", MessageBoxIcon.Warning);
                    ClearBracketFields();
                }
                else
                {
                    var errorContent = await response.Content.ReadAsStringAsync();
                    ShowMessage($"Error loading tax bracket for edit: {response.ReasonPhrase}\nDetails: {errorContent}", "API Error", MessageBoxIcon.Error);
                }
            }
            catch (HttpRequestException ex)
            {
                ShowMessage($"API communication error while loading tax bracket: {ex.Message}", "Connection Error", MessageBoxIcon.Error);
            }
            catch (JsonException ex)
            {
                ShowMessage($"Error parsing tax bracket data for edit: {ex.Message}", "Data Error", MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                ShowMessage($"An unexpected error occurred while loading tax bracket: {ex.Message}", "Error", MessageBoxIcon.Error);
            }
        }

        private async void BtnDeleteBracket_Click(object sender, EventArgs e)
        {
            ShowMessage("Delete functionality not available. TaxBracketController needs DELETE endpoint.", "Feature Not Available", MessageBoxIcon.Warning);
        }

        private async void BtnCalculateTax_Click(object sender, EventArgs e)
        {
            if (!decimal.TryParse(txtSalaryForCalculation.Text, out decimal salary))
            {
                ShowMessage("Please enter a valid numeric value for Gross Salary to calculate.", "Input Error", MessageBoxIcon.Warning);
                lblCalculatedTaxResultValue.Text = "N/A";
                return;
            }

            try
            {
                var salaryDto = new GrossSalaryDto
                {
                    GrossSalary = salary
                };

                var jsonContent = new StringContent(JsonConvert.SerializeObject(salaryDto), Encoding.UTF8, "application/json");
                HttpResponseMessage response = await _httpClient.PostAsync("TaxBracket/calculate", jsonContent);

                if (response.IsSuccessStatusCode)
                {
                    var jsonResponse = await response.Content.ReadAsStringAsync();
                    var taxResult = JsonConvert.DeserializeObject<TaxResultDto>(jsonResponse);

                    lblCalculatedTaxResultValue.Text = taxResult.TaxAmount.ToString("C2");
                    ShowMessage($"Tax calculation successful!\nGross Salary: {taxResult.GrossSalary:C2}\nTax Rate: {taxResult.TaxRateApplied}%\nDeductible: {taxResult.Deductible:C2}\nTax Amount: {taxResult.TaxAmount:C2}\nNet Salary: {taxResult.NetSalary:C2}", "Success", MessageBoxIcon.Information);
                }
                else if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
                {
                    ShowMessage("No applicable tax bracket found for the given salary.", "Calculation Error", MessageBoxIcon.Warning);
                    lblCalculatedTaxResultValue.Text = "N/A";
                }
                else if (response.StatusCode == System.Net.HttpStatusCode.BadRequest)
                {
                    var errorContent = await response.Content.ReadAsStringAsync();
                    ShowMessage($"Invalid salary amount: {errorContent}", "Input Error", MessageBoxIcon.Warning);
                    lblCalculatedTaxResultValue.Text = "N/A";
                }
                else
                {
                    var errorContent = await response.Content.ReadAsStringAsync();
                    ShowMessage($"Error calculating tax: {response.ReasonPhrase}\nDetails: {errorContent}", "API Error", MessageBoxIcon.Error);
                    lblCalculatedTaxResultValue.Text = "N/A";
                }
            }
            catch (HttpRequestException ex)
            {
                ShowMessage($"API communication error during tax calculation: {ex.Message}", "Connection Error", MessageBoxIcon.Error);
                lblCalculatedTaxResultValue.Text = "N/A";
            }
            catch (JsonException ex)
            {
                ShowMessage($"Error parsing tax calculation result: {ex.Message}", "Data Error", MessageBoxIcon.Error);
                lblCalculatedTaxResultValue.Text = "N/A";
            }
            catch (Exception ex)
            {
                ShowMessage($"An unexpected error occurred during tax calculation: {ex.Message}", "Error", MessageBoxIcon.Error);
                lblCalculatedTaxResultValue.Text = "N/A";
            }
        }

        private async void BtnViewTaxSummary_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtEmployeeSummaryId.Text, out int employeeId))
            {
                ShowMessage("Please enter a valid numeric Employee ID for tax summary.", "Input Error", MessageBoxIcon.Warning);
                rtbTaxSummaryOutput.Text = "";
                return;
            }

            try
            {
                HttpResponseMessage response = await _httpClient.GetAsync($"Tax/employee/{employeeId}");
                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    var taxList = JsonConvert.DeserializeObject<List<TaxDto>>(json);

                    if (taxList == null || taxList.Count == 0)
                    {
                        rtbTaxSummaryOutput.Text = "No tax records found.";
                        return;
                    }

                    var output = new StringBuilder();
                    output.AppendLine($"Tax Summary for Employee ID: {employeeId}");
                    output.AppendLine("--------------------------------------------");

                    foreach (var tax in taxList)
                    {
                        output.AppendLine($"Tax ID: {tax.TaxId}");
                        output.AppendLine($"Rate: {tax.TaxRate}%");
                        //output.AppendLine($"Deduction: {tax.Deduction:C}");
                        output.AppendLine($"Tax Amount: {tax.TaxAmount:C}");
                        output.AppendLine("--------------------------------------------");
                    }

                    rtbTaxSummaryOutput.Text = output.ToString();
                }
                else if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
                {
                    ShowMessage($"Tax details not found for Employee ID {employeeId}.", "Not Found", MessageBoxIcon.Warning);
                    rtbTaxSummaryOutput.Text = "";
                }
                else
                {
                    var errorContent = await response.Content.ReadAsStringAsync();
                    ShowMessage($"Error retrieving tax summary: {response.ReasonPhrase}\nDetails: {errorContent}", "API Error", MessageBoxIcon.Error);
                    rtbTaxSummaryOutput.Text = "";
                }
            }
            catch (HttpRequestException ex)
            {
                ShowMessage($"API communication error during tax summary retrieval: {ex.Message}", "Connection Error", MessageBoxIcon.Error);
                rtbTaxSummaryOutput.Text = "";
            }
            catch (Exception ex)
            {
                ShowMessage($"An unexpected error occurred while retrieving tax summary: {ex.Message}", "Error", MessageBoxIcon.Error);
                rtbTaxSummaryOutput.Text = "";
            }
        }

    }
}
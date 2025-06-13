    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;
    using Newtonsoft.Json;
    using static SolmileGuesthouseAPI.DTO.NavigatorModel.DTOs;

    namespace SolmileGuestHouseUI.Forms.AdminForms
    {
    public partial class SearchByIdForm : Form
    {
        private readonly Func<int, Task<object>> _searchFunction;
        public object SelectedItem { get; private set; }

        public SearchByIdForm(string title, Func<int, Task<object>> searchFunction)
        {
            InitializeComponent();
            _searchFunction = searchFunction;
            this.Text = title;
            btnFind.Click += BtnFind_Click;
        }

        private async void BtnFind_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtSearchId.Text.Trim(), out int id))
            {
                MessageBox.Show("Please enter a valid numeric ID.");
                return;
            }

            var item = await _searchFunction(id);
            if (item != null)
            {
                SelectedItem = item;
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Item not found.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        }
    }

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SolmileGuestHouseUI.Forms.ManagerForms
{
    public partial class Employee : UserControl
    {
        public Employee()
        {
            InitializeComponent();
        }
        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            // TODO: Add logic to create a new employee record
            MessageBox.Show("Create Account clicked.");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // TODO: Add logic to update selected employee
            MessageBox.Show("Update clicked.");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // TODO: Add logic to delete selected employee
            MessageBox.Show("Delete clicked.");
        }

        private void btnFindById_Click(object sender, EventArgs e)
        {
            // TODO: Add logic to find employee by ID
            MessageBox.Show("Find by ID clicked.");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            // TODO: Add search logic
            MessageBox.Show("Search clicked.");
        }

    }
}

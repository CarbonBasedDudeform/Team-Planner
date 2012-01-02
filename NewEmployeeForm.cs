using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Team_Manager
{
    public partial class NewEmployeeForm : Form
    {
        public NewEmployeeForm()
        {
            InitializeComponent();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NewEmployeeForm_Load(object sender, EventArgs e)
        {
            foreach (Role curRole in Main.Roles)
            {
                AvailableRolesDrop.Items.Add(curRole.Title);
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (employeeNameTxt.Text == string.Empty)
            {
                MessageBox.Show("Please enter an employee name");
            }
            else if (AvailableRolesDrop.SelectedItem == null)
            {
                MessageBox.Show("Please select a role for the employee");
            }
            else
            {
                this.Close();
            }
        }
    }
}

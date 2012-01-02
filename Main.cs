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
    public partial class Main : Form
    {
        static public List<Employee> Employees = new List<Employee>();
        static public List<Role> Roles = new List<Role>();
        static public List<Job> Jobs = new List<Job>();

        public Main()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void addNewJob_Click(object sender, EventArgs e)
        {
            NewJobForm form = new NewJobForm();
            form.Show();
        }

        private void addNewMember_Click(object sender, EventArgs e)
        {
            NewEmployeeForm form = new NewEmployeeForm();
            form.Show();
        }

        private void addNewRole_Click(object sender, EventArgs e)
        {
            NewRoleForm form = new NewRoleForm();
            form.Show();
        }

        private void Main_Enter(object sender, EventArgs e)
        {
        }
    }
}

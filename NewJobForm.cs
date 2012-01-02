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
    public partial class NewJobForm : Form
    {
        public NewJobForm()
        {
            InitializeComponent();
        }

        private void NewJobForm_Load(object sender, EventArgs e)
        {

        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (jobTitleTxt.Text == string.Empty)
            {
                MessageBox.Show("Please enter a job title");
            }
            else if (locationTxt.Text == string.Empty)
            {
                MessageBox.Show("Please enter a job location");
            }
            else
            {
                //Main.JobAdded = true;
                Job temp = new Job();
                temp.Title = jobTitleTxt.Text;
                temp.Location = locationTxt.Text;
                Main.Jobs.Add(temp);

                this.Close();
            }
        }
    }
}

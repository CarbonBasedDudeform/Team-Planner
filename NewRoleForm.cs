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
    public partial class NewRoleForm : Form
    {
        public NewRoleForm()
        {
            InitializeComponent();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void colourBtn_Click(object sender, EventArgs e)
        {
            Bitmap newPrev = new Bitmap(Team_Manager.Properties.Resources.shirt);

            colorPicker.ShowDialog();

            Color temp = colorPicker.Color;
            for (int width = 0; width < preview.Image.Width; ++width)
            {
                for (int height = 0; height < preview.Image.Height; ++height)
                {
                    if (newPrev.GetPixel(width, height).R == 255 && newPrev.GetPixel(width, height).G == 255 && newPrev.GetPixel(width, height).B == 255)
                        newPrev.SetPixel(width, height, colorPicker.Color);
                }
            }

            preview.Image = newPrev;
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            Role temp = new Role();

            if (nameTxt.Text == string.Empty)
            {
                MessageBox.Show("Name field is blank. Please enter a name or click cancel");
            }
            else
            {
                temp.Title = nameTxt.Text;
                temp.Colour = colorPicker.Color;

                Main.Roles.Add(temp);

                this.Close();
            }
        }
    }
}

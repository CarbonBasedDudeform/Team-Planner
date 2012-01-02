using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Team_Manager
{
    public class Role
    {
        private Color m_colour;
        private string m_title;

        public Color Colour
        {
            set { m_colour = value; }
            get { return m_colour; }
        }

        public string Title
        {
            set { m_title = value; }
            get { return m_title; }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Появлялочка : Form
    {
        public Появлялочка()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                checkBox1.Text = "Активен."; Появлялка.Visible = true;
            }
            else
            {
                checkBox1.Text = "Не активен"; Появлялка.Visible = false;
            }
        }

        private void Появлялка_Click(object sender, EventArgs e)
        {
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(textBox1.Text);
            double minutes = x / 60;
            double hours = x / 3600;
            double days = x / 86400;

             if (x >= 60)
            {
                label2.Text = "There is " + minutes + " minutes in " + x + " seconds";
            }
             if (x >= 3600)
            {
                
                label2.Text = "There is " + hours + " hours in " + x + " seconds";
            }
             if (x >= 86400)
            {
                label2.Text = "There is " + days + " days in " + x + " seconds";
            }
        }
    }
}

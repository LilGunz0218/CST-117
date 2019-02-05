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
            int x = int.Parse(textBox1.Text);
            int minutes = x / 60;
            int hours = x / 3600;
            int days = x / 86400;

            try
            {
                if (x >= 60)
                {
                    label2.Text = "There is " + minutes + " minutes in " + x + " seconds";
                }
                if (x >= 3600)
                {

                    label3.Text = "There is " + hours + " hours in " + x + " seconds";
                }
                if (x >= 86400)
                {
                    label4.Text = "There is " + days + " days in " + x + " seconds";
                }
            }
            catch
            {
                label2.Text = "Please enter a positive number";
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}

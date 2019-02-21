using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /* Tommy Trujillo III
             * This is my own work.
             * */
            try
            {
                string input = textBox1.Text;
                int x = Convert.ToInt32(input);

                double denom = 1;
                double num = 4;
                double sum = 0;

                for (int i = 1; i < x; i++)
                {
                    if (i % 2 == 1)
                    {
                        sum += num / denom;
                    }
                    else
                    {
                        sum -= num / denom;
                    }
                    denom += 2;
                }
                label2.Visible = true;
                label2.Text = "Approximate value of pi after " + x + " terms.";
                label3.Visible = true;
                label3.Text = "= " + sum;

            }

            catch
            {
                MessageBox.Show("Something went wrong. Please try again");
            }
        }
    }
}

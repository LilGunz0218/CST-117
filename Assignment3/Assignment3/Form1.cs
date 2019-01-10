using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double weight = Convert.ToDouble(textBox1.Text); //Takes the text from textbox1, converts it to a double
            double newWeight = (weight / 9.81) * 3.711; //Formula for Conversion

            string MarsWeight = Convert.ToString(newWeight); //Converts newWeight to string so it will show in textbox2

            textBox2.Text = MarsWeight; //Changes the text in texbox2 to MarsWeight
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

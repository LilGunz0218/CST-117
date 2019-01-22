using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double weight = Convert.ToDouble(textBox1.Text); //Takes the text from textbox1, converts it to a double

            double newWeight = Math.Round((weight / 9.81) * 3.711, 3); /*Formula for Conversion found from http://www.learningaboutelectronics.com/Articles/Weight-on-mars-conversion-calculator.php
                                                                      Also uses Math.Round();  to round newWeight to 3 Decimal Places */

            string MarsWeight = Convert.ToString(newWeight); //Converts newWeight to string so it will show in textbox2


            textBox2.Text = MarsWeight; //Changes the text in textbox2 to MarsWeight

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Day6Participation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Cost of each Class ticket
            double ClassA = 15.0;
            double ClassB = 12.0;
            double ClassC = 9.0;

            //Converts the input from the textboxes to a double for calculations
            double AmountSoldA = Convert.ToDouble(textBox1.Text);
            double AmountSoldB = Convert.ToDouble(textBox2.Text);
            double AmountSoldC = Convert.ToDouble(textBox3.Text);

            //Calculates Revenue for each Class
            double RevenueA = ClassA * AmountSoldA;
            double RevenueB = ClassB * AmountSoldB;
            double RevenueC = ClassC * AmountSoldC;
            double TotalRevenue = RevenueA + RevenueB + RevenueC;

            //Converts the Revenue for each class into String to be put into designated textbox
            string GeneratedA = Convert.ToString(RevenueA);
            string GeneratedB = Convert.ToString(RevenueB);
            string GeneratedC = Convert.ToString(RevenueC);
            string TotalGenerated = Convert.ToString(TotalRevenue);

            //Changes the text to the generated funds of each class and total
            textBox4.Text = "$" + GeneratedA;
            textBox5.Text = "$" + GeneratedB;
            textBox6.Text = "$" + GeneratedC;
            textBox7.Text = "$" + TotalGenerated;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Closes the application..obviously
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Changes the text of each textBox to an empty string
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";

            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
        }
    }
}

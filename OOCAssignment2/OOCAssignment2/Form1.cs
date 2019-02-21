using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOCAssignment2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            pictureBox7.Visible = false;
            pictureBox1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
           

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string op = listBox1.SelectedItem.ToString();

            if (op == "I.Q.")
            {
                pictureBox1.Visible = true;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;

                label2.Text = "Monika 'I.Q.' Weiss";
                label3.Text = "08/01/1979";
            }
            if (op == "Blitz")
            {
                pictureBox3.Visible = true;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                pictureBox1.Visible = false;
                pictureBox6.Visible = false;

                label2.Text = "Elias Kotz";
                label3.Text = "04/02/1980";
            }
            if (op == "Jager")
            {
                pictureBox4.Visible = true;
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;
                pictureBox1.Visible = false;
                pictureBox3.Visible = false;
                label2.Text = "Marius Stricher";
                label3.Text = "03/09/1978";
            }
            if (op == "Bandit")
            {
                pictureBox5.Visible = true;
                pictureBox6.Visible = false;
                pictureBox1.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                label2.Text = "Dominc Brunsmeier";
                label3.Text = "08/13/1974";
            }
            if (op == "Recruit")
            {
                pictureBox6.Visible = true;
                pictureBox1.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                label2.Text = "Dat Boi";
                label3.Text = "06/09/1337";
            }

            if (radioButton1.Checked == true)
            {
                pictureBox7.Visible = true;
                pictureBox2.Visible = false;

            }

            if (radioButton2.Checked == true)
            {
                pictureBox2.Visible = true;
                pictureBox7.Visible = false;
            }

            if (checkBox1.Checked == true)
            {
                label2.Visible = true;
            }
            else if (checkBox1.Checked == false)
            {
                label2.Visible = false;
            }

            if (checkBox2.Checked == true)
            {
                label3.Visible = true;
            }
            else if (checkBox2.Checked == false)
            {
                label3.Visible = false;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            pictureBox7.Visible = false;
            pictureBox1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
        }
    }
}

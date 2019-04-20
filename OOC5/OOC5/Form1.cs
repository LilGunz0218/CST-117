using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOC5
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

        private void BirthYearBox_SelectedIndexChanged(object sender, EventArgs e)
        {
         //NOT THE RIGHT METHOD
        }

        //made public so i can use days later
        public static int days = 0;
        public static int monthLetters = 0;
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.BirthDayBox.Items.Clear();
         
            if (BirthMonthBox.SelectedItem.ToString() == "January" || BirthMonthBox.SelectedItem.ToString() == "March" || BirthMonthBox.SelectedItem.ToString() == "May" || BirthMonthBox.SelectedItem.ToString() == "July" || BirthMonthBox.SelectedItem.ToString() == "August" || BirthMonthBox.SelectedItem.ToString() == "October" || BirthMonthBox.SelectedItem.ToString() == "December")
            {
                days = 31;
                monthLetters = Convert.ToInt32(BirthMonthBox.SelectedItem.ToString().Length);

            }
            else if (BirthMonthBox.SelectedItem.ToString() == "April" || BirthMonthBox.SelectedItem.ToString() == "June" || BirthMonthBox.SelectedItem.ToString() == "September" || BirthMonthBox.SelectedItem.ToString() == "November" || BirthMonthBox.SelectedItem.ToString() == "October")
            {
                days = 30;
                monthLetters = Convert.ToInt32(BirthMonthBox.SelectedItem.ToString().Length);
            }
            else
            {
                days = 29;
                monthLetters = Convert.ToInt32(BirthMonthBox.SelectedItem.ToString().Length);
            }

            for (int i = 0; i <= days; i++)
            {
                BirthDayBox.Items.Add(i);
            }
        }

        public static int yearLength;
        private void Form1_Load(object sender, EventArgs e)
        {
           
            for (int i = 1900; i <= 2019; i++)
            {
                BirthYearBox.Items.Add(i);
                
            }

           





        }
        //equation for lucky number
      

        private void BirthYearBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
          yearLength = BirthYearBox.SelectedItem.ToString().Length;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            Form2 newForm = new Form2();
            int luckynumber = days - (yearLength + monthLetters);
            newForm.Show();
            
        }
    }
}

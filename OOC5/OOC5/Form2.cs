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
    public partial class Form2 : Form
    {
        int luckynumber = Form1.days - (Form1.yearLength + Form1.monthLetters);
        public Form2()
        {
            InitializeComponent();
           
             labelLuckyNumber.Text = luckynumber.ToString(); 
        }

        private void Form2_Load(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

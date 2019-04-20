using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryFinal
{
    //Tommy Trujillo III
    //This is my own work.

    public partial class Form1 : Form
    {
        InvManager im = new InvManager();
        StreamWriter sw = new StreamWriter("discs.txt");
        StreamReader sr = new StreamReader("discs.txt");


        public Form1()
        {
            InitializeComponent();

           
          

            Disc gladiator = new Disc("1","Gladiator",12.50,"Pink","175",20);

            Disc kong = new Disc("2","Kong",20.50,"Green","175",12);
            
            Disc XXX = new Disc("3","XXX",9.50,"Blue","172",30);
          
            
            //Tests addItem
            im.addItem(gladiator);
            im.addItem(kong);
            im.addItem(XXX);
            

            //Tests displayAllItems
            im.displayItems();

           

            //Tests findbyName
            Disc locatedItem1 = im.findbyName("Kong");
            if (locatedItem1 == null)
            {
                MessageBox.Show("item is not here");
            }
            else
            {
                MessageBox.Show("found " + locatedItem1.Productname);
            }

            

            //Tests findbyID
            Disc locatedItem2 = im.findbyID("1");
            if (locatedItem2 == null)
            {
                MessageBox.Show("item is not here");
            }
            else
            {
                MessageBox.Show("found " + locatedItem2.Productname);
            }



            //Tests findbyPrice
            Disc locatedItem3 = im.findbyPrice(9.50);
            if (locatedItem3 == null)
            {
                MessageBox.Show("item is not here");
            }
            else
            {
                MessageBox.Show("found " + locatedItem3.Productname);
            }

            
           


            //Tests restockDisc
            im.restockDisc(gladiator, 20);


           


        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string prod_id = this.newIDBox.Text;
                string prod_name = this.newNameBox.Text;
                double prod_price = double.Parse(this.newPriceBox.Text);
                string prod_color = this.newColorBox.Text;
                string prod_weight = this.newWeightBox.Text;
                int prod_quantity = int.Parse(this.newQuantityBox.Text);
                Disc a = new Disc(prod_id, prod_name, prod_price, prod_color, prod_weight, prod_quantity);
                im.addItem(a);
                MessageBox.Show("You added " + prod_name);

                sw.WriteLineAsync();

                this.newIDBox.Text = "";
                this.newNameBox.Text = "";
                this.newPriceBox.Text = "";
                this.newColorBox.Text = "";
                this.newWeightBox.Text = "";
                this.newQuantityBox.Text = "";
                
                
            }
            catch
            {

            }
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = im.getItemList();
        }
    }
}

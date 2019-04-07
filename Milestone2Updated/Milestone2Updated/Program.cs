using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Milestone2Updated
{
    //Tommy Trujillo III
    //This is my own work.

    public class Disc
    {
        public string Productid { set; get; }
        public string Productname { set; get; }
        public double Productprice { set; get; }
        public string Productcolor { set; get; }
        public string Productweight { set; get; }
        public int Quantityonhand { set; get; }
    }
    
    class Program
    {
        
        static void Main(string[] args)
        {
            InvManager im = new InvManager();

            Disc gladiator = new Disc();
            gladiator.Productname = "Gladiator";
           // Console.WriteLine(newdisc.Productname);
            gladiator.Productid = "1";
            // Console.WriteLine(newdisc.Productid);
            gladiator.Productprice = 12.50;
            // Console.WriteLine(newdisc.Productprice);
            gladiator.Quantityonhand = 20;
            // Console.WriteLine(newdisc.Quantityonhand);
            gladiator.Productcolor = "Pink";
            //Console.WriteLine(newdisc.Productcolor);
            gladiator.Productweight = "175 grams";
            // Console.WriteLine(newdisc.Productweight);
            gladiator.Quantityonhand = 20;


            Disc kong = new Disc();
            kong.Productname = "Kong";
            //Console.WriteLine(kong.Productname);
            kong.Productid = "2";
           //Console.WriteLine(kong.Productid);
            kong.Productprice = 20.50;
            //Console.WriteLine(kong.Productprice);
            kong.Quantityonhand = 5;
           // Console.WriteLine(kong.Quantityonhand);
            kong.Productcolor = "Green";
           // Console.WriteLine(kong.Productcolor);
            kong.Productweight = "173 grams";
            // Console.WriteLine(kong.Productweight);
            kong.Quantityonhand = 5;

            Disc XXX = new Disc();
            XXX.Productname = "XXX";
            //Console.WriteLine(kong.Productname);
            XXX.Productid = "3";
            //Console.WriteLine(kong.Productid);
            XXX.Productprice = 9.50;
            //Console.WriteLine(kong.Productprice);
            XXX.Quantityonhand = 3;
            // Console.WriteLine(kong.Quantityonhand);
            XXX.Productcolor = "Blue";
            // Console.WriteLine(kong.Productcolor);
            XXX.Productweight = "178 grams";
            // Console.WriteLine(kong.Productweight);
            XXX.Quantityonhand = 50;

            //Tests addItem
            im.addItem(gladiator);
            im.addItem(kong);
            im.addItem(XXX);

            Console.WriteLine("==========================================");

            //Tests displayAllItems
            im.displayItems();

            Console.WriteLine("==========================================");

            //Tests findbyName
            Disc locatedItem1 = im.findbyName("Kong");
            if (locatedItem1 == null)
            {
                Console.WriteLine("item is not here");
            }
            else
            {
                Console.WriteLine("found " + locatedItem1.Productname);
            }

            Console.WriteLine("==========================================");

            //Tests findbyID
            Disc locatedItem2 = im.findbyID("1");
            if (locatedItem2 == null)
            {
                Console.WriteLine("item is not here");
            }
            else
            {
                Console.WriteLine("found " + locatedItem2.Productname);
            }

            Console.WriteLine("==========================================");

            //Tests findbyPrice
            Disc locatedItem3 = im.findbyPrice(9.50);
            if (locatedItem3 == null)
            {
                Console.WriteLine("item is not here");
            }
            else
            {
                Console.WriteLine("found " + locatedItem3.Productname);
            }

            Console.WriteLine("==========================================");

            //Tests remove item
            im.removeItem(XXX);

            Console.WriteLine("==========================================");

            //Tests restockDisc
            im.restockDisc(gladiator, 20);

            Console.WriteLine("==========================================");

            //Tests getAllItems
            im.getAllProducts();


            Console.ReadKey();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Milestone2Updated
{
    public class Disc
    {
        public string productid { get; set; }
        public string productname { get; set; }
        public double productprice { get; set; }
        public int quantityonhand { get; set; }
        public string productcolor { get; set; }
        public string productweight { get; set; }
        
    }
    class Program
    {
        
        static void Main(string[] args)
        {
            Disc newdisc = new Disc();
            newdisc.productname = "Gladiator";
            newdisc.productid = "1";
            newdisc.productprice = 12.50;
            newdisc.quantityonhand = 20;
            newdisc.productcolor = "Pink";
            newdisc.productweight = "175 grams";


            Console.ReadKey();

        }
    }
}

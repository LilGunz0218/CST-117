﻿using System;
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
        private string productid;
        public string Productid
        { 
            get
            {
                return productid;
            }
            set
            {
                productid = value;
            }
        }
        private string productname;
        public string Productname
        {
            get
            {
                return productname;
            }
            set
            {
                productname = value;
            }
        }
        private double productprice;
        public double Productprice
        {
            get
            {
                return productprice;
            }
            set
            {
                productprice = value;
            }
        }
        private int quantityonhand;
        public int Quantityonhand
        {
            get
            {
                return quantityonhand;
            }
            set
            {
                quantityonhand = value;
            }
        }
        private string productcolor;
        public string Productcolor
        {
            get
            {
                return productcolor;
            }
            set
            {
                productcolor= value;
            }
        }
        private string productweight;
        public string Productweight
        {
            get
            {
                return productweight;
            }
            set
            {
                productweight = value;
            }
        }


    }
    
    class Program
    {
        
        static void Main(string[] args)
        {
            Disc newdisc = new Disc();
            newdisc.Productname = "Gladiator";
            Console.WriteLine(newdisc.Productname);
            newdisc.Productid = "1";
            Console.WriteLine(newdisc.Productid);
            newdisc.Productprice = 12.50;
            Console.WriteLine(newdisc.Productprice);
            newdisc.Quantityonhand = 20;
            Console.WriteLine(newdisc.Quantityonhand);
            newdisc.Productcolor = "Pink";
            Console.WriteLine(newdisc.Productcolor);
            newdisc.Productweight = "175 grams";
            Console.WriteLine(newdisc.Productweight);



            Item testdisc = new Item();
            testdisc.Productname = "Kong";
            Console.WriteLine(testdisc.Productname);
            testdisc.Productid = "2";
            Console.WriteLine(testdisc.Productid);
            testdisc.Productprice = 12.50;
            Console.WriteLine(testdisc.Productprice);
            testdisc.Quantityonhand = 5;
            Console.WriteLine(testdisc.Quantityonhand);
            testdisc.Productcolor = "Green";
            Console.WriteLine(testdisc.Productcolor);
            testdisc.Productweight = "173 grams";
            Console.WriteLine(testdisc.Productweight);

            Console.ReadKey();

        }
    }
}

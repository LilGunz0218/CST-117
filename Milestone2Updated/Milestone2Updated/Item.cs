using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Milestone2Updated
{
    public class Item
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
                productcolor = value;
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
}

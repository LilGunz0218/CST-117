using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Milestone2Updated
{
    class InvManager
    {
        //product list
        private List<Disc> items;

        public InvManager()
        {

            //initialize the attributes
            items = new List<Disc>();

        }

        public void addItem(Disc item)
        {

                if (!items.Contains(item))
                {
                    items.Add(item);
                    Console.WriteLine("You added " + item.Productname);

                }
            
        }

        public void removeItem(Disc item)
        {
            items.Remove(item);
            Console.WriteLine("You removed " + item.Productname);
        }

        public Disc findbyPrice(double price)
        {
            Disc result = null;

            for (int i = 0; i < items.Count(); i++)
            {
                
                //does this product have the same price as param price
                if (items[i].Productprice == price)
                    result = items[i];
            }

            return result;
        }

        public Disc findbyID(string id)
        {
            Disc result = null;

            for (int i = 0; i < items.Count(); i++)
            {
                //does this product have the same id as param id
                if (items[i].Productid == id)
                    result = items[i];
            }

            return result;
        }

        public Disc findbyName(string name)
        {
            Disc result = null;

            for (int i = 0; i < items.Count(); i++)
            {
                //does this product have the same name as param name
                if (items[i].Productname == name)
                    result = items[i];
            }

            return result;
        }

        public void restockDisc(Disc name,int quantity)
        {
            name.Quantityonhand = name.Quantityonhand + quantity;
            Console.WriteLine("You added " + quantity + " discs to " + name.Productname);
            Console.WriteLine(name.Productname + " Now has " + name.Quantityonhand + " discs in stock");

        }

        public void displayItems()
        {

            for (int i = 0; i < items.Count(); i++)
            {
                //does this product have the same name as param name
                Console.WriteLine(items[i].Productname);
            }
        }

        public void getAllProducts()
        {
            Array DiscArray = items.ToArray();

            Console.WriteLine(DiscArray);
            
        }
    }
}


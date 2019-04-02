using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Milestone3
{
    class Program
    {

        static void Main(string[] args)
        {
            InvManager manager = new InvManager();

            Product p = new Milestone3.Product();
            p.name = "Gladiator";
            p.price = 12.99;
            p.quantity = 72;


            manager.addItem(p);

            Product target = manager.findByName("123");

            if(target == null)
            {
                Console.WriteLine("Product with id \'superstar\' is ");
            }
        }

    }

    class Product
    {
        string name { get; set; }
        int quantity { set; get; }
        double price { get; set; }

        public Product()
        {
            name = "";
            price = 0;
            quantity = 0;
        }

    }
    
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Milestone3wfa
{
    class InventoryManager : Form1
    {
        //product list
        private List<Product> items;

        public InventoryManager()
            {

            //initialize the attributes
            items = new List<Product>(); 

            }

        public void addItem(Product item)
        {
            String name = name.Text;

            /*Add logic to control duplicates
             * 
             * 
             * 
             * 
             * */

            items.Add(item);
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Milestone3
{
    class InvManager
    {
        //product list
        private List<Product> items;

        public InvManager()
        {

            //initialize the attributes
            items = new List<Product>();

        }

        public void addItem(Product item)
        {
            

            /*Add logic to control duplicates
             * 
             * 
             * 
             * 
             * */

            items.Add(item);
        }

        public Product findbyName(string name)
        {
            Product result = null;

            for (int i = 0; i < items.Count(); i++)
            {
                //does this product have the same name as param name
                if (items[i].p.name == name)
                    result = items[i];
            }

            return result;
        }

    }
}

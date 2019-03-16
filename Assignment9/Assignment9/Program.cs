using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment9
{
    class Program
    {
        static void Main(string[] args)
        {
            //EDITED BY TOMMY TRUJILLO III

            //make some sets
            Set A = new Set();
            Set B = new Set();
            Set C = new Set();
            C = A.union(B);

            //put some stuff in the sets
            Random r = new Random();
            for (int i = 0; i < 10; i++)
            {
                A.addElement(r.Next(4));
                B.addElement(r.Next(12));
                
            }

            //display each set and the union
            Console.WriteLine("A: " + A);
            Console.WriteLine("B: " + B);

           // Console.WriteLine("A union B: " + A.union(B));
            // No need to edit A and B.
            Console.WriteLine("A union B: " + C);


            //display original sets (should be unchanged)
            Console.WriteLine("After union operation");
            Console.WriteLine("A: " + A);
            Console.WriteLine("B: " + B);

            Console.ReadKey();

        }
    }

    class Set
    {
        private List<int> elements;


        public Set()
        {
            elements = new List<int>();
        }

        public bool addElement(int val)
        {
            if (containsElement(val)) return false;
            else
            {
                elements.Add(val);
                return true;
            }
        }

        private bool containsElement(int val)
        {
            for (int i = 0; i < elements.Count; i++)
            {
                if (val == elements[i])
                    return true;

                //No need for an else, if you already are returning it false if the if statement doesn't execute.
               // else
                   // return false;
            }
            return false;
        }

        public override string ToString()
        {
            string str = "";
            foreach (int i in elements)
            {
                str += i + " ";
            }
            return str;
        }

        public void clearSet()
        {
            elements.Clear();
        }

        public Set union(Set rhs)
        {
            Set newset = new Set();

            for (int i = 0; i < rhs.elements.Count; i++)
            {
                this.addElement(rhs.elements[i]);
            }
          for (int i = 0; i < this.elements.Count; i++)
          {
                newset.addElement(this.elements[i]);
          }
            return newset;
           // return rhs;
           // Doesn't change A and B.
            

            

        }
    }

}

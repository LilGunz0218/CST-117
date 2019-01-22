using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calories
{
    class Program
    {
        static void Main(string[] args)
        {
            //Gets user input
            Console.WriteLine("How many cookies did you eat?");
            string input = Console.ReadLine();
            int cookies = Convert.ToInt32(input);

            //Data types needed for calculations
            int serving = 4;
            int calories = 300;
            int caloriesperserving = calories / serving;
           
            //Calculations
            int consumedcalories = cookies * caloriesperserving;
            Console.WriteLine("You consumed " + consumedcalories + " total calories.");

            Console.ReadKey();
        }
    }
}

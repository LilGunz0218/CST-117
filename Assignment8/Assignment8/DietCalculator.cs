using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment8
{
    class DietCalculator
    {
        public static double FatCalories (double fatgrams)
            {
            Console.WriteLine("Enter how many Fat Grams you consumed today.");

            fatgrams = Convert.ToDouble(Console.ReadLine());

            double fatCalories = fatgrams * 9;

            Console.WriteLine("You consumed " + fatCalories + " fat calories!");
            return fatCalories;
            }

        public static double CarbCalories (double carbgrams)
        {
            Console.WriteLine("Enter how many Carb Grams you consumed today.");

            carbgrams = Convert.ToDouble(Console.ReadLine());

            double carbCalories = carbgrams * 4;
            Console.WriteLine("You consumed " + carbCalories + " carb calories!");
            return carbCalories;
        }
    }
}

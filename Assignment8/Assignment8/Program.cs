using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment8
{
    class Program
    {

        //Tommy Trujillo III
        //This is my own work.
        public static double FatCalories(double fatgrams)
        {

            double fatCalories = fatgrams * 9;
            Console.WriteLine("You consumed " + fatCalories + " Carb calories today.");
            return fatCalories;
        }

        public static double CarbCalories(double carbgrams)
        {
            double carbCalories = carbgrams * 4;
            Console.WriteLine("You consumed " + carbCalories + " Carb calories today.");
            return carbCalories;
        }

        public static void Main(string[] args)
        {

                CarbCalories(48.0);
                FatCalories(128.6);



                Console.ReadKey();

        }
        
    }
}

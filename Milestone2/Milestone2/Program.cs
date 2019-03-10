using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Milestone2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the name of the disc.");
            String discname = Console.ReadLine();

            Console.WriteLine("Enter the ID# for the disc.");
            int idnum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the color of the disc.");
            String discColor = Console.ReadLine();

            Console.WriteLine("Enter the weight of the disc.");
            int discWeight = Convert.ToInt32(Console.ReadLine());

        }
    }
}

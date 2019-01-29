using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParticipationWeek4
{
    class Program
    {
        static void Main(string[] args)
        {
            int val = 35;
            int n = -5;

            if (val + 3 == 38)
            {
                Console.WriteLine("val + 3 == 38 is True");
            }
            else
            {
                Console.WriteLine("val + 3 == 38 is False");
            }
            if (val * 3 > 120)
            {
                Console.WriteLine("val * 3 > 120 is True");
            }
            else
            {
                Console.WriteLine("val * 3 > 120 is False");
            }

            if ( val -30 < -5+10)
            {
                Console.WriteLine("val - 30 < -5 + 10 is True");
            }
            else
            {
                Console.WriteLine("val - 30 < -5 + 10 is False");
            }

            if (n < 0 )
            {
                Console.WriteLine("n < 0 is true");
            }
            else
            {
                Console.WriteLine("n < 0 is false");
            }

            if (val/n + 9 <= 0)
            {
                Console.WriteLine("val/n + 9 <= 0 is True");
            }
            else
            {
                Console.WriteLine("val/n + 9 <= 0 is False");
            }

            if (val % 2 != 0)
            {
                Console.WriteLine("val % 2 != 0 is True");
            }
            else
            {
                Console.WriteLine("val % 2 != 0 is False");
            }

            bool p = true;
            bool q = false;
            bool r = false;
           
            Console.WriteLine(!r);
            Console.WriteLine(r && p);
            Console.WriteLine(!(r || q) && p);
            Console.WriteLine((r && !r) || (p && !p));
            Console.WriteLine((p && !q) || (!p && q));
            Console.WriteLine((r || !r) && (p || !p));

            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Assignment10
{
    class Program
    {
       
            static void Main(string[] args)
        {
            /* Tommy Trujillo III
             * This is my own work 
             */

            
        
            StreamReader reader = new StreamReader(@"C:\Users\tommy\Desktop\School Files\Semester 2 Year 1\CST-117\Assignment10\LiveWire.txt");

            //stores each word in an array
            string[] words = reader.ReadToEnd().Split(' ');
            int count = 0;
            foreach (string word in words)
            {
               char lastLetter = word[word.Length - 1];
                if (lastLetter == 't' || lastLetter == 'e')
                    count++;                
            }

            Console.WriteLine("There are " + count + " words that end in t or e.");

           
            Console.ReadKey();
        }
    }
}

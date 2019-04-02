using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6
{
    class Program
    {
        class Dice
        {
            static int dice1;
            static int dice2;
            static int tries = 0;
            public static void RollDie()
            {
              
                bool SnakeEyes = false;

                //Sets the amount of sides for the dice
                
                    Random random = new Random();
                    int setside = random.Next(4, 21);
                    Console.WriteLine("The Dice has " + setside + " sides.");

                while (SnakeEyes == false)
                {
                    //Counts how many
                    tries++;

                    

                    //Rolls dice1
                    Random rand1 = new Random();
                    dice1 = rand1.Next(1, setside);

                    //Rolls dice2
                    Random rand2 = new Random();
                    dice2 = rand2.Next(1, setside);

                    Console.WriteLine("On roll " + tries + ":  " + "The first die landed on: " + dice1 + " The second die landed on: " + dice2);
                    //Checks if rolled snake eyes
                    if (dice1 == 1 && dice2 == 1)
                    {
                    SnakeEyes = true;
                    Console.WriteLine("You win!");
                    Console.WriteLine("It took " + tries + " tries to rolls snake eyes.");

                        
                    }

                }

               
            }
        
            static void Main(string[] args)
            {
                RollDie();
                Console.ReadKey();

            }

          
        }
    }
}

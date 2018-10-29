using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseP94
{
    class ExerciseP94
    {
        static void Main(string[] args)
        {
            bool clearFlag = false;
            bool correctFlag = false;
            double num1;

            while (correctFlag == false)
            {
                Console.WriteLine("Guess the number. It could be any number. Even 13.");
                clearFlag = false;
                do
                {
                    Console.WriteLine("");
                    Console.WriteLine("Enter a number:");
                    if (double.TryParse(Console.ReadLine(), out num1))
                    {
                        clearFlag = true;
                    }
                    else
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Invalid Entry.");
                    }
                } while (clearFlag == false);

                if (num1 == 13)
                {
                    correctFlag = true;
                    Console.WriteLine("");
                    Console.WriteLine("Got em. You win the game.");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("Wrong.");
                    Console.WriteLine("");
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseP92
{
    class ExerciseP92
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            bool clearFlag = false;
            double packageWeight;
            do
            {
                Console.WriteLine("");
                Console.WriteLine("Please enter package weight:");
                if (double.TryParse(Console.ReadLine(),out packageWeight))
                {
                    clearFlag = true;
                }
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("Invalid input.");
                }
            } while (clearFlag == false);

            if (packageWeight > 50)
            {
                Console.WriteLine("");
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                Console.ReadLine();
                System.Environment.Exit(0);
            }

            clearFlag = false;
            double packageWidth;
            do
            {
                Console.WriteLine("");
                Console.WriteLine("Please enter package width:");
                if (double.TryParse(Console.ReadLine(), out packageWidth))
                {
                    clearFlag = true;
                }
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("Invalid input.");
                }
            } while (clearFlag == false);

            clearFlag = false;
            double packageHeight                ;
            do
            {
                Console.WriteLine("");
                Console.WriteLine("Please enter package height:");
                if (double.TryParse(Console.ReadLine(), out packageHeight))
                {
                    clearFlag = true;
                }
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("Invalid input.");
                }
            } while (clearFlag == false);

            clearFlag = false;
            double packageLength;
            do
            {
                Console.WriteLine("");
                Console.WriteLine("Please enter package length:");
                if (double.TryParse(Console.ReadLine(), out packageLength))
                {
                    clearFlag = true;
                }
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("Invalid input.");
                }
            } while (clearFlag == false);

            if ((packageWidth + packageHeight + packageLength) > 50)
            {
                Console.WriteLine("");
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                Console.ReadLine();
                System.Environment.Exit(0);
            }

            double sumTotal = (packageWidth + packageHeight + packageLength) * packageWeight / 100;
            double sumTotalRound = Math.Round(sumTotal, 2);

            Console.WriteLine("");
            Console.WriteLine("Your estimated total for shipping is $" + sumTotalRound);
            Console.ReadLine();
        }
    }
}

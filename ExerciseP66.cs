using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseP66
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let's do that number math.");

            bool numFlag = false;
            double num1;
            do
            {
                Console.WriteLine("");
                Console.WriteLine("Gimme that number input:");
                if (double.TryParse(Console.ReadLine(),out num1))
                {
                    numFlag = true;
                }
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("Do that, but with a number.");
                }
            } while (numFlag == false);
            double num1Math = num1 * 50;
            Console.WriteLine("");
            Console.WriteLine(num1 + " multiplied by 50 equals " + num1Math);

            numFlag = false;
            double num2;
            do
            {
                Console.WriteLine("");
                Console.WriteLine("Gimme that number input:");
                if (double.TryParse(Console.ReadLine(), out num2))
                {
                    numFlag = true;
                }
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("Do that, but with a number.");
                }
            } while (numFlag == false);
            double num2Math = num2 + 25;
            Console.WriteLine("");
            Console.WriteLine(num2 + " plus 25 equals " + num2Math);

            numFlag = false;
            double num3;
            do
            {
                Console.WriteLine("");
                Console.WriteLine("Gimme that number input:");
                if (double.TryParse(Console.ReadLine(), out num3))
                {
                    numFlag = true;
                }
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("Do that, but with a number.");
                }
            } while (numFlag == false);
            double num3Math = num3 / 12.5;
            Console.WriteLine("");
            Console.WriteLine(num3 + " divided by 12.5 equals " + num3Math);

            numFlag = false;
            double num4;
            do
            {
                Console.WriteLine("");
                Console.WriteLine("Gimme that number input:");
                if (double.TryParse(Console.ReadLine(), out num4))
                {
                    numFlag = true;
                }
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("Do that, but with a number.");
                }
            } while (numFlag == false);
            bool num4Math = num4 > 50;
            Console.WriteLine("");
            Console.WriteLine("Is " + num4 + " greater than 50? That's " + num4Math + " fam.");

            numFlag = false;
            double num5;
            do
            {
                Console.WriteLine("");
                Console.WriteLine("Gimme that number input:");
                if (double.TryParse(Console.ReadLine(), out num5))
                {
                    numFlag = true;
                }
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("Do that, but with a number.");
                }
            } while (numFlag == false);
            double num5Math = num5 % 7;
            Console.WriteLine("");
            Console.WriteLine(num5 + " divided by 7 gives you a remainder of " + num5Math);
            Console.ReadLine();
        }
    }
}

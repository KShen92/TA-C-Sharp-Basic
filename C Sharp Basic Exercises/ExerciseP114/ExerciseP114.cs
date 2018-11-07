using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseP114
{
    class ExerciseP114
    {
        static void Main(string[] args)
        {
            bool clearFlag = false;
            int num1 = 0;
            double num2 = 0;
            int num3 = 0;
            double num3Double = 0;

            do
            {
                try
                {
                    Console.WriteLine("Enter an integer:");
                    num1 = Convert.ToInt32(Console.ReadLine());
                    clearFlag = true;
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid Input");
                    Console.ReadLine();
                }
            } while (clearFlag == false);

            MathOps calcs = new MathOps();
            int mathNum1 = calcs.MathOps1(num1);
            Console.WriteLine("Your integer was " + num1 + ", " + num1 + " times 2 is " + mathNum1);
            Console.ReadLine();

            clearFlag = false;
            do
            {
                try
                {
                    Console.WriteLine("Enter a decimal:");
                    num2 = Convert.ToDouble(Console.ReadLine());
                    clearFlag = true;
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid Input");
                    Console.ReadLine();
                }
            } while (clearFlag == false);

            double mathNum2 = calcs.MathOps2(num2);
            Console.WriteLine("Your decimal was " + num2 + ", " + num2 + " times 3 and rounded is " + mathNum2);
            Console.ReadLine();

            Console.WriteLine("Enter some content. Anything.");
            string contentLine = Console.ReadLine();
            if (int.TryParse(contentLine, out num3))
            {
                int mathNum3 = calcs.MathOps3(num3);
                Console.WriteLine("You entered " + num3 + ". " + num3 + " times 4 equals " + mathNum3);
            }
            else if (double.TryParse(contentLine, out num3Double))
            {
                num3 = Convert.ToInt32(num3Double);
                int mathNum3 = calcs.MathOps3(num3);
                Console.WriteLine("You entered " + num3Double + ", which rounds into " + num3 + ". " + num3 + " times 4 equals " + mathNum3);
            }
            else
            {
                Console.WriteLine("You entered " + contentLine + ". Can't convert to an integer.");
            }
            Console.ReadLine();
        }
    }
}

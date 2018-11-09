using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseP117
{
    class ExerciseP117
    {
        static void Main(string[] args)
        {
            bool clearFlag = false;
            double num1 = 0;
            do
            {
                try
                {
                    Console.WriteLine("Enter a number:");
                    num1 = Convert.ToDouble(Console.ReadLine());
                    clearFlag = true;
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid Input");
                }
            } while (clearFlag == false);

            MathOps calc = new MathOps();
            int result1 = 0;
            calc.MathOps1(out result1, num1);

            Console.WriteLine(num1 + " divided by two and rounded equals " + result1);
            Console.ReadLine();

            int num2 = 2;
            double result2 = 0;
            calc.MathOps1(out result2, num1, num2);

            Console.WriteLine(num1 + " times " + num2 + " equals " + result2);
            Console.ReadLine();
        }
    }
}

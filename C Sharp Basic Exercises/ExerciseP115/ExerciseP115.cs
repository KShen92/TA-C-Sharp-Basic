using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseP115
{
    class ExerciseP115
    {
        static void Main(string[] args)
        {
            bool clearFlag = false;
            int num1 = 0;
            int num2 = 0;

            do
            {
                try
                {
                    Console.WriteLine("Please enter an integer.");
                    num1 = Convert.ToInt32(Console.ReadLine());
                    clearFlag = true;
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid Entry.");
                }
            } while (clearFlag == false);

            Console.WriteLine("Please enter another integer. If you feel like it.");
            if (int.TryParse(Console.ReadLine(), out num2))
            {
                Console.WriteLine("Solid integer choice.");
            }
            else
            {
                num2 = 0;
                Console.WriteLine("Not feeling any more integers, eh.");
            }
            Console.ReadLine();

            MathOps calc = new MathOps();
            int result1 = calc.MathOps1(num1, num2);
            Console.WriteLine("The sum of your integers, plus 2, is " + result1);
            Console.ReadLine();
        }
    }
}

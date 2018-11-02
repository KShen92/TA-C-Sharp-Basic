using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseP111
{
    class ExerciseP111
    {
        static void Main(string[] args)
        {
            bool clearFlag = false;
            int intNum = 0;
            do
            {
                try
                {
                    Console.WriteLine("Enter an integer to get fucking handled:");
                    intNum = Convert.ToInt32(Console.ReadLine());
                    clearFlag = true;
                }
                catch (Exception error)
                {
                    Console.WriteLine(error.Message);
                    Console.ReadLine();
                }
            } while (clearFlag == false);

            MathOperations calcs = new MathOperations();

            int result1 = MathOperations.Operation1(intNum);
            int result2 = MathOperations.Operation2(intNum);
            int result3 = MathOperations.Operation3(intNum);

            Console.WriteLine("Your integer is " + intNum);
            Console.WriteLine(intNum + " multiplied by 2 is " + result1);
            Console.WriteLine(intNum + " plus 10 is " + result2);
            Console.WriteLine(intNum + " minus 5 is " + result3);
            Console.ReadLine();
        }
    }
}

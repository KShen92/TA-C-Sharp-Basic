using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseP156
{
    class ExerciseP156
    {
        static void Main(string[] args)
        {
            bool clearFlag = false;
            double inputNumber = 0;
            while (clearFlag == false)
            {
                try
                {
                    Console.WriteLine("Please enter a number.");
                    inputNumber = Convert.ToDouble(Console.ReadLine());
                    clearFlag = true;
                }
                catch
                {
                    Console.WriteLine("Invalid input.");
                }
            }

            DateTime currentTime = DateTime.Now;
            DateTime timeInX = currentTime.AddHours(inputNumber);
            Console.WriteLine("Current date and time: " + currentTime);
            Console.WriteLine("In " + inputNumber + " hours, it will be " + timeInX);
            Console.ReadLine();            
        }
    }
}

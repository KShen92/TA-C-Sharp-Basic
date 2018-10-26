using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Branching
{
    class Branching
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your fave num?");
            int faveNum = Convert.ToInt32(Console.ReadLine());

            string result = faveNum == 12 ? "That's a dope fave number." : "What a shitty fave number.";
            Console.WriteLine(result);
            Console.ReadLine();

            //int currentTemp = 70;
            //int roomTemp = 70;

            //Console.WriteLine("Hi, what is your name?");
            //string name = Console.ReadLine();

            //Console.WriteLine("Hi " + name + ", what is the temperature where you are?");
            //int currentTemperature = Convert.ToInt32(Console.ReadLine());

            //if (currentTemperature == roomTemp)
            //{
            //    Console.WriteLine("It is exactly room temperature.");
            //}
            //else if (currentTemperature > roomTemp)
            //{
            //    Console.WriteLine("It is warmer than room temperature.");       
            //}
            //else if (roomTemp > currentTemperature)
            //{
            //    Console.WriteLine("It is colder than room temperature.");
            //}
            //else
            //{
            //    Console.WriteLine("This branch is ass.");
            //}


            //string comparisonResult = currentTemp == roomTemp ? "It is room temperature." : "It is not room temperature.";
            //// One-line comparison - Syntax: variable - variableName - condition - output if true - output if false

            //if (currentTemp == roomTemp)
            //{
            //    Console.WriteLine("It is exactly room temperature.");
            //}
            //else if (currentTemp > roomTemp)
            //{
            //    Console.WriteLine("It is warmer than room temperature.");
            //}
            //else if (roomTemp > currentTemp)
            //{
            //    Console.WriteLine("It is colder than room temperature.");
            //}
            //else
            //{
            //    Console.WriteLine("It is not exactly room temperature.");
            //}
            //Console.ReadLine();


        }
    }
}

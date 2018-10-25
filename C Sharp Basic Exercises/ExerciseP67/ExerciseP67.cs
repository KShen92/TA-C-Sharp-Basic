using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseP67
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.WriteLine("");
            Console.WriteLine("Person 1");

            bool clearFlag = false;
            double p1Rate;
            do
            {
                Console.WriteLine("");
                Console.WriteLine("Enter Hourly Rate for Person 1:");
                if (double.TryParse(Console.ReadLine(),out p1Rate))
                {
                    clearFlag = true;
                }
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("Invalid Entry.");
                }
            } while (clearFlag == false);

            clearFlag = false;
            double p1Hours;
            do
            {
                Console.WriteLine("");
                Console.WriteLine("Enter Weekly Hours for Person 1:");
                if (double.TryParse(Console.ReadLine(), out p1Hours))
                {
                    clearFlag = true;
                }
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("Invalid Entry.");
                }
            } while (clearFlag == false);

            Console.WriteLine("");
            Console.WriteLine("Person 2");

            clearFlag = false;
            double p2Rate;
            do
            {
                Console.WriteLine("");
                Console.WriteLine("Enter Hourly Rate for Person 2:");
                if (double.TryParse(Console.ReadLine(), out p2Rate))
                {
                    clearFlag = true;
                }
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("Invalid Entry.");
                }
            } while (clearFlag == false);

            clearFlag = false;
            double p2Hours;
            do
            {
                Console.WriteLine("");
                Console.WriteLine("Enter Weekly Hours for Person 2:");
                if (double.TryParse(Console.ReadLine(), out p2Hours))
                {
                    clearFlag = true;
                }
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("Invalid Entry.");
                }
            } while (clearFlag == false);

            double p1Sal = p1Rate * p1Hours;
            double p2Sal = p2Rate * p2Hours;
            bool salComparison = p1Sal > p2Sal;

            Console.WriteLine("");
            Console.WriteLine("Weekly Salary of Person 1:");
            Console.WriteLine("$" + p1Sal);
            Console.WriteLine("");
            Console.WriteLine("Weekly Salary of Person 2:");
            Console.WriteLine("$" + p2Sal);
            Console.WriteLine("");
            Console.WriteLine("Does Person 1 make more money than Person 2?");
            Console.WriteLine(salComparison);
            Console.ReadLine();
        }
    }
}

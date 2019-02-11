using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseP165
{
    class Program
    {
        static void Main(string[] args)
        {
            bool validInput = false;
            int userAge = 0;

            while (!validInput)
            {
                try
                {
                    Console.WriteLine("Please enter your age:");
                    userAge = Convert.ToInt32(Console.ReadLine());
                    if (userAge <= 0)
                    {
                        throw new ZeroNegException();
                    }
                    else
                    {
                        validInput = true;
                    }
                }
                catch (ZeroNegException)
                {
                    Console.WriteLine("Please enter an age greater than 0.");
                    validInput = false;
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid input.");
                    validInput = false;
                }
            }

            int currentYear = DateTime.Now.Year;
            int birthYear = currentYear - userAge;
            Console.WriteLine("Your birth year is {0}.", birthYear);
            Console.ReadLine();
        }
    }
}

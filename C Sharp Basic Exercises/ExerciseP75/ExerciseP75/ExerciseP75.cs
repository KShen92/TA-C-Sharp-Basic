using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseP75
{
    class ExerciseP75
    {
        static void Main(string[] args)
        {
            bool clearFlag = false;
            int driverAge;
            do
            {
                Console.WriteLine("What is your age?");
                if (int.TryParse(Console.ReadLine(),out driverAge))
                {
                    clearFlag = true;
                }
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("But use your real age though.");
                    Console.WriteLine("");
                }
            } while (clearFlag == false);

            string driverDUICon;
            clearFlag = false;
            do
            {
                Console.WriteLine("");
                Console.WriteLine("Have you ever had a DUI? Please answer Yes or No.");
                string driverDUI = Console.ReadLine();
                driverDUICon = driverDUI.ToLower();
                if (driverDUICon == "yes" || driverDUICon == "no")
                {
                    clearFlag = true;
                }
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("But use Yes or No though.");
                }
            } while (clearFlag == false);

            int driverTickets;
            clearFlag = false;
            do
            {
                Console.WriteLine("");
                Console.WriteLine("How many speeding tickets do you have?");
                if (int.TryParse(Console.ReadLine(), out driverTickets))
                {
                    clearFlag = true;
                }
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("This is the police. We call bullshit.");
                }
            } while (clearFlag == false);

            if (driverAge > 15 && driverDUICon == "no" && driverTickets <= 3)
            {
                Console.WriteLine("");
                Console.WriteLine("Congratulations, you've been approved for coverage.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("You didn't qualify. RIP.");
                Console.ReadLine();
            }
        }
    }
}

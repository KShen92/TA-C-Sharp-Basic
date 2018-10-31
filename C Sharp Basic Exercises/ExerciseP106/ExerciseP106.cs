using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseP106
{
    class ExerciseP106
    {
        static void Main(string[] args)
        {
            List<int> intList = new List<int>() { 10, 12, 15, 25, 76 };
            StringBuilder intListFull = new StringBuilder();
            foreach (int intNum in intList)
            {
                intListFull.Append(intNum + " ");
            }
            Console.WriteLine("Number List: " + intListFull);

            bool errorFlag = false;

            do
            {
                try
                {
                    Console.WriteLine("");
                    Console.WriteLine("Enter a number to divide each number by:");
                    double divNum = Convert.ToDouble(Console.ReadLine());
                    if (divNum == 0)
                    {
                        Console.WriteLine("Cannot divide by 0.");
                    }
                    else
                    {
                        foreach (int intNum in intList)
                        {
                            if (divNum == 0)
                            {
                                Console.WriteLine("Cannot divide by zero.");
                            }
                            else
                            {
                                double quotNum = intNum / divNum;
                                Console.WriteLine(intNum + " divided by " + divNum + " equals " + quotNum);
                                errorFlag = true;
                            }
                        }
                    }                    
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            } while (errorFlag == false);
            Console.ReadLine();
        }
    }
}

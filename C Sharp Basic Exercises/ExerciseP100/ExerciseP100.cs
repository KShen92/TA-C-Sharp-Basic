using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseP100
{
    class ExerciseP100
    {
        static void Main(string[] args)
        {
            string[] stringArray = { "string1", "string2", "string3", "string4" };
            int[] intArray = { 10, 20, 30, 50, 90 };
            List<string> stringList = new List<string>();
            stringList.Add("ah");
            stringList.Add("yes");
            stringList.Add("hello");
            stringList.Add("person");

            int stringArrayCount = stringArray.Count();
            int intArrayCount = intArray.Count();
            int stringListCount = stringList.Count();
            bool clearFlag = false;
            int stringArrayInd;
            int intArrayInd;
            int stringListInd;

            do
            {
                Console.WriteLine("Enter an index number for your string array.");
                if (int.TryParse(Console.ReadLine(), out stringArrayInd))
                {
                    if (stringArrayInd < stringArrayCount)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Your array index value is " + stringArray[stringArrayInd]);
                        clearFlag = true;
                    }
                    else
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Array index does not exist.");
                        Console.WriteLine("");
                    }
                }
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("Invalid Input");
                    Console.WriteLine("");
                }
            } while (clearFlag == false);

            clearFlag = false;
            do
            {
                Console.WriteLine("");
                Console.WriteLine("Enter an index number for your integer array.");
                if (int.TryParse(Console.ReadLine(), out intArrayInd))
                {
                    if (intArrayInd < intArrayCount)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Your array index value is " + intArray[intArrayInd]);
                        clearFlag = true;
                    }
                    else
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Array index does not exist.");
                    }
                }
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("Invalid Input");
                }
            } while (clearFlag == false);

            clearFlag = false;
            do
            {
                Console.WriteLine("");
                Console.WriteLine("Enter an index number for your string list.");
                if (int.TryParse(Console.ReadLine(), out stringListInd))
                {
                    if (stringListInd < stringListCount)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Your list index value is " + stringList[stringListInd]);
                        clearFlag = true;
                    }
                    else
                    {
                        Console.WriteLine("");
                        Console.WriteLine("List index does not exist.");
                    }
                }
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("Invalid Input");
                }
            } while (clearFlag == false);
            Console.ReadLine();
        }
    }
}

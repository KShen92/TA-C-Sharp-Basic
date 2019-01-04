using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ExerciseP154
{
    class ExerciseP154
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
            string inNumString = Convert.ToString(inputNumber);
            File.WriteAllText(@"C:\Users\Ken\Desktop\Open Folder\log154.txt", inNumString);
            string readNumString = File.ReadAllText(@"C:\Users\Ken\Desktop\Open Folder\log154.txt");
            Console.WriteLine(readNumString);
            Console.ReadLine();
        }
    }
}

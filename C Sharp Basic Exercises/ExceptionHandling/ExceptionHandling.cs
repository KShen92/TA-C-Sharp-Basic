﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    class ExceptionHandling
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Pick a number.");
                int numberOne = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Pick a second number.");
                int numberTwo = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Dividing the two...");
                int numberThree = numberOne / numberTwo;
                Console.WriteLine(numberOne + " divided by " + numberTwo + " equals " + numberThree);
                Console.ReadLine();
            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter a whole number.");
                return;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Please don't divide by zero.");
            }
            catch (Exception ex)    // general exceptions
            {
                Console.WriteLine(ex.Message);
            }
            finally // stops execution of everything
            {
                Console.ReadLine();
            }
            Console.ReadLine();
        }
    }
}

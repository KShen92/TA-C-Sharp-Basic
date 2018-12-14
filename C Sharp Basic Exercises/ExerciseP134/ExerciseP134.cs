using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseP134
{
    class ExerciseP134
    {
        static void Main(string[] args)
        {
            bool clearFlag = false;

            while (clearFlag == false)
            {
                Console.WriteLine("Please enter day of the week: ");
                string dayInput = Console.ReadLine();
                string lowerInput = dayInput.ToLower();
                if (Enum.TryParse(lowerInput, out DaysOfWeek inDay))
                {
                    clearFlag = true;
                    string properDay = UppercaseFirst(lowerInput);
                    Console.WriteLine("You selected " + properDay + ".");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Please enter an actual day of the week.");
                    Console.ReadLine();
                }
            }
        }

        static string UppercaseFirst(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return string.Empty;
            }            
            return char.ToUpper(s[0]) + s.Substring(1);
        }

        public enum DaysOfWeek
        {
           monday,
           tuesday,
           wednesday,
           thursday,
           friday,
           saturday,
           sunday
        }
    }
}

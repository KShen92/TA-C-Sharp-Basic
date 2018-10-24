using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseP57
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Tech Academy");
            Console.WriteLine("");
            Console.WriteLine("Student Daily Report - Press Enter to Submit a Report");
            Console.ReadLine();

            Console.WriteLine("");
            Console.WriteLine("What course are you on?");
            string currentCourse = Console.ReadLine();

            bool clearFlag = false;
            int pageNum;
            do
            {
                Console.WriteLine("");
                Console.WriteLine("What page number?");
                if (int.TryParse(Console.ReadLine(), out pageNum))
                {
                    clearFlag = true;
                }
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("Not a number dawg.");
                }
            } while (clearFlag == false);

            clearFlag = false;
            do
            {
                Console.WriteLine("");
                Console.WriteLine("Do you need help with anything? Please answer \"True\" or \"False\".");
                string needsHelp = Console.ReadLine();
                string needsHelpConvert = needsHelp.ToLower();
                if (needsHelpConvert != "true" && needsHelpConvert != "false")
                {
                    Console.WriteLine("");
                    Console.WriteLine("You obviously needed help.");
                }
                else
                {
                    clearFlag = true;
                }
            } while (clearFlag == false);

            Console.WriteLine("");
            Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics.");
            string posExp = Console.ReadLine();

            Console.WriteLine("");
            Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific.");
            string addFeedback = Console.ReadLine();

            clearFlag = false;
            int studyHours;
            do
            {
                Console.WriteLine("");
                Console.WriteLine("How many hours did you study today?");
                if (int.TryParse(Console.ReadLine(), out studyHours))
                {
                    clearFlag = true;
                }
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("Please measure time with numbers like a normal person.");
                }
            } while (clearFlag == false);

            Console.WriteLine("");
            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringFunctions
{
    class StringFunctions
    {
        static void Main(string[] args)
        {
            //changing existing strings actually results in creating a new string under the same string name - see Stringbuilder

            string name = "Jesse";
            string quote = "The man said, \"Hello\", Jesse. \n Hello on a new line. \n \t Hello on a tab.";
            string fileName = @"C:\\Users\\Jesse";

            bool trueOrFalse = name.Contains("s");

            int length = name.Length;

            string upperName = name.ToUpper();

            Console.WriteLine(quote);
            Console.WriteLine(fileName);
            Console.WriteLine(trueOrFalse);
            Console.WriteLine(length);
            Console.WriteLine(upperName);
            Console.ReadLine();

            // useful for high volume string manipulation
            StringBuilder sb = new StringBuilder();
            sb.Append("My name is Ken");
            Console.WriteLine(sb);
            Console.ReadLine();
        }
    }
}

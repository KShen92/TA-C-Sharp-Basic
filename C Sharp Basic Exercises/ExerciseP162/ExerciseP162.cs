using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseP162
{
    class ExerciseP162
    {
        static void Main(string[] args)
        {
            const string openingLine = "Exercise P162 here.";
            Console.WriteLine(openingLine);
            Console.WriteLine("Enter construct name:");
            string constructName = Console.ReadLine();
            var varInput = 6;

            Construct construct = new Construct(constructName, varInput);
            Console.WriteLine("Created {0} armed construct, {1}.",construct.Count,construct.Name);
            Console.ReadLine();

            Construct construct2 = new Construct();
            Console.WriteLine("Created {0} armed construct, {1}.", construct2.Count, construct2.Name);
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iteration
{
    class Iteration
    {
        static void Main(string[] args)
        {
            int[] testScores = { 90, 81, 92, 83, 94, 85, 96, 87, 98, 89, 100 };

            for (int i = 0; i < testScores.Length; i++)
            {
                if (testScores[i] >= 85)
                {
                    Console.WriteLine("Passing test score: " + testScores[i]);
                }
            }
            Console.ReadLine();

            string[] names = { "Ken", "Jesse", "Erik", "Daniel", "Adam" };

            for (int j = 0; j < names.Length; j++)
            {
                if (names[j] == "Ken")
                {
                    Console.WriteLine("AH YES " + names[j] + " THE BEST NAME");
                }
            }
            Console.ReadLine();

            List<int> testScores2 = new List<int>();
            testScores2.Add(75);
            testScores2.Add(80);
            testScores2.Add(85);
            testScores2.Add(90);
            testScores2.Add(95);
            testScores2.Add(99);

            foreach (int score in testScores2)
            {
                if (score > 85)
                {
                    Console.WriteLine("Passing test score: " + score);
                }
            }
            Console.ReadLine();

            List<string> names2 = new List<string>() { "Ken", "Jesse", "Erik", "Adam", "Daniel" };

            foreach (string name in names2)
            {
                    Console.WriteLine(name);
            }
            Console.ReadLine();

            List<int> testScores3 = new List<int>() { 75, 80, 85, 90, 95 };
            List<int> passingScores = new List<int>();

            foreach (int score in testScores3)
            {
                if (score >= 85)
                {
                    passingScores.Add(score);
                }
            }
            Console.WriteLine("There are " + passingScores.Count + " passing scores.");
            passingScores.ForEach(Console.WriteLine);
            Console.ReadLine();
        }
    }
}

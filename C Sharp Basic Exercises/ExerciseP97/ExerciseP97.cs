using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseP97
{
    class ExerciseP97
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tell me your name.");
            string reply1 = "Here lies " + Console.ReadLine() + ". ";
            Console.WriteLine("Tell me about your life.");
            string reply2 = "He who spent his life " + Console.ReadLine() + ". ";
            Console.WriteLine("Tell me of your greatest triumphs and failures.");
            string reply3 = "He who most notably " + Console.ReadLine() + ".";

            string replyFull = reply1 + reply2 + reply3;
            string replyFullCaps = replyFull.ToUpper();

            Console.WriteLine("");
            Console.WriteLine(replyFull);
            Console.WriteLine("...");
            Console.WriteLine("I SAID, " + replyFullCaps);
            Console.ReadLine();

            StringBuilder replyPar = new StringBuilder();
            replyPar.Append(reply1);
            Console.WriteLine(replyPar);
            replyPar.Replace(reply1,reply2);
            Console.WriteLine(replyPar);
            replyPar.Replace(reply2, reply3);
            Console.WriteLine(replyPar);
            Console.ReadLine();
        }
    }
}

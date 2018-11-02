using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseP103
{
    class ExerciseP103
    {
        static void Main(string[] args)
        {
            string[] madLib = { "doge", "CHAD", "Trump", "bananas", "waluigi" };
            Console.WriteLine("Lemme get a dope adjective.");
            string madLibAdj = Console.ReadLine();
            
            for (int madLibIt = 0; madLibIt < madLib.Length; madLibIt++)
            {
                Console.WriteLine(madLibAdj + " " + madLib[madLibIt] + "!");
            }
            Console.ReadLine();

            // Infinite loop:
            //
            //bool infinityFlag = false;
            //while (infinityFlag == false)
            //{
            //    Console.WriteLine("PERFECTLY BALANCED");
            //}

            // Not-so-Infinite loop:
            bool infinityFlag = false;
            while (infinityFlag == false)
            {
                Console.WriteLine("PERFECTLY BALANCED, AS ALL THINGS SHOULD BE");
                infinityFlag = true;
            }
            Console.ReadLine();

            for (int compCounter1 = 0; compCounter1 < 5; compCounter1++)
            {
                Console.WriteLine("< comparison counter: " + compCounter1);
            }
            Console.ReadLine();

            for (int compCounter2 = 0; compCounter2 <= 5; compCounter2++)
            {
                Console.WriteLine("<= comparison counter: " + compCounter2);
            }
            Console.ReadLine();

            List<string> uniqueList = new List<string>() { "doge", "CHAD", "Trump", "bananas", "waluigi", "moardoge" };

            bool lookupFlag = false;
            bool tagFlag = false;
            int tagCount;
            int listIt;
            do
            {
                tagCount = 0;
                Console.WriteLine("Input search terms:");
                string uniqueLookup = Console.ReadLine();
                do
                {
                    for (listIt = 0; listIt < uniqueList.Count; listIt++)
                    {
                        if (uniqueList[listIt].Contains(uniqueLookup))
                        {
                            Console.WriteLine(uniqueLookup + " found in index " + listIt + ": " + uniqueList[listIt]);
                            tagCount++;
                        }

                        if (listIt == (uniqueList.Count - 1) && tagCount > 0)
                        {
                            tagFlag = true;
                            lookupFlag = true;
                        }
                        else if (listIt == (uniqueList.Count - 1) && tagCount == 0)
                        {
                            Console.WriteLine("Search term " + uniqueLookup + " not found.");
                            Console.ReadLine();
                            tagFlag = true;
                        }
                    }
                } while (tagFlag == false);
            } while (lookupFlag == false);
            Console.ReadLine();

            List<string> uniqueList2 = new List<string>() { "doge", "CHAD", "Trump", "bananas", "waluigi", "doge" };

            bool lookupFlag2 = false;
            bool tagFlag2 = false;
            int tagCount2;
            int listIt2;
            do
            {
                tagCount2 = 0;
                Console.WriteLine("Input search terms:");
                string uniqueLookup2 = Console.ReadLine();
                do
                {
                    for (listIt2 = 0; listIt2 < uniqueList2.Count; listIt2++)
                    {
                        if (uniqueList2[listIt2].Contains(uniqueLookup2))
                        {
                            Console.WriteLine(uniqueLookup2 + " found in index " + listIt2 + ": " + uniqueList2[listIt2]);
                            tagCount2++;
                        }

                        if (listIt2 == (uniqueList2.Count - 1) && tagCount2 > 0)
                        {
                            tagFlag2 = true;
                            lookupFlag2 = true;
                        }
                        else if (listIt2 == (uniqueList2.Count - 1) && tagCount2 == 0)
                        {
                            Console.WriteLine("Search term " + uniqueLookup2 + " not found.");
                            Console.ReadLine();
                            tagFlag2 = true;
                        }
                    }
                } while (tagFlag2 == false);
            } while (lookupFlag2 == false);
            Console.ReadLine();

            List<string> stringList = new List<string>() { "doge", "notdoge", "doge", "bush", "notdoge", "doge" };
            List<string> stringListAlt = new List<string>();
            foreach (string listItem in stringList)
            {
                Console.WriteLine("Current Item: " + listItem);
                if (stringListAlt.Contains(listItem))
                {
                    Console.WriteLine("This item has already appeared in the list.");
                }
                else
                {
                    stringListAlt.Add(listItem);
                }
            }
            Console.ReadLine();
        }
    }
}

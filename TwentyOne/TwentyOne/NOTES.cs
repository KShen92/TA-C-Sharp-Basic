using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    class NOTES
    {
        //Object initialization notes
        //Card card = new Card() { Face = "King", Suit = "Spades };

        //TwentyOneGame game = new TwentyOneGame();
        //game.Players = new List<string>() { "Jesse", "Bill", "Ken" };
        //game.ListPlayers();
        //game.Play();
        //Console.ReadLine();

        //Game game = new TwentyOneGame();
        //game.Players = new List<Player>();
        //Player player = new Player();
        //player.Name = "Ken";
        //game = game + player;
        //game += player;
        //game = game - player;
        //game -= player;

        //Enum Notes - Limits value selection to those specified by the enum
        //Underlying value of enum selection 0 - 7, in order. Can also be specified like below.
        //DaysOfTheWeek day = DaysOfTheWeek.Monday;
        //public enum DaysOfTheWeek
        //{
        //    Monday,
        //    Tuesday,
        //    Wednesday,
        //    Thursday,
        //    Friday,
        //    Saturday,
        //    Sunday,
        //    CanAlsoSetUnderlyingValueDay=10
        //}

        //Lambda Function Notes
        //int count = deck.Cards.Count(x => x.Face == Face.Ace);
        //
        //counts number of Face.Ace in deck.Cards
        //
        //List<Card> newList = deck.Cards.Where(x => x.Face == Face.King).ToList();
        //
        //creates list with Face.Kings from deck.Cards
        //
        //List<int> numberList = new List<int>() { 1, 2, 3, 535, 342, 23 };
        //int sum = numberList.Where(x => x > 20).Sum();
        //
        //creates new list of numbers greater than 20 from numberList, sums numbers

        //Write to Notepad
        //string text = "Heart! \r\n \r\n-Moni";
        //File.WriteAllText(@"C:\Users\Ken\Desktop\Open Folder\log.txt", text);
        //string readText = File.ReadAllText(@"C:\Users\Ken\Desktop\Open Folder\log.txt");
        //Console.WriteLine(readText);
        //Console.ReadLine();

        //DateTime function
        //DateTime yearOfBirth = new DateTime(1995, 5, 23, 8, 32, 45);
        //DateTime yearOfGraduation = new DateTime(2013, 6, 1, 16, 34, 22);
        //
        //TimeSpan ageAtGraduation = yearOfGraduation - yearOfBirth;
        //
        //Console.WriteLine(yearOfBirth);
        //Console.WriteLine(yearOfGraduation);
        //Console.WriteLine(ageAtGraduation);
        //Console.ReadLine();

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck deck = new Deck();
            deck.Shuffle(3);

            foreach (Card card in deck.Cards)
            {
                Console.WriteLine(card.Face + " of " + card.Suit);                
            }
            Console.WriteLine(deck.Cards.Count);
            Console.ReadLine();
        }

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
    }
}

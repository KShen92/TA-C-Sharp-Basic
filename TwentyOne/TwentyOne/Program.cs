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
    }
}

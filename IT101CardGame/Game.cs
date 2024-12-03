using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT101CardGame
{
    public class Game
    {
        public Deck myDeck { get; set; }
        public Deck hand { get; set; }
        public Deck dealer { get; set; }

        public int Bank { get; set; }

        public Game()
        {
            myDeck = new Deck();
            hand = new Deck(false);
            dealer = new Deck(false);
            Bank = 100;
        }

        public void Run()
        {
            // your game code goes here
            myDeck.Shuffle();

            for (int i = 0; i < 2; i++)
            {
                hand.AddCard(myDeck.Draw());
                dealer.AddCard(myDeck.Draw());
            }

            PrintDeck(hand, "Player");
            Console.WriteLine("---------------------");
            PrintDeck(dealer, "Dealer");

            if (dealer.GetTotal() == 21 || hand.GetTotal() == 21)
            {
                Console.WriteLine("BLACKJACK");
            }

            if (dealer.GetTotal() >= hand.GetTotal())
            {
                Console.WriteLine("Dealer wins");
            }
            else
            {
                Console.WriteLine("Player wins");
            }
        }

        public void PrintDeck(Deck deck, string label)
        {
            Console.Write($"Cards in {label} Hand: ");
            foreach (Card card in deck.Cards)
            {
                // print values
                Console.Write(card + ", ");
            }
            Console.WriteLine();
            Console.WriteLine($"The {label}'s hand is valued at: {deck.GetTotal()}");
        }
    }
}

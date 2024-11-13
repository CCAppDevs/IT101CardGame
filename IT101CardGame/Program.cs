namespace IT101CardGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int z = 0; z < 5; z++)
            {
                Deck myDeck = new Deck();
                Deck hand = new Deck(false);
                Deck dealer = new Deck(false);
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
        }

        static void PrintDeck(Deck deck, string label)
        {
            Console.Write($"Cards in { label } Hand: ");
            foreach (Card card in deck.Cards)
            {
                // print values
                Console.Write(card + ", ");
            }
            Console.WriteLine();
            Console.WriteLine($"The { label }'s hand is valued at: { deck.GetTotal() }");
        }
    }
}

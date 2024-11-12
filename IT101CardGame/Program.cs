namespace IT101CardGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Deck myDeck = new Deck();
            Deck hand = new Deck(false);
            myDeck.Shuffle();

            for (int i = 0; i < 2; i++)
            {
                hand.AddCard(myDeck.Draw());
            }

            Console.WriteLine();
        }
    }
}

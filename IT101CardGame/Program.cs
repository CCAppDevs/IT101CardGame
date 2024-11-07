namespace IT101CardGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Card[] deck = new Card[52];

            for (int s = 0; s < 4; s++)
            {
                for (int i = 1; i <= 13; i++)
                {
                    string suit = "";

                    switch (s)
                    {
                        case 0:
                            suit = "Hearts";
                            break;
                        case 1:
                            suit = "Diamonds";
                            break;
                        case 2:
                            suit = "Clubs";
                            break;
                        case 3:
                            suit = "Spades";
                            break;
                        default:
                            break;
                    }

                    Card myCard = new Card(i, suit);

                    Console.WriteLine(myCard.ToString());
                }
            }
        }
    }
}

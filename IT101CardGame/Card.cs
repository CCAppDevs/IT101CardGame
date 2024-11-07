using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT101CardGame
{
    public class Card
    {
        public int Rank { get; private set; }
        public string Suit { get; private set; }

        public Card(int rank, string suit)
        {
            Rank = rank;
            Suit = suit;
        }

        public override string? ToString()
        {
            return $"{ RankToString() } of { Suit }";
        }

        private string RankToString()
        {
            string value = "";

            switch (Rank)
            {
                case 1:
                    value = "Ace";
                    break;
                case 11:
                    value = "Jack";
                    break;
                case 12:
                    value = "Queen";
                    break;
                case 13:
                    value = "King";
                    break;
                default:
                    value = Rank.ToString();
                    break;
            }

            return value;
        }
    }
}

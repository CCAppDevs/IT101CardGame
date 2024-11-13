using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT101CardGame
{
    public class Deck
    {
        public List<Card> Cards { get; private set; }

        public Deck(bool init = true)
        {
            Cards = new List<Card>();
            // create a deck of cards
            if (init)
            {
                ResetDeck();
            }
        }

        public void ResetDeck()
        {
            // empty the deck
            Cards.Clear();

            // create a fresh deck
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

                    Cards.Add(new Card(i, suit));
                }
            }
        }

        public void Shuffle()
        {
            Random rand = new Random();

            Cards = Cards.OrderBy(x => rand.Next()).ToList();
        }

        public Card Draw()
        {
            // get the first element of cards
            Card card = Cards[0];

            // delete the first element from cards
            Cards.RemoveAt(0);

            // return the saved element
            return card;
        }

        public void AddCard(Card card)
        {
            Cards.Add(card);
        }

        public int GetTotal()
        {
            // bucket to hold the total
            int total = 0;

            // loop over all cards in the deck
            for (int i = 0; i < Cards.Count; i++)
            {
                // add the card's value to the total
                total += Cards[i].GetValue();
            }

            return total;
        }
    }
}

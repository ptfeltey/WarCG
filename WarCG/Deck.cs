using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarCG
{
    class Deck
    {
        public List<Card> FullDeck;
        public Card testCard;
        public Deck()
        {
            FullDeck = new List<Card>();
            testCard = new Card();
            testCard.CardSuit = 0;
            for (int suit = 0; suit < 4; ++suit)
            {
                Console.WriteLine(testCard.CardSuit);
            }

        }
    }
}

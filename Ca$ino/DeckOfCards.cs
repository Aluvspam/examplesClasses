using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino
{
    public class DeckOfCards
    {
       public Card [] deck;
        public Random ranNum;
        public int currentCard;
        public int numberOfCard = 52;

        public DeckOfCards()
        {
            currentCard = 0;
            ranNum = new Random();
            deck = new Card[] { new Card() };
           

        }
        public Card PullCard()
        {
            if (currentCard < deck.Length)
            {
                return deck[currentCard++];

            }
            else
            {
                return null;
            }
        }
    }
}

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
            deck = new Card;

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

        public enum CardNumber
        {
            Two = 2,
            Three = 3,
            Four = 4,
            Five = 5,
            Six = 6,
            Seven = 7,
            Eight = 8,
            Nine = 9,
            Ten = 10,
            J = 12,
            Q = 13,
            K = 14,
            A = 15
        }
    }
}

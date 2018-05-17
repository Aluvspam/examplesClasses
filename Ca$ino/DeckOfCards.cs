using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino
{
    public class DeckOfCards
    {
        public Card[] deck;
        public static Random ranNum;
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
        public static Card[] Suffle(Card[] initialSet)
        {
            Card[] exitSet = new Card[] { };

            for (int i = 0; i < initialSet.Length; i++)
            {

                exitSet[i] = initialSet[ranNum.Next(0, 52)];
            }

            return exitSet;
        
        }
    }
}

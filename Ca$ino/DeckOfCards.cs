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
        public static void Shuffle(Card[] initialSet)
        {
            int n = initialSet.Length;
            for (int i = 0; i < n; i++)
            {
                int random = i + ranNum.Next(n - i);
                var temp = initialSet[random];
                initialSet[random] = initialSet[i];
                initialSet[i] = temp;
            }
        }

    }
}


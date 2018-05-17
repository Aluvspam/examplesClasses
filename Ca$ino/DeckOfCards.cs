using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino
{
    public class DeckOfCards
    {
        
        private Card[] deck;
        private static Random ranNum;
        private int currentCard;
        private int numberOfCard = 52;

        public DeckOfCards()
        {
            currentCard = 0;
            ranNum = new Random();
            deck = new Card[] { new Card() };//Dana: aici am vrut sa spun deck = new Card[numberOfCard],dar vedem ce si cum 


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
        public void Shuffle(Card[] initialSet)//am sters static ca sa pot chema metoda din main dar nu stiu ce-i cu acest parametru
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


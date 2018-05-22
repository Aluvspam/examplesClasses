using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino
{
    public class DeckOfCards
    {

        private static Card[] initialSet;
        private static Random ranNum;
        private int currentCard;
        private int numberOfCard = 52;
        private List<Card> deckCards = new List<Card>();//am facut si o lista de carti, dar apare o eroare, ca cica e null, de ce?

        public DeckOfCards()
        {
            CardRank[] rank = { CardRank.Two, CardRank.Three,CardRank.Four,CardRank.Five,CardRank.Six,CardRank.Seven,CardRank.Eight,CardRank.Nine,CardRank.Ten,CardRank.Jack,CardRank.Queen,CardRank.King,CardRank.Ace};//am adaugat enumurile de CardRank, in loc de string-ul initial

            CardSuit[] suit = { CardSuit.Club,CardSuit.Diamond,CardSuit.Heart,CardSuit.Spade}; // { "Club \u2663 ", "Diamond \u2666", "Spade \u2660", "Heart \u2665" }; am adaugat enumurile de CardSuit, in loc de string-ul initial = TO DO: un overide ToString() pentru a folosi iconitele Danei

            currentCard = 0;
            ranNum = new Random();
            initialSet = new Card[numberOfCard];
            //populez pachetul de carti
            for (int count = 0; count < initialSet.Length; count++)
            {
                initialSet[count] = new Card(rank[count % 13], suit[count / 13]);
                deckCards.Add(new Card(rank[count % 13], suit[count / 13]));//aici populam pachetul dupa algoritmul Danei
            }
        }
        public Card PullCard()
        {
            if (currentCard < initialSet.Length)
            {
                return initialSet[currentCard++];
            }
            else
            {
                return null;
            }
        }
        public static void Shuffle()
        {
            int n = initialSet.Length;
            for (int i = 0; i < n; i++)
            {
                int random = i + ranNum.Next(n - i);//i + (0...51)?
                // partea de jos e o schimbare ca la Bubble = se produce o inversare de la cartea gasita in random cu cartea aflata la index-ul i
                var temp = initialSet[random];
                initialSet[random] = initialSet[i];
                initialSet[i] = temp;
            }
        }
        public void ShuffleforList()//cu liste, de verificat!! TO DO: de catre maestrul ANDREI
        {
            List<Card> cartiShuff = new List<Card>();
            for (int i = deckCards.Count; i > deckCards.Count; i--)
            {
                deckCards.Remove(deckCards[ranNum.Next(i)]);//aici scoate cu ranNum cartea la index-ul gasit 
                cartiShuff.Add(deckCards[ranNum.Next(i)]);//aici adauga cu ranNum cartea la index-ul gasit
            }
            deckCards = cartiShuff;// si aici salvam in deck-ul initial cartile amestecate 
        }

        public static void Execute()
        {
            DeckOfCards deck = new DeckOfCards();
            Shuffle();
            deck.ShuffleforList();//aici chemam metoda de shuffle for list
            for (int i = 0; i < 52; i++)
            {
                Console.WriteLine("{0, -19}", deck.PullCard());
                if (i % 4 == 0)
                {
                    Console.WriteLine();
                }
            }
            Console.ReadLine();
        }
    }
}

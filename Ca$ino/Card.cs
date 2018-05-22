using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino
{
    public class Card 
    {
        private CardSuit suit;//am modificat din tipul initial (string) in Enum de CardSuit
        private CardRank rank;//am modificat din tipul initial (string) in Enum de CardRank

        public Card(CardRank CardRank, CardSuit CardSuit)
        {
            suit = CardSuit;
            rank = CardRank;
        }
        //public CardNumber number
        //{
        //    get
        //    {
        //        return this.number;
        //    }
        //    set
        //    {
        //        this.number = value;
        //    }
        //}


        //public CardSuit color

        //{
        //    get
        //    {
        //        return this.color;
        //    }
        //    set
        //    {
        //        this.color = value;
        //    }
        //}


        //public override bool Equals(object obj)
        //{
        //    return base.Equals(obj);
        //}

        public override string ToString()
        {
            return rank + " of " + suit;
        }
    }
}

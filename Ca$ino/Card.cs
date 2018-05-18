using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino
{
    public class Card
    {
        private CardNumber number;
        //private CardColor color;  -> nu e inca implementata

        public CardNumber number 
        {
            get 
            { 
                return number; 
            }
            set 
            {
                number = value;
            }
        }

        /*
        public CardColor color 
        {
            get 
            { 
                return color; 
            }
            set 
            {
                color = value;
            }
        }
        */

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Casino
{
    public class Dice
    {
        private int die1;
        private int die2;
        public int Die1
        {
            get { return die1; }
            set { die1 = value; }
        }
        public int Die2
        {
            get { return die2; }
            set { die2 = value; }
        }
        public Dice()
        {
            var newdie1 = Die1;
            var newdie2 = Die2;
        }
        public int RollDice()
        {
            Random rng = new Random();
            Die1 = rng.Next(1, 7);
            Die2 = rng.Next(1, 7);
            int[] result = new int[] { Die1, Die2 };
            return result;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Casino
{
    public class Dice
    {
        private static int die1;
        private static int die2;
        public static int Die1
        {
            get { return die1; }
            set { die1 = value; }
        }
        public static int Die2
        {
            get { return die2; }
            set { die2 = value; }
        }
        public Dice()
        {
            var newdie1 = Die1;
            var newdie2 = Die2;
        }
        public static int[] RollDice()
        {
            Random rng = new Random();
            Die1 = rng.Next(1, 7);
            Die2 = rng.Next(1, 7);
            int[] result = new int[] { Die1, Die2 };
            return result;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TFT
{
    class RandomPlayer : IPlayer
    {
        public Moves FirstMove()
        {
            return RandomMove();
        }

        public Moves MyMove(Moves myLastMove, Moves othersLastMove)
        {
            return RandomMove();
        }

        private Moves RandomMove()
        {
            return ((new Random()).Next(2) == 0) ? Moves.C : Moves.D;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TFT
{
    class LuanaPlayer : IPlayer
    {
        public Moves FirstMove()
        {
            return Moves.C;
        }

        public Moves MyMove(Moves myLastMove, Moves othersLastMove)
        {
            if(myLastMove == Moves.C && othersLastMove == Moves.C)
           {
               return Moves.C;
           }else (myLastMove == Moves.C && othersLastMove == Moves.D)
                {
                
                return Moves.D;
                }
        }

        private Moves LuanaMove()
        {
            
            return ((new Random()).Next(2) == 0) ? Moves.C : Moves.C;
        }

        
    }
}

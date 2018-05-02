using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TFT
{
    public delegate void BossDelegate();

    abstract class AbstractTFTPlayer : IPlayer
    {
        public event BossDelegate event1;
        public event BossDelegate event2;

        protected AbstractStrategy strategy;
        public virtual Moves FirstMove()
        {
            return Moves.C;
        }
        protected void Invoke1()
        {
            event1.Invoke();
        }
        public virtual Moves MyMove(Moves myLastMove, Moves othersLastMove)
        {
            var result = (othersLastMove == Moves.B) ? Moves.D : othersLastMove;
            return result;
        }
        public void Event1Handler()
        {
            if (event2 != null)
            {
                event2.Invoke();
            }
        }
        public virtual void Event2Handler()
        {

        }
    }
}

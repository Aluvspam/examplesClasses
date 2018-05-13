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
        public static event BossDelegate event1;
        public static event BossDelegate event2;
        public Moves myLastMove;
        public Moves hisLastMove;

        protected AbstractStrategy strategy;

        public AbstractTFTPlayer()
        {

        }

        public virtual Moves FirstMove()
        {
            return Moves.C;
        }
        protected bool Invoke1()
        {
            if (event1 != null)
            {
                //WhenIInvoke1();
                event1.Invoke();
                return true;
            }
            return false;
        }
        public virtual Moves MyMove(Moves myLastMove, Moves othersLastMove)
        {
            var result = (othersLastMove == Moves.B) ? Moves.D : othersLastMove;
            return result;
        }
        protected virtual void Event1Handler()
        {
            if (event2 != null)
            {
                event2.Invoke();
            }
        }
        protected virtual void Event2Handler()
        {

        }
        /// <summary>
        /// method that helps classes that inherits this class to subscribe to events
        /// </summary>
        /// <param name="n">number of the event to subscribe to</param>
        /// <param name="a">the delegate you wish to subscribe to the event</param>
        public void Subscribe(byte n, BossDelegate a)
        {
            if (n == 1)
            {
                event1 += a;
            }
            else if (n == 2)
            {
                event2 += a;
            }
        }
        //protected virtual void WhenIInvoke1()
        //{
        //}
    }
}

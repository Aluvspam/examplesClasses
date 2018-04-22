using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TFT
{
    interface IPlayer
    {
        Moves MyMove(Moves myLastMove, Moves othersLastMove);
        Moves FirstMove();
    }
}

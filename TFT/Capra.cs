using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLog;

namespace TFT
{
    class Capra : AbstractStrategy
    {
        private static Logger logger;
        public override Moves MoveLikeABoss(AbstractTFTPlayer player)
        {
            logger.Trace("Capra strategy called");
            return Moves.C;
        }
    }
}

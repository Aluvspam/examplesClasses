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
        private static Logger logger = LogManager.GetCurrentClassLogger();
     //   private static ALog aLogger = new ALog();
        public override Moves MoveLikeABoss(AbstractTFTPlayer player)
        {
            logger.Trace("Capra strategy called");
            //aLogger.Log("Capra strategy called");
            return Moves.C;
        }
    }
}

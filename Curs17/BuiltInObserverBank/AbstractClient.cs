using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curs17.BuiltInObserverBank
{
    class AbstractClient
    {
        protected Bank Bank;

        public AbstractClient(Bank bank)
        {
            Bank = bank;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Examples.CoR
{
    class HandlerDana: AbstractHandler
    {
        public override void Handle(Request r)
        {//TEma - un handler al carui constructor sa primeasca un 
            //integer si pe baza lui sa dea rapunsuri
            if (CanHandle(r))
            {
                if (r.X==15||r.X==3)
                {
                    int y = r.X;
                    Console.WriteLine(words[y]);
                    r.Handled = true;

                }
                base.Handle(r);
            }
        }

        private bool CanHandle(Request r)
        {
            throw new NotImplementedException();
        }
    }
}

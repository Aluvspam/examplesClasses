using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Examples.CoR
{
    class HandlerDana: AbstractHandler
    {
        private int x;//fac un camp ca sa pot stoca in el
        
        //Andrei Prof.
        public HandlerDana(int numarul)
        {
            x = numarul;
        }
        public override void Handle(Request r)
        {//TEma - un handler al carui constructor sa primeasca un 
         //integer si pe baza lui sa dea rapunsuri
         // ctr handle mix sa primeasca un integer ca sa stie el...handlerii sa faca acelasi lucru 
         //o clasa constructor de handlere
         // Ma uit la handler 3 si 5, au cod comun, si vreau o clasa ca sa fie handler ca sa fie comun pt toate iar constr ei sa primeasca ca parametru un integer
         //un handler comun ca sa functioneze pt toate
            if (CanHandle(r))
            {
                {
                    Console.WriteLine(words[x]);
                    r.Handled = true;
                }
                base.Handle(r);
            }
        }
        private bool CanHandle(Request r)
        {
            return (r.X % x == 0);
        }
    }
}

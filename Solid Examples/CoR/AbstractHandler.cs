using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Examples.CoR
{
    public class AbstractHandler
    {
        //TEma - un handler al carui constructor sa primeasca un 
        //integer si pe baza lui sa dea rapunsuri
        // ctr handle mix sa primeasca un integer ca sa stie el...handlerii sa faca acelasi lucru 
        //o clasa constructor de handlere
        // Ma uit la handler 3 si 5, au cod comun, si vreau o clasa ca sa fie handler ca sa fie comun pt toate iar constr ei sa primeasca ca parametru un integer
        //un handler comun ca sa functioneze pt toate

        protected Dictionary<int, string> words;
        public AbstractHandler nextHandler;
        public AbstractHandler()
        {
            words = new Dictionary<int, string>();
            words.Add(3, "Fizz");
            words.Add(5, "Buzz");
            words.Add(7, "Gizz");
            words.Add(11, "Quizz");
            words.Add(13, "Jazz");
           

        }
        public virtual void Handle(Request r)
        {
            if (nextHandler != null)
            {
                nextHandler.Handle(r);
            }
        }
        public void AddHandler(AbstractHandler ah)
        {
            if (nextHandler == null)
            {
                nextHandler = ah;
            }
            else
            {
                nextHandler.AddHandler(ah);
            }
        }
    }
}

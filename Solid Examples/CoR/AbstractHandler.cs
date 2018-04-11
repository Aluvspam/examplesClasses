using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Examples.CoR
{
    public class AbstractHandler
    {
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
            words.Add(15, "Dana");

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

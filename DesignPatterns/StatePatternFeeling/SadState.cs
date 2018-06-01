using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DesignPatterns.StatePatternFeeling
{
    public class SadState : AbstractState
    {
        public override void GoNext(Human human)
        {
            human.SetState(new HappyState());
        }

        public override void ToDo(Human human)
        {
            Console.WriteLine("The human is now sad...");
            Thread.Sleep(1000);
            GoNext(human);
        }
    }
}

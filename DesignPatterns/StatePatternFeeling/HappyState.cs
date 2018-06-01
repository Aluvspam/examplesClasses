using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DesignPatterns.StatePatternFeeling
{
    public class HappyState : AbstractState
    {
        public override void GoNext(Human human)
        {
            human.SetState(new SadState());
        }

        public override void ToDo(Human human)
        {
            Console.WriteLine("The human is now happy...");
            Thread.Sleep(1000);
            GoNext(human);
        }
    }
}

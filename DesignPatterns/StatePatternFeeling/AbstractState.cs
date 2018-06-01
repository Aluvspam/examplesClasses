using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.StatePatternFeeling
{
    public abstract class AbstractState
    {
        public abstract void ToDo(Human human);
        public abstract void GoNext(Human human);
    }
}

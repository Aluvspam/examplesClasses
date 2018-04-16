using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Examples.CoR
{
    public class FizzBuzz
    {
        AbstractHandler handler;
        public FizzBuzz()
        {
            handler = new HandlerDana(3);
            handler.AddHandler(new HandlerDana(5));
           // handler.AddHandler(new HandlerMixAndreiR());
            handler.AddHandler(new FinalHandle());
        }
        public FizzBuzz(int a, int b)
        {
            //handler = new Handler(a);
            //handler.AddHandler(new Handler(b));
            handler.AddHandler(new FinalHandle());
        }
        public void Run(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                handler.Handle(new Request(i));
            }
        }
    }
}

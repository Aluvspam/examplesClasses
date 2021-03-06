﻿namespace Solid_Examples.CoR
{
    public class FizzBuzz
    {
        AbstractHandler handler;
        public FizzBuzz()
        {
            handler = new HandleUniversal(7);
            handler.AddHandler(new HandleUniversal(11));
            //handler.AddHandler(new HandlerMix());
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

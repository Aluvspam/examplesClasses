using System;

namespace ChainOfResponsability
{
    public class Handler
    {
        Handler nextHandler;

        public void handle()
        {
            nextHandler.handle();
        }
    }
}

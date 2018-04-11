using System;
using System.Timers;

public class Class1
{
	public Class1()
	{

        Timer myTimer = new Timer(2000); //2 sec
        //unul din overloaded constr. al acestui timer, ne permite sa 
        //pasam intervalul in milisecunde
        myTimer.Elapsed += MyTimer_Elapsed;
        //atasez evenimentul MyTimer_Elapsed la event Elapsed
        myTimer.Start();
        Console.ReadLine();
	}

    private void MyTimer_Elapsed(object sender, ElapsedEventArgs e)
    {
        //scriu codul care vreau sa se execute de fiecare data cand Elapsed este declansat
        Console.WriteLine("Elapsed: {0:HH:MM:ss.fff}" + e.SignalTime);
    }
}

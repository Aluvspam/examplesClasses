using System;
using System.Collections.Generic;

/**
 * Auto-generated code below aims at helping you parse
 * the standard input according to the problem statement.
 **/
class Clash
{
    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());
        List<string> result = new List<string>();
        for (int i = 0; i < N; i++)
        {
            string ROW = Console.ReadLine();
            Console.WriteLine(ROW.Replace('0', '-'));
            //result.Add(ROW.Replace('0', '-'));
        }
        //var output = string.Empty;
        //for (int i = 0; i < result.Count - 1; i++)
        //{

        //}
    }
}
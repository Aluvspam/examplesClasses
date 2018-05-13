using System;
using System.Threading.Tasks;
namespace ExercisesCsharp
{
    class DanProblem
    {
        public static void Execute()
        {
            string word = String.Empty;
            string reverseWord = String.Empty;
            Console.WriteLine("Write any word: ");
            word = Console.ReadLine();
            for (int i = word.Length - 1; i >= 0; i--)
                reverseWord += word[i];
            Console.WriteLine("Reverse word :- " + reverseWord);
            Console.ReadKey();
        }
    }
}
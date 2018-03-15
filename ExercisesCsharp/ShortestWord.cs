using System;

namespace ExercisesCsharp
{
    //Simple, given a string of words, return the length of the shortest word(s).
    //String will never be empty and you do not need to account for different data types.

    public class ShortestWord
    {
        public static int FindShort(string s)
        {
            string[] words = s.Split(" ");
            int shortestWord = Int32.MaxValue;

            foreach (String w in words)
            {
                if (w.Length < shortestWord)
                {
                    shortestWord = w.Length;
                }
            }

            return shortestWord;

        }
    }
}
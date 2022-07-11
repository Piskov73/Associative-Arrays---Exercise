using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Count_Chars_in_a_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> textWords = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            Dictionary<char, int> charCounter = new Dictionary<char, int>();
            charCounter = CharCounter(textWords, charCounter);
            PrintCharConter(charCounter);


        }



        static Dictionary<char, int> CharCounter(List<string> textWords, Dictionary<char, int> charCounter)
        {
            char tem = ' ';
            foreach (var word in textWords)
            {
                for (int i = 0; i < word.Length; i++)
                {
                    tem = word[i];
                    if (charCounter.ContainsKey(tem))
                    {
                        charCounter[tem]++;
                    }
                    else
                    {
                        charCounter.Add(tem, 1);
                    }
                }
            }
            return charCounter;
        }

        static void PrintCharConter(Dictionary<char, int> charCounter)
        {
            foreach (var ch in charCounter)
            {
                Console.WriteLine($"{ch.Key} -> {ch.Value}");
            }
        }
    }
}

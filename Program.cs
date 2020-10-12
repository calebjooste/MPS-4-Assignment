using System;

namespace MPS_4_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            string charCounts = Words.CountCharactersInSentence("Hello world");
            Console.WriteLine(charCounts);
        }
    }
}

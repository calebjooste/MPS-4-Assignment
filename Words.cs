using System;
using System.Collections.Generic;
using System.Text;

namespace MPS_4_Assignment
{
    class Words
    {
        public static string CountCharactersInSentence(string inputString)
        {
            string Alphabet_inputString = inputString;
            string r = "";
            //int i = 0;
            Alphabet_inputString = Alphabet_inputString.Replace(" ", string.Empty);
            while (Alphabet_inputString != "")
            {
                char first = Alphabet_inputString[0];
                int Repeats = 1;
                for (int j = 1; j < Alphabet_inputString.Length; j++)
                {
                    if (Alphabet_inputString[j] == first)
                    {
                        Repeats++;
                    }
                }
                r += " " + first + " = " + Repeats + " ";
                Alphabet_inputString = Alphabet_inputString.Replace(new String(first, 1), string.Empty);
            }
            return r;
        }
    }
}

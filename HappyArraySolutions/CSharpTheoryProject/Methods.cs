using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTheoryProject
{
    internal class Methods
    {
        public static int CountWordsWithMoreThanFourLetters(string str) 
        { 
            int count = 0;

            string[] words = str.Split(' ').ToArray();

            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length >= 4)
                {
                    count++;
                }
            }

            return count;
        }
    }
}

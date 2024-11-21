using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTheoryProject
{
    internal class TextHelper
    {
        private string Text { get; set; }

        public TextHelper(string text) 
        {
            Text = text;
        }
        public bool IsStringPalindrome()
        {
            string str = Text;
            bool result = true;

            if (str == null || str.Length == 0)
            {
                result = false;
            }

            for (int i = 0, j = str.Length - 1; i < str.Length / 2 & j >= str.Length / 2; i++, j--)
            {
                if (str[i] != str[j])
                {
                    result = false;
                    break;
                }
            }
            return result;
        }

        public int CountWordsWithMoreThanFourLetters()
        {
            string str = Text;
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
        public void CountVowels()
        {
            string text = Text;

            Dictionary<char, int> vowels = new Dictionary<char, int>()
            {
                { 'a', 0 },
                { 'e', 0},
                { 'i', 0},
                { 'o', 0},
                { 'u', 0}
            };

            for (int i = 0; i < text.Length; i++)
            {
                if (vowels.ContainsKey(text[i]))
                {
                    vowels[text[i]]++;
                }
            }

            foreach (var kvp in vowels)
            {
                if(kvp.Value > 0) 
                {
                    Console.WriteLine(kvp.Key + " - " + kvp.Value);
                }
            }
        }
    }
}

using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
            string text = Text;

            bool result = true;

            if (string.IsNullOrEmpty(text)) return false;

            for (int i = 0, j = text.Length - 1; i < j; i++, j--)
            {
                if (text[i] != text[j])
                {
                    result = false;
                    break;
                }
            }
            return result;
        }

        public int CountWordsWithMoreThanFourLetters()
        {

            string cleanedText = Regex.Replace(Text, @"[^a-zA-Z\s]", " ");
            string[] words = cleanedText.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            return words.Count(word => word.Length >= 4);

            //int count = 0;
            //string text = Text;

            //string[] words = text.ToLower().Split(' ').ToArray();

            //for (int i = 0; i < words.Length; i++)
            //{
            //    if (words[i].Length >= 4)
            //    {
            //        count++;
            //    }
            //}
            //return count;
        }

        public void CountVowels()
        {
            string text = Text.ToLower();

            Dictionary<char, int> vowels = new Dictionary<char, int>()
            {
                { 'a', 0 },
                { 'e', 0 },
                { 'i', 0 },
                { 'o', 0 },
                { 'u', 0 },
            };

            for (int i = 0; i < text.Length; i++)
            {
                if (vowels.ContainsKey(text[i]))
                {
                    vowels[text[i]]++;
                }
            }

            foreach (var kv in vowels)
            {
                if (kv.Value > 0)
                {
                    Console.WriteLine($"{kv.Key} - {kv.Value}");
                }
            }
        }

        public string ReverseWords()
        {
            string text = Text;
            var words = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            List<string> wordsReverse = new List<string>();

            for (int i = words.Length - 1; i >= 0; i--)
            {
                wordsReverse.Add(words[i]);
            }

            string result = string.Join(" ", wordsReverse);

            return result;
        }

        public string RemoveDuplicateLetters()
        {
            string text = Text.ToLower();
            HashSet<char> uniqueLetters = new HashSet<char>();

            for (int i = 0; i < text.Length; i++)
            {
                if (!uniqueLetters.Contains(text[i]))
                {
                    uniqueLetters.Add(text[i]);
                }
            }


            string result = String.Join("", uniqueLetters);
            return result;
        }
    }
}

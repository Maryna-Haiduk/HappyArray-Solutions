using System.Text;
using System.Threading.Tasks;

namespace CSharpTheoryProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string myText = Console.ReadLine();

            TextHelper myTextHelper = new TextHelper(myText);
            Console.WriteLine("Is Palindrome: " + myTextHelper.IsStringPalindrome());
            Console.WriteLine("Count Words With More Than FourLetter: " + myTextHelper.CountWordsWithMoreThanFourLetters());
            Console.WriteLine("Count vowels: ");
            myTextHelper.CountVowels();
        }
    }
}
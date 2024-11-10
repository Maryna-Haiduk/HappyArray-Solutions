using System.Text;
using System.Threading.Tasks;

namespace CSharpTheoryProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TextHelper myTextHelper = new TextHelper("Hello, Friend!");
            bool result1 = myTextHelper.IsStringPalindrome();
            Console.WriteLine($"Is string palindrome: {result1}");
            
            Console.WriteLine("Result of counting vowels: ");
            myTextHelper.CountVowels();

            Console.WriteLine($"How many words has more than four letters: {myTextHelper.CountWordsWithMoreThanFourLetters()}");

            Console.WriteLine(myTextHelper.ReverseWords());
            Console.WriteLine($"Remove Duplicate Letters: {myTextHelper.RemoveDuplicateLetters()}");
        }
    }
}
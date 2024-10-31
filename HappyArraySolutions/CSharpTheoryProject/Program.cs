using System.Text;
using System.Threading.Tasks;

namespace CSharpTheoryProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Write your string: ");
            string isPalindoreCheck = Console.ReadLine();
            Console.WriteLine("Your string is a palindrome: " + Methods.IsStringPalindrome(myString));
          
            Console.WriteLine("Create your string to count the number of words in it that have more than 4 letters: ");
            string moreThanFourLettersCheck = Console.ReadLine();
            Console.WriteLine("Number of words with more then 4 letters: " + Methods.CountWordsWithMoreThanFourLetters(moreThanFourLetters));
        }
    }
}
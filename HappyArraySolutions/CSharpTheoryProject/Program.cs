using System.Text;
using System.Threading.Tasks;

namespace CSharpTheoryProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Create your string to count the number of words in it that have more than 4 letters: ");
            string moreThanFourLetters = Console.ReadLine();
            Console.WriteLine("Number of words with more then 4 letters: " + Methods.CountWordsWithMoreThanFourLetters(moreThanFourLetters));
        }
    }
}
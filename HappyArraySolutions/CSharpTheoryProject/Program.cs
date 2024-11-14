using System.Text;
using System.Threading.Tasks;

namespace CSharpTheoryProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> productsDic = new Dictionary<string, string>()
            {
                { "Cheese", "Dairy" },
                {"Carrots", "Produce"},
                {"Romaine Lettuce", "Produce"},
                {"Chocolate Milk", "Dairy"},
                {"Flour", "Pantry"},
                {"Iceberg Lettuce", "Produce"},
                {"Coffee", "Pantry"},
                {"Pasta", "Pantry"},
                {"Milk", "Dairy"},
                {"Blueberries", "Produce"},
                {"Pasta Sauce", "Pantry" }
            };

            List<string[]> products = new List<string[]>
            {
                new string[] {"Cheese", "Dairy" },
                new string[] {"Carrots", "Produce"},
                new string[] {"Romaine Lettuce", "Produce"},
                new string[] {"Chocolate Milk", "Dairy"},
                new string[] {"Flour", "Pantry"},
                new string[] {"Iceberg Lettuce", "Produce"},
                new string[] {"Coffee", "Pantry"},
                new string[] {"Pasta", "Pantry"},
                new string[] {"Milk", "Dairy"},
                new string[] {"Blueberries", "Produce"},
                new string[] {"Pasta Sauce", "Pantry" }
            };

            List<string> shopingList = new List<string>()
            {
                "Blueberries", "Milk", "Coffee", "Flour", "Cheese", "Carrots"
            };

            List<string> shopingList2 = new List<string>()
            {
                "Blueberries", "Carrots", "Coffee", "Milk", "Flour", "Cheese"
            };

            List<string> shopingList3 = new List<string>()
            {
                "Blueberries", "Carrots", "Romaine Lettuce", "Iceberg Lettuce"
            };
            List<string> shopingList4 = new List<string>()
            {
                "Milk", "Flour", "Chocolate Milk", "Pasta Sauce"
            };
            List<string> shopingList5 = new List<string>()
            {
                "Cheese", "Potatoes", "Blueberries", "Canned Tuna"
            };

            Console.WriteLine(CampingTripShoping.SaveShopingTime(productsDic, shopingList5));

            //Console.Write("Write your string: ");
            //string isPalindoreCheck = Console.ReadLine();
            //Console.WriteLine("Your string is a palindrome: " + Methods.IsStringPalindrome(isPalindoreCheck));
          
            //Console.WriteLine("Create your string to count the number of words in it that have more than 4 letters: ");
            //string moreThanFourLettersCheck = Console.ReadLine();
            //Console.WriteLine("Number of words with more then 4 letters: " + Methods.CountWordsWithMoreThanFourLetters(moreThanFourLettersCheck));
        }
    }
}
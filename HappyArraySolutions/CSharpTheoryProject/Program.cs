namespace CSharpTheoryProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Write your string: ");
            string myString = Console.ReadLine();
            Console.WriteLine("Your string is a palindrome: " + Methods.IsStringPalindrome(myString));
        }
    }
}

using System.Text.RegularExpressions;

namespace _01.MatchFullName
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\b(?<FirstName>[A-Z][a-z]+) (?<LastName>[A-Z][a-z]+)\b";
            string textInput = Console.ReadLine();

            MatchCollection matchCollection = Regex.Matches(textInput, pattern);

            foreach (Match match in matchCollection)
            {
                Console.Write(match.Value + " ");
            }
            Console.WriteLine();
        }
    }
}

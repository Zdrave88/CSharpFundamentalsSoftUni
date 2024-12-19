using System.Net.Http.Headers;
using System.Text.RegularExpressions;

namespace _03.MatchDates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string input = Console.ReadLine();
            //string pattern = @"(?<day>\d{2})(?<separator>\.|\-|\/)(?<month>[A-Z][a-z]{2})\k<separator>(?<year>\d{4})";

            //MatchCollection matchCollection = Regex.Matches(input, pattern);

            //foreach (Match match in matchCollection)
            //{
            //    Console.WriteLine($"Day: {match.Groups["day"]}, Month: {match.Groups["month"]}, Year: {match.Groups["year"]}");
            //}

            string input = Console.ReadLine();
            string pattern = @"(?<day>\d{2})(?<separator>\.|\-|\/)(?<month>[A-Z][a-z]{2})\k<separator>(?<year>\d{4})";

            MatchCollection matchCollection = Regex.Matches(input, pattern);
            foreach (Match match in matchCollection)
            {
                var day = match.Groups["day"].Value;
                var month = match.Groups["month"].Value;
                var year = match.Groups["year"].Value;

                Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
            }
        }
    }
}

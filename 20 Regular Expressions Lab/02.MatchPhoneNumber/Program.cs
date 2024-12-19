using System.Text.RegularExpressions;
using System.Threading.Channels;

namespace _02.MatchPhoneNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\+359(\ |-)2\1\d{3}\1\d{4}\b";
            string textInput = Console.ReadLine();

            MatchCollection matchCollection = Regex.Matches(textInput, pattern);

            Console.WriteLine(string.Join(", ", matchCollection));
           
        }
    }
}

using System.Net.Http.Headers;
using System.Security.AccessControl;

namespace _04.TextFilter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] bannedWords = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
            string wordsText = Console.ReadLine();

            foreach (string bannedWord in bannedWords)
            {
                string cencoredWord = new string('*', bannedWord.Length);
                //ordsText = wordsText.Replace(bannedWord, new string('*', bannedWord.Length));
                wordsText = wordsText.Replace(bannedWord, cencoredWord);
            }
            Console.WriteLine(wordsText);
        }
    }
}

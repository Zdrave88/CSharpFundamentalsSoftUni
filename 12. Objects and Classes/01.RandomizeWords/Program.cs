using System.Runtime.InteropServices;

namespace _01.RandomizeWords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(" ");


            // set class Random called "randomizer"
            Random randomizer = new();

            for (int i = 0; i < words.Length; i++)
            {
                // take random word at random index
                int randomIndex = randomizer.Next(0, words.Length);

                // set words[i] as a temporary word
                string tempWord = words[i];

                // set words[i] as the random word taken bafore 
                words[i] = words[randomIndex];

                // set the random word as the temporary word
                words[randomIndex] = tempWord;
            }

            foreach (string word in words)
            {
                Console.WriteLine($"{word}");
            }
        }
    }
}

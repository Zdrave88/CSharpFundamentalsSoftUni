using System.Text;

namespace _02.RepeatStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            StringBuilder output = new StringBuilder();

            foreach (string word in words)
            {
                int wordLength = word.Length;

                for (int i = 0; i < wordLength; i++)
                {
                   output.Append(word);
                }
            }
            Console.WriteLine(output);


            //string[] words = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            //foreach (string word in words)
            //{
            //    int wordLength = word.Length;

            //    for (int i = 0; i < wordLength; i++)
            //    {
            //        Console.Write(word);
            //    }
            //}
        }
    }
}

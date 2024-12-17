using System.Text;

namespace _05.Digits_LettersAndOther
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            StringBuilder numbers = new StringBuilder();
            StringBuilder letters = new StringBuilder();
            StringBuilder symbols = new StringBuilder();

            foreach (char character in input)
            {
                if (character >= 48 && character <= 57)
                {
                    numbers.Append(character);
                }
                else if (character >= 65 && character <= 90 || character >= 97 && character <= 122)
                {
                    letters.Append(character);
                }
                else
                {
                    symbols.Append(character);
                }
            }
            Console.WriteLine(numbers.ToString());
            Console.WriteLine(letters.ToString());
            Console.WriteLine(symbols.ToString());
        }
    }
}

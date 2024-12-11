
namespace _03.CharactersInRange
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int char1 = char.Parse(Console.ReadLine());
            int char2 = char.Parse(Console.ReadLine());
            CharactersInRangeBetween(char1, char2);
        }

        static void CharactersInRangeBetween(int char1, int char2)
        {
            int charactersArrayLenght = 0;
            int charStart = (int)char1;
            int charEnd = (int)char2;

            if (charStart < charEnd)
            {
                for (int i = charStart + 1; i < charEnd; i++)
                {
                    charactersArrayLenght++;
                }
                char[] characters = new char[charactersArrayLenght];

                for (int i = 0; i < characters.Length; i++)
                {
                    characters[i] = (char)(charStart + i + 1);
                    Console.Write($"{characters[i]} ");
                }
            }
            else
            {
                charStart = (int)char2;
                charEnd = (int)char1;
                for (int i = charStart + 1; i < charEnd; i++)
                {
                    charactersArrayLenght++;
                }
                char[] characters = new char[charactersArrayLenght];

                for (int i = 0; i < characters.Length; i++)
                {
                    characters[i] = (char)(charStart + i + 1);
                    Console.Write($"{characters[i]} ");
                }
            }
        }
    }
}
